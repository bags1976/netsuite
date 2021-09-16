namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class OpportunityCompetitors {

        private RecordRef competitorField;

        private string urlField;

        private string notesField;

        private string strategyField;

        private bool winnerField;

        private bool winnerFieldSpecified;

        /// <remarks/>
        public RecordRef competitor {
            get {
                return this.competitorField;
            }
            set {
                this.competitorField = value;
            }
        }

        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public string strategy {
            get {
                return this.strategyField;
            }
            set {
                this.strategyField = value;
            }
        }

        /// <remarks/>
        public bool winner {
            get {
                return this.winnerField;
            }
            set {
                this.winnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool winnerSpecified {
            get {
                return this.winnerFieldSpecified;
            }
            set {
                this.winnerFieldSpecified = value;
            }
        }
    }
}