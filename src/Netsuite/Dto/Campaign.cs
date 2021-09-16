namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class Campaign : Record {

        private RecordRef customFormField;

        private string campaignIdField;

        private string titleField;

        private RecordRef categoryField;

        private RecordRef ownerField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private string urlField;

        private double baseCostField;

        private bool baseCostFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private double expectedRevenueField;

        private bool expectedRevenueFieldSpecified;

        private string messageField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool localField;

        private bool localFieldSpecified;

        private double totalRevenueField;

        private bool totalRevenueFieldSpecified;

        private double roiField;

        private bool roiFieldSpecified;

        private double profitField;

        private bool profitFieldSpecified;

        private double costPerCustomerField;

        private bool costPerCustomerFieldSpecified;

        private double convCostPerCustomerField;

        private bool convCostPerCustomerFieldSpecified;

        private long conversionsField;

        private bool conversionsFieldSpecified;

        private long leadsGeneratedField;

        private bool leadsGeneratedFieldSpecified;

        private long uniqueVisitorsField;

        private bool uniqueVisitorsFieldSpecified;

        private RecordRef verticalField;

        private RecordRef audienceField;

        private RecordRef offerField;

        private RecordRef promotionCodeField;

        private RecordRef[] itemListField;

        private RecordRef familyField;

        private RecordRef searchEngineField;

        private string keywordField;

        private CampaignEmailList campaignEmailListField;

        private CampaignDirectMailList campaignDirectMailListField;

        private CampaignEventList campaignEventListField;

        private CampaignEventResponseList eventResponseListField;

        private CustomFieldRef[] customFieldListField;

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
        public string campaignId {
            get {
                return this.campaignIdField;
            }
            set {
                this.campaignIdField = value;
            }
        }

        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public double baseCost {
            get {
                return this.baseCostField;
            }
            set {
                this.baseCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseCostSpecified {
            get {
                return this.baseCostFieldSpecified;
            }
            set {
                this.baseCostFieldSpecified = value;
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
        public double expectedRevenue {
            get {
                return this.expectedRevenueField;
            }
            set {
                this.expectedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedRevenueSpecified {
            get {
                return this.expectedRevenueFieldSpecified;
            }
            set {
                this.expectedRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
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
        public bool local {
            get {
                return this.localField;
            }
            set {
                this.localField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localSpecified {
            get {
                return this.localFieldSpecified;
            }
            set {
                this.localFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double totalRevenue {
            get {
                return this.totalRevenueField;
            }
            set {
                this.totalRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalRevenueSpecified {
            get {
                return this.totalRevenueFieldSpecified;
            }
            set {
                this.totalRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double roi {
            get {
                return this.roiField;
            }
            set {
                this.roiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roiSpecified {
            get {
                return this.roiFieldSpecified;
            }
            set {
                this.roiFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double profit {
            get {
                return this.profitField;
            }
            set {
                this.profitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool profitSpecified {
            get {
                return this.profitFieldSpecified;
            }
            set {
                this.profitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double costPerCustomer {
            get {
                return this.costPerCustomerField;
            }
            set {
                this.costPerCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costPerCustomerSpecified {
            get {
                return this.costPerCustomerFieldSpecified;
            }
            set {
                this.costPerCustomerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double convCostPerCustomer {
            get {
                return this.convCostPerCustomerField;
            }
            set {
                this.convCostPerCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool convCostPerCustomerSpecified {
            get {
                return this.convCostPerCustomerFieldSpecified;
            }
            set {
                this.convCostPerCustomerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long conversions {
            get {
                return this.conversionsField;
            }
            set {
                this.conversionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conversionsSpecified {
            get {
                return this.conversionsFieldSpecified;
            }
            set {
                this.conversionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long leadsGenerated {
            get {
                return this.leadsGeneratedField;
            }
            set {
                this.leadsGeneratedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leadsGeneratedSpecified {
            get {
                return this.leadsGeneratedFieldSpecified;
            }
            set {
                this.leadsGeneratedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long uniqueVisitors {
            get {
                return this.uniqueVisitorsField;
            }
            set {
                this.uniqueVisitorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uniqueVisitorsSpecified {
            get {
                return this.uniqueVisitorsFieldSpecified;
            }
            set {
                this.uniqueVisitorsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef vertical {
            get {
                return this.verticalField;
            }
            set {
                this.verticalField = value;
            }
        }

        /// <remarks/>
        public RecordRef audience {
            get {
                return this.audienceField;
            }
            set {
                this.audienceField = value;
            }
        }

        /// <remarks/>
        public RecordRef offer {
            get {
                return this.offerField;
            }
            set {
                this.offerField = value;
            }
        }

        /// <remarks/>
        public RecordRef promotionCode {
            get {
                return this.promotionCodeField;
            }
            set {
                this.promotionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public RecordRef family {
            get {
                return this.familyField;
            }
            set {
                this.familyField = value;
            }
        }

        /// <remarks/>
        public RecordRef searchEngine {
            get {
                return this.searchEngineField;
            }
            set {
                this.searchEngineField = value;
            }
        }

        /// <remarks/>
        public string keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        public CampaignEmailList campaignEmailList {
            get {
                return this.campaignEmailListField;
            }
            set {
                this.campaignEmailListField = value;
            }
        }

        /// <remarks/>
        public CampaignDirectMailList campaignDirectMailList {
            get {
                return this.campaignDirectMailListField;
            }
            set {
                this.campaignDirectMailListField = value;
            }
        }

        /// <remarks/>
        public CampaignEventList campaignEventList {
            get {
                return this.campaignEventListField;
            }
            set {
                this.campaignEventListField = value;
            }
        }

        /// <remarks/>
        public CampaignEventResponseList eventResponseList {
            get {
                return this.eventResponseListField;
            }
            set {
                this.eventResponseListField = value;
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