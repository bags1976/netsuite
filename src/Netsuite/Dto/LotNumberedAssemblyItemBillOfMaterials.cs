namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class LotNumberedAssemblyItemBillOfMaterials {

        private RecordRef billOfMaterialsField;

        private string currentRevisionField;

        private bool masterDefaultField;

        private bool masterDefaultFieldSpecified;

        private RecordRef[] defaultForLocationListField;

        private string inactiveField;

        private string memoField;

        /// <remarks/>
        public RecordRef billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
            }
        }

        /// <remarks/>
        public string currentRevision {
            get {
                return this.currentRevisionField;
            }
            set {
                this.currentRevisionField = value;
            }
        }

        /// <remarks/>
        public bool masterDefault {
            get {
                return this.masterDefaultField;
            }
            set {
                this.masterDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool masterDefaultSpecified {
            get {
                return this.masterDefaultFieldSpecified;
            }
            set {
                this.masterDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] defaultForLocationList {
            get {
                return this.defaultForLocationListField;
            }
            set {
                this.defaultForLocationListField = value;
            }
        }

        /// <remarks/>
        public string inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }
    }
}