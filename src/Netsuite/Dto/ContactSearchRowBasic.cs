namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ContactSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] addressField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] addresseeField;

        private SearchColumnStringField[] addressInternalIdField;

        private SearchColumnStringField[] addressLabelField;

        private SearchColumnStringField[] addressPhoneField;

        private SearchColumnStringField[] altEmailField;

        private SearchColumnStringField[] altNameField;

        private SearchColumnStringField[] altPhoneField;

        private SearchColumnStringField[] attentionField;

        private SearchColumnBooleanField[] availableOfflineField;

        private SearchColumnStringField[] billAddress1Field;

        private SearchColumnStringField[] billAddress2Field;

        private SearchColumnStringField[] billAddress3Field;

        private SearchColumnStringField[] billAddresseeField;

        private SearchColumnStringField[] billAttentionField;

        private SearchColumnStringField[] billCityField;

        private SearchColumnEnumSelectField[] billCountryField;

        private SearchColumnStringField[] billCountryCodeField;

        private SearchColumnStringField[] billPhoneField;

        private SearchColumnStringField[] billStateField;

        private SearchColumnStringField[] billZipCodeField;

        private SearchColumnSelectField[] categoryField;

        private SearchColumnStringField[] cityField;

        private SearchColumnStringField[] commentsField;

        private SearchColumnSelectField[] companyField;

        private SearchColumnSelectField[] contactRoleField;

        private SearchColumnStringField[] contactSourceField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countryCodeField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnStringField[] defaultTaxRegField;

        private SearchColumnStringField[] emailField;

        private SearchColumnStringField[] entityIdField;

        private SearchColumnLongField[] entityNumberField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] faxField;

        private SearchColumnStringField[] firstNameField;

        private SearchColumnBooleanField[] giveAccessField;

        private SearchColumnEnumSelectField[] globalSubscriptionStatusField;

        private SearchColumnBooleanField[] hasDuplicatesField;

        private SearchColumnStringField[] homePhoneField;

        private SearchColumnSelectField[] imageField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDefaultBillingField;

        private SearchColumnBooleanField[] isDefaultShippingField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnEnumSelectField[] languageField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] lastNameField;

        private SearchColumnEnumSelectField[] levelField;

        private SearchColumnStringField[] middleNameField;

        private SearchColumnStringField[] mobilePhoneField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnEnumSelectField[] permissionField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnStringField[] phoneticNameField;

        private SearchColumnStringField[] salutationField;

        private SearchColumnStringField[] shipAddress1Field;

        private SearchColumnStringField[] shipAddress2Field;

        private SearchColumnStringField[] shipAddress3Field;

        private SearchColumnStringField[] shipAddresseeField;

        private SearchColumnStringField[] shipAttentionField;

        private SearchColumnStringField[] shipCityField;

        private SearchColumnEnumSelectField[] shipCountryField;

        private SearchColumnStringField[] shipCountryCodeField;

        private SearchColumnStringField[] shipPhoneField;

        private SearchColumnStringField[] shipStateField;

        private SearchColumnStringField[] shipZipField;

        private SearchColumnStringField[] stateField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnDateField[] subscriptionDateField;

        private SearchColumnBooleanField[] subscriptionStatusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnStringField[] titleField;

        private SearchColumnStringField[] zipCodeField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address")]
        public SearchColumnStringField[] address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address1")]
        public SearchColumnStringField[] address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address2")]
        public SearchColumnStringField[] address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address3")]
        public SearchColumnStringField[] address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressee")]
        public SearchColumnStringField[] addressee {
            get {
                return this.addresseeField;
            }
            set {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressInternalId")]
        public SearchColumnStringField[] addressInternalId {
            get {
                return this.addressInternalIdField;
            }
            set {
                this.addressInternalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressLabel")]
        public SearchColumnStringField[] addressLabel {
            get {
                return this.addressLabelField;
            }
            set {
                this.addressLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressPhone")]
        public SearchColumnStringField[] addressPhone {
            get {
                return this.addressPhoneField;
            }
            set {
                this.addressPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altEmail")]
        public SearchColumnStringField[] altEmail {
            get {
                return this.altEmailField;
            }
            set {
                this.altEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altName")]
        public SearchColumnStringField[] altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altPhone")]
        public SearchColumnStringField[] altPhone {
            get {
                return this.altPhoneField;
            }
            set {
                this.altPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attention")]
        public SearchColumnStringField[] attention {
            get {
                return this.attentionField;
            }
            set {
                this.attentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableOffline")]
        public SearchColumnBooleanField[] availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress1")]
        public SearchColumnStringField[] billAddress1 {
            get {
                return this.billAddress1Field;
            }
            set {
                this.billAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress2")]
        public SearchColumnStringField[] billAddress2 {
            get {
                return this.billAddress2Field;
            }
            set {
                this.billAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress3")]
        public SearchColumnStringField[] billAddress3 {
            get {
                return this.billAddress3Field;
            }
            set {
                this.billAddress3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddressee")]
        public SearchColumnStringField[] billAddressee {
            get {
                return this.billAddresseeField;
            }
            set {
                this.billAddresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAttention")]
        public SearchColumnStringField[] billAttention {
            get {
                return this.billAttentionField;
            }
            set {
                this.billAttentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCity")]
        public SearchColumnStringField[] billCity {
            get {
                return this.billCityField;
            }
            set {
                this.billCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCountry")]
        public SearchColumnEnumSelectField[] billCountry {
            get {
                return this.billCountryField;
            }
            set {
                this.billCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCountryCode")]
        public SearchColumnStringField[] billCountryCode {
            get {
                return this.billCountryCodeField;
            }
            set {
                this.billCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billPhone")]
        public SearchColumnStringField[] billPhone {
            get {
                return this.billPhoneField;
            }
            set {
                this.billPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billState")]
        public SearchColumnStringField[] billState {
            get {
                return this.billStateField;
            }
            set {
                this.billStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billZipCode")]
        public SearchColumnStringField[] billZipCode {
            get {
                return this.billZipCodeField;
            }
            set {
                this.billZipCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public SearchColumnStringField[] city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("comments")]
        public SearchColumnStringField[] comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("company")]
        public SearchColumnSelectField[] company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contactRole")]
        public SearchColumnSelectField[] contactRole {
            get {
                return this.contactRoleField;
            }
            set {
                this.contactRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contactSource")]
        public SearchColumnStringField[] contactSource {
            get {
                return this.contactSourceField;
            }
            set {
                this.contactSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public SearchColumnStringField[] countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateCreated")]
        public SearchColumnDateField[] dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultTaxReg")]
        public SearchColumnStringField[] defaultTaxReg {
            get {
                return this.defaultTaxRegField;
            }
            set {
                this.defaultTaxRegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public SearchColumnStringField[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entityId")]
        public SearchColumnStringField[] entityId {
            get {
                return this.entityIdField;
            }
            set {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entityNumber")]
        public SearchColumnLongField[] entityNumber {
            get {
                return this.entityNumberField;
            }
            set {
                this.entityNumberField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fax")]
        public SearchColumnStringField[] fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("firstName")]
        public SearchColumnStringField[] firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giveAccess")]
        public SearchColumnBooleanField[] giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("globalSubscriptionStatus")]
        public SearchColumnEnumSelectField[] globalSubscriptionStatus {
            get {
                return this.globalSubscriptionStatusField;
            }
            set {
                this.globalSubscriptionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hasDuplicates")]
        public SearchColumnBooleanField[] hasDuplicates {
            get {
                return this.hasDuplicatesField;
            }
            set {
                this.hasDuplicatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("homePhone")]
        public SearchColumnStringField[] homePhone {
            get {
                return this.homePhoneField;
            }
            set {
                this.homePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image")]
        public SearchColumnSelectField[] image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isDefaultBilling")]
        public SearchColumnBooleanField[] isDefaultBilling {
            get {
                return this.isDefaultBillingField;
            }
            set {
                this.isDefaultBillingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isDefaultShipping")]
        public SearchColumnBooleanField[] isDefaultShipping {
            get {
                return this.isDefaultShippingField;
            }
            set {
                this.isDefaultShippingField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("language")]
        public SearchColumnEnumSelectField[] language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("lastName")]
        public SearchColumnStringField[] lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("level")]
        public SearchColumnEnumSelectField[] level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("middleName")]
        public SearchColumnStringField[] middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mobilePhone")]
        public SearchColumnStringField[] mobilePhone {
            get {
                return this.mobilePhoneField;
            }
            set {
                this.mobilePhoneField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("permission")]
        public SearchColumnEnumSelectField[] permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phoneticName")]
        public SearchColumnStringField[] phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salutation")]
        public SearchColumnStringField[] salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress1")]
        public SearchColumnStringField[] shipAddress1 {
            get {
                return this.shipAddress1Field;
            }
            set {
                this.shipAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress2")]
        public SearchColumnStringField[] shipAddress2 {
            get {
                return this.shipAddress2Field;
            }
            set {
                this.shipAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress3")]
        public SearchColumnStringField[] shipAddress3 {
            get {
                return this.shipAddress3Field;
            }
            set {
                this.shipAddress3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddressee")]
        public SearchColumnStringField[] shipAddressee {
            get {
                return this.shipAddresseeField;
            }
            set {
                this.shipAddresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAttention")]
        public SearchColumnStringField[] shipAttention {
            get {
                return this.shipAttentionField;
            }
            set {
                this.shipAttentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCity")]
        public SearchColumnStringField[] shipCity {
            get {
                return this.shipCityField;
            }
            set {
                this.shipCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCountry")]
        public SearchColumnEnumSelectField[] shipCountry {
            get {
                return this.shipCountryField;
            }
            set {
                this.shipCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCountryCode")]
        public SearchColumnStringField[] shipCountryCode {
            get {
                return this.shipCountryCodeField;
            }
            set {
                this.shipCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipPhone")]
        public SearchColumnStringField[] shipPhone {
            get {
                return this.shipPhoneField;
            }
            set {
                this.shipPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipState")]
        public SearchColumnStringField[] shipState {
            get {
                return this.shipStateField;
            }
            set {
                this.shipStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipZip")]
        public SearchColumnStringField[] shipZip {
            get {
                return this.shipZipField;
            }
            set {
                this.shipZipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnStringField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("subscriptionDate")]
        public SearchColumnDateField[] subscriptionDate {
            get {
                return this.subscriptionDateField;
            }
            set {
                this.subscriptionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionStatus")]
        public SearchColumnBooleanField[] subscriptionStatus {
            get {
                return this.subscriptionStatusField;
            }
            set {
                this.subscriptionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("zipCode")]
        public SearchColumnStringField[] zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
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