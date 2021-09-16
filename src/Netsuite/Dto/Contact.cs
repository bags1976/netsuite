namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Contact : Record {

        private RecordRef customFormField;

        private string entityIdField;

        private RecordRef contactSourceField;

        private RecordRef companyField;

        private string salutationField;

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string titleField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string defaultAddressField;

        private bool isPrivateField;

        private bool isPrivateFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef subsidiaryField;

        private string phoneticNameField;

        private RecordRef[] categoryListField;

        private string altEmailField;

        private string officePhoneField;

        private string homePhoneField;

        private string mobilePhoneField;

        private RecordRef supervisorField;

        private string supervisorPhoneField;

        private RecordRef assistantField;

        private string assistantPhoneField;

        private string commentsField;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private RecordRef imageField;

        private bool billPayField;

        private bool billPayFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private ContactAddressbookList addressbookListField;

        private SubscriptionsList subscriptionsListField;

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
        public string entityId {
            get {
                return this.entityIdField;
            }
            set {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef contactSource {
            get {
                return this.contactSourceField;
            }
            set {
                this.contactSourceField = value;
            }
        }

        /// <remarks/>
        public RecordRef company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public string salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
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
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string defaultAddress {
            get {
                return this.defaultAddressField;
            }
            set {
                this.defaultAddressField = value;
            }
        }

        /// <remarks/>
        public bool isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrivateSpecified {
            get {
                return this.isPrivateFieldSpecified;
            }
            set {
                this.isPrivateFieldSpecified = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public string phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable=false)]
        public RecordRef[] categoryList {
            get {
                return this.categoryListField;
            }
            set {
                this.categoryListField = value;
            }
        }

        /// <remarks/>
        public string altEmail {
            get {
                return this.altEmailField;
            }
            set {
                this.altEmailField = value;
            }
        }

        /// <remarks/>
        public string officePhone {
            get {
                return this.officePhoneField;
            }
            set {
                this.officePhoneField = value;
            }
        }

        /// <remarks/>
        public string homePhone {
            get {
                return this.homePhoneField;
            }
            set {
                this.homePhoneField = value;
            }
        }

        /// <remarks/>
        public string mobilePhone {
            get {
                return this.mobilePhoneField;
            }
            set {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        public RecordRef supervisor {
            get {
                return this.supervisorField;
            }
            set {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        public string supervisorPhone {
            get {
                return this.supervisorPhoneField;
            }
            set {
                this.supervisorPhoneField = value;
            }
        }

        /// <remarks/>
        public RecordRef assistant {
            get {
                return this.assistantField;
            }
            set {
                this.assistantField = value;
            }
        }

        /// <remarks/>
        public string assistantPhone {
            get {
                return this.assistantPhoneField;
            }
            set {
                this.assistantPhoneField = value;
            }
        }

        /// <remarks/>
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public GlobalSubscriptionStatus globalSubscriptionStatus {
            get {
                return this.globalSubscriptionStatusField;
            }
            set {
                this.globalSubscriptionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool globalSubscriptionStatusSpecified {
            get {
                return this.globalSubscriptionStatusFieldSpecified;
            }
            set {
                this.globalSubscriptionStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public bool billPay {
            get {
                return this.billPayField;
            }
            set {
                this.billPayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billPaySpecified {
            get {
                return this.billPayFieldSpecified;
            }
            set {
                this.billPayFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateCreatedSpecified {
            get {
                return this.dateCreatedFieldSpecified;
            }
            set {
                this.dateCreatedFieldSpecified = value;
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
        public ContactAddressbookList addressbookList {
            get {
                return this.addressbookListField;
            }
            set {
                this.addressbookListField = value;
            }
        }

        /// <remarks/>
        public SubscriptionsList subscriptionsList {
            get {
                return this.subscriptionsListField;
            }
            set {
                this.subscriptionsListField = value;
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