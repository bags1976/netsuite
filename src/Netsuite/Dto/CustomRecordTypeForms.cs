namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeForms {

        private string formEditField;

        private string formNameField;

        private bool formPrefField;

        private bool formPrefFieldSpecified;

        /// <remarks/>
        public string formEdit {
            get {
                return this.formEditField;
            }
            set {
                this.formEditField = value;
            }
        }

        /// <remarks/>
        public string formName {
            get {
                return this.formNameField;
            }
            set {
                this.formNameField = value;
            }
        }

        /// <remarks/>
        public bool formPref {
            get {
                return this.formPrefField;
            }
            set {
                this.formPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formPrefSpecified {
            get {
                return this.formPrefFieldSpecified;
            }
            set {
                this.formPrefFieldSpecified = value;
            }
        }
    }
}