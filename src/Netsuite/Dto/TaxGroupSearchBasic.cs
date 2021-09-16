namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxGroupSearchBasic : SearchRecordBasic {

        private SearchStringField cityField;

        private SearchEnumMultiSelectField countryField;

        private SearchStringField countyField;

        private SearchStringField descriptionField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField includeChildrenField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDefaultField;

        private SearchBooleanField isInactiveField;

        private SearchStringField itemIdField;

        private SearchBooleanField piggyBackField;

        private SearchDoubleField rateField;

        private SearchMultiSelectField stateField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField taxItem1Field;

        private SearchMultiSelectField taxItem2Field;

        private SearchMultiSelectField taxTypeField;

        private SearchDoubleField unitPrice1Field;

        private SearchDoubleField unitPrice2Field;

        private SearchStringField zipField;

        /// <remarks/>
        public SearchStringField city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        public SearchBooleanField includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
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
        public SearchBooleanField isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchStringField itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField piggyBack {
            get {
                return this.piggyBackField;
            }
            set {
                this.piggyBackField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
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
        public SearchMultiSelectField taxItem1 {
            get {
                return this.taxItem1Field;
            }
            set {
                this.taxItem1Field = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxItem2 {
            get {
                return this.taxItem2Field;
            }
            set {
                this.taxItem2Field = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField unitPrice1 {
            get {
                return this.unitPrice1Field;
            }
            set {
                this.unitPrice1Field = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField unitPrice2 {
            get {
                return this.unitPrice2Field;
            }
            set {
                this.unitPrice2Field = value;
            }
        }

        /// <remarks/>
        public SearchStringField zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
}