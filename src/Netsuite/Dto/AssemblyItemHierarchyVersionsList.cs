namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class AssemblyItemHierarchyVersionsList {

        private AssemblyItemHierarchyVersions[] assemblyItemHierarchyVersionsField;

        private bool replaceAllField;

        public AssemblyItemHierarchyVersionsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assemblyItemHierarchyVersions")]
        public AssemblyItemHierarchyVersions[] assemblyItemHierarchyVersions {
            get {
                return this.assemblyItemHierarchyVersionsField;
            }
            set {
                this.assemblyItemHierarchyVersionsField = value;
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