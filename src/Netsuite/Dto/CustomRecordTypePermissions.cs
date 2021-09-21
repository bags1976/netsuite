using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypePermissions {

        private RecordRef permittedRoleField;

        private CustomRecordTypePermissionsPermittedLevel permittedLevelField;

        private bool permittedLevelFieldSpecified;

        private CustomRecordTypePermissionsRestriction restrictionField;

        private bool restrictionFieldSpecified;

        private RecordRef defaultFormField;

        private bool restrictFormField;

        private bool restrictFormFieldSpecified;

        private RecordRef searchFormField;

        private RecordRef searchResultsField;

        private RecordRef listViewField;

        private bool listViewRestrictedField;

        private bool listViewRestrictedFieldSpecified;

        private RecordRef dashboardViewField;

        private bool restrictDashboardViewField;

        private bool restrictDashboardViewFieldSpecified;

        private RecordRef sublistViewField;

        private bool restrictSublistViewField;

        private bool restrictSublistViewFieldSpecified;

        /// <remarks/>
        public RecordRef permittedRole {
            get {
                return this.permittedRoleField;
            }
            set {
                this.permittedRoleField = value;
            }
        }

        /// <remarks/>
        public CustomRecordTypePermissionsPermittedLevel permittedLevel {
            get {
                return this.permittedLevelField;
            }
            set {
                this.permittedLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool permittedLevelSpecified {
            get {
                return this.permittedLevelFieldSpecified;
            }
            set {
                this.permittedLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomRecordTypePermissionsRestriction restriction {
            get {
                return this.restrictionField;
            }
            set {
                this.restrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictionSpecified {
            get {
                return this.restrictionFieldSpecified;
            }
            set {
                this.restrictionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultForm {
            get {
                return this.defaultFormField;
            }
            set {
                this.defaultFormField = value;
            }
        }

        /// <remarks/>
        public bool restrictForm {
            get {
                return this.restrictFormField;
            }
            set {
                this.restrictFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictFormSpecified {
            get {
                return this.restrictFormFieldSpecified;
            }
            set {
                this.restrictFormFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef searchForm {
            get {
                return this.searchFormField;
            }
            set {
                this.searchFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef searchResults {
            get {
                return this.searchResultsField;
            }
            set {
                this.searchResultsField = value;
            }
        }

        /// <remarks/>
        public RecordRef listView {
            get {
                return this.listViewField;
            }
            set {
                this.listViewField = value;
            }
        }

        /// <remarks/>
        public bool listViewRestricted {
            get {
                return this.listViewRestrictedField;
            }
            set {
                this.listViewRestrictedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool listViewRestrictedSpecified {
            get {
                return this.listViewRestrictedFieldSpecified;
            }
            set {
                this.listViewRestrictedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef dashboardView {
            get {
                return this.dashboardViewField;
            }
            set {
                this.dashboardViewField = value;
            }
        }

        /// <remarks/>
        public bool restrictDashboardView {
            get {
                return this.restrictDashboardViewField;
            }
            set {
                this.restrictDashboardViewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictDashboardViewSpecified {
            get {
                return this.restrictDashboardViewFieldSpecified;
            }
            set {
                this.restrictDashboardViewFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef sublistView {
            get {
                return this.sublistViewField;
            }
            set {
                this.sublistViewField = value;
            }
        }

        /// <remarks/>
        public bool restrictSublistView {
            get {
                return this.restrictSublistViewField;
            }
            set {
                this.restrictSublistViewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictSublistViewSpecified {
            get {
                return this.restrictSublistViewFieldSpecified;
            }
            set {
                this.restrictSublistViewFieldSpecified = value;
            }
        }
    }
}