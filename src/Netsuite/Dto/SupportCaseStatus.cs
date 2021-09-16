namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class SupportCaseStatus : Record {

        private string nameField;

        private RecordRef insertBeforeField;

        private SupportCaseStatusStage stageField;

        private bool stageFieldSpecified;

        private bool caseOnHoldField;

        private bool caseOnHoldFieldSpecified;

        private bool autoCloseCaseField;

        private bool autoCloseCaseFieldSpecified;

        private string descriptionField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef insertBefore {
            get {
                return this.insertBeforeField;
            }
            set {
                this.insertBeforeField = value;
            }
        }

        /// <remarks/>
        public SupportCaseStatusStage stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stageSpecified {
            get {
                return this.stageFieldSpecified;
            }
            set {
                this.stageFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool caseOnHold {
            get {
                return this.caseOnHoldField;
            }
            set {
                this.caseOnHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caseOnHoldSpecified {
            get {
                return this.caseOnHoldFieldSpecified;
            }
            set {
                this.caseOnHoldFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autoCloseCase {
            get {
                return this.autoCloseCaseField;
            }
            set {
                this.autoCloseCaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoCloseCaseSpecified {
            get {
                return this.autoCloseCaseFieldSpecified;
            }
            set {
                this.autoCloseCaseFieldSpecified = value;
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