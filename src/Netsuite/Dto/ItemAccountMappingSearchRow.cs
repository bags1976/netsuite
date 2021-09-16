namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemAccountMappingSearchRow : SearchRow {

        private ItemAccountMappingSearchRowBasic basicField;

        private ClassificationSearchRowBasic classJoinField;

        private DepartmentSearchRowBasic departmentJoinField;

        private AccountSearchRowBasic destinationAccountJoinField;

        private LocationSearchRowBasic locationJoinField;

        private AccountSearchRowBasic sourceAccountJoinField;

        private SubsidiarySearchRowBasic subsidiaryJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ItemAccountMappingSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchRowBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchRowBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic destinationAccountJoin {
            get {
                return this.destinationAccountJoinField;
            }
            set {
                this.destinationAccountJoinField = value;
            }
        }

        /// <remarks/>
        public LocationSearchRowBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic sourceAccountJoin {
            get {
                return this.sourceAccountJoinField;
            }
            set {
                this.sourceAccountJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchRowBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}