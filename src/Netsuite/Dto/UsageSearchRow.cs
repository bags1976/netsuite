namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class UsageSearchRow : SearchRow {

        private UsageSearchRowBasic basicField;

        private ChargeSearchRowBasic chargeJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private ItemSearchRowBasic itemJoinField;

        private ItemSearchRowBasic subscriptionPlanJoinField;

        /// <remarks/>
        public UsageSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ChargeSearchRowBasic chargeJoin {
            get {
                return this.chargeJoinField;
            }
            set {
                this.chargeJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchRowBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
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
        public ItemSearchRowBasic subscriptionPlanJoin {
            get {
                return this.subscriptionPlanJoinField;
            }
            set {
                this.subscriptionPlanJoinField = value;
            }
        }
    }
}