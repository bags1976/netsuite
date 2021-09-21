using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Partner : Record {

        private RecordRef customFormField;

        private string entityIdField;

        private string altNameField;

        private string partnerCodeField;

        private bool isPersonField;

        private bool isPersonFieldSpecified;

        private string phoneticNameField;

        private string salutationField;

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string companyNameField;

        private RecordRef parentField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string urlField;

        private string defaultAddressField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private PartnerTaxRegistrationList taxRegistrationListField;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private string referringUrlField;

        private RecordRef[] roleListField;

        private RecordRef[] categoryListField;

        private string titleField;

        private string printOnCheckAsField;

        private string taxIdNumField;

        private string vatRegNumberField;

        private string commentsField;

        private string bcnField;

        private RecordRef imageField;

        private TaxFractionUnit taxFractionUnitField;

        private bool taxFractionUnitFieldSpecified;

        private EmailPreference emailPreferenceField;

        private bool emailPreferenceFieldSpecified;

        private RecordRef defaultTaxRegField;

        private TaxRounding taxRoundingField;

        private bool taxRoundingFieldSpecified;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef classField;

        private RecordRef subsidiaryField;

        private string homePhoneField;

        private string mobilePhoneField;

        private string altEmailField;

        private bool giveAccessField;

        private bool giveAccessFieldSpecified;

        private RecordRef accessRoleField;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private string passwordField;

        private string password2Field;

        private bool requirePwdChangeField;

        private bool requirePwdChangeFieldSpecified;

        private bool subPartnerLoginField;

        private bool subPartnerLoginFieldSpecified;

        private string loginAsField;

        private bool eligibleForCommissionField;

        private bool eligibleForCommissionFieldSpecified;

        private ContactAccessRolesList contactRolesListField;

        private PartnerPromoCodeList promoCodeListField;

        private PartnerAddressbookList addressbookListField;

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
        public string altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
            }
        }

        /// <remarks/>
        public string partnerCode {
            get {
                return this.partnerCodeField;
            }
            set {
                this.partnerCodeField = value;
            }
        }

        /// <remarks/>
        public bool isPerson {
            get {
                return this.isPersonField;
            }
            set {
                this.isPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonSpecified {
            get {
                return this.isPersonFieldSpecified;
            }
            set {
                this.isPersonFieldSpecified = value;
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
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
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
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
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
        public PartnerTaxRegistrationList taxRegistrationList {
            get {
                return this.taxRegistrationListField;
            }
            set {
                this.taxRegistrationListField = value;
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
        public string referringUrl {
            get {
                return this.referringUrlField;
            }
            set {
                this.referringUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] roleList {
            get {
                return this.roleListField;
            }
            set {
                this.roleListField = value;
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
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string printOnCheckAs {
            get {
                return this.printOnCheckAsField;
            }
            set {
                this.printOnCheckAsField = value;
            }
        }

        /// <remarks/>
        public string taxIdNum {
            get {
                return this.taxIdNumField;
            }
            set {
                this.taxIdNumField = value;
            }
        }

        /// <remarks/>
        public string vatRegNumber {
            get {
                return this.vatRegNumberField;
            }
            set {
                this.vatRegNumberField = value;
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
        public string bcn {
            get {
                return this.bcnField;
            }
            set {
                this.bcnField = value;
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
        public TaxFractionUnit taxFractionUnit {
            get {
                return this.taxFractionUnitField;
            }
            set {
                this.taxFractionUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxFractionUnitSpecified {
            get {
                return this.taxFractionUnitFieldSpecified;
            }
            set {
                this.taxFractionUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmailPreference emailPreference {
            get {
                return this.emailPreferenceField;
            }
            set {
                this.emailPreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailPreferenceSpecified {
            get {
                return this.emailPreferenceFieldSpecified;
            }
            set {
                this.emailPreferenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultTaxReg {
            get {
                return this.defaultTaxRegField;
            }
            set {
                this.defaultTaxRegField = value;
            }
        }

        /// <remarks/>
        public TaxRounding taxRounding {
            get {
                return this.taxRoundingField;
            }
            set {
                this.taxRoundingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRoundingSpecified {
            get {
                return this.taxRoundingFieldSpecified;
            }
            set {
                this.taxRoundingFieldSpecified = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public string altEmail {
            get {
                return this.altEmailField;
            }
            set {
                this.altEmailField = value;
            }
        }

        /// <remarks/>
        public bool giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giveAccessSpecified {
            get {
                return this.giveAccessFieldSpecified;
            }
            set {
                this.giveAccessFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef accessRole {
            get {
                return this.accessRoleField;
            }
            set {
                this.accessRoleField = value;
            }
        }

        /// <remarks/>
        public bool sendEmail {
            get {
                return this.sendEmailField;
            }
            set {
                this.sendEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendEmailSpecified {
            get {
                return this.sendEmailFieldSpecified;
            }
            set {
                this.sendEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public string password2 {
            get {
                return this.password2Field;
            }
            set {
                this.password2Field = value;
            }
        }

        /// <remarks/>
        public bool requirePwdChange {
            get {
                return this.requirePwdChangeField;
            }
            set {
                this.requirePwdChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requirePwdChangeSpecified {
            get {
                return this.requirePwdChangeFieldSpecified;
            }
            set {
                this.requirePwdChangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool subPartnerLogin {
            get {
                return this.subPartnerLoginField;
            }
            set {
                this.subPartnerLoginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subPartnerLoginSpecified {
            get {
                return this.subPartnerLoginFieldSpecified;
            }
            set {
                this.subPartnerLoginFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string loginAs {
            get {
                return this.loginAsField;
            }
            set {
                this.loginAsField = value;
            }
        }

        /// <remarks/>
        public bool eligibleForCommission {
            get {
                return this.eligibleForCommissionField;
            }
            set {
                this.eligibleForCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligibleForCommissionSpecified {
            get {
                return this.eligibleForCommissionFieldSpecified;
            }
            set {
                this.eligibleForCommissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ContactAccessRolesList contactRolesList {
            get {
                return this.contactRolesListField;
            }
            set {
                this.contactRolesListField = value;
            }
        }

        /// <remarks/>
        public PartnerPromoCodeList promoCodeList {
            get {
                return this.promoCodeListField;
            }
            set {
                this.promoCodeListField = value;
            }
        }

        /// <remarks/>
        public PartnerAddressbookList addressbookList {
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