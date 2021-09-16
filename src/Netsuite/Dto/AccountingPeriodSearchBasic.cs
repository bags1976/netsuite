namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountingPeriodSearchBasic : SearchRecordBasic {

        private SearchBooleanField allLockedField;

        private SearchBooleanField allowNonGlChangesField;

        private SearchBooleanField apLockedField;

        private SearchBooleanField arLockedField;

        private SearchBooleanField closedField;

        private SearchDateField closedOnDateField;

        private SearchDateField endDateField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isAdjustField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isQuarterField;

        private SearchBooleanField isYearField;

        private SearchMultiSelectField parentField;

        private SearchBooleanField payrollLockedField;

        private SearchStringField periodNameField;

        private SearchDateField startDateField;

        /// <remarks/>
        public SearchBooleanField allLocked {
            get {
                return this.allLockedField;
            }
            set {
                this.allLockedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allowNonGlChanges {
            get {
                return this.allowNonGlChangesField;
            }
            set {
                this.allowNonGlChangesField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField apLocked {
            get {
                return this.apLockedField;
            }
            set {
                this.apLockedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField arLocked {
            get {
                return this.arLockedField;
            }
            set {
                this.arLockedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        public SearchDateField closedOnDate {
            get {
                return this.closedOnDateField;
            }
            set {
                this.closedOnDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isAdjust {
            get {
                return this.isAdjustField;
            }
            set {
                this.isAdjustField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isQuarter {
            get {
                return this.isQuarterField;
            }
            set {
                this.isQuarterField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isYear {
            get {
                return this.isYearField;
            }
            set {
                this.isYearField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField payrollLocked {
            get {
                return this.payrollLockedField;
            }
            set {
                this.payrollLockedField = value;
            }
        }

        /// <remarks/>
        public SearchStringField periodName {
            get {
                return this.periodNameField;
            }
            set {
                this.periodNameField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
    }
}