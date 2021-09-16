namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:website_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategorySearchRow : SearchRow {

        private SiteCategorySearchRowBasic basicField;

        private CustomerSearchRowBasic shopperJoinField;

        private EmployeeSearchRowBasic userJoinField;

        /// <remarks/>
        public SiteCategorySearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchRowBasic shopperJoin {
            get {
                return this.shopperJoinField;
            }
            set {
                this.shopperJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}