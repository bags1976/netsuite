namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class MerchandiseHierarchyNodeSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] descriptionField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] hierarchyLevelField;

        private SearchColumnSelectField[] hierarchyVersionField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] nameField;

        private SearchColumnSelectField[] parentNodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("hierarchyLevel")]
        public SearchColumnSelectField[] hierarchyLevel {
            get {
                return this.hierarchyLevelField;
            }
            set {
                this.hierarchyLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hierarchyVersion")]
        public SearchColumnSelectField[] hierarchyVersion {
            get {
                return this.hierarchyVersionField;
            }
            set {
                this.hierarchyVersionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("parentNode")]
        public SearchColumnSelectField[] parentNode {
            get {
                return this.parentNodeField;
            }
            set {
                this.parentNodeField = value;
            }
        }
    }
}