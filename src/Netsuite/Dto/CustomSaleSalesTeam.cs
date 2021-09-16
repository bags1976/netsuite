namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomSaleSalesTeam {

        private RecordRef employeeField;

        private RecordRef salesRoleField;

        private bool isPrimaryField;

        private bool isPrimaryFieldSpecified;

        private double contributionField;

        private bool contributionFieldSpecified;

        /// <remarks/>
        public RecordRef employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        public RecordRef salesRole {
            get {
                return this.salesRoleField;
            }
            set {
                this.salesRoleField = value;
            }
        }

        /// <remarks/>
        public bool isPrimary {
            get {
                return this.isPrimaryField;
            }
            set {
                this.isPrimaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimarySpecified {
            get {
                return this.isPrimaryFieldSpecified;
            }
            set {
                this.isPrimaryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double contribution {
            get {
                return this.contributionField;
            }
            set {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contributionSpecified {
            get {
                return this.contributionFieldSpecified;
            }
            set {
                this.contributionFieldSpecified = value;
            }
        }
    }
}