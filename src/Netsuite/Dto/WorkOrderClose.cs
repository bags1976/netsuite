namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class WorkOrderClose : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private string tranIdField;

        private RecordRef itemField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double orderQuantityField;

        private bool orderQuantityFieldSpecified;

        private double scrapQuantityField;

        private bool scrapQuantityFieldSpecified;

        private RecordRef createdFromField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef postingPeriodField;

        private string memoField;

        private RecordRef subsidiaryField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef revisionField;

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
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double orderQuantity {
            get {
                return this.orderQuantityField;
            }
            set {
                this.orderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderQuantitySpecified {
            get {
                return this.orderQuantityFieldSpecified;
            }
            set {
                this.orderQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double scrapQuantity {
            get {
                return this.scrapQuantityField;
            }
            set {
                this.scrapQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scrapQuantitySpecified {
            get {
                return this.scrapQuantityFieldSpecified;
            }
            set {
                this.scrapQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        public RecordRef revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
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