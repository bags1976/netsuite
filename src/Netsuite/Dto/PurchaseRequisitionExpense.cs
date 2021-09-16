namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class PurchaseRequisitionExpense {

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef categoryField;

        private RecordRef locationField;

        private bool isClosedField;

        private bool isClosedFieldSpecified;

        private RecordRef accountField;

        private RecordRef poVendorField;

        private double estimatedAmountField;

        private bool estimatedAmountFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private string memoField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef customerField;

        private RecordRef[] linkedOrderListField;

        private string linkedOrderStatusField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        /// <remarks/>
        public long line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified {
            get {
                return this.lineFieldSpecified;
            }
            set {
                this.lineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public bool isClosed {
            get {
                return this.isClosedField;
            }
            set {
                this.isClosedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isClosedSpecified {
            get {
                return this.isClosedFieldSpecified;
            }
            set {
                this.isClosedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public RecordRef poVendor {
            get {
                return this.poVendorField;
            }
            set {
                this.poVendorField = value;
            }
        }

        /// <remarks/>
        public double estimatedAmount {
            get {
                return this.estimatedAmountField;
            }
            set {
                this.estimatedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedAmountSpecified {
            get {
                return this.estimatedAmountFieldSpecified;
            }
            set {
                this.estimatedAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] linkedOrderList {
            get {
                return this.linkedOrderListField;
            }
            set {
                this.linkedOrderListField = value;
            }
        }

        /// <remarks/>
        public string linkedOrderStatus {
            get {
                return this.linkedOrderStatusField;
            }
            set {
                this.linkedOrderStatusField = value;
            }
        }

        /// <remarks/>
        public bool isBillable {
            get {
                return this.isBillableField;
            }
            set {
                this.isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBillableSpecified {
            get {
                return this.isBillableFieldSpecified;
            }
            set {
                this.isBillableFieldSpecified = value;
            }
        }
    }
}