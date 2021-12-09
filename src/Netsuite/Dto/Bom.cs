namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Bom : Record {

        #region AudtoGeneratedPrivateFields

        private RecordRef customFormField;

        private string nameField;

        private bool usedOnAssemblyField;

        private bool usedOnAssemblyFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private bool useComponentYieldField;

        private bool useComponentYieldFieldSpecified;

        private string memoField;

        private RecordRef legacyBomForAssemblyField;

        private bool availableForAllAssembliesField;

        private bool availableForAllAssembliesFieldSpecified;

        private RecordRef[] restrictToAssembliesListField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        #endregion

        #region  PublicFields

        public int assemblyId {get; set;}
        public int bomId {get; set;}
        public string subsidiary {get; set; }
        public string bomName {get; set; }
        public DateTime bomCreatedDate {get; set;}
        public bool bomIsInactive {get; set;}
        public string bomExternalId {get; set; }
        public string assemblyName {get; set; }
        public bool assemblyIsInactive {get; set;}
        public string assemblyDescription {get; set; }
        public string revisionName {get; set; }
        public int revisionId {get; set;}
        public DateTime revisionCreatedDate {get; set;}
        public string revisionExternalId {get; set; }
        public bool revisionIsInactive {get; set;}
        public DateTime? effectiveStartDate {get; set;}
        public DateTime? effectiveEndDate {get; set;}
        public int componentId { get; set; }
        public string itemSource {get; set; }
        public string description {get; set; }
        public string componentName {get; set; }
        public string unitsName {get; set; }
        public string restrictToLocations {get; set; }
        public decimal bomQuantity {get; set; }
        public int componentLineId { get; set; }
        public int units { get; set; }

        #endregion

        #region  AudtoGeneratedPublicFields

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
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
        public bool usedOnAssembly {
            get {
                return this.usedOnAssemblyField;
            }
            set {
                this.usedOnAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedOnAssemblySpecified {
            get {
                return this.usedOnAssemblyFieldSpecified;
            }
            set {
                this.usedOnAssemblyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useComponentYieldSpecified {
            get {
                return this.useComponentYieldFieldSpecified;
            }
            set {
                this.useComponentYieldFieldSpecified = value;
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
        public RecordRef legacyBomForAssembly {
            get {
                return this.legacyBomForAssemblyField;
            }
            set {
                this.legacyBomForAssemblyField = value;
            }
        }

        /// <remarks/>
        public bool availableForAllAssemblies {
            get {
                return this.availableForAllAssembliesField;
            }
            set {
                this.availableForAllAssembliesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableForAllAssembliesSpecified {
            get {
                return this.availableForAllAssembliesFieldSpecified;
            }
            set {
                this.availableForAllAssembliesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] restrictToAssembliesList {
            get {
                return this.restrictToAssembliesListField;
            }
            set {
                this.restrictToAssembliesListField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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

        #endregion


    }
}