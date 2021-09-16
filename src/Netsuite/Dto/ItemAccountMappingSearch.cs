namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemAccountMappingSearch : SearchRecord {

        private ItemAccountMappingSearchBasic basicField;

        private ClassificationSearchBasic classJoinField;

        private DepartmentSearchBasic departmentJoinField;

        private AccountSearchBasic destinationAccountJoinField;

        private LocationSearchBasic locationJoinField;

        private AccountSearchBasic sourceAccountJoinField;

        private SubsidiarySearchBasic subsidiaryJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ItemAccountMappingSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic destinationAccountJoin {
            get {
                return this.destinationAccountJoinField;
            }
            set {
                this.destinationAccountJoinField = value;
            }
        }

        /// <remarks/>
        public LocationSearchBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic sourceAccountJoin {
            get {
                return this.sourceAccountJoinField;
            }
            set {
                this.sourceAccountJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}