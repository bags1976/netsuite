namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BillingSchedule : Record {

        private BillingScheduleType scheduleTypeField;

        private bool scheduleTypeFieldSpecified;

        private string nameField;

        private BillingScheduleRecurrencePattern recurrencePatternField;

        private bool recurrencePatternFieldSpecified;

        private RecordRef projectField;

        private string initialAmountField;

        private RecordRef initialTermsField;

        private BillingScheduleFrequency frequencyField;

        private bool frequencyFieldSpecified;

        private RecurrenceDow[] recurrenceDowMaskListField;

        private BillingScheduleRecurrenceMode yearModeField;

        private bool yearModeFieldSpecified;

        private BillingScheduleYearDowim yearDowimField;

        private bool yearDowimFieldSpecified;

        private BillingScheduleYearDow yearDowField;

        private bool yearDowFieldSpecified;

        private BillingScheduleYearDowimMonth yearDowimMonthField;

        private bool yearDowimMonthFieldSpecified;

        private BillingScheduleYearMonth yearMonthField;

        private bool yearMonthFieldSpecified;

        private long yearDomField;

        private bool yearDomFieldSpecified;

        private BillingScheduleRecurrenceMode monthModeField;

        private bool monthModeFieldSpecified;

        private BillingScheduleMonthDowim monthDowimField;

        private bool monthDowimFieldSpecified;

        private BillingScheduleMonthDow monthDowField;

        private bool monthDowFieldSpecified;

        private long monthDomField;

        private bool monthDomFieldSpecified;

        private long dayPeriodField;

        private bool dayPeriodFieldSpecified;

        private BillingScheduleRepeatEvery repeatEveryField;

        private bool repeatEveryFieldSpecified;

        private bool billForActualsField;

        private bool billForActualsFieldSpecified;

        private long numberRemainingField;

        private bool numberRemainingFieldSpecified;

        private bool inArrearsField;

        private bool inArrearsFieldSpecified;

        private RecordRef recurrenceTermsField;

        private bool isPublicField;

        private bool isPublicFieldSpecified;

        private bool applyToSubtotalField;

        private bool applyToSubtotalFieldSpecified;

        private RecordRef transactionField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private System.DateTime seriesStartDateField;

        private bool seriesStartDateFieldSpecified;

        private BillingScheduleRecurrenceList recurrenceListField;

        private BillingScheduleMilestoneList milestoneListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public BillingScheduleType scheduleType {
            get {
                return this.scheduleTypeField;
            }
            set {
                this.scheduleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduleTypeSpecified {
            get {
                return this.scheduleTypeFieldSpecified;
            }
            set {
                this.scheduleTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleRecurrencePattern recurrencePattern {
            get {
                return this.recurrencePatternField;
            }
            set {
                this.recurrencePatternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrencePatternSpecified {
            get {
                return this.recurrencePatternFieldSpecified;
            }
            set {
                this.recurrencePatternFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public string initialAmount {
            get {
                return this.initialAmountField;
            }
            set {
                this.initialAmountField = value;
            }
        }

        /// <remarks/>
        public RecordRef initialTerms {
            get {
                return this.initialTermsField;
            }
            set {
                this.initialTermsField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleFrequency frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool frequencySpecified {
            get {
                return this.frequencyFieldSpecified;
            }
            set {
                this.frequencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recurrenceDowMask", Namespace="urn:common_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecurrenceDow[] recurrenceDowMaskList {
            get {
                return this.recurrenceDowMaskListField;
            }
            set {
                this.recurrenceDowMaskListField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleRecurrenceMode yearMode {
            get {
                return this.yearModeField;
            }
            set {
                this.yearModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearModeSpecified {
            get {
                return this.yearModeFieldSpecified;
            }
            set {
                this.yearModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleYearDowim yearDowim {
            get {
                return this.yearDowimField;
            }
            set {
                this.yearDowimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearDowimSpecified {
            get {
                return this.yearDowimFieldSpecified;
            }
            set {
                this.yearDowimFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleYearDow yearDow {
            get {
                return this.yearDowField;
            }
            set {
                this.yearDowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearDowSpecified {
            get {
                return this.yearDowFieldSpecified;
            }
            set {
                this.yearDowFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleYearDowimMonth yearDowimMonth {
            get {
                return this.yearDowimMonthField;
            }
            set {
                this.yearDowimMonthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearDowimMonthSpecified {
            get {
                return this.yearDowimMonthFieldSpecified;
            }
            set {
                this.yearDowimMonthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleYearMonth yearMonth {
            get {
                return this.yearMonthField;
            }
            set {
                this.yearMonthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearMonthSpecified {
            get {
                return this.yearMonthFieldSpecified;
            }
            set {
                this.yearMonthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long yearDom {
            get {
                return this.yearDomField;
            }
            set {
                this.yearDomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearDomSpecified {
            get {
                return this.yearDomFieldSpecified;
            }
            set {
                this.yearDomFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleRecurrenceMode monthMode {
            get {
                return this.monthModeField;
            }
            set {
                this.monthModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthModeSpecified {
            get {
                return this.monthModeFieldSpecified;
            }
            set {
                this.monthModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleMonthDowim monthDowim {
            get {
                return this.monthDowimField;
            }
            set {
                this.monthDowimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthDowimSpecified {
            get {
                return this.monthDowimFieldSpecified;
            }
            set {
                this.monthDowimFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleMonthDow monthDow {
            get {
                return this.monthDowField;
            }
            set {
                this.monthDowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthDowSpecified {
            get {
                return this.monthDowFieldSpecified;
            }
            set {
                this.monthDowFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long monthDom {
            get {
                return this.monthDomField;
            }
            set {
                this.monthDomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthDomSpecified {
            get {
                return this.monthDomFieldSpecified;
            }
            set {
                this.monthDomFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long dayPeriod {
            get {
                return this.dayPeriodField;
            }
            set {
                this.dayPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dayPeriodSpecified {
            get {
                return this.dayPeriodFieldSpecified;
            }
            set {
                this.dayPeriodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleRepeatEvery repeatEvery {
            get {
                return this.repeatEveryField;
            }
            set {
                this.repeatEveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool repeatEverySpecified {
            get {
                return this.repeatEveryFieldSpecified;
            }
            set {
                this.repeatEveryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool billForActuals {
            get {
                return this.billForActualsField;
            }
            set {
                this.billForActualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billForActualsSpecified {
            get {
                return this.billForActualsFieldSpecified;
            }
            set {
                this.billForActualsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long numberRemaining {
            get {
                return this.numberRemainingField;
            }
            set {
                this.numberRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberRemainingSpecified {
            get {
                return this.numberRemainingFieldSpecified;
            }
            set {
                this.numberRemainingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool inArrears {
            get {
                return this.inArrearsField;
            }
            set {
                this.inArrearsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inArrearsSpecified {
            get {
                return this.inArrearsFieldSpecified;
            }
            set {
                this.inArrearsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef recurrenceTerms {
            get {
                return this.recurrenceTermsField;
            }
            set {
                this.recurrenceTermsField = value;
            }
        }

        /// <remarks/>
        public bool isPublic {
            get {
                return this.isPublicField;
            }
            set {
                this.isPublicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPublicSpecified {
            get {
                return this.isPublicFieldSpecified;
            }
            set {
                this.isPublicFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool applyToSubtotal {
            get {
                return this.applyToSubtotalField;
            }
            set {
                this.applyToSubtotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyToSubtotalSpecified {
            get {
                return this.applyToSubtotalFieldSpecified;
            }
            set {
                this.applyToSubtotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime seriesStartDate {
            get {
                return this.seriesStartDateField;
            }
            set {
                this.seriesStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seriesStartDateSpecified {
            get {
                return this.seriesStartDateFieldSpecified;
            }
            set {
                this.seriesStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BillingScheduleRecurrenceList recurrenceList {
            get {
                return this.recurrenceListField;
            }
            set {
                this.recurrenceListField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleMilestoneList milestoneList {
            get {
                return this.milestoneListField;
            }
            set {
                this.milestoneListField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}