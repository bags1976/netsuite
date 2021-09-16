namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomFieldDepartmentAccess {

        private RecordRef deptField;

        private CustomizationAccessLevel accessLevelField;

        private bool accessLevelFieldSpecified;

        private CustomizationSearchLevel searchLevelField;

        private bool searchLevelFieldSpecified;

        /// <remarks/>
        public RecordRef dept {
            get {
                return this.deptField;
            }
            set {
                this.deptField = value;
            }
        }

        /// <remarks/>
        public CustomizationAccessLevel accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessLevelSpecified {
            get {
                return this.accessLevelFieldSpecified;
            }
            set {
                this.accessLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomizationSearchLevel searchLevel {
            get {
                return this.searchLevelField;
            }
            set {
                this.searchLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchLevelSpecified {
            get {
                return this.searchLevelFieldSpecified;
            }
            set {
                this.searchLevelFieldSpecified = value;
            }
        }
    }
}