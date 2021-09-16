namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:website_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategorySearch : SearchRecord {

        private SiteCategorySearchBasic basicField;

        private CustomerSearchBasic shopperJoinField;

        private EmployeeSearchBasic userJoinField;

        /// <remarks/>
        public SiteCategorySearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchBasic shopperJoin {
            get {
                return this.shopperJoinField;
            }
            set {
                this.shopperJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}