namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorSubsidiaryRelationshipSearch : SearchRecord {

        private VendorSubsidiaryRelationshipSearchBasic basicField;

        private SubsidiarySearchBasic subsidiaryJoinField;

        private VendorSearchBasic vendorJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public VendorSubsidiaryRelationshipSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}