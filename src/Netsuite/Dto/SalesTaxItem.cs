using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SalesTaxItem : Record {

        private string itemIdField;

        private string displayNameField;

        private string descriptionField;

        private string rateField;

        private RecordRef taxTypeField;

        private RecordRef taxAgencyField;

        private RecordRef purchaseAccountField;

        private RecordRef saleAccountField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private System.DateTime effectiveFromField;

        private bool effectiveFromFieldSpecified;

        private System.DateTime validUntilField;

        private bool validUntilFieldSpecified;

        private RecordRef[] subsidiaryListField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private bool eccodeField;

        private bool eccodeFieldSpecified;

        private bool reverseChargeField;

        private bool reverseChargeFieldSpecified;

        private RecordRef parentField;

        private bool serviceField;

        private bool serviceFieldSpecified;

        private bool exemptField;

        private bool exemptFieldSpecified;

        private bool isDefaultField;

        private bool isDefaultFieldSpecified;

        private bool excludeFromTaxReportsField;

        private bool excludeFromTaxReportsFieldSpecified;

        private SalesTaxItemAvailable availableField;

        private bool availableFieldSpecified;

        private bool exportField;

        private bool exportFieldSpecified;

        private RecordRef taxAccountField;

        private string countyField;

        private string cityField;

        private string stateField;

        private string zipField;

        private RecordRef nexusCountryField;

        private string nameField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
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
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxAgency {
            get {
                return this.taxAgencyField;
            }
            set {
                this.taxAgencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseAccount {
            get {
                return this.purchaseAccountField;
            }
            set {
                this.purchaseAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef saleAccount {
            get {
                return this.saleAccountField;
            }
            set {
                this.saleAccountField = value;
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
        public System.DateTime effectiveFrom {
            get {
                return this.effectiveFromField;
            }
            set {
                this.effectiveFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveFromSpecified {
            get {
                return this.effectiveFromFieldSpecified;
            }
            set {
                this.effectiveFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime validUntil {
            get {
                return this.validUntilField;
            }
            set {
                this.validUntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validUntilSpecified {
            get {
                return this.validUntilFieldSpecified;
            }
            set {
                this.validUntilFieldSpecified = value;
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
        public bool eccode {
            get {
                return this.eccodeField;
            }
            set {
                this.eccodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eccodeSpecified {
            get {
                return this.eccodeFieldSpecified;
            }
            set {
                this.eccodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool reverseCharge {
            get {
                return this.reverseChargeField;
            }
            set {
                this.reverseChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reverseChargeSpecified {
            get {
                return this.reverseChargeFieldSpecified;
            }
            set {
                this.reverseChargeFieldSpecified = value;
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
        public bool service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceSpecified {
            get {
                return this.serviceFieldSpecified;
            }
            set {
                this.serviceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool exempt {
            get {
                return this.exemptField;
            }
            set {
                this.exemptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exemptSpecified {
            get {
                return this.exemptFieldSpecified;
            }
            set {
                this.exemptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultSpecified {
            get {
                return this.isDefaultFieldSpecified;
            }
            set {
                this.isDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool excludeFromTaxReports {
            get {
                return this.excludeFromTaxReportsField;
            }
            set {
                this.excludeFromTaxReportsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromTaxReportsSpecified {
            get {
                return this.excludeFromTaxReportsFieldSpecified;
            }
            set {
                this.excludeFromTaxReportsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SalesTaxItemAvailable available {
            get {
                return this.availableField;
            }
            set {
                this.availableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableSpecified {
            get {
                return this.availableFieldSpecified;
            }
            set {
                this.availableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool export {
            get {
                return this.exportField;
            }
            set {
                this.exportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exportSpecified {
            get {
                return this.exportFieldSpecified;
            }
            set {
                this.exportFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxAccount {
            get {
                return this.taxAccountField;
            }
            set {
                this.taxAccountField = value;
            }
        }

        /// <remarks/>
        public string county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public RecordRef nexusCountry {
            get {
                return this.nexusCountryField;
            }
            set {
                this.nexusCountryField = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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