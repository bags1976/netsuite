namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class LocationSearchRow : SearchRow {

        private LocationSearchRowBasic basicField;

        private AddressSearchRowBasic addressJoinField;

        private AddressSearchRowBasic returnAddressJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public LocationSearchRowBasic basic {
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
        public AddressSearchRowBasic returnAddressJoin {
            get {
                return this.returnAddressJoinField;
            }
            set {
                this.returnAddressJoinField = value;
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