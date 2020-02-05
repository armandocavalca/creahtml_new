
using System;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.IO;
using System.Drawing.Printing;
using Pechkin.Synchronized;
using System.Xml.Serialization;
using System.Diagnostics;
using Pechkin;

namespace creahtml
{
    public partial class Form1 : Form
    {
        public bool _errore = false;
        //public string XmlDaImpotare = @"C:\TestEdicom\XML_FATTURAELETTRONICA_FPA12_16092019_31072019.XML";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //

            var _elencoFile=Directory.GetFiles(@"c:\testedicom", "*.xml");
            foreach(var XmlDaImpotare in _elencoFile )
                Elabora(XmlDaImpotare);

            if(!_errore)
                MessageBox.Show("Creazione Cartelle Terminata");
            else
                MessageBox.Show("Creazione Cartelle Terminata -- >> ATTENZIONE VERIFICARE CARTELLE RILEVATA ANOMALIA");

            MessageBox.Show("Elaborazione Terminata");
            string fileToSelect = @"C:\TestEdicom\";
            string args = string.Format("/root, \"{0}\"", fileToSelect);
            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            System.Diagnostics.Process.Start(pfi);
        }

        public void Elabora(string XmlDaImpotare)
        {
            string xslFile = @"C:\TestEdicom\fatturaordinaria_v1.2.1.xsl";

            string xmlFile = XmlDaImpotare;

            string htmlFile = @"C:\TestEdicom\prova.HTML";

            string _NomePdf = NomePDF(XmlDaImpotare);

            listBox1.Items.Add(_NomePdf);

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
            string directory = @"C:\TestEdicom\" + _NomePdf;
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
            File.Move(XmlDaImpotare, Path.GetDirectoryName(XmlDaImpotare) + "\\Park\\" + Path.GetFileName(XmlDaImpotare));
            File.Copy(Path.GetDirectoryName(XmlDaImpotare) + "\\DATI PER REGISTRAZIONE.xlsx", directory + "\\DATI PER REGISTRAZIONE.xlsx");


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

        private void Button2_Click(object sender, EventArgs e)
        {
        }
        public string NomePDF(string XmlDaImpotare)
        {
            try
            {
                string PercorsoFile = XmlDaImpotare;
                Fattura.FatturaElettronica fatturaElettronica = new Fattura.FatturaElettronica();
                XmlSerializer serializzare = new XmlSerializer(typeof(Fattura.FatturaElettronica));
                StreamReader readerLettura = new StreamReader(PercorsoFile);
                fatturaElettronica = (Fattura.FatturaElettronica)serializzare.Deserialize(readerLettura);
                readerLettura.Close();
                string NomeFornitore = fatturaElettronica.FatturaElettronicaHeader.CedentePrestatore.DatiAnagrafici.Anagrafica.Denominazione.Replace(".", " ").Replace("/", " ");
                string DataFattura = fatturaElettronica.FatturaElettronicaBody.DatiGenerali.DatiGeneraliDocumento.Data.ToString("yyyyMMdd");
                string NumeroFattura = fatturaElettronica.FatturaElettronicaBody.DatiGenerali.DatiGeneraliDocumento.Numero.ToString();
                
                //MessageBox.Show(NomeFornitore.Trim() + " " + DataFattura.Trim() + " " + NumeroFattura.Trim());
                return NomeFornitore.Trim() + " " + DataFattura.Trim() + " " + NumeroFattura.Trim();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _errore = true;
                return Path.GetFileNameWithoutExtension( XmlDaImpotare);
            }
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
    }

}

