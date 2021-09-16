namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class UsageSearch : SearchRecord {

        private UsageSearchBasic basicField;

        private ChargeSearchBasic chargeJoinField;

        private CustomerSearchBasic customerJoinField;

        private ItemSearchBasic itemJoinField;

        private ItemSearchBasic subscriptionPlanJoinField;

        /// <remarks/>
        public UsageSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ChargeSearchBasic chargeJoin {
            get {
                return this.chargeJoinField;
            }
            set {
                this.chargeJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
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
        public ItemSearchBasic subscriptionPlanJoin {
            get {
                return this.subscriptionPlanJoinField;
            }
            set {
                this.subscriptionPlanJoinField = value;
            }
        }
    }
}