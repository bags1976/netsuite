namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BomSearchBasic : SearchRecordBasic {

        private SearchBooleanField availableForAllAssembliesField;

        private SearchBooleanField availableForAllLocationsField;

        private SearchDateField createdDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField includeChildrenField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchMultiSelectField legacyBomForAssemblyField;

        private SearchStringField memoField;

        private SearchStringField nameField;

        private SearchMultiSelectField restrictToAssembliesField;

        private SearchMultiSelectField restrictToLocationsField;

        private SearchMultiSelectField subsidiaryField;

        private SearchBooleanField useComponentYieldField;

        private SearchBooleanField usedOnAssemblyField;

        /// <remarks/>
        public SearchBooleanField availableForAllAssemblies {
            get {
                return this.availableForAllAssembliesField;
            }
            set {
                this.availableForAllAssembliesField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField availableForAllLocations {
            get {
                return this.availableForAllLocationsField;
            }
            set {
                this.availableForAllLocationsField = value;
            }
        }

        /// <remarks/>
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
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
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField legacyBomForAssembly {
            get {
                return this.legacyBomForAssemblyField;
            }
            set {
                this.legacyBomForAssemblyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField restrictToAssemblies {
            get {
                return this.restrictToAssembliesField;
            }
            set {
                this.restrictToAssembliesField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField restrictToLocations {
            get {
                return this.restrictToLocationsField;
            }
            set {
                this.restrictToLocationsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField usedOnAssembly {
            get {
                return this.usedOnAssemblyField;
            }
            set {
                this.usedOnAssemblyField = value;
            }
        }
    }
}