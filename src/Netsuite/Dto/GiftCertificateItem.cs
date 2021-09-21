using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class GiftCertificateItem : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef parentField;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isGcoCompliantField;

        private bool isGcoCompliantFieldSpecified;

        private bool offerSupportField;

        private bool offerSupportFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool availableToPartnersField;

        private bool availableToPartnersFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef[] subsidiaryListField;

        private string salesDescriptionField;

        private RecordRef incomeAccountField;

        private RecordRef liabilityAccountField;

        private long daysBeforeExpirationField;

        private bool daysBeforeExpirationFieldSpecified;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

        private string urlComponentField;

        private RecordRef salesTaxCodeField;

        private bool pricesIncludeTaxField;

        private bool pricesIncludeTaxFieldSpecified;

        private RecordRef taxScheduleField;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private RecordRef billingScheduleField;

        private RecordRef issueProductField;

        private bool isFulfillableField;

        private bool isFulfillableFieldSpecified;

        private string storeDisplayNameField;

        private RecordRef storeDisplayThumbnailField;

        private RecordRef storeDisplayImageField;

        private string storeDescriptionField;

        private string storeDetailedDescriptionField;

        private RecordRef storeItemTemplateField;

        private string pageTitleField;

        private string metaTagHtmlField;

        private bool excludeFromSitemapField;

        private bool excludeFromSitemapFieldSpecified;

        private SitemapPriority sitemapPriorityField;

        private bool sitemapPriorityFieldSpecified;

        private string searchKeywordsField;

        private bool isDonationItemField;

        private bool isDonationItemFieldSpecified;

        private bool showDefaultDonationAmountField;

        private bool showDefaultDonationAmountFieldSpecified;

        private double maxDonationAmountField;

        private bool maxDonationAmountFieldSpecified;

        private bool dontShowPriceField;

        private bool dontShowPriceFieldSpecified;

        private string noPriceMessageField;

        private string outOfStockMessageField;

        private bool onSpecialField;

        private bool onSpecialFieldSpecified;

        private ItemOutOfStockBehavior outOfStockBehaviorField;

        private bool outOfStockBehaviorFieldSpecified;

        private string specialsDescriptionField;

        private string featuredDescriptionField;

        private string relatedItemsDescriptionField;

        private PricingMatrix pricingMatrixField;

        private GiftCertificateItemAuthCodesList authCodesListField;

        private SiteCategoryList siteCategoryListField;

        private TranslationList translationsListField;

        private RecordRef[] itemOptionsListField;

        private PresentationItemList presentationItemListField;

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
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isGcoCompliant {
            get {
                return this.isGcoCompliantField;
            }
            set {
                this.isGcoCompliantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGcoCompliantSpecified {
            get {
                return this.isGcoCompliantFieldSpecified;
            }
            set {
                this.isGcoCompliantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool offerSupport {
            get {
                return this.offerSupportField;
            }
            set {
                this.offerSupportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool offerSupportSpecified {
            get {
                return this.offerSupportFieldSpecified;
            }
            set {
                this.offerSupportFieldSpecified = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public string salesDescription {
            get {
                return this.salesDescriptionField;
            }
            set {
                this.salesDescriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef incomeAccount {
            get {
                return this.incomeAccountField;
            }
            set {
                this.incomeAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef liabilityAccount {
            get {
                return this.liabilityAccountField;
            }
            set {
                this.liabilityAccountField = value;
            }
        }

        /// <remarks/>
        public long daysBeforeExpiration {
            get {
                return this.daysBeforeExpirationField;
            }
            set {
                this.daysBeforeExpirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysBeforeExpirationSpecified {
            get {
                return this.daysBeforeExpirationFieldSpecified;
            }
            set {
                this.daysBeforeExpirationFieldSpecified = value;
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
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
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
        public bool pricesIncludeTax {
            get {
                return this.pricesIncludeTaxField;
            }
            set {
                this.pricesIncludeTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pricesIncludeTaxSpecified {
            get {
                return this.pricesIncludeTaxFieldSpecified;
            }
            set {
                this.pricesIncludeTaxFieldSpecified = value;
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
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
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
        public string storeDisplayName {
            get {
                return this.storeDisplayNameField;
            }
            set {
                this.storeDisplayNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayThumbnail {
            get {
                return this.storeDisplayThumbnailField;
            }
            set {
                this.storeDisplayThumbnailField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayImage {
            get {
                return this.storeDisplayImageField;
            }
            set {
                this.storeDisplayImageField = value;
            }
        }

        /// <remarks/>
        public string storeDescription {
            get {
                return this.storeDescriptionField;
            }
            set {
                this.storeDescriptionField = value;
            }
        }

        /// <remarks/>
        public string storeDetailedDescription {
            get {
                return this.storeDetailedDescriptionField;
            }
            set {
                this.storeDetailedDescriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeItemTemplate {
            get {
                return this.storeItemTemplateField;
            }
            set {
                this.storeItemTemplateField = value;
            }
        }

        /// <remarks/>
        public string pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
            }
        }

        /// <remarks/>
        public string metaTagHtml {
            get {
                return this.metaTagHtmlField;
            }
            set {
                this.metaTagHtmlField = value;
            }
        }

        /// <remarks/>
        public bool excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromSitemapSpecified {
            get {
                return this.excludeFromSitemapFieldSpecified;
            }
            set {
                this.excludeFromSitemapFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SitemapPriority sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sitemapPrioritySpecified {
            get {
                return this.sitemapPriorityFieldSpecified;
            }
            set {
                this.sitemapPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string searchKeywords {
            get {
                return this.searchKeywordsField;
            }
            set {
                this.searchKeywordsField = value;
            }
        }

        /// <remarks/>
        public bool isDonationItem {
            get {
                return this.isDonationItemField;
            }
            set {
                this.isDonationItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDonationItemSpecified {
            get {
                return this.isDonationItemFieldSpecified;
            }
            set {
                this.isDonationItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showDefaultDonationAmount {
            get {
                return this.showDefaultDonationAmountField;
            }
            set {
                this.showDefaultDonationAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showDefaultDonationAmountSpecified {
            get {
                return this.showDefaultDonationAmountFieldSpecified;
            }
            set {
                this.showDefaultDonationAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double maxDonationAmount {
            get {
                return this.maxDonationAmountField;
            }
            set {
                this.maxDonationAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxDonationAmountSpecified {
            get {
                return this.maxDonationAmountFieldSpecified;
            }
            set {
                this.maxDonationAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool dontShowPrice {
            get {
                return this.dontShowPriceField;
            }
            set {
                this.dontShowPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dontShowPriceSpecified {
            get {
                return this.dontShowPriceFieldSpecified;
            }
            set {
                this.dontShowPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string noPriceMessage {
            get {
                return this.noPriceMessageField;
            }
            set {
                this.noPriceMessageField = value;
            }
        }

        /// <remarks/>
        public string outOfStockMessage {
            get {
                return this.outOfStockMessageField;
            }
            set {
                this.outOfStockMessageField = value;
            }
        }

        /// <remarks/>
        public bool onSpecial {
            get {
                return this.onSpecialField;
            }
            set {
                this.onSpecialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onSpecialSpecified {
            get {
                return this.onSpecialFieldSpecified;
            }
            set {
                this.onSpecialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemOutOfStockBehavior outOfStockBehavior {
            get {
                return this.outOfStockBehaviorField;
            }
            set {
                this.outOfStockBehaviorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool outOfStockBehaviorSpecified {
            get {
                return this.outOfStockBehaviorFieldSpecified;
            }
            set {
                this.outOfStockBehaviorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string specialsDescription {
            get {
                return this.specialsDescriptionField;
            }
            set {
                this.specialsDescriptionField = value;
            }
        }

        /// <remarks/>
        public string featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
            }
        }

        /// <remarks/>
        public string relatedItemsDescription {
            get {
                return this.relatedItemsDescriptionField;
            }
            set {
                this.relatedItemsDescriptionField = value;
            }
        }

        /// <remarks/>
        public PricingMatrix pricingMatrix {
            get {
                return this.pricingMatrixField;
            }
            set {
                this.pricingMatrixField = value;
            }
        }

        /// <remarks/>
        public GiftCertificateItemAuthCodesList authCodesList {
            get {
                return this.authCodesListField;
            }
            set {
                this.authCodesListField = value;
            }
        }

        /// <remarks/>
        public SiteCategoryList siteCategoryList {
            get {
                return this.siteCategoryListField;
            }
            set {
                this.siteCategoryListField = value;
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
        public PresentationItemList presentationItemList {
            get {
                return this.presentationItemListField;
            }
            set {
                this.presentationItemListField = value;
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