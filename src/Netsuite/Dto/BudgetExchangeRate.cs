namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class BudgetExchangeRate {

        private RecordRef periodField;

        private RecordRef fromSubsidiaryField;

        private RecordRef toSubsidiaryField;

        private double currentRateField;

        private bool currentRateFieldSpecified;

        private double averageRateField;

        private bool averageRateFieldSpecified;

        private double historicalRateField;

        private bool historicalRateFieldSpecified;

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

        /// <remarks/>
        public double currentRate {
            get {
                return this.currentRateField;
            }
            set {
                this.currentRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentRateSpecified {
            get {
                return this.currentRateFieldSpecified;
            }
            set {
                this.currentRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double averageRate {
            get {
                return this.averageRateField;
            }
            set {
                this.averageRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageRateSpecified {
            get {
                return this.averageRateFieldSpecified;
            }
            set {
                this.averageRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double historicalRate {
            get {
                return this.historicalRateField;
            }
            set {
                this.historicalRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool historicalRateSpecified {
            get {
                return this.historicalRateFieldSpecified;
            }
            set {
                this.historicalRateFieldSpecified = value;
            }
        }
    }
}