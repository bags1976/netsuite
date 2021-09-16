namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountingPeriodSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] allLockedField;

        private SearchColumnBooleanField[] allowNonGLChangesField;

        private SearchColumnBooleanField[] apLockedField;

        private SearchColumnBooleanField[] arLockedField;

        private SearchColumnBooleanField[] closedField;

        private SearchColumnDateField[] closedOnDateField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isAdjustField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isQuarterField;

        private SearchColumnBooleanField[] isYearField;

        private SearchColumnSelectField[] parentField;

        private SearchColumnBooleanField[] payrollLockedField;

        private SearchColumnStringField[] periodNameField;

        private SearchColumnDateField[] startDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allLocked")]
        public SearchColumnBooleanField[] allLocked {
            get {
                return this.allLockedField;
            }
            set {
                this.allLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowNonGLChanges")]
        public SearchColumnBooleanField[] allowNonGLChanges {
            get {
                return this.allowNonGLChangesField;
            }
            set {
                this.allowNonGLChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("apLocked")]
        public SearchColumnBooleanField[] apLocked {
            get {
                return this.apLockedField;
            }
            set {
                this.apLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arLocked")]
        public SearchColumnBooleanField[] arLocked {
            get {
                return this.arLockedField;
            }
            set {
                this.arLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closed")]
        public SearchColumnBooleanField[] closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closedOnDate")]
        public SearchColumnDateField[] closedOnDate {
            get {
                return this.closedOnDateField;
            }
            set {
                this.closedOnDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isAdjust")]
        public SearchColumnBooleanField[] isAdjust {
            get {
                return this.isAdjustField;
            }
            set {
                this.isAdjustField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isQuarter")]
        public SearchColumnBooleanField[] isQuarter {
            get {
                return this.isQuarterField;
            }
            set {
                this.isQuarterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isYear")]
        public SearchColumnBooleanField[] isYear {
            get {
                return this.isYearField;
            }
            set {
                this.isYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parent")]
        public SearchColumnSelectField[] parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payrollLocked")]
        public SearchColumnBooleanField[] payrollLocked {
            get {
                return this.payrollLockedField;
            }
            set {
                this.payrollLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodName")]
        public SearchColumnStringField[] periodName {
            get {
                return this.periodNameField;
            }
            set {
                this.periodNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
    }
}