namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeEarning {

        private RecordRef payrollItemField;

        private string payRateField;

        private bool primaryEarningField;

        private bool primaryEarningFieldSpecified;

        private double defaultHoursField;

        private bool defaultHoursFieldSpecified;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

        private bool defaultEarningField;

        private bool defaultEarningFieldSpecified;

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
        public string payRate {
            get {
                return this.payRateField;
            }
            set {
                this.payRateField = value;
            }
        }

        /// <remarks/>
        public bool primaryEarning {
            get {
                return this.primaryEarningField;
            }
            set {
                this.primaryEarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool primaryEarningSpecified {
            get {
                return this.primaryEarningFieldSpecified;
            }
            set {
                this.primaryEarningFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double defaultHours {
            get {
                return this.defaultHoursField;
            }
            set {
                this.defaultHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultHoursSpecified {
            get {
                return this.defaultHoursFieldSpecified;
            }
            set {
                this.defaultHoursFieldSpecified = value;
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
        public bool defaultEarning {
            get {
                return this.defaultEarningField;
            }
            set {
                this.defaultEarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultEarningSpecified {
            get {
                return this.defaultEarningFieldSpecified;
            }
            set {
                this.defaultEarningFieldSpecified = value;
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