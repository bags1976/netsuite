namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BudgetSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountField;

        private SearchColumnStringField[] accountingBookField;

        private SearchColumnDoubleField[] amountField;

        private SearchColumnStringField[] categoryField;

        private SearchColumnStringField[] classField;

        private SearchColumnStringField[] classnohierarchyField;

        private SearchColumnStringField[] currencyField;

        private SearchColumnStringField[] customerField;

        private SearchColumnStringField[] departmentField;

        private SearchColumnStringField[] departmentnohierarchyField;

        private SearchColumnBooleanField[] globalField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] itemField;

        private SearchColumnStringField[] locationField;

        private SearchColumnStringField[] locationnohierarchyField;

        private SearchColumnStringField[] subsidiaryField;

        private SearchColumnStringField[] subsidiarynohierarchyField;

        private SearchColumnStringField[] yearField;

        private SearchColumnStringField[] year2Field;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("account")]
        public SearchColumnStringField[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnStringField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amount")]
        public SearchColumnDoubleField[] amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public SearchColumnStringField[] category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnStringField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classnohierarchy")]
        public SearchColumnStringField[] classnohierarchy {
            get {
                return this.classnohierarchyField;
            }
            set {
                this.classnohierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnStringField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnStringField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnStringField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("departmentnohierarchy")]
        public SearchColumnStringField[] departmentnohierarchy {
            get {
                return this.departmentnohierarchyField;
            }
            set {
                this.departmentnohierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("global")]
        public SearchColumnBooleanField[] global {
            get {
                return this.globalField;
            }
            set {
                this.globalField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnStringField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnStringField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationnohierarchy")]
        public SearchColumnStringField[] locationnohierarchy {
            get {
                return this.locationnohierarchyField;
            }
            set {
                this.locationnohierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnStringField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiarynohierarchy")]
        public SearchColumnStringField[] subsidiarynohierarchy {
            get {
                return this.subsidiarynohierarchyField;
            }
            set {
                this.subsidiarynohierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("year")]
        public SearchColumnStringField[] year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("year2")]
        public SearchColumnStringField[] year2 {
            get {
                return this.year2Field;
            }
            set {
                this.year2Field = value;
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