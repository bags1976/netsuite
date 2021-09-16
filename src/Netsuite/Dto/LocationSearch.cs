namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class LocationSearch : SearchRecord {

        private LocationSearchBasic basicField;

        private AddressSearchBasic addressJoinField;

        private AddressSearchBasic returnAddressJoinField;

        private EmployeeSearchBasic userJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public LocationSearchBasic basic {
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
        public AddressSearchBasic returnAddressJoin {
            get {
                return this.returnAddressJoinField;
            }
            set {
                this.returnAddressJoinField = value;
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