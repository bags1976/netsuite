namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SubsidiarySearchRow : SearchRow {

        private SubsidiarySearchRowBasic basicField;

        private AddressSearchRowBasic addressJoinField;

        private AccountSearchRowBasic defaultAdvanceToApplyAccountJoinField;

        private AddressSearchRowBasic returnAddressJoinField;

        private AddressSearchRowBasic shippingAddressJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public SubsidiarySearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AddressSearchRowBasic addressJoin {
            get {
                return this.addressJoinField;
            }
            set {
                this.addressJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic defaultAdvanceToApplyAccountJoin {
            get {
                return this.defaultAdvanceToApplyAccountJoinField;
            }
            set {
                this.defaultAdvanceToApplyAccountJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchRowBasic returnAddressJoin {
            get {
                return this.returnAddressJoinField;
            }
            set {
                this.returnAddressJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchRowBasic shippingAddressJoin {
            get {
                return this.shippingAddressJoinField;
            }
            set {
                this.shippingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
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