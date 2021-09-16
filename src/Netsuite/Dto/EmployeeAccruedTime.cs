namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeAccruedTime {

        private RecordRef payrollItemField;

        private double accruedHoursField;

        private bool accruedHoursFieldSpecified;

        private double accrualRateField;

        private bool accrualRateFieldSpecified;

        private double monetaryRateField;

        private bool monetaryRateFieldSpecified;

        private bool resetAccruedHoursAtYearEndField;

        private bool resetAccruedHoursAtYearEndFieldSpecified;

        private EmployeeAccruedTimeAccrualMethod accrualMethodField;

        private bool accrualMethodFieldSpecified;

        private double maximumAccruedHoursField;

        private bool maximumAccruedHoursFieldSpecified;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        /// <remarks/>
        public RecordRef payrollItem {
            get {
                return this.payrollItemField;
            }
            set {
                this.payrollItemField = value;
            }
        }

        /// <remarks/>
        public double accruedHours {
            get {
                return this.accruedHoursField;
            }
            set {
                this.accruedHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accruedHoursSpecified {
            get {
                return this.accruedHoursFieldSpecified;
            }
            set {
                this.accruedHoursFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double accrualRate {
            get {
                return this.accrualRateField;
            }
            set {
                this.accrualRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accrualRateSpecified {
            get {
                return this.accrualRateFieldSpecified;
            }
            set {
                this.accrualRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double monetaryRate {
            get {
                return this.monetaryRateField;
            }
            set {
                this.monetaryRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monetaryRateSpecified {
            get {
                return this.monetaryRateFieldSpecified;
            }
            set {
                this.monetaryRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool resetAccruedHoursAtYearEnd {
            get {
                return this.resetAccruedHoursAtYearEndField;
            }
            set {
                this.resetAccruedHoursAtYearEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resetAccruedHoursAtYearEndSpecified {
            get {
                return this.resetAccruedHoursAtYearEndFieldSpecified;
            }
            set {
                this.resetAccruedHoursAtYearEndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeAccruedTimeAccrualMethod accrualMethod {
            get {
                return this.accrualMethodField;
            }
            set {
                this.accrualMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accrualMethodSpecified {
            get {
                return this.accrualMethodFieldSpecified;
            }
            set {
                this.accrualMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double maximumAccruedHours {
            get {
                return this.maximumAccruedHoursField;
            }
            set {
                this.maximumAccruedHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumAccruedHoursSpecified {
            get {
                return this.maximumAccruedHoursFieldSpecified;
            }
            set {
                this.maximumAccruedHoursFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inactiveSpecified {
            get {
                return this.inactiveFieldSpecified;
            }
            set {
                this.inactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }
    }
}