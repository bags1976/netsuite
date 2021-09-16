namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TimeItem {

        private long idField;

        private bool idFieldSpecified;

        private RecordRef employeeField;

        private TimeItemTimeType timeTypeField;

        private bool timeTypeFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef customerField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private RecordRef payrollItemField;

        private RecordRef itemField;

        private RecordRef temporaryLocalJurisdictionField;

        private RecordRef temporaryStateJurisdictionField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private Duration hoursField;

        private RecordRef priceField;

        private double rateField;

        private bool rateFieldSpecified;

        private bool overrideRateField;

        private bool overrideRateFieldSpecified;

        private Duration hoursTotalField;

        private RecordRef caseTaskEventField;

        private string memoField;

        private bool isUtilizedField;

        private bool isUtilizedFieldSpecified;

        private bool isProductiveField;

        private bool isProductiveFieldSpecified;

        private bool isExemptField;

        private bool isExemptFieldSpecified;

        /// <remarks/>
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        public TimeItemTimeType timeType {
            get {
                return this.timeTypeField;
            }
            set {
                this.timeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeTypeSpecified {
            get {
                return this.timeTypeFieldSpecified;
            }
            set {
                this.timeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public bool isBillable {
            get {
                return this.isBillableField;
            }
            set {
                this.isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBillableSpecified {
            get {
                return this.isBillableFieldSpecified;
            }
            set {
                this.isBillableFieldSpecified = value;
            }
        }

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
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public RecordRef temporaryLocalJurisdiction {
            get {
                return this.temporaryLocalJurisdictionField;
            }
            set {
                this.temporaryLocalJurisdictionField = value;
            }
        }

        /// <remarks/>
        public RecordRef temporaryStateJurisdiction {
            get {
                return this.temporaryStateJurisdictionField;
            }
            set {
                this.temporaryStateJurisdictionField = value;
            }
        }

        /// <remarks/>
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public Duration hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
            }
        }

        /// <remarks/>
        public RecordRef price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool overrideRate {
            get {
                return this.overrideRateField;
            }
            set {
                this.overrideRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideRateSpecified {
            get {
                return this.overrideRateFieldSpecified;
            }
            set {
                this.overrideRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration hoursTotal {
            get {
                return this.hoursTotalField;
            }
            set {
                this.hoursTotalField = value;
            }
        }

        /// <remarks/>
        public RecordRef caseTaskEvent {
            get {
                return this.caseTaskEventField;
            }
            set {
                this.caseTaskEventField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public bool isUtilized {
            get {
                return this.isUtilizedField;
            }
            set {
                this.isUtilizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUtilizedSpecified {
            get {
                return this.isUtilizedFieldSpecified;
            }
            set {
                this.isUtilizedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isProductive {
            get {
                return this.isProductiveField;
            }
            set {
                this.isProductiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isProductiveSpecified {
            get {
                return this.isProductiveFieldSpecified;
            }
            set {
                this.isProductiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isExempt {
            get {
                return this.isExemptField;
            }
            set {
                this.isExemptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isExemptSpecified {
            get {
                return this.isExemptFieldSpecified;
            }
            set {
                this.isExemptFieldSpecified = value;
            }
        }
    }
}