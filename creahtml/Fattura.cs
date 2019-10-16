using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creahtml
{
    public class Fattura
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2", IsNullable = false)]
        public partial class FatturaElettronica
        {

            private FatturaElettronicaHeader fatturaElettronicaHeaderField;

            private FatturaElettronicaBody fatturaElettronicaBodyField;

            private string versioneField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaHeader FatturaElettronicaHeader
            {
                get
                {
                    return this.fatturaElettronicaHeaderField;
                }
                set
                {
                    this.fatturaElettronicaHeaderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaBody FatturaElettronicaBody
            {
                get
                {
                    return this.fatturaElettronicaBodyField;
                }
                set
                {
                    this.fatturaElettronicaBodyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string versione
            {
                get
                {
                    return this.versioneField;
                }
                set
                {
                    this.versioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaHeader
        {

            private FatturaElettronicaHeaderDatiTrasmissione datiTrasmissioneField;

            private FatturaElettronicaHeaderCedentePrestatore cedentePrestatoreField;

            private FatturaElettronicaHeaderCessionarioCommittente cessionarioCommittenteField;

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente terzoIntermediarioOSoggettoEmittenteField;

            private string soggettoEmittenteField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissione DatiTrasmissione
            {
                get
                {
                    return this.datiTrasmissioneField;
                }
                set
                {
                    this.datiTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatore CedentePrestatore
            {
                get
                {
                    return this.cedentePrestatoreField;
                }
                set
                {
                    this.cedentePrestatoreField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittente CessionarioCommittente
            {
                get
                {
                    return this.cessionarioCommittenteField;
                }
                set
                {
                    this.cessionarioCommittenteField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente TerzoIntermediarioOSoggettoEmittente
            {
                get
                {
                    return this.terzoIntermediarioOSoggettoEmittenteField;
                }
                set
                {
                    this.terzoIntermediarioOSoggettoEmittenteField = value;
                }
            }

            /// <remarks/>
            public string SoggettoEmittente
            {
                get
                {
                    return this.soggettoEmittenteField;
                }
                set
                {
                    this.soggettoEmittenteField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissione
        {

            private FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente idTrasmittenteField;

            private string progressivoInvioField;

            private string formatoTrasmissioneField;

            private string codiceDestinatarioField;

            private FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente contattiTrasmittenteField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente IdTrasmittente
            {
                get
                {
                    return this.idTrasmittenteField;
                }
                set
                {
                    this.idTrasmittenteField = value;
                }
            }

            /// <remarks/>
            public string ProgressivoInvio
            {
                get
                {
                    return this.progressivoInvioField;
                }
                set
                {
                    this.progressivoInvioField = value;
                }
            }

            /// <remarks/>
            public string FormatoTrasmissione
            {
                get
                {
                    return this.formatoTrasmissioneField;
                }
                set
                {
                    this.formatoTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public string CodiceDestinatario
            {
                get
                {
                    return this.codiceDestinatarioField;
                }
                set
                {
                    this.codiceDestinatarioField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente ContattiTrasmittente
            {
                get
                {
                    return this.contattiTrasmittenteField;
                }
                set
                {
                    this.contattiTrasmittenteField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente
        {

            private string idPaeseField;

            private ulong idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public ulong IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente
        {

            private string emailField;

            /// <remarks/>
            public string Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            private string TelefonoField;
            public string Telefono
            {
                get
                {
                    return this.TelefonoField;
                }
                set
                {
                    this.TelefonoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatore
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCedentePrestatoreSede sedeField;

            private FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA iscrizioneREAField;

            private FatturaElettronicaHeaderCedentePrestatoreContatti contattiField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA IscrizioneREA
            {
                get
                {
                    return this.iscrizioneREAField;
                }
                set
                {
                    this.iscrizioneREAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreContatti Contatti
            {
                get
                {
                    return this.contattiField;
                }
                set
                {
                    this.contattiField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private uint codiceFiscaleField;

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica anagraficaField;

            private string regimeFiscaleField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public uint CodiceFiscale
            {
                get
                {
                    return this.codiceFiscaleField;
                }
                set
                {
                    this.codiceFiscaleField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }

            /// <remarks/>
            public string RegimeFiscale
            {
                get
                {
                    return this.regimeFiscaleField;
                }
                set
                {
                    this.regimeFiscaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreSede
        {

            private string indirizzoField;

            private ushort cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public ushort CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA
        {

            private string ufficioField;

            private string numeroREAField;

            private decimal capitaleSocialeField;

            private string socioUnicoField;

            private string statoLiquidazioneField;

            /// <remarks/>
            public string Ufficio
            {
                get
                {
                    return this.ufficioField;
                }
                set
                {
                    this.ufficioField = value;
                }
            }

            /// <remarks/>
            public string NumeroREA
            {
                get
                {
                    return this.numeroREAField;
                }
                set
                {
                    this.numeroREAField = value;
                }
            }

            /// <remarks/>
            public decimal CapitaleSociale
            {
                get
                {
                    return this.capitaleSocialeField;
                }
                set
                {
                    this.capitaleSocialeField = value;
                }
            }

            /// <remarks/>
            public string SocioUnico
            {
                get
                {
                    return this.socioUnicoField;
                }
                set
                {
                    this.socioUnicoField = value;
                }
            }

            /// <remarks/>
            public string StatoLiquidazione
            {
                get
                {
                    return this.statoLiquidazioneField;
                }
                set
                {
                    this.statoLiquidazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreContatti
        {

            private uint telefonoField;

            private uint faxField;

            private string emailField;

            /// <remarks/>
            public uint Telefono
            {
                get
                {
                    return this.telefonoField;
                }
                set
                {
                    this.telefonoField = value;
                }
            }

            /// <remarks/>
            public uint Fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            public string Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittente
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCessionarioCommittenteSede sedeField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica anagraficaField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteSede
        {

            private string indirizzoField;

            private ushort cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public ushort CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente
        {

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici datiAnagraficiField;

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici
        {

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica anagraficaField;

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private ulong idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public ulong IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaBody
        {

            private FatturaElettronicaBodyDatiGenerali datiGeneraliField;

            private FatturaElettronicaBodyDatiBeniServizi datiBeniServiziField;

            private FatturaElettronicaBodyDatiPagamento datiPagamentoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGenerali DatiGenerali
            {
                get
                {
                    return this.datiGeneraliField;
                }
                set
                {
                    this.datiGeneraliField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServizi DatiBeniServizi
            {
                get
                {
                    return this.datiBeniServiziField;
                }
                set
                {
                    this.datiBeniServiziField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamento DatiPagamento
            {
                get
                {
                    return this.datiPagamentoField;
                }
                set
                {
                    this.datiPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGenerali
        {

            private FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento datiGeneraliDocumentoField;

            private FatturaElettronicaBodyDatiGeneraliDatiDDT[] datiDDTField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento DatiGeneraliDocumento
            {
                get
                {
                    return this.datiGeneraliDocumentoField;
                }
                set
                {
                    this.datiGeneraliDocumentoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DatiDDT")]
            public FatturaElettronicaBodyDatiGeneraliDatiDDT[] DatiDDT
            {
                get
                {
                    return this.datiDDTField;
                }
                set
                {
                    this.datiDDTField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento
        {

            private string tipoDocumentoField;

            private string divisaField;

            private System.DateTime dataField;

            private ushort numeroField;

            private decimal importoTotaleDocumentoField;

            private string causaleField;

            /// <remarks/>
            public string TipoDocumento
            {
                get
                {
                    return this.tipoDocumentoField;
                }
                set
                {
                    this.tipoDocumentoField = value;
                }
            }

            /// <remarks/>
            public string Divisa
            {
                get
                {
                    return this.divisaField;
                }
                set
                {
                    this.divisaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime Data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }

            /// <remarks/>
            public ushort Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoTotaleDocumento
            {
                get
                {
                    return this.importoTotaleDocumentoField;
                }
                set
                {
                    this.importoTotaleDocumentoField = value;
                }
            }

            /// <remarks/>
            public string Causale
            {
                get
                {
                    return this.causaleField;
                }
                set
                {
                    this.causaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGeneraliDatiDDT
        {

            private string numeroDDTField;

            private System.DateTime dataDDTField;

            private byte riferimentoNumeroLineaField;

            /// <remarks/>
            public string NumeroDDT
            {
                get
                {
                    return this.numeroDDTField;
                }
                set
                {
                    this.numeroDDTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataDDT
            {
                get
                {
                    return this.dataDDTField;
                }
                set
                {
                    this.dataDDTField = value;
                }
            }

            /// <remarks/>
            public byte RiferimentoNumeroLinea
            {
                get
                {
                    return this.riferimentoNumeroLineaField;
                }
                set
                {
                    this.riferimentoNumeroLineaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServizi
        {

            private FatturaElettronicaBodyDatiBeniServiziDettaglioLinee[] dettaglioLineeField;

            private FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo datiRiepilogoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DettaglioLinee")]
            public FatturaElettronicaBodyDatiBeniServiziDettaglioLinee[] DettaglioLinee
            {
                get
                {
                    return this.dettaglioLineeField;
                }
                set
                {
                    this.dettaglioLineeField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo DatiRiepilogo
            {
                get
                {
                    return this.datiRiepilogoField;
                }
                set
                {
                    this.datiRiepilogoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDettaglioLinee
        {

            private byte numeroLineaField;

            private string descrizioneField;

            private decimal quantitaField;

            private string unitaMisuraField;

            private decimal prezzoUnitarioField;

            private decimal prezzoTotaleField;

            private decimal aliquotaIVAField;

            /// <remarks/>
            public byte NumeroLinea
            {
                get
                {
                    return this.numeroLineaField;
                }
                set
                {
                    this.numeroLineaField = value;
                }
            }

            /// <remarks/>
            public string Descrizione
            {
                get
                {
                    return this.descrizioneField;
                }
                set
                {
                    this.descrizioneField = value;
                }
            }

            /// <remarks/>
            public decimal Quantita
            {
                get
                {
                    return this.quantitaField;
                }
                set
                {
                    this.quantitaField = value;
                }
            }

            /// <remarks/>
            public string UnitaMisura
            {
                get
                {
                    return this.unitaMisuraField;
                }
                set
                {
                    this.unitaMisuraField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoUnitario
            {
                get
                {
                    return this.prezzoUnitarioField;
                }
                set
                {
                    this.prezzoUnitarioField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoTotale
            {
                get
                {
                    return this.prezzoTotaleField;
                }
                set
                {
                    this.prezzoTotaleField = value;
                }
            }

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo
        {

            private decimal aliquotaIVAField;

            private decimal imponibileImportoField;

            private decimal impostaField;

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }

            /// <remarks/>
            public decimal ImponibileImporto
            {
                get
                {
                    return this.imponibileImportoField;
                }
                set
                {
                    this.imponibileImportoField = value;
                }
            }

            /// <remarks/>
            public decimal Imposta
            {
                get
                {
                    return this.impostaField;
                }
                set
                {
                    this.impostaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamento
        {

            private string condizioniPagamentoField;

            private FatturaElettronicaBodyDatiPagamentoDettaglioPagamento dettaglioPagamentoField;

            /// <remarks/>
            public string CondizioniPagamento
            {
                get
                {
                    return this.condizioniPagamentoField;
                }
                set
                {
                    this.condizioniPagamentoField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamentoDettaglioPagamento DettaglioPagamento
            {
                get
                {
                    return this.dettaglioPagamentoField;
                }
                set
                {
                    this.dettaglioPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamentoDettaglioPagamento
        {

            private string beneficiarioField;

            private string modalitaPagamentoField;

            private System.DateTime dataScadenzaPagamentoField;

            private decimal importoPagamentoField;

            private string istitutoFinanziarioField;

            private string iBANField;

            /// <remarks/>
            public string Beneficiario
            {
                get
                {
                    return this.beneficiarioField;
                }
                set
                {
                    this.beneficiarioField = value;
                }
            }

            /// <remarks/>
            public string ModalitaPagamento
            {
                get
                {
                    return this.modalitaPagamentoField;
                }
                set
                {
                    this.modalitaPagamentoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataScadenzaPagamento
            {
                get
                {
                    return this.dataScadenzaPagamentoField;
                }
                set
                {
                    this.dataScadenzaPagamentoField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoPagamento
            {
                get
                {
                    return this.importoPagamentoField;
                }
                set
                {
                    this.importoPagamentoField = value;
                }
            }

            /// <remarks/>
            public string IstitutoFinanziario
            {
                get
                {
                    return this.istitutoFinanziarioField;
                }
                set
                {
                    this.istitutoFinanziarioField = value;
                }
            }

            /// <remarks/>
            public string IBAN
            {
                get
                {
                    return this.iBANField;
                }
                set
                {
                    this.iBANField = value;
                }
            }
        }


    }
    public class Fattura_old1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2", IsNullable = false)]
        public partial class FatturaElettronica
        {

            private FatturaElettronicaHeader fatturaElettronicaHeaderField;

            private FatturaElettronicaBody fatturaElettronicaBodyField;

            private string versioneField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaHeader FatturaElettronicaHeader
            {
                get
                {
                    return this.fatturaElettronicaHeaderField;
                }
                set
                {
                    this.fatturaElettronicaHeaderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaBody FatturaElettronicaBody
            {
                get
                {
                    return this.fatturaElettronicaBodyField;
                }
                set
                {
                    this.fatturaElettronicaBodyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string versione
            {
                get
                {
                    return this.versioneField;
                }
                set
                {
                    this.versioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaHeader
        {

            private FatturaElettronicaHeaderDatiTrasmissione datiTrasmissioneField;

            private FatturaElettronicaHeaderCedentePrestatore cedentePrestatoreField;

            private FatturaElettronicaHeaderCessionarioCommittente cessionarioCommittenteField;

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente terzoIntermediarioOSoggettoEmittenteField;

            private string soggettoEmittenteField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissione DatiTrasmissione
            {
                get
                {
                    return this.datiTrasmissioneField;
                }
                set
                {
                    this.datiTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatore CedentePrestatore
            {
                get
                {
                    return this.cedentePrestatoreField;
                }
                set
                {
                    this.cedentePrestatoreField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittente CessionarioCommittente
            {
                get
                {
                    return this.cessionarioCommittenteField;
                }
                set
                {
                    this.cessionarioCommittenteField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente TerzoIntermediarioOSoggettoEmittente
            {
                get
                {
                    return this.terzoIntermediarioOSoggettoEmittenteField;
                }
                set
                {
                    this.terzoIntermediarioOSoggettoEmittenteField = value;
                }
            }

            /// <remarks/>
            public string SoggettoEmittente
            {
                get
                {
                    return this.soggettoEmittenteField;
                }
                set
                {
                    this.soggettoEmittenteField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissione
        {

            private FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente idTrasmittenteField;

            private string progressivoInvioField;

            private string formatoTrasmissioneField;

            private string codiceDestinatarioField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente IdTrasmittente
            {
                get
                {
                    return this.idTrasmittenteField;
                }
                set
                {
                    this.idTrasmittenteField = value;
                }
            }

            /// <remarks/>
            public string ProgressivoInvio
            {
                get
                {
                    return this.progressivoInvioField;
                }
                set
                {
                    this.progressivoInvioField = value;
                }
            }

            /// <remarks/>
            public string FormatoTrasmissione
            {
                get
                {
                    return this.formatoTrasmissioneField;
                }
                set
                {
                    this.formatoTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public string CodiceDestinatario
            {
                get
                {
                    return this.codiceDestinatarioField;
                }
                set
                {
                    this.codiceDestinatarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente
        {

            private string idPaeseField;

            private ulong idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public ulong IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatore
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCedentePrestatoreSede sedeField;

            private FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA iscrizioneREAField;

            private FatturaElettronicaHeaderCedentePrestatoreContatti contattiField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA IscrizioneREA
            {
                get
                {
                    return this.iscrizioneREAField;
                }
                set
                {
                    this.iscrizioneREAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreContatti Contatti
            {
                get
                {
                    return this.contattiField;
                }
                set
                {
                    this.contattiField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica anagraficaField;

            private string regimeFiscaleField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }

            /// <remarks/>
            public string RegimeFiscale
            {
                get
                {
                    return this.regimeFiscaleField;
                }
                set
                {
                    this.regimeFiscaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreSede
        {

            private string indirizzoField;

            private ushort cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public ushort CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA
        {

            private string ufficioField;

            private string numeroREAField;

            private string socioUnicoField;

            private string statoLiquidazioneField;

            /// <remarks/>
            public string Ufficio
            {
                get
                {
                    return this.ufficioField;
                }
                set
                {
                    this.ufficioField = value;
                }
            }

            /// <remarks/>
            public string NumeroREA
            {
                get
                {
                    return this.numeroREAField;
                }
                set
                {
                    this.numeroREAField = value;
                }
            }

            /// <remarks/>
            public string SocioUnico
            {
                get
                {
                    return this.socioUnicoField;
                }
                set
                {
                    this.socioUnicoField = value;
                }
            }

            /// <remarks/>
            public string StatoLiquidazione
            {
                get
                {
                    return this.statoLiquidazioneField;
                }
                set
                {
                    this.statoLiquidazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreContatti
        {

            private string telefonoField;

            /// <remarks/>
            public string Telefono
            {
                get
                {
                    return this.telefonoField;
                }
                set
                {
                    this.telefonoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittente
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCessionarioCommittenteSede sedeField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private uint codiceFiscaleField;

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica anagraficaField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public uint CodiceFiscale
            {
                get
                {
                    return this.codiceFiscaleField;
                }
                set
                {
                    this.codiceFiscaleField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteSede
        {

            private string indirizzoField;

            private ushort cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public ushort CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittente
        {

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici datiAnagraficiField;

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagrafici
        {

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private uint codiceFiscaleField;

            private FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica anagraficaField;

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public uint CodiceFiscale
            {
                get
                {
                    return this.codiceFiscaleField;
                }
                set
                {
                    this.codiceFiscaleField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderTerzoIntermediarioOSoggettoEmittenteDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaBody
        {

            private FatturaElettronicaBodyDatiGenerali datiGeneraliField;

            private FatturaElettronicaBodyDatiBeniServizi datiBeniServiziField;

            private FatturaElettronicaBodyDatiPagamento datiPagamentoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGenerali DatiGenerali
            {
                get
                {
                    return this.datiGeneraliField;
                }
                set
                {
                    this.datiGeneraliField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServizi DatiBeniServizi
            {
                get
                {
                    return this.datiBeniServiziField;
                }
                set
                {
                    this.datiBeniServiziField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamento DatiPagamento
            {
                get
                {
                    return this.datiPagamentoField;
                }
                set
                {
                    this.datiPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGenerali
        {

            private FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento datiGeneraliDocumentoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento DatiGeneraliDocumento
            {
                get
                {
                    return this.datiGeneraliDocumentoField;
                }
                set
                {
                    this.datiGeneraliDocumentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento
        {

            private string tipoDocumentoField;

            private string divisaField;

            private System.DateTime dataField;

            private byte numeroField;

            private decimal importoTotaleDocumentoField;

            /// <remarks/>
            public string TipoDocumento
            {
                get
                {
                    return this.tipoDocumentoField;
                }
                set
                {
                    this.tipoDocumentoField = value;
                }
            }

            /// <remarks/>
            public string Divisa
            {
                get
                {
                    return this.divisaField;
                }
                set
                {
                    this.divisaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime Data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }

            /// <remarks/>
            public byte Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoTotaleDocumento
            {
                get
                {
                    return this.importoTotaleDocumentoField;
                }
                set
                {
                    this.importoTotaleDocumentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServizi
        {

            private FatturaElettronicaBodyDatiBeniServiziDettaglioLinee[] dettaglioLineeField;

            private FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo[] datiRiepilogoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DettaglioLinee")]
            public FatturaElettronicaBodyDatiBeniServiziDettaglioLinee[] DettaglioLinee
            {
                get
                {
                    return this.dettaglioLineeField;
                }
                set
                {
                    this.dettaglioLineeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DatiRiepilogo")]
            public FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo[] DatiRiepilogo
            {
                get
                {
                    return this.datiRiepilogoField;
                }
                set
                {
                    this.datiRiepilogoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDettaglioLinee
        {

            private byte numeroLineaField;

            private FatturaElettronicaBodyDatiBeniServiziDettaglioLineeCodiceArticolo codiceArticoloField;

            private string descrizioneField;

            private decimal quantitaField;

            private bool quantitaFieldSpecified;

            private string unitaMisuraField;

            private decimal prezzoUnitarioField;

            private decimal prezzoTotaleField;

            private decimal aliquotaIVAField;

            private string naturaField;

            /// <remarks/>
            public byte NumeroLinea
            {
                get
                {
                    return this.numeroLineaField;
                }
                set
                {
                    this.numeroLineaField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServiziDettaglioLineeCodiceArticolo CodiceArticolo
            {
                get
                {
                    return this.codiceArticoloField;
                }
                set
                {
                    this.codiceArticoloField = value;
                }
            }

            /// <remarks/>
            public string Descrizione
            {
                get
                {
                    return this.descrizioneField;
                }
                set
                {
                    this.descrizioneField = value;
                }
            }

            /// <remarks/>
            public decimal Quantita
            {
                get
                {
                    return this.quantitaField;
                }
                set
                {
                    this.quantitaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool QuantitaSpecified
            {
                get
                {
                    return this.quantitaFieldSpecified;
                }
                set
                {
                    this.quantitaFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string UnitaMisura
            {
                get
                {
                    return this.unitaMisuraField;
                }
                set
                {
                    this.unitaMisuraField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoUnitario
            {
                get
                {
                    return this.prezzoUnitarioField;
                }
                set
                {
                    this.prezzoUnitarioField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoTotale
            {
                get
                {
                    return this.prezzoTotaleField;
                }
                set
                {
                    this.prezzoTotaleField = value;
                }
            }

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }

            /// <remarks/>
            public string Natura
            {
                get
                {
                    return this.naturaField;
                }
                set
                {
                    this.naturaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDettaglioLineeCodiceArticolo
        {

            private string codiceTipoField;

            private string codiceValoreField;

            /// <remarks/>
            public string CodiceTipo
            {
                get
                {
                    return this.codiceTipoField;
                }
                set
                {
                    this.codiceTipoField = value;
                }
            }

            /// <remarks/>
            public string CodiceValore
            {
                get
                {
                    return this.codiceValoreField;
                }
                set
                {
                    this.codiceValoreField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo
        {

            private decimal aliquotaIVAField;

            private string naturaField;

            private decimal speseAccessorieField;

            private decimal arrotondamentoField;

            private decimal imponibileImportoField;

            private decimal impostaField;

            private string esigibilitaIVAField;

            private string riferimentoNormativoField;

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }

            /// <remarks/>
            public string Natura
            {
                get
                {
                    return this.naturaField;
                }
                set
                {
                    this.naturaField = value;
                }
            }

            /// <remarks/>
            public decimal SpeseAccessorie
            {
                get
                {
                    return this.speseAccessorieField;
                }
                set
                {
                    this.speseAccessorieField = value;
                }
            }

            /// <remarks/>
            public decimal Arrotondamento
            {
                get
                {
                    return this.arrotondamentoField;
                }
                set
                {
                    this.arrotondamentoField = value;
                }
            }

            /// <remarks/>
            public decimal ImponibileImporto
            {
                get
                {
                    return this.imponibileImportoField;
                }
                set
                {
                    this.imponibileImportoField = value;
                }
            }

            /// <remarks/>
            public decimal Imposta
            {
                get
                {
                    return this.impostaField;
                }
                set
                {
                    this.impostaField = value;
                }
            }

            /// <remarks/>
            public string EsigibilitaIVA
            {
                get
                {
                    return this.esigibilitaIVAField;
                }
                set
                {
                    this.esigibilitaIVAField = value;
                }
            }

            /// <remarks/>
            public string RiferimentoNormativo
            {
                get
                {
                    return this.riferimentoNormativoField;
                }
                set
                {
                    this.riferimentoNormativoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamento
        {

            private string condizioniPagamentoField;

            private FatturaElettronicaBodyDatiPagamentoDettaglioPagamento dettaglioPagamentoField;

            /// <remarks/>
            public string CondizioniPagamento
            {
                get
                {
                    return this.condizioniPagamentoField;
                }
                set
                {
                    this.condizioniPagamentoField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamentoDettaglioPagamento DettaglioPagamento
            {
                get
                {
                    return this.dettaglioPagamentoField;
                }
                set
                {
                    this.dettaglioPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamentoDettaglioPagamento
        {

            private string modalitaPagamentoField;

            private System.DateTime dataScadenzaPagamentoField;

            private decimal importoPagamentoField;

            /// <remarks/>
            public string ModalitaPagamento
            {
                get
                {
                    return this.modalitaPagamentoField;
                }
                set
                {
                    this.modalitaPagamentoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataScadenzaPagamento
            {
                get
                {
                    return this.dataScadenzaPagamentoField;
                }
                set
                {
                    this.dataScadenzaPagamentoField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoPagamento
            {
                get
                {
                    return this.importoPagamentoField;
                }
                set
                {
                    this.importoPagamentoField = value;
                }
            }
        }


    }
    public class Fattura_old2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2", IsNullable = false)]
        public partial class FatturaElettronica
        {

            private FatturaElettronicaHeader fatturaElettronicaHeaderField;

            private FatturaElettronicaBody fatturaElettronicaBodyField;

            private string versioneField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaHeader FatturaElettronicaHeader
            {
                get
                {
                    return this.fatturaElettronicaHeaderField;
                }
                set
                {
                    this.fatturaElettronicaHeaderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public FatturaElettronicaBody FatturaElettronicaBody
            {
                get
                {
                    return this.fatturaElettronicaBodyField;
                }
                set
                {
                    this.fatturaElettronicaBodyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string versione
            {
                get
                {
                    return this.versioneField;
                }
                set
                {
                    this.versioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaHeader
        {

            private FatturaElettronicaHeaderDatiTrasmissione datiTrasmissioneField;

            private FatturaElettronicaHeaderCedentePrestatore cedentePrestatoreField;

            private FatturaElettronicaHeaderCessionarioCommittente cessionarioCommittenteField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissione DatiTrasmissione
            {
                get
                {
                    return this.datiTrasmissioneField;
                }
                set
                {
                    this.datiTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatore CedentePrestatore
            {
                get
                {
                    return this.cedentePrestatoreField;
                }
                set
                {
                    this.cedentePrestatoreField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittente CessionarioCommittente
            {
                get
                {
                    return this.cessionarioCommittenteField;
                }
                set
                {
                    this.cessionarioCommittenteField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissione
        {

            private FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente idTrasmittenteField;

            private ushort progressivoInvioField;

            private string formatoTrasmissioneField;

            private string codiceDestinatarioField;

            /// <remarks/>
            public FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente IdTrasmittente
            {
                get
                {
                    return this.idTrasmittenteField;
                }
                set
                {
                    this.idTrasmittenteField = value;
                }
            }

            /// <remarks/>
            public ushort ProgressivoInvio
            {
                get
                {
                    return this.progressivoInvioField;
                }
                set
                {
                    this.progressivoInvioField = value;
                }
            }

            /// <remarks/>
            public string FormatoTrasmissione
            {
                get
                {
                    return this.formatoTrasmissioneField;
                }
                set
                {
                    this.formatoTrasmissioneField = value;
                }
            }

            /// <remarks/>
            public string CodiceDestinatario
            {
                get
                {
                    return this.codiceDestinatarioField;
                }
                set
                {
                    this.codiceDestinatarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatore
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCedentePrestatoreSede sedeField;

            private FatturaElettronicaHeaderCedentePrestatoreContatti contattiField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreContatti Contatti
            {
                get
                {
                    return this.contattiField;
                }
                set
                {
                    this.contattiField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici
        {

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private uint codiceFiscaleField;

            private FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica anagraficaField;

            private string regimeFiscaleField;

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public uint CodiceFiscale
            {
                get
                {
                    return this.codiceFiscaleField;
                }
                set
                {
                    this.codiceFiscaleField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }

            /// <remarks/>
            public string RegimeFiscale
            {
                get
                {
                    return this.regimeFiscaleField;
                }
                set
                {
                    this.regimeFiscaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreSede
        {

            private string indirizzoField;

            private byte numeroCivicoField;

            private uint cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public byte NumeroCivico
            {
                get
                {
                    return this.numeroCivicoField;
                }
                set
                {
                    this.numeroCivicoField = value;
                }
            }

            /// <remarks/>
            public uint CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCedentePrestatoreContatti
        {

            private string telefonoField;

            private string emailField;

            /// <remarks/>
            public string Telefono
            {
                get
                {
                    return this.telefonoField;
                }
                set
                {
                    this.telefonoField = value;
                }
            }

            /// <remarks/>
            public string Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittente
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici datiAnagraficiField;

            private FatturaElettronicaHeaderCessionarioCommittenteSede sedeField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici DatiAnagrafici
            {
                get
                {
                    return this.datiAnagraficiField;
                }
                set
                {
                    this.datiAnagraficiField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteSede Sede
            {
                get
                {
                    return this.sedeField;
                }
                set
                {
                    this.sedeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici
        {

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA idFiscaleIVAField;

            private FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica anagraficaField;

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA IdFiscaleIVA
            {
                get
                {
                    return this.idFiscaleIVAField;
                }
                set
                {
                    this.idFiscaleIVAField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica Anagrafica
            {
                get
                {
                    return this.anagraficaField;
                }
                set
                {
                    this.anagraficaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiIdFiscaleIVA
        {

            private string idPaeseField;

            private uint idCodiceField;

            /// <remarks/>
            public string IdPaese
            {
                get
                {
                    return this.idPaeseField;
                }
                set
                {
                    this.idPaeseField = value;
                }
            }

            /// <remarks/>
            public uint IdCodice
            {
                get
                {
                    return this.idCodiceField;
                }
                set
                {
                    this.idCodiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica
        {

            private string denominazioneField;

            /// <remarks/>
            public string Denominazione
            {
                get
                {
                    return this.denominazioneField;
                }
                set
                {
                    this.denominazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaHeaderCessionarioCommittenteSede
        {

            private string indirizzoField;

            private byte numeroCivicoField;

            private ushort cAPField;

            private string comuneField;

            private string provinciaField;

            private string nazioneField;

            /// <remarks/>
            public string Indirizzo
            {
                get
                {
                    return this.indirizzoField;
                }
                set
                {
                    this.indirizzoField = value;
                }
            }

            /// <remarks/>
            public byte NumeroCivico
            {
                get
                {
                    return this.numeroCivicoField;
                }
                set
                {
                    this.numeroCivicoField = value;
                }
            }

            /// <remarks/>
            public ushort CAP
            {
                get
                {
                    return this.cAPField;
                }
                set
                {
                    this.cAPField = value;
                }
            }

            /// <remarks/>
            public string Comune
            {
                get
                {
                    return this.comuneField;
                }
                set
                {
                    this.comuneField = value;
                }
            }

            /// <remarks/>
            public string Provincia
            {
                get
                {
                    return this.provinciaField;
                }
                set
                {
                    this.provinciaField = value;
                }
            }

            /// <remarks/>
            public string Nazione
            {
                get
                {
                    return this.nazioneField;
                }
                set
                {
                    this.nazioneField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FatturaElettronicaBody
        {

            private FatturaElettronicaBodyDatiGenerali datiGeneraliField;

            private FatturaElettronicaBodyDatiBeniServizi datiBeniServiziField;

            private FatturaElettronicaBodyDatiPagamento datiPagamentoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGenerali DatiGenerali
            {
                get
                {
                    return this.datiGeneraliField;
                }
                set
                {
                    this.datiGeneraliField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServizi DatiBeniServizi
            {
                get
                {
                    return this.datiBeniServiziField;
                }
                set
                {
                    this.datiBeniServiziField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamento DatiPagamento
            {
                get
                {
                    return this.datiPagamentoField;
                }
                set
                {
                    this.datiPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGenerali
        {

            private FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento datiGeneraliDocumentoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento DatiGeneraliDocumento
            {
                get
                {
                    return this.datiGeneraliDocumentoField;
                }
                set
                {
                    this.datiGeneraliDocumentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento
        {

            private string tipoDocumentoField;

            private string divisaField;

            private System.DateTime dataField;

            private string numeroField;

            private decimal importoTotaleDocumentoField;

            /// <remarks/>
            public string TipoDocumento
            {
                get
                {
                    return this.tipoDocumentoField;
                }
                set
                {
                    this.tipoDocumentoField = value;
                }
            }

            /// <remarks/>
            public string Divisa
            {
                get
                {
                    return this.divisaField;
                }
                set
                {
                    this.divisaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime Data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }

            /// <remarks/>
            public string Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoTotaleDocumento
            {
                get
                {
                    return this.importoTotaleDocumentoField;
                }
                set
                {
                    this.importoTotaleDocumentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServizi
        {

            private FatturaElettronicaBodyDatiBeniServiziDettaglioLinee dettaglioLineeField;

            private FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo datiRiepilogoField;

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServiziDettaglioLinee DettaglioLinee
            {
                get
                {
                    return this.dettaglioLineeField;
                }
                set
                {
                    this.dettaglioLineeField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo DatiRiepilogo
            {
                get
                {
                    return this.datiRiepilogoField;
                }
                set
                {
                    this.datiRiepilogoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDettaglioLinee
        {

            private byte numeroLineaField;

            private string descrizioneField;

            private decimal quantitaField;

            private decimal prezzoUnitarioField;

            private decimal prezzoTotaleField;

            private decimal aliquotaIVAField;

            private string naturaField;

            /// <remarks/>
            public byte NumeroLinea
            {
                get
                {
                    return this.numeroLineaField;
                }
                set
                {
                    this.numeroLineaField = value;
                }
            }

            /// <remarks/>
            public string Descrizione
            {
                get
                {
                    return this.descrizioneField;
                }
                set
                {
                    this.descrizioneField = value;
                }
            }

            /// <remarks/>
            public decimal Quantita
            {
                get
                {
                    return this.quantitaField;
                }
                set
                {
                    this.quantitaField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoUnitario
            {
                get
                {
                    return this.prezzoUnitarioField;
                }
                set
                {
                    this.prezzoUnitarioField = value;
                }
            }

            /// <remarks/>
            public decimal PrezzoTotale
            {
                get
                {
                    return this.prezzoTotaleField;
                }
                set
                {
                    this.prezzoTotaleField = value;
                }
            }

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }

            /// <remarks/>
            public string Natura
            {
                get
                {
                    return this.naturaField;
                }
                set
                {
                    this.naturaField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo
        {

            private decimal aliquotaIVAField;

            private string naturaField;

            private decimal imponibileImportoField;

            private decimal impostaField;

            private string riferimentoNormativoField;

            /// <remarks/>
            public decimal AliquotaIVA
            {
                get
                {
                    return this.aliquotaIVAField;
                }
                set
                {
                    this.aliquotaIVAField = value;
                }
            }

            /// <remarks/>
            public string Natura
            {
                get
                {
                    return this.naturaField;
                }
                set
                {
                    this.naturaField = value;
                }
            }

            /// <remarks/>
            public decimal ImponibileImporto
            {
                get
                {
                    return this.imponibileImportoField;
                }
                set
                {
                    this.imponibileImportoField = value;
                }
            }

            /// <remarks/>
            public decimal Imposta
            {
                get
                {
                    return this.impostaField;
                }
                set
                {
                    this.impostaField = value;
                }
            }

            /// <remarks/>
            public string RiferimentoNormativo
            {
                get
                {
                    return this.riferimentoNormativoField;
                }
                set
                {
                    this.riferimentoNormativoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamento
        {

            private string condizioniPagamentoField;

            private FatturaElettronicaBodyDatiPagamentoDettaglioPagamento dettaglioPagamentoField;

            /// <remarks/>
            public string CondizioniPagamento
            {
                get
                {
                    return this.condizioniPagamentoField;
                }
                set
                {
                    this.condizioniPagamentoField = value;
                }
            }

            /// <remarks/>
            public FatturaElettronicaBodyDatiPagamentoDettaglioPagamento DettaglioPagamento
            {
                get
                {
                    return this.dettaglioPagamentoField;
                }
                set
                {
                    this.dettaglioPagamentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FatturaElettronicaBodyDatiPagamentoDettaglioPagamento
        {

            private string modalitaPagamentoField;

            private System.DateTime dataScadenzaPagamentoField;

            private decimal importoPagamentoField;

            private string istitutoFinanziarioField;

            private string iBANField;

            /// <remarks/>
            public string ModalitaPagamento
            {
                get
                {
                    return this.modalitaPagamentoField;
                }
                set
                {
                    this.modalitaPagamentoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataScadenzaPagamento
            {
                get
                {
                    return this.dataScadenzaPagamentoField;
                }
                set
                {
                    this.dataScadenzaPagamentoField = value;
                }
            }

            /// <remarks/>
            public decimal ImportoPagamento
            {
                get
                {
                    return this.importoPagamentoField;
                }
                set
                {
                    this.importoPagamentoField = value;
                }
            }

            /// <remarks/>
            public string IstitutoFinanziario
            {
                get
                {
                    return this.istitutoFinanziarioField;
                }
                set
                {
                    this.istitutoFinanziarioField = value;
                }
            }

            /// <remarks/>
            public string IBAN
            {
                get
                {
                    return this.iBANField;
                }
                set
                {
                    this.iBANField = value;
                }
            }
        }


    }

}

