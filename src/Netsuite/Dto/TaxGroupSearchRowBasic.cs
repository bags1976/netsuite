namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxGroupSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] cityField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countyField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] includeChildrenField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDefaultField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnStringField[] itemIdField;

        private SearchColumnBooleanField[] piggyBackField;

        private SearchColumnDoubleField[] rateField;

        private SearchColumnSelectField[] stateField;

        private SearchColumnStringField[] stateDisplayNameField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] subsidiaryNoHierarchyField;

        private SearchColumnSelectField[] taxItem1Field;

        private SearchColumnSelectField[] taxItem2Field;

        private SearchColumnSelectField[] taxTypeField;

        private SearchColumnDoubleField[] unitPrice1Field;

        private SearchColumnDoubleField[] unitPrice2Field;

        private SearchColumnStringField[] zipField;

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
        [System.Xml.Serialization.XmlElementAttribute("county")]
        public SearchColumnStringField[] county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("includeChildren")]
        public SearchColumnBooleanField[] includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isDefault")]
        public SearchColumnBooleanField[] isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("itemId")]
        public SearchColumnStringField[] itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("piggyBack")]
        public SearchColumnBooleanField[] piggyBack {
            get {
                return this.piggyBackField;
            }
            set {
                this.piggyBackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rate")]
        public SearchColumnDoubleField[] rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnSelectField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stateDisplayName")]
        public SearchColumnStringField[] stateDisplayName {
            get {
                return this.stateDisplayNameField;
            }
            set {
                this.stateDisplayNameField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("subsidiaryNoHierarchy")]
        public SearchColumnSelectField[] subsidiaryNoHierarchy {
            get {
                return this.subsidiaryNoHierarchyField;
            }
            set {
                this.subsidiaryNoHierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxItem1")]
        public SearchColumnSelectField[] taxItem1 {
            get {
                return this.taxItem1Field;
            }
            set {
                this.taxItem1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxItem2")]
        public SearchColumnSelectField[] taxItem2 {
            get {
                return this.taxItem2Field;
            }
            set {
                this.taxItem2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxType")]
        public SearchColumnSelectField[] taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitPrice1")]
        public SearchColumnDoubleField[] unitPrice1 {
            get {
                return this.unitPrice1Field;
            }
            set {
                this.unitPrice1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitPrice2")]
        public SearchColumnDoubleField[] unitPrice2 {
            get {
                return this.unitPrice2Field;
            }
            set {
                this.unitPrice2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zip")]
        public SearchColumnStringField[] zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
}