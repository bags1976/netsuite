namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CampaignSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] audienceField;

        private SearchColumnDoubleField[] baseCostField;

        private SearchColumnStringField[] campaignIdField;

        private SearchColumnSelectField[] categoryField;

        private SearchColumnSelectField[] channelField;

        private SearchColumnDoubleField[] costField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnStringField[] eventField;

        private SearchColumnDateField[] executedDateField;

        private SearchColumnDoubleField[] expectedRevenueField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] familyField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isSalesCampaignField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnStringField[] keywordField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnSelectField[] managerRoleField;

        private SearchColumnStringField[] messageField;

        private SearchColumnSelectField[] offerField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnStringField[] promoCodeField;

        private SearchColumnSelectField[] recipientField;

        private SearchColumnEnumSelectField[] responseField;

        private SearchColumnEnumSelectField[] responseCategoryField;

        private SearchColumnLongField[] responseCodeField;

        private SearchColumnDateField[] responseDateField;

        private SearchColumnStringField[] responseNotesField;

        private SearchColumnDoubleField[] revenueField;

        private SearchColumnDoubleField[] roiField;

        private SearchColumnDateField[] scheduledDateField;

        private SearchColumnSelectField[] searchEngineField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnStringField[] titleField;

        private SearchColumnStringField[] urlField;

        private SearchColumnSelectField[] verticalField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("audience")]
        public SearchColumnSelectField[] audience {
            get {
                return this.audienceField;
            }
            set {
                this.audienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseCost")]
        public SearchColumnDoubleField[] baseCost {
            get {
                return this.baseCostField;
            }
            set {
                this.baseCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaignId")]
        public SearchColumnStringField[] campaignId {
            get {
                return this.campaignIdField;
            }
            set {
                this.campaignIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public SearchColumnSelectField[] category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("channel")]
        public SearchColumnSelectField[] channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cost")]
        public SearchColumnDoubleField[] cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("event")]
        public SearchColumnStringField[] @event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("executedDate")]
        public SearchColumnDateField[] executedDate {
            get {
                return this.executedDateField;
            }
            set {
                this.executedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedRevenue")]
        public SearchColumnDoubleField[] expectedRevenue {
            get {
                return this.expectedRevenueField;
            }
            set {
                this.expectedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("family")]
        public SearchColumnSelectField[] family {
            get {
                return this.familyField;
            }
            set {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSalesCampaign")]
        public SearchColumnBooleanField[] isSalesCampaign {
            get {
                return this.isSalesCampaignField;
            }
            set {
                this.isSalesCampaignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keyword")]
        public SearchColumnStringField[] keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("managerRole")]
        public SearchColumnSelectField[] managerRole {
            get {
                return this.managerRoleField;
            }
            set {
                this.managerRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offer")]
        public SearchColumnSelectField[] offer {
            get {
                return this.offerField;
            }
            set {
                this.offerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("owner")]
        public SearchColumnSelectField[] owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("promoCode")]
        public SearchColumnStringField[] promoCode {
            get {
                return this.promoCodeField;
            }
            set {
                this.promoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recipient")]
        public SearchColumnSelectField[] recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public SearchColumnEnumSelectField[] response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseCategory")]
        public SearchColumnEnumSelectField[] responseCategory {
            get {
                return this.responseCategoryField;
            }
            set {
                this.responseCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseCode")]
        public SearchColumnLongField[] responseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseDate")]
        public SearchColumnDateField[] responseDate {
            get {
                return this.responseDateField;
            }
            set {
                this.responseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseNotes")]
        public SearchColumnStringField[] responseNotes {
            get {
                return this.responseNotesField;
            }
            set {
                this.responseNotesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revenue")]
        public SearchColumnDoubleField[] revenue {
            get {
                return this.revenueField;
            }
            set {
                this.revenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roi")]
        public SearchColumnDoubleField[] roi {
            get {
                return this.roiField;
            }
            set {
                this.roiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduledDate")]
        public SearchColumnDateField[] scheduledDate {
            get {
                return this.scheduledDateField;
            }
            set {
                this.scheduledDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("searchEngine")]
        public SearchColumnSelectField[] searchEngine {
            get {
                return this.searchEngineField;
            }
            set {
                this.searchEngineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnEnumSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription")]
        public SearchColumnSelectField[] subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public SearchColumnStringField[] title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("url")]
        public SearchColumnStringField[] url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vertical")]
        public SearchColumnSelectField[] vertical {
            get {
                return this.verticalField;
            }
            set {
                this.verticalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}