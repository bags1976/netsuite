namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class Usage : Record {

        private RecordRef customFormField;

        private string memoField;

        private RecordRef itemField;

        private RecordRef subscriptionPlanField;

        private RecordRef customerField;

        private RecordRef usageSubscriptionField;

        private RecordRef usageSubscriptionLineField;

        private double usageQuantityField;

        private bool usageQuantityFieldSpecified;

        private System.DateTime usageDateField;

        private bool usageDateFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public RecordRef subscriptionPlan {
            get {
                return this.subscriptionPlanField;
            }
            set {
                this.subscriptionPlanField = value;
            }
        }

        /// <remarks/>
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public RecordRef usageSubscription {
            get {
                return this.usageSubscriptionField;
            }
            set {
                this.usageSubscriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef usageSubscriptionLine {
            get {
                return this.usageSubscriptionLineField;
            }
            set {
                this.usageSubscriptionLineField = value;
            }
        }

        /// <remarks/>
        public double usageQuantity {
            get {
                return this.usageQuantityField;
            }
            set {
                this.usageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usageQuantitySpecified {
            get {
                return this.usageQuantityFieldSpecified;
            }
            set {
                this.usageQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime usageDate {
            get {
                return this.usageDateField;
            }
            set {
                this.usageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usageDateSpecified {
            get {
                return this.usageDateFieldSpecified;
            }
            set {
                this.usageDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}