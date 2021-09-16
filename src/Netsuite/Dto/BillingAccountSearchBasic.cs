namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BillingAccountSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField billingScheduleField;

        private SearchMultiSelectField cashSaleFormField;

        private SearchMultiSelectField classField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField customerField;

        private SearchBooleanField customerDefaultField;

        private SearchDateField dateCreatedField;

        private SearchMultiSelectField departmentField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField frequencyField;

        private SearchStringField idNumberField;

        private SearchBooleanField inactiveField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField invoiceFormField;

        private SearchDateField lastBillCycleDateField;

        private SearchDateField lastBillDateField;

        private SearchMultiSelectField locationField;

        private SearchStringField memoField;

        private SearchStringField nameField;

        private SearchDateField nextBillCycleDateField;

        private SearchDateField startDateField;

        private SearchMultiSelectField subsidiaryField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField cashSaleForm {
            get {
                return this.cashSaleFormField;
            }
            set {
                this.cashSaleFormField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField customerDefault {
            get {
                return this.customerDefaultField;
            }
            set {
                this.customerDefaultField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField idNumber {
            get {
                return this.idNumberField;
            }
            set {
                this.idNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField invoiceForm {
            get {
                return this.invoiceFormField;
            }
            set {
                this.invoiceFormField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastBillCycleDate {
            get {
                return this.lastBillCycleDateField;
            }
            set {
                this.lastBillCycleDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastBillDate {
            get {
                return this.lastBillDateField;
            }
            set {
                this.lastBillDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchDateField nextBillCycleDate {
            get {
                return this.nextBillCycleDateField;
            }
            set {
                this.nextBillCycleDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}