namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingSearch : SearchRecord {

        private ManufacturingRoutingSearchBasic basicField;

        private ItemSearchBasic itemJoinField;

        private LocationSearchBasic locationJoinField;

        private ManufacturingCostTemplateSearchBasic manufacturingCostTemplateJoinField;

        private EntityGroupSearchBasic manufacturingWorkCenterJoinField;

        private EmployeeSearchBasic userJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ManufacturingRoutingSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ItemSearchBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
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
        public ManufacturingCostTemplateSearchBasic manufacturingCostTemplateJoin {
            get {
                return this.manufacturingCostTemplateJoinField;
            }
            set {
                this.manufacturingCostTemplateJoinField = value;
            }
        }

        /// <remarks/>
        public EntityGroupSearchBasic manufacturingWorkCenterJoin {
            get {
                return this.manufacturingWorkCenterJoinField;
            }
            set {
                this.manufacturingWorkCenterJoinField = value;
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