namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemAvailabilityFilter {

        private RecordRef[] itemField;

        private System.DateTime lastQtyAvailableChangeField;

        private bool lastQtyAvailableChangeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastQtyAvailableChange {
            get {
                return this.lastQtyAvailableChangeField;
            }
            set {
                this.lastQtyAvailableChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastQtyAvailableChangeSpecified {
            get {
                return this.lastQtyAvailableChangeFieldSpecified;
            }
            set {
                this.lastQtyAvailableChangeFieldSpecified = value;
            }
        }
    }
}