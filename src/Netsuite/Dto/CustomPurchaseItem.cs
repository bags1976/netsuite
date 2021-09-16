namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomPurchaseItem {

        private RecordRef itemField;

        private string vendorNameField;

        private long lineField;

        private bool lineFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private InventoryDetail inventoryDetailField;

        private string descriptionField;

        private string serialNumbersField;

        private string binNumbersField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private string rateField;

        private double amountField;

        private bool amountFieldSpecified;

        private CustomFieldRef[] optionsField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef landedCostCategoryField;

        private RecordRef customerField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private TransactionBillVarianceStatus billVarianceStatusField;

        private bool billVarianceStatusFieldSpecified;

        private RecordRef amortizationSchedField;

        private System.DateTime amortizStartDateField;

        private bool amortizStartDateFieldSpecified;

        private System.DateTime amortizationEndDateField;

        private bool amortizationEndDateFieldSpecified;

        private string amortizationResidualField;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private string taxDetailsReferenceField;

        private LandedCost landedCostField;

        private CustomFieldRef[] customFieldListField;

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
        public string vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
            }
        }

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
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public InventoryDetail inventoryDetail {
            get {
                return this.inventoryDetailField;
            }
            set {
                this.inventoryDetailField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
            }
        }

        /// <remarks/>
        public string binNumbers {
            get {
                return this.binNumbersField;
            }
            set {
                this.binNumbersField = value;
            }
        }

        /// <remarks/>
        public double grossAmt {
            get {
                return this.grossAmtField;
            }
            set {
                this.grossAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossAmtSpecified {
            get {
                return this.grossAmtFieldSpecified;
            }
            set {
                this.grossAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public RecordRef landedCostCategory {
            get {
                return this.landedCostCategoryField;
            }
            set {
                this.landedCostCategoryField = value;
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

        /// <remarks/>
        public TransactionBillVarianceStatus billVarianceStatus {
            get {
                return this.billVarianceStatusField;
            }
            set {
                this.billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billVarianceStatusSpecified {
            get {
                return this.billVarianceStatusFieldSpecified;
            }
            set {
                this.billVarianceStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef amortizationSched {
            get {
                return this.amortizationSchedField;
            }
            set {
                this.amortizationSchedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime amortizStartDate {
            get {
                return this.amortizStartDateField;
            }
            set {
                this.amortizStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizStartDateSpecified {
            get {
                return this.amortizStartDateFieldSpecified;
            }
            set {
                this.amortizStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime amortizationEndDate {
            get {
                return this.amortizationEndDateField;
            }
            set {
                this.amortizationEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationEndDateSpecified {
            get {
                return this.amortizationEndDateFieldSpecified;
            }
            set {
                this.amortizationEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string amortizationResidual {
            get {
                return this.amortizationResidualField;
            }
            set {
                this.amortizationResidualField = value;
            }
        }

        /// <remarks/>
        public double taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxAmountSpecified {
            get {
                return this.taxAmountFieldSpecified;
            }
            set {
                this.taxAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string taxDetailsReference {
            get {
                return this.taxDetailsReferenceField;
            }
            set {
                this.taxDetailsReferenceField = value;
            }
        }

        /// <remarks/>
        public LandedCost landedCost {
            get {
                return this.landedCostField;
            }
            set {
                this.landedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}