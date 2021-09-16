namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategory {

        private RecordRef websiteField;

        private RecordRef categoryField;

        private bool isDefaultField;

        private bool isDefaultFieldSpecified;

        private string categoryDescriptionField;

        /// <remarks/>
        public RecordRef website {
            get {
                return this.websiteField;
            }
            set {
                this.websiteField = value;
            }
        }

        /// <remarks/>
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public bool isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultSpecified {
            get {
                return this.isDefaultFieldSpecified;
            }
            set {
                this.isDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string categoryDescription {
            get {
                return this.categoryDescriptionField;
            }
            set {
                this.categoryDescriptionField = value;
            }
        }
    }
}