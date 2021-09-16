namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemAccountingBookDetail {

        private RecordRef accountingBookField;

        private RecordRef createRevenuePlansOnField;

        private RecordRef revenueRecognitionRuleField;

        private RecordRef revRecForecastRuleField;

        private RecordRef revRecScheduleField;

        private bool sameAsPrimaryRevRecField;

        private bool sameAsPrimaryRevRecFieldSpecified;

        private RecordRef amortizationTemplateField;

        private bool sameAsPrimaryAmortizationField;

        private bool sameAsPrimaryAmortizationFieldSpecified;

        /// <remarks/>
        public RecordRef accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public RecordRef createRevenuePlansOn {
            get {
                return this.createRevenuePlansOnField;
            }
            set {
                this.createRevenuePlansOnField = value;
            }
        }

        /// <remarks/>
        public RecordRef revenueRecognitionRule {
            get {
                return this.revenueRecognitionRuleField;
            }
            set {
                this.revenueRecognitionRuleField = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        public bool sameAsPrimaryRevRec {
            get {
                return this.sameAsPrimaryRevRecField;
            }
            set {
                this.sameAsPrimaryRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sameAsPrimaryRevRecSpecified {
            get {
                return this.sameAsPrimaryRevRecFieldSpecified;
            }
            set {
                this.sameAsPrimaryRevRecFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef amortizationTemplate {
            get {
                return this.amortizationTemplateField;
            }
            set {
                this.amortizationTemplateField = value;
            }
        }

        /// <remarks/>
        public bool sameAsPrimaryAmortization {
            get {
                return this.sameAsPrimaryAmortizationField;
            }
            set {
                this.sameAsPrimaryAmortizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sameAsPrimaryAmortizationSpecified {
            get {
                return this.sameAsPrimaryAmortizationFieldSpecified;
            }
            set {
                this.sameAsPrimaryAmortizationFieldSpecified = value;
            }
        }
    }
}