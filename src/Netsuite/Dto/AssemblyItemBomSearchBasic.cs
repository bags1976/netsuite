namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AssemblyItemBomSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField assemblyField;

        private SearchMultiSelectField billOfMaterialsField;

        private SearchBooleanField defaultField;

        private SearchMultiSelectField locationsField;

        /// <remarks/>
        public SearchMultiSelectField assembly {
            get {
                return this.assemblyField;
            }
            set {
                this.assemblyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
            }
        }
    }
}