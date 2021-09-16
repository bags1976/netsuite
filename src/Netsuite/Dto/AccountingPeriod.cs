namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class AccountingPeriod : Record {

        private string periodNameField;

        private RecordRef parentField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private RecordRef fiscalCalendarField;

        private System.DateTime closedOnDateField;

        private bool closedOnDateFieldSpecified;

        private bool isAdjustField;

        private bool isAdjustFieldSpecified;

        private AccountingPeriodFiscalCalendarsList fiscalCalendarsListField;

        private bool isQuarterField;

        private bool isQuarterFieldSpecified;

        private bool isYearField;

        private bool isYearFieldSpecified;

        private bool closedField;

        private bool closedFieldSpecified;

        private bool apLockedField;

        private bool apLockedFieldSpecified;

        private bool arLockedField;

        private bool arLockedFieldSpecified;

        private bool payrollLockedField;

        private bool payrollLockedFieldSpecified;

        private bool allLockedField;

        private bool allLockedFieldSpecified;

        private bool allowNonGLChangesField;

        private bool allowNonGLChangesFieldSpecified;

        private string internalIdField;

        /// <remarks/>
        public string periodName {
            get {
                return this.periodNameField;
            }
            set {
                this.periodNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef fiscalCalendar {
            get {
                return this.fiscalCalendarField;
            }
            set {
                this.fiscalCalendarField = value;
            }
        }

        /// <remarks/>
        public System.DateTime closedOnDate {
            get {
                return this.closedOnDateField;
            }
            set {
                this.closedOnDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool closedOnDateSpecified {
            get {
                return this.closedOnDateFieldSpecified;
            }
            set {
                this.closedOnDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAdjust {
            get {
                return this.isAdjustField;
            }
            set {
                this.isAdjustField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdjustSpecified {
            get {
                return this.isAdjustFieldSpecified;
            }
            set {
                this.isAdjustFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AccountingPeriodFiscalCalendarsList fiscalCalendarsList {
            get {
                return this.fiscalCalendarsListField;
            }
            set {
                this.fiscalCalendarsListField = value;
            }
        }

        /// <remarks/>
        public bool isQuarter {
            get {
                return this.isQuarterField;
            }
            set {
                this.isQuarterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isQuarterSpecified {
            get {
                return this.isQuarterFieldSpecified;
            }
            set {
                this.isQuarterFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isYear {
            get {
                return this.isYearField;
            }
            set {
                this.isYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isYearSpecified {
            get {
                return this.isYearFieldSpecified;
            }
            set {
                this.isYearFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool closedSpecified {
            get {
                return this.closedFieldSpecified;
            }
            set {
                this.closedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool apLocked {
            get {
                return this.apLockedField;
            }
            set {
                this.apLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apLockedSpecified {
            get {
                return this.apLockedFieldSpecified;
            }
            set {
                this.apLockedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool arLocked {
            get {
                return this.arLockedField;
            }
            set {
                this.arLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arLockedSpecified {
            get {
                return this.arLockedFieldSpecified;
            }
            set {
                this.arLockedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool payrollLocked {
            get {
                return this.payrollLockedField;
            }
            set {
                this.payrollLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool payrollLockedSpecified {
            get {
                return this.payrollLockedFieldSpecified;
            }
            set {
                this.payrollLockedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allLocked {
            get {
                return this.allLockedField;
            }
            set {
                this.allLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allLockedSpecified {
            get {
                return this.allLockedFieldSpecified;
            }
            set {
                this.allLockedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowNonGLChanges {
            get {
                return this.allowNonGLChangesField;
            }
            set {
                this.allowNonGLChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowNonGLChangesSpecified {
            get {
                return this.allowNonGLChangesFieldSpecified;
            }
            set {
                this.allowNonGLChangesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }
    }
}