namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class OtherChargePurchaseItem : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string purchaseDescriptionField;

        private bool manufacturingChargeItemField;

        private bool manufacturingChargeItemFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private string costUnitsField;

        private RecordRef expenseAccountField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private ItemMatrixType matrixTypeField;

        private bool matrixTypeFieldSpecified;

        private RecordRef unitsTypeField;

        private RecordRef purchaseUnitField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef issueProductField;

        private RecordRef customFormField;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private string vendorNameField;

        private RecordRef parentField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string matrixItemNameTemplateField;

        private bool availableToPartnersField;

        private bool availableToPartnersFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef[] subsidiaryListField;

        private RecordRef locationField;

        private RecordRef taxScheduleField;

        private RecordRef deferralAccountField;

        private RecordRef amortizationTemplateField;

        private string residualField;

        private long amortizationPeriodField;

        private bool amortizationPeriodFieldSpecified;

        private bool isFulfillableField;

        private bool isFulfillableFieldSpecified;

        private bool generateAccrualsField;

        private bool generateAccrualsFieldSpecified;

        private ItemAccountingBookDetailList accountingBookDetailListField;

        private RecordRef costCategoryField;

        private ItemOverheadType overheadTypeField;

        private bool overheadTypeFieldSpecified;

        private double purchaseOrderQuantityField;

        private bool purchaseOrderQuantityFieldSpecified;

        private double purchaseOrderAmountField;

        private bool purchaseOrderAmountFieldSpecified;

        private double purchaseOrderQuantityDiffField;

        private bool purchaseOrderQuantityDiffFieldSpecified;

        private double receiptQuantityField;

        private bool receiptQuantityFieldSpecified;

        private double receiptAmountField;

        private bool receiptAmountFieldSpecified;

        private double receiptQuantityDiffField;

        private bool receiptQuantityDiffFieldSpecified;

        private string currencyField;

        private RecordRef[] itemOptionsListField;

        private SelectCustomFieldRef[] matrixOptionListField;

        private ItemVendorList itemVendorListField;

        private RecordRef purchaseTaxCodeField;

        private RecordRef salesTaxCodeField;

        private TranslationList translationsListField;

        private RecordRef vendorField;

        private OtherChargePurchaseItemHierarchyVersionsList hierarchyVersionsListField;

        private RecordRef consumptionUnitField;

        private RecordRef billQtyVarianceAcctField;

        private RecordRef billPriceVarianceAcctField;

        private RecordRef billExchRateVarianceAcctField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string purchaseDescription {
            get {
                return this.purchaseDescriptionField;
            }
            set {
                this.purchaseDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool manufacturingChargeItem {
            get {
                return this.manufacturingChargeItemField;
            }
            set {
                this.manufacturingChargeItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manufacturingChargeItemSpecified {
            get {
                return this.manufacturingChargeItemFieldSpecified;
            }
            set {
                this.manufacturingChargeItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string costUnits {
            get {
                return this.costUnitsField;
            }
            set {
                this.costUnitsField = value;
            }
        }

        /// <remarks/>
        public RecordRef expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
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
        public ItemMatrixType matrixType {
            get {
                return this.matrixTypeField;
            }
            set {
                this.matrixTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matrixTypeSpecified {
            get {
                return this.matrixTypeFieldSpecified;
            }
            set {
                this.matrixTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseUnit {
            get {
                return this.purchaseUnitField;
            }
            set {
                this.purchaseUnitField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
            }
        }

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
        public string itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public string upcCode {
            get {
                return this.upcCodeField;
            }
            set {
                this.upcCodeField = value;
            }
        }

        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
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
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string matrixItemNameTemplate {
            get {
                return this.matrixItemNameTemplateField;
            }
            set {
                this.matrixItemNameTemplateField = value;
            }
        }

        /// <remarks/>
        public bool availableToPartners {
            get {
                return this.availableToPartnersField;
            }
            set {
                this.availableToPartnersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableToPartnersSpecified {
            get {
                return this.availableToPartnersFieldSpecified;
            }
            set {
                this.availableToPartnersFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] subsidiaryList {
            get {
                return this.subsidiaryListField;
            }
            set {
                this.subsidiaryListField = value;
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
        public RecordRef taxSchedule {
            get {
                return this.taxScheduleField;
            }
            set {
                this.taxScheduleField = value;
            }
        }

        /// <remarks/>
        public RecordRef deferralAccount {
            get {
                return this.deferralAccountField;
            }
            set {
                this.deferralAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef amortizationTemplate {
            get {
                return this.amortizationTemplateField;
            }
            set {
                this.amortizationTemplateField = value;
            }
        }

        /// <remarks/>
        public string residual {
            get {
                return this.residualField;
            }
            set {
                this.residualField = value;
            }
        }

        /// <remarks/>
        public long amortizationPeriod {
            get {
                return this.amortizationPeriodField;
            }
            set {
                this.amortizationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationPeriodSpecified {
            get {
                return this.amortizationPeriodFieldSpecified;
            }
            set {
                this.amortizationPeriodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isFulfillable {
            get {
                return this.isFulfillableField;
            }
            set {
                this.isFulfillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFulfillableSpecified {
            get {
                return this.isFulfillableFieldSpecified;
            }
            set {
                this.isFulfillableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool generateAccruals {
            get {
                return this.generateAccrualsField;
            }
            set {
                this.generateAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generateAccrualsSpecified {
            get {
                return this.generateAccrualsFieldSpecified;
            }
            set {
                this.generateAccrualsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemAccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public RecordRef costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        public ItemOverheadType overheadType {
            get {
                return this.overheadTypeField;
            }
            set {
                this.overheadTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overheadTypeSpecified {
            get {
                return this.overheadTypeFieldSpecified;
            }
            set {
                this.overheadTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantitySpecified {
            get {
                return this.purchaseOrderQuantityFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderAmountSpecified {
            get {
                return this.purchaseOrderAmountFieldSpecified;
            }
            set {
                this.purchaseOrderAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantityDiffSpecified {
            get {
                return this.purchaseOrderQuantityDiffFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityDiffFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantitySpecified {
            get {
                return this.receiptQuantityFieldSpecified;
            }
            set {
                this.receiptQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptAmountSpecified {
            get {
                return this.receiptAmountFieldSpecified;
            }
            set {
                this.receiptAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantityDiffSpecified {
            get {
                return this.receiptQuantityDiffFieldSpecified;
            }
            set {
                this.receiptQuantityDiffFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("itemOptions", IsNullable=false)]
        public RecordRef[] itemOptionsList {
            get {
                return this.itemOptionsListField;
            }
            set {
                this.itemOptionsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("matrixOption", IsNullable=false)]
        public SelectCustomFieldRef[] matrixOptionList {
            get {
                return this.matrixOptionListField;
            }
            set {
                this.matrixOptionListField = value;
            }
        }

        /// <remarks/>
        public ItemVendorList itemVendorList {
            get {
                return this.itemVendorListField;
            }
            set {
                this.itemVendorListField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseTaxCode {
            get {
                return this.purchaseTaxCodeField;
            }
            set {
                this.purchaseTaxCodeField = value;
            }
        }

        /// <remarks/>
        public RecordRef salesTaxCode {
            get {
                return this.salesTaxCodeField;
            }
            set {
                this.salesTaxCodeField = value;
            }
        }

        /// <remarks/>
        public TranslationList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public OtherChargePurchaseItemHierarchyVersionsList hierarchyVersionsList {
            get {
                return this.hierarchyVersionsListField;
            }
            set {
                this.hierarchyVersionsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef consumptionUnit {
            get {
                return this.consumptionUnitField;
            }
            set {
                this.consumptionUnitField = value;
            }
        }

        /// <remarks/>
        public RecordRef billQtyVarianceAcct {
            get {
                return this.billQtyVarianceAcctField;
            }
            set {
                this.billQtyVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef billPriceVarianceAcct {
            get {
                return this.billPriceVarianceAcctField;
            }
            set {
                this.billPriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef billExchRateVarianceAcct {
            get {
                return this.billExchRateVarianceAcctField;
            }
            set {
                this.billExchRateVarianceAcctField = value;
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