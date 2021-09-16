namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomListTranslations {

        private Language localeField;

        private bool localeFieldSpecified;

        private string localeDescriptionField;

        private string nameField;

        /// <remarks/>
        public Language locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localeSpecified {
            get {
                return this.localeFieldSpecified;
            }
            set {
                this.localeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string localeDescription {
            get {
                return this.localeDescriptionField;
            }
            set {
                this.localeDescriptionField = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}