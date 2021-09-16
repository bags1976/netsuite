namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomSegment : Record {

        private string labelField;

        private string scriptIdField;

        private string recordScriptIdField;

        private RecordRef recordTypeField;

        private CustomizationFieldType fieldTypeField;

        private bool fieldTypeFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool showInListField;

        private bool showInListFieldSpecified;

        private RecordRef[] filteredByListField;

        private bool hasGLImpactField;

        private bool hasGLImpactFieldSpecified;

        private string helpField;

        private string descriptionField;

        private bool isMandatoryField;

        private bool isMandatoryFieldSpecified;

        private RecordRef defaultSelectionField;

        private string internalIdField;

        /// <remarks/>
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public string scriptId {
            get {
                return this.scriptIdField;
            }
            set {
                this.scriptIdField = value;
            }
        }

        /// <remarks/>
        public string recordScriptId {
            get {
                return this.recordScriptIdField;
            }
            set {
                this.recordScriptIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        public CustomizationFieldType fieldType {
            get {
                return this.fieldTypeField;
            }
            set {
                this.fieldTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fieldTypeSpecified {
            get {
                return this.fieldTypeFieldSpecified;
            }
            set {
                this.fieldTypeFieldSpecified = value;
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
        public bool showInList {
            get {
                return this.showInListField;
            }
            set {
                this.showInListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showInListSpecified {
            get {
                return this.showInListFieldSpecified;
            }
            set {
                this.showInListFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] filteredByList {
            get {
                return this.filteredByListField;
            }
            set {
                this.filteredByListField = value;
            }
        }

        /// <remarks/>
        public bool hasGLImpact {
            get {
                return this.hasGLImpactField;
            }
            set {
                this.hasGLImpactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasGLImpactSpecified {
            get {
                return this.hasGLImpactFieldSpecified;
            }
            set {
                this.hasGLImpactFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string help {
            get {
                return this.helpField;
            }
            set {
                this.helpField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool isMandatory {
            get {
                return this.isMandatoryField;
            }
            set {
                this.isMandatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMandatorySpecified {
            get {
                return this.isMandatoryFieldSpecified;
            }
            set {
                this.isMandatoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultSelection {
            get {
                return this.defaultSelectionField;
            }
            set {
                this.defaultSelectionField = value;
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