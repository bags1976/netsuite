namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class RevRecScheduleRecurrence {

        private RecordRef incomeaccountField;

        private long periodOffsetField;

        private bool periodOffsetFieldSpecified;

        private string recamountField;

        /// <remarks/>
        public RecordRef incomeaccount {
            get {
                return this.incomeaccountField;
            }
            set {
                this.incomeaccountField = value;
            }
        }

        /// <remarks/>
        public long periodOffset {
            get {
                return this.periodOffsetField;
            }
            set {
                this.periodOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodOffsetSpecified {
            get {
                return this.periodOffsetFieldSpecified;
            }
            set {
                this.periodOffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string recamount {
            get {
                return this.recamountField;
            }
            set {
                this.recamountField = value;
            }
        }
    }
}