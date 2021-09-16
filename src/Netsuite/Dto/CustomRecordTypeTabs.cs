namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeTabs {

        private string tabTitleField;

        private RecordRef tabParentField;

        private LanguageValueList tabTitleLanguageValueListField;

        /// <remarks/>
        public string tabTitle {
            get {
                return this.tabTitleField;
            }
            set {
                this.tabTitleField = value;
            }
        }

        /// <remarks/>
        public RecordRef tabParent {
            get {
                return this.tabParentField;
            }
            set {
                this.tabParentField = value;
            }
        }

        /// <remarks/>
        public LanguageValueList tabTitleLanguageValueList {
            get {
                return this.tabTitleLanguageValueListField;
            }
            set {
                this.tabTitleLanguageValueListField = value;
            }
        }
    }
}