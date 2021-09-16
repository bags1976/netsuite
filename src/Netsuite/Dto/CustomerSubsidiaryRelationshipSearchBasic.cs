namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomerSubsidiaryRelationshipSearchBasic : SearchRecordBasic {

        private SearchDoubleField balanceField;

        private SearchDoubleField depositBalanceField;

        private SearchMultiSelectField entityField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isPrimarySubField;

        private SearchMultiSelectField primaryCurrencyField;

        private SearchMultiSelectField subsidiaryField;

        private SearchDoubleField unbilledOrdersField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField depositBalance {
            get {
                return this.depositBalanceField;
            }
            set {
                this.depositBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
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
        public SearchBooleanField isPrimarySub {
            get {
                return this.isPrimarySubField;
            }
            set {
                this.isPrimarySubField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField primaryCurrency {
            get {
                return this.primaryCurrencyField;
            }
            set {
                this.primaryCurrencyField = value;
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
        public SearchDoubleField unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
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