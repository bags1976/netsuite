using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class InitializeRecord {

        private InitializeType typeField;

        private InitializeRef referenceField;

        private InitializeAuxRef auxReferenceField;

        private InitializeRef[] referenceListField;

        /// <remarks/>
        public InitializeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public InitializeRef reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public InitializeAuxRef auxReference {
            get {
                return this.auxReferenceField;
            }
            set {
                this.auxReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("initializeRef", IsNullable=false)]
        public InitializeRef[] referenceList {
            get {
                return this.referenceListField;
            }
            set {
                this.referenceListField = value;
            }
        }
    }
}