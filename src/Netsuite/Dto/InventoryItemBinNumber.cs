namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class InventoryItemBinNumber {

        private RecordRef binNumberField;

        private string onHandField;

        private string onHandAvailField;

        private string locationField;

        private bool preferredBinField;

        private bool preferredBinFieldSpecified;

        /// <remarks/>
        public RecordRef binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        public string onHand {
            get {
                return this.onHandField;
            }
            set {
                this.onHandField = value;
            }
        }

        /// <remarks/>
        public string onHandAvail {
            get {
                return this.onHandAvailField;
            }
            set {
                this.onHandAvailField = value;
            }
        }

        /// <remarks/>
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public bool preferredBin {
            get {
                return this.preferredBinField;
            }
            set {
                this.preferredBinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredBinSpecified {
            get {
                return this.preferredBinFieldSpecified;
            }
            set {
                this.preferredBinFieldSpecified = value;
            }
        }
    }
}