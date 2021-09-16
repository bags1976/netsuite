namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BomSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] availableForAllAssembliesField;

        private SearchColumnBooleanField[] availableForAllLocationsField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] includeChildrenField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnSelectField[] legacyBomForAssemblyField;

        private SearchColumnStringField[] memoField;

        private SearchColumnStringField[] nameField;

        private SearchColumnSelectField[] restrictToAssembliesField;

        private SearchColumnSelectField[] restrictToLocationsField;

        private SearchColumnStringField[] revisionNameField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] subsidiaryNoHierarchyField;

        private SearchColumnBooleanField[] useComponentYieldField;

        private SearchColumnBooleanField[] usedOnAssemblyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableForAllAssemblies")]
        public SearchColumnBooleanField[] availableForAllAssemblies {
            get {
                return this.availableForAllAssembliesField;
            }
            set {
                this.availableForAllAssembliesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableForAllLocations")]
        public SearchColumnBooleanField[] availableForAllLocations {
            get {
                return this.availableForAllLocationsField;
            }
            set {
                this.availableForAllLocationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includeChildren")]
        public SearchColumnBooleanField[] includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("legacyBomForAssembly")]
        public SearchColumnSelectField[] legacyBomForAssembly {
            get {
                return this.legacyBomForAssemblyField;
            }
            set {
                this.legacyBomForAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("restrictToAssemblies")]
        public SearchColumnSelectField[] restrictToAssemblies {
            get {
                return this.restrictToAssembliesField;
            }
            set {
                this.restrictToAssembliesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("restrictToLocations")]
        public SearchColumnSelectField[] restrictToLocations {
            get {
                return this.restrictToLocationsField;
            }
            set {
                this.restrictToLocationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revisionName")]
        public SearchColumnStringField[] revisionName {
            get {
                return this.revisionNameField;
            }
            set {
                this.revisionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiaryNoHierarchy")]
        public SearchColumnSelectField[] subsidiaryNoHierarchy {
            get {
                return this.subsidiaryNoHierarchyField;
            }
            set {
                this.subsidiaryNoHierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useComponentYield")]
        public SearchColumnBooleanField[] useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usedOnAssembly")]
        public SearchColumnBooleanField[] usedOnAssembly {
            get {
                return this.usedOnAssemblyField;
            }
            set {
                this.usedOnAssemblyField = value;
            }
        }
    }
}