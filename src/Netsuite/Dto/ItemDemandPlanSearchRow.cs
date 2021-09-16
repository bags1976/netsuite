namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:demandplanning_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemDemandPlanSearchRow : SearchRow {

        private ItemDemandPlanSearchRowBasic basicField;

        private ItemSearchRowBasic itemJoinField;

        private ItemSearchRowBasic lastAlternateSourceItemJoinField;

        private LocationSearchRowBasic locationJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ItemDemandPlanSearchRowBasic basic {
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
        public ItemSearchRowBasic lastAlternateSourceItemJoin {
            get {
                return this.lastAlternateSourceItemJoinField;
            }
            set {
                this.lastAlternateSourceItemJoinField = value;
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