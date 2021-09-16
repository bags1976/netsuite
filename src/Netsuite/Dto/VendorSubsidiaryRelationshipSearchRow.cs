namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorSubsidiaryRelationshipSearchRow : SearchRow {

        private VendorSubsidiaryRelationshipSearchRowBasic basicField;

        private SubsidiarySearchRowBasic subsidiaryJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public VendorSubsidiaryRelationshipSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchRowBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchRowBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}