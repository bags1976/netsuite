namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class OtherChargeResaleItemHierarchyVersionsList {

        private OtherChargeResaleItemHierarchyVersions[] otherChargeResaleItemHierarchyVersionsField;

        private bool replaceAllField;

        public OtherChargeResaleItemHierarchyVersionsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherChargeResaleItemHierarchyVersions")]
        public OtherChargeResaleItemHierarchyVersions[] otherChargeResaleItemHierarchyVersions {
            get {
                return this.otherChargeResaleItemHierarchyVersionsField;
            }
            set {
                this.otherChargeResaleItemHierarchyVersionsField = value;
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