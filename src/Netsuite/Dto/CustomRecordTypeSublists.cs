namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeSublists {

        private RecordRef recordSearchField;

        private string recordDescrField;

        private LanguageValueList recordDescrLanguageValueListField;

        private RecordRef recordTabField;

        private string recordIdField;

        /// <remarks/>
        public RecordRef recordSearch {
            get {
                return this.recordSearchField;
            }
            set {
                this.recordSearchField = value;
            }
        }

        /// <remarks/>
        public string recordDescr {
            get {
                return this.recordDescrField;
            }
            set {
                this.recordDescrField = value;
            }
        }

        /// <remarks/>
        public LanguageValueList recordDescrLanguageValueList {
            get {
                return this.recordDescrLanguageValueListField;
            }
            set {
                this.recordDescrLanguageValueListField = value;
            }
        }

        /// <remarks/>
        public RecordRef recordTab {
            get {
                return this.recordTabField;
            }
            set {
                this.recordTabField = value;
            }
        }

        /// <remarks/>
        public string recordId {
            get {
                return this.recordIdField;
            }
            set {
                this.recordIdField = value;
            }
        }
    }
}