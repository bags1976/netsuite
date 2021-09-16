namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class BudgetExchangeRateFilter {

        private RecordRef periodField;

        private RecordRef fromSubsidiaryField;

        private RecordRef toSubsidiaryField;

        /// <remarks/>
        public RecordRef period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public RecordRef fromSubsidiary {
            get {
                return this.fromSubsidiaryField;
            }
            set {
                this.fromSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }
    }
}