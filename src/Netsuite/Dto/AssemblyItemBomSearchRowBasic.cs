namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AssemblyItemBomSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] assemblyField;

        private SearchColumnSelectField[] billOfMaterialsField;

        private SearchColumnBooleanField[] defaultField;

        private SearchColumnSelectField[] locationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assembly")]
        public SearchColumnSelectField[] assembly {
            get {
                return this.assemblyField;
            }
            set {
                this.assemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billOfMaterials")]
        public SearchColumnSelectField[] billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("default")]
        public SearchColumnBooleanField[] @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locations")]
        public SearchColumnSelectField[] locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
            }
        }
    }
}