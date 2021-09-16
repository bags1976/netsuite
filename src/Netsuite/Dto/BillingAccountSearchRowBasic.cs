namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BillingAccountSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] billingScheduleField;

        private SearchColumnSelectField[] cashSaleFormField;

        private SearchColumnSelectField[] classField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnSelectField[] customerField;

        private SearchColumnBooleanField[] customerDefaultField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] frequencyField;

        private SearchColumnStringField[] idNumberField;

        private SearchColumnBooleanField[] inactiveField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] invoiceFormField;

        private SearchColumnDateField[] lastBillCycleDateField;

        private SearchColumnDateField[] lastBillDateField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnStringField[] memoField;

        private SearchColumnStringField[] nameField;

        private SearchColumnDateField[] nextBillCycleDateField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingSchedule")]
        public SearchColumnSelectField[] billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cashSaleForm")]
        public SearchColumnSelectField[] cashSaleForm {
            get {
                return this.cashSaleFormField;
            }
            set {
                this.cashSaleFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnSelectField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnSelectField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customerDefault")]
        public SearchColumnBooleanField[] customerDefault {
            get {
                return this.customerDefaultField;
            }
            set {
                this.customerDefaultField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnSelectField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("frequency")]
        public SearchColumnEnumSelectField[] frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("idNumber")]
        public SearchColumnStringField[] idNumber {
            get {
                return this.idNumberField;
            }
            set {
                this.idNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inactive")]
        public SearchColumnBooleanField[] inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("invoiceForm")]
        public SearchColumnSelectField[] invoiceForm {
            get {
                return this.invoiceFormField;
            }
            set {
                this.invoiceFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastBillCycleDate")]
        public SearchColumnDateField[] lastBillCycleDate {
            get {
                return this.lastBillCycleDateField;
            }
            set {
                this.lastBillCycleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastBillDate")]
        public SearchColumnDateField[] lastBillDate {
            get {
                return this.lastBillDateField;
            }
            set {
                this.lastBillDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextBillCycleDate")]
        public SearchColumnDateField[] nextBillCycleDate {
            get {
                return this.nextBillCycleDateField;
            }
            set {
                this.nextBillCycleDateField = value;
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