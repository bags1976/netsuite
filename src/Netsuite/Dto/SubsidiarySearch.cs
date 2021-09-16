namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SubsidiarySearch : SearchRecord {

        private SubsidiarySearchBasic basicField;

        private AddressSearchBasic addressJoinField;

        private AccountSearchBasic defaultAdvanceToApplyAccountJoinField;

        private AddressSearchBasic returnAddressJoinField;

        private AddressSearchBasic shippingAddressJoinField;

        private EmployeeSearchBasic userJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public SubsidiarySearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AddressSearchBasic addressJoin {
            get {
                return this.addressJoinField;
            }
            set {
                this.addressJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic defaultAdvanceToApplyAccountJoin {
            get {
                return this.defaultAdvanceToApplyAccountJoinField;
            }
            set {
                this.defaultAdvanceToApplyAccountJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchBasic returnAddressJoin {
            get {
                return this.returnAddressJoinField;
            }
            set {
                this.returnAddressJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchBasic shippingAddressJoin {
            get {
                return this.shippingAddressJoinField;
            }
            set {
                this.shippingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
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