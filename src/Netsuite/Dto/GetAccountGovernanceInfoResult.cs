namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetAccountGovernanceInfoResult {

        private Status statusField;

        private long accountConcurrencyLimitField;

        private bool accountConcurrencyLimitFieldSpecified;

        private long unallocatedConcurrencyLimitField;

        private bool unallocatedConcurrencyLimitFieldSpecified;

        /// <remarks/>
        public Status status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public long accountConcurrencyLimit {
            get {
                return this.accountConcurrencyLimitField;
            }
            set {
                this.accountConcurrencyLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountConcurrencyLimitSpecified {
            get {
                return this.accountConcurrencyLimitFieldSpecified;
            }
            set {
                this.accountConcurrencyLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long unallocatedConcurrencyLimit {
            get {
                return this.unallocatedConcurrencyLimitField;
            }
            set {
                this.unallocatedConcurrencyLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unallocatedConcurrencyLimitSpecified {
            get {
                return this.unallocatedConcurrencyLimitFieldSpecified;
            }
            set {
                this.unallocatedConcurrencyLimitFieldSpecified = value;
            }
        }
    }
}