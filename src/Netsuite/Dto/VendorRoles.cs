namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorRoles {

        private RecordRef selectedRoleField;

        /// <remarks/>
        public RecordRef selectedRole {
            get {
                return this.selectedRoleField;
            }
            set {
                this.selectedRoleField = value;
            }
        }
    }
}