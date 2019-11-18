using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using Pechkin;
using Pechkin.Synchronized;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace creahtml
{
    public partial class Form1 : Form
    {
        public bool _errore = false;
        public string CartellaVisti = @"c:\testedicom";
        public Form1()
        {
                    InitializeComponent();
            if (!Directory.Exists(CartellaVisti))
                Directory.CreateDirectory(CartellaVisti);
            this.Text = string.Concat(this.Text.Trim(), " ", Application.ProductVersion);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = ConfigurationManager.AppSettings["MyPath"];
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                CartellaVisti = fbd.SelectedPath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["MyPath"].Value=CartellaVisti;
                config.Save(ConfigurationSaveMode.Full, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
                return;

            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            
            var _elencoFile = Directory.GetFiles(CartellaVisti, "*.xml");
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = _elencoFile.Count();
            circularProgressBar1.Text = _elencoFile.Count().ToString("#.###");
            circularProgressBar1.Value = 0;
            foreach (var XmlDaImpotare in _elencoFile)
            {
                circularProgressBar1.Value  ++;
                circularProgressBar1.Text =string.Concat(circularProgressBar1.Value.ToString("#.###")," di ", _elencoFile.Count().ToString("#.###"));
                Application.DoEvents();
                Elabora(XmlDaImpotare);
            }
            if (!_errore)
                MessageBox.Show("Creazione Cartelle Terminata");
            else
                MessageBox.Show("Creazione Cartelle Terminata -- >> ATTENZIONE VERIFICARE CARTELLE RILEVATA ANOMALIA");

            MessageBox.Show("Elaborazione Terminata");
            string fileToSelect =CartellaVisti;
            string args = string.Format("/root, \"{0}\"", fileToSelect);
            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            System.Diagnostics.Process.Start(pfi);
        }

        public void Elabora(string XmlDaImpotare)
        {
            string xslFile = @"C:\TestEdicom\fatturaordinaria_v1.2.1.xsl";

            string xmlFile = XmlDaImpotare;

            string htmlFile = @"C:\TestEdicom\prova.HTML";

            //string _NomePdf = NomePDF(XmlDaImpotare);
            CartellaFile _cf = NomePDF(XmlDaImpotare);
            string _NomePdf = _cf._file.Replace("/", "");
            string _Cartella = _cf._cartella.Replace("/", "");
            //_NomePdf = _NomePdf.Replace("/", "");
            if(_NomePdf.Contains("verifica"))
                listBox1.Items.Add(_NomePdf + " xml origine --> " + Path.GetFileName(XmlDaImpotare));
            else
                listBox1.Items.Add(_NomePdf );
            listBox1.SelectedIndex    = listBox1.Items.Count - 1;

            XslCompiledTransform transform = new XslCompiledTransform();

            transform.Load(xslFile);

            transform.Transform(xmlFile, htmlFile);

            //MessageBox.Show("Ho ottenuto HTML");

            //EO.Pdf.HtmlToPdf.ConvertHtml( @"C:\TestEdicom\prova.HTML", @"C:\TestEdicom\prova.pdf");
            // create global configuration object
            GlobalConfig gc = new GlobalConfig();

            // set it up using fluent notation
            // Remember to import the following type:
            //     using System.Drawing.Printing;
            //
            // a new instance of Margins with 1-inch margins.
            gc.SetMargins(new Margins(100, 100, 100, 100))
                .SetDocumentTitle("Test document")
                .SetPaperSize(PaperKind.Letter);

            // Create converter
            IPechkin pechkin = new SynchronizedPechkin(gc);

            // Create document configuration object
            ObjectConfig configuration = new ObjectConfig();


            string HTML_FILEPATH = @"C:\TestEdicom\prova.HTML";

            // and set it up using fluent notation too
            configuration
            .SetAllowLocalContent(true)
            .SetPageUri(@"file:///" + HTML_FILEPATH);

            // Generate the PDF with the given configuration
            // The Convert method will return a Byte Array with the content of the PDF
            // You will need to use another method to save the PDF (mentioned on step #3)
            byte[] pdfContent = pechkin.Convert(configuration);

            // Folder where the file will be created 
            //string directory = CartellaVisti +"\\"+ _NomePdf;
            string directory = CartellaVisti + "\\" + _Cartella;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            // Name of the PDF
            string filename = _NomePdf + ".pdf";

            if (ByteArrayToFile(directory + "\\" + filename, pdfContent))
            {
                Console.WriteLine("PDF Succesfully created");
            }
            else
            {
                Console.WriteLine("Cannot create PDF");
            }

            //MessageBox.Show("Ho generato PDF");
            try
            {
                scarica_allegati(xmlFile, directory, filename);
                File.Move(XmlDaImpotare,
                    "C:\\TestEdicom" + "\\Park\\" + 
                    Path.GetFileNameWithoutExtension(XmlDaImpotare)+ DateTime.Now.ToString("yyyyMMddhhmmss")+Path.GetExtension(XmlDaImpotare));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            try
            {
                // sostituito da appendice in pdf
                //File.Copy("C:\\TestEdicom" + "\\DATI PER REGISTRAZIONE.xlsx", directory + "\\DATI PER REGISTRAZIONE.xlsx");
            }
            catch(Exception e)
            {
#if !DEBUG
                MessageBox.Show(e.Message);
#else
                listBox1.Items.Add(e.Message);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
#endif
            }

            #region ITEXT7
            try
            {
                PdfDocument pdf = new PdfDocument(new PdfWriter(directory + "\\pdf.pdf"));
                PdfMerger merger = new PdfMerger(pdf);

                //Add pages from the first document
                PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(directory + "\\" + filename));
                merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());

                //Add pages from the second pdf document
                PdfDocument secondSourcePdf = new PdfDocument(new PdfReader("C:\\TestEdicom\\foglio2.pdf"));
                merger.Merge(secondSourcePdf, 1, secondSourcePdf.GetNumberOfPages());

                firstSourcePdf.Close();
                secondSourcePdf.Close();
                pdf.Close();

                // cancello file origina e rinomino il nuovo
                File.Delete(directory + "\\" + filename);
                File.Copy(directory + "\\pdf.pdf", directory + "\\" + filename);
                File.Delete(directory + "\\pdf.pdf");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion


        }

        public bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            try
            {
                // Open file for reading
                FileStream _FileStream = new FileStream(_FileName, FileMode.Create, FileAccess.Write);
                // Writes a block of bytes to this stream using data from  a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // Close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                Console.WriteLine("Exception caught in process while trying to save : {0}", _Exception.ToString());
            }

            return false;
        }
        public CartellaFile NomePDF(string XmlDaImpotare)
        {
            string _Nome = "";
            string _Cogonme = "";
            string NomeFornitore = "";
#region controll se congnome e nome
            var xmr = new XmlTextReader(XmlDaImpotare);
            xmr.ReadToFollowing("Anagrafica");
            xmr.MoveToAttribute("Nome");
            xmr.ReadToFollowing("Nome");
            //MessageBox.Show(xmr.ReadElementContentAsString());
            try
            {
                _Nome = xmr.ReadElementContentAsString();
            }
            catch
            { _Nome = ""; }
            xmr.Close();
            xmr = new XmlTextReader(XmlDaImpotare);
            xmr.ReadToFollowing("Anagrafica");
            xmr.MoveToAttribute("Cognome");
            xmr.ReadToFollowing("Cognome");
            //MessageBox.Show(xmr.ReadElementContentAsString());
            try
            { _Cogonme = xmr.ReadElementContentAsString(); }
            catch
            { _Cogonme = ""; }
            xmr.Close();
            NomeFornitore = string.Concat(_Cogonme,"_", _Nome);
#endregion
            xmr = new XmlTextReader(XmlDaImpotare);
            xmr.ReadToFollowing("Anagrafica");
            xmr.MoveToAttribute("Denominazione");
            xmr.ReadToFollowing("Denominazione");
            //MessageBox.Show(xmr.ReadElementContentAsString());
            if(_Nome=="" && _Cogonme=="" || _Nome != "" && _Cogonme != "")
                try
                {
                    NomeFornitore = xmr.ReadElementContentAsString();
                    if (NomeFornitore.ToLower().Contains("fagioli") && _Nome != "" && _Cogonme != "")
                        NomeFornitore = string.Concat(_Cogonme, "_", _Nome);
                }
                catch (Exception)
                {

                    try
                    {
                        xmr.Close();
                        xmr = new XmlTextReader(XmlDaImpotare);
                        xmr.ReadToFollowing("CedentePrestatore");
                        xmr.MoveToAttribute("Denominazione");
                        xmr.ReadToFollowing("Denominazione");
                        NomeFornitore = xmr.ReadElementContentAsString();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Problemi con il tracciato chiamare IT");
                    }
                }
                //NomeFornitore = xmr.ReadElementContentAsString();
            //xmr.MoveToFirstAttribute();
            xmr.ReadToFollowing("DatiGeneraliDocumento");
            xmr.MoveToAttribute("Data");
            xmr.ReadToFollowing("Data");
            //MessageBox.Show(xmr.ReadElementContentAsString("yyyyMMdd"));
            string DataFattura = xmr.ReadElementContentAsString();
            xmr.Close();
            xmr = new XmlTextReader(XmlDaImpotare);
            xmr.ReadToFollowing("DatiGeneraliDocumento");
            xmr.MoveToAttribute("Numero");
            xmr.ReadToFollowing("Numero");
            //MessageBox.Show(xmr.ReadElementContentAsString());
            string NumeroFattura = "";
            try
            {
                NumeroFattura = xmr.ReadElementContentAsString();
            }
            catch
            {
                NumeroFattura = "verifica"+DateTime.Now.ToString("yyyyMMddhhmmss");
            }

            xmr.ReadToFollowing("DatiPagamento");
            xmr.MoveToAttribute("DettaglioPagamento");
            xmr.ReadToFollowing("DataScadenzaPagamento");
            string _datascadenza;
            try
            {
                _datascadenza= xmr.ReadElementContentAsString();
            }
            catch
            {
                _datascadenza = "9999 - 99 - 99";
            }


            xmr.Close();

            CartellaFile _cf = new CartellaFile();
            _cf._cartella = NomeFornitore.Trim().Replace("\"", " ") +" " + DataFattura.Trim() + " " + NumeroFattura.Trim().Replace("\\", " "); 
            _cf._file = _datascadenza + "_" + NomeFornitore.Trim().Replace("\"", " ") + " " + DataFattura.Trim() + " " + NumeroFattura.Trim().Replace("\\", " ");

            //return NomeFornitore.Trim().Replace("\"", " ") + " " + DataFattura.Trim() + " " + NumeroFattura.Trim().Replace("\\", " ");
            return _cf;
            #region annullata
            //    try
            //{

            //    string PercorsoFile = XmlDaImpotare;
            //    Fattura.FatturaElettronica fatturaElettronica = new Fattura.FatturaElettronica();
            //    XmlSerializer serializzare = new XmlSerializer(typeof(Fattura.FatturaElettronica));
            //    StreamReader readerLettura = new StreamReader(PercorsoFile);
            //    fatturaElettronica = (Fattura.FatturaElettronica)serializzare.Deserialize(readerLettura);
            //    readerLettura.Close();
            //    string NomeFornitore = fatturaElettronica.FatturaElettronicaHeader.CedentePrestatore.DatiAnagrafici.Anagrafica.Denominazione.Replace(".", " ").Replace("/", " ");
            //    string DataFattura = fatturaElettronica.FatturaElettronicaBody.DatiGenerali.DatiGeneraliDocumento.Data.ToString("yyyyMMdd");
            //    string NumeroFattura = fatturaElettronica.FatturaElettronicaBody.DatiGenerali.DatiGeneraliDocumento.Numero.ToString();

            //    //MessageBox.Show(NomeFornitore.Trim() + " " + DataFattura.Trim() + " " + NumeroFattura.Trim());
            //    return NomeFornitore.Trim() + " " + DataFattura.Trim() + " " + NumeroFattura.Trim();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    _errore = true;
            //    return Path.GetFileNameWithoutExtension(XmlDaImpotare);
            //}
            #endregion
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string fileToSelect = @"C:\TestEdicom\";
            string args = string.Format("/root, \"{0}\"", fileToSelect);
            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            System.Diagnostics.Process.Start(pfi);

            //System.Diagnostics.Process.Start("Explorer");


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string filename = @"C:\TestEdicom\Note per scarico documenti EDICOM.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void scarica_allegati_old(string NomeFile, string CartellaDestinazione, string filename)
        {
            // The XML invoice is shown at the bottom of this example.
            Chilkat.Xml xml = new Chilkat.Xml();
            //bool success = xml.LoadXmlFile("qa_data/xml/fatture_invoice.xml");
            bool success = xml.LoadXmlFile(NomeFile);
            if (success != true)
            {
                Debug.WriteLine(xml.LastErrorText);
                return;
            }


                // Get the Base64 PDF content.
                Chilkat.StringBuilder sb = new Chilkat.StringBuilder();

                success = xml.GetChildContentSb("FatturaElettronicaBody|Allegati|Attachment", sb);
                if (success != true)
                {
                    Debug.WriteLine(xml.LastErrorText);
                    return;
                }

                // Decode the base64
                Chilkat.BinData bd = new Chilkat.BinData();
                success = bd.AppendEncodedSb(sb, "base64");

                // Save to a PDF file.
                success = bd.WriteFile(Path.Combine(CartellaDestinazione, Path.GetFileNameWithoutExtension(filename) + "_ALL0.pdf"));

        }
        private void scarica_allegati(string NomeFile, string CartellaDestinazione, string filename)
        {
            var xmr = new XmlTextReader(NomeFile);

            // prova creazione pdf
            for (int i = 0; i <= 99; i++)
            {
                xmr.ReadToFollowing("Allegati");
                xmr.MoveToAttribute("FormatoAttachment");
                xmr.ReadToFollowing("FormatoAttachment");
                try
                {
                    if (xmr.ReadElementContentAsString().ToUpper() == "PDF")
                    {
                        xmr.MoveToAttribute("Attachment");
                        xmr.ReadToFollowing("Attachment");
                        byte[] file = System.Convert.FromBase64String((xmr.ReadElementContentAsString()));
                        System.IO.FileStream stream =
                        new FileStream(Path.Combine(CartellaDestinazione, Path.GetFileNameWithoutExtension(filename) + "_ALL" + i.ToString() + ".pdf"), FileMode.CreateNew);
                        System.IO.BinaryWriter writer =
                            new BinaryWriter(stream);
                        writer.Write(file, 0, file.Length);
                        writer.Close();
                    }
                }
                catch
                {
                    xmr.Close();
                    return;
                }
                
            }
            xmr.Close();
        }

        public struct CartellaFile
        {
            public string _cartella;
            public string _file;
        }


    }
}
