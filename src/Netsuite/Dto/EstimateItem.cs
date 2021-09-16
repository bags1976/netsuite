namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class EstimateItem {

        private RecordRef jobField;

        private RecordRef itemField;

        private long lineField;

        private bool lineFieldSpecified;

        private bool expandItemGroupField;

        private bool expandItemGroupFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private string descriptionField;

        private string serialNumbersField;

        private RecordRef priceField;

        private string rateField;

        private double amountField;

        private bool amountFieldSpecified;

        private CustomFieldRef[] optionsField;

        private long revRecTermInMonthsField;

        private bool revRecTermInMonthsFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private double altSalesAmtField;

        private bool altSalesAmtFieldSpecified;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private bool fromJobField;

        private bool fromJobFieldSpecified;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private bool isEstimateField;

        private bool isEstimateFieldSpecified;

        private RecordRef subscriptionField;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef taxCodeField;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private bool excludeFromRateRequestField;

        private bool excludeFromRateRequestFieldSpecified;

        private string taxDetailsReferenceField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private long shipGroupField;

        private bool shipGroupFieldSpecified;

        private bool itemIsFulfilledField;

        private bool itemIsFulfilledFieldSpecified;

        private RecordRef shipAddressField;

        private RecordRef shipMethodField;

        private System.DateTime expectedShipDateField;

        private bool expectedShipDateFieldSpecified;

        private RecordRef chargeTypeField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public RecordRef job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
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
        public bool expandItemGroup {
            get {
                return this.expandItemGroupField;
            }
            set {
                this.expandItemGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expandItemGroupSpecified {
            get {
                return this.expandItemGroupFieldSpecified;
            }
            set {
                this.expandItemGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
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
        public RecordRef price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
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
        public long revRecTermInMonths {
            get {
                return this.revRecTermInMonthsField;
            }
            set {
                this.revRecTermInMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecTermInMonthsSpecified {
            get {
                return this.revRecTermInMonthsFieldSpecified;
            }
            set {
                this.revRecTermInMonthsFieldSpecified = value;
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
        public bool isTaxable {
            get {
                return this.isTaxableField;
            }
            set {
                this.isTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTaxableSpecified {
            get {
                return this.isTaxableFieldSpecified;
            }
            set {
                this.isTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altSalesAmt {
            get {
                return this.altSalesAmtField;
            }
            set {
                this.altSalesAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altSalesAmtSpecified {
            get {
                return this.altSalesAmtFieldSpecified;
            }
            set {
                this.altSalesAmtFieldSpecified = value;
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
        public bool fromJob {
            get {
                return this.fromJobField;
            }
            set {
                this.fromJobField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fromJobSpecified {
            get {
                return this.fromJobFieldSpecified;
            }
            set {
                this.fromJobFieldSpecified = value;
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
        public bool isEstimate {
            get {
                return this.isEstimateField;
            }
            set {
                this.isEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEstimateSpecified {
            get {
                return this.isEstimateFieldSpecified;
            }
            set {
                this.isEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        public double tax1Amt {
            get {
                return this.tax1AmtField;
            }
            set {
                this.tax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax1AmtSpecified {
            get {
                return this.tax1AmtFieldSpecified;
            }
            set {
                this.tax1AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public ItemCostEstimateType costEstimateType {
            get {
                return this.costEstimateTypeField;
            }
            set {
                this.costEstimateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateTypeSpecified {
            get {
                return this.costEstimateTypeFieldSpecified;
            }
            set {
                this.costEstimateTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double costEstimate {
            get {
                return this.costEstimateField;
            }
            set {
                this.costEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateSpecified {
            get {
                return this.costEstimateFieldSpecified;
            }
            set {
                this.costEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool excludeFromRateRequest {
            get {
                return this.excludeFromRateRequestField;
            }
            set {
                this.excludeFromRateRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromRateRequestSpecified {
            get {
                return this.excludeFromRateRequestFieldSpecified;
            }
            set {
                this.excludeFromRateRequestFieldSpecified = value;
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
        public double taxRate1 {
            get {
                return this.taxRate1Field;
            }
            set {
                this.taxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate1Specified {
            get {
                return this.taxRate1FieldSpecified;
            }
            set {
                this.taxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxRate2 {
            get {
                return this.taxRate2Field;
            }
            set {
                this.taxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate2Specified {
            get {
                return this.taxRate2FieldSpecified;
            }
            set {
                this.taxRate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public long shipGroup {
            get {
                return this.shipGroupField;
            }
            set {
                this.shipGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipGroupSpecified {
            get {
                return this.shipGroupFieldSpecified;
            }
            set {
                this.shipGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool itemIsFulfilled {
            get {
                return this.itemIsFulfilledField;
            }
            set {
                this.itemIsFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemIsFulfilledSpecified {
            get {
                return this.itemIsFulfilledFieldSpecified;
            }
            set {
                this.itemIsFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                this.shipAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedShipDate {
            get {
                return this.expectedShipDateField;
            }
            set {
                this.expectedShipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedShipDateSpecified {
            get {
                return this.expectedShipDateFieldSpecified;
            }
            set {
                this.expectedShipDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
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