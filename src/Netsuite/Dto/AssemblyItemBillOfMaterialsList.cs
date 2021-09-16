namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class AssemblyItemBillOfMaterialsList {

        private AssemblyItemBillOfMaterials[] assemblyItemBillOfMaterialsField;

        private bool replaceAllField;

        public AssemblyItemBillOfMaterialsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assemblyItemBillOfMaterials")]
        public AssemblyItemBillOfMaterials[] assemblyItemBillOfMaterials {
            get {
                return this.assemblyItemBillOfMaterialsField;
            }
            set {
                this.assemblyItemBillOfMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool replaceAll {
            get {
                return this.replaceAllField;
            }
            set {
                this.replaceAllField = value;
            }
        }
    }
}