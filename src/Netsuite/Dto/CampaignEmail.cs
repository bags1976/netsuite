namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignEmail {

        private string internalIdField;

        private RecordRef campaignGroupField;

        private RecordRef templateField;

        private string descriptionField;

        private RecordRef subscriptionField;

        private RecordRef channelField;

        private double costField;

        private bool costFieldSpecified;

        private CampaignCampaignEmailStatus statusField;

        private bool statusFieldSpecified;

        private System.DateTime dateScheduledField;

        private bool dateScheduledFieldSpecified;

        private RecordRef promoCodeField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef campaignGroup {
            get {
                return this.campaignGroupField;
            }
            set {
                this.campaignGroupField = value;
            }
        }

        /// <remarks/>
        public RecordRef template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
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
        public RecordRef subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
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
        public CampaignCampaignEmailStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateScheduled {
            get {
                return this.dateScheduledField;
            }
            set {
                this.dateScheduledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateScheduledSpecified {
            get {
                return this.dateScheduledFieldSpecified;
            }
            set {
                this.dateScheduledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef promoCode {
            get {
                return this.promoCodeField;
            }
            set {
                this.promoCodeField = value;
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