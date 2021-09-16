namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class ChargeSearchAdvanced : SearchRecord {

        private ChargeSearch criteriaField;

        private ChargeSearchRow columnsField;

        private string savedSearchIdField;

        private string savedSearchScriptIdField;

        /// <remarks/>
        public ChargeSearch criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }

        /// <remarks/>
        public ChargeSearchRow columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string savedSearchId {
            get {
                return this.savedSearchIdField;
            }
            set {
                this.savedSearchIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string savedSearchScriptId {
            get {
                return this.savedSearchScriptIdField;
            }
            set {
                this.savedSearchScriptIdField = value;
            }
        }
    }
}