namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemBinNumberSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] binNumberField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnDoubleField[] quantityAvailableField;

        private SearchColumnDoubleField[] quantityOnHandField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binNumber")]
        public SearchColumnSelectField[] binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityAvailable")]
        public SearchColumnDoubleField[] quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityOnHand")]
        public SearchColumnDoubleField[] quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }
    }
}