namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingSearchRow : SearchRow {

        private ManufacturingRoutingSearchRowBasic basicField;

        private ItemSearchRowBasic itemJoinField;

        private LocationSearchRowBasic locationJoinField;

        private ManufacturingCostTemplateSearchRowBasic manufacturingCostTemplateJoinField;

        private EntityGroupSearchRowBasic manufacturingWorkCenterJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ManufacturingRoutingSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ItemSearchRowBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
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
        public ManufacturingCostTemplateSearchRowBasic manufacturingCostTemplateJoin {
            get {
                return this.manufacturingCostTemplateJoinField;
            }
            set {
                this.manufacturingCostTemplateJoinField = value;
            }
        }

        /// <remarks/>
        public EntityGroupSearchRowBasic manufacturingWorkCenterJoin {
            get {
                return this.manufacturingWorkCenterJoinField;
            }
            set {
                this.manufacturingWorkCenterJoinField = value;
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