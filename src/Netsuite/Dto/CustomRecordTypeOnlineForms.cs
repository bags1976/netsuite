namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeOnlineForms {

        private string onlineFormNameField;

        private string isOnlineField;

        private string templateNameField;

        /// <remarks/>
        public string onlineFormName {
            get {
                return this.onlineFormNameField;
            }
            set {
                this.onlineFormNameField = value;
            }
        }

        /// <remarks/>
        public string isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        public string templateName {
            get {
                return this.templateNameField;
            }
            set {
                this.templateNameField = value;
            }
        }
    }
}