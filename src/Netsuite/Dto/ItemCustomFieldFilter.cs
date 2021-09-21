using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class ItemCustomFieldFilter {

        private RecordRef fldFilterField;

        private bool fldFilterCheckedField;

        private bool fldFilterCheckedFieldSpecified;

        private CustomizationFilterCompareType fldFilterCompareTypeField;

        private bool fldFilterCompareTypeFieldSpecified;

        private string fldFilterValField;

        private RecordRef[] fldFilterSelListField;

        private bool fldFilterNotNullField;

        private bool fldFilterNotNullFieldSpecified;

        /// <remarks/>
        public RecordRef fldFilter {
            get {
                return this.fldFilterField;
            }
            set {
                this.fldFilterField = value;
            }
        }

        /// <remarks/>
        public bool fldFilterChecked {
            get {
                return this.fldFilterCheckedField;
            }
            set {
                this.fldFilterCheckedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fldFilterCheckedSpecified {
            get {
                return this.fldFilterCheckedFieldSpecified;
            }
            set {
                this.fldFilterCheckedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomizationFilterCompareType fldFilterCompareType {
            get {
                return this.fldFilterCompareTypeField;
            }
            set {
                this.fldFilterCompareTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fldFilterCompareTypeSpecified {
            get {
                return this.fldFilterCompareTypeFieldSpecified;
            }
            set {
                this.fldFilterCompareTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fldFilterVal {
            get {
                return this.fldFilterValField;
            }
            set {
                this.fldFilterValField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fldFilterSel", IsNullable=false)]
        public RecordRef[] fldFilterSelList {
            get {
                return this.fldFilterSelListField;
            }
            set {
                this.fldFilterSelListField = value;
            }
        }

        /// <remarks/>
        public bool fldFilterNotNull {
            get {
                return this.fldFilterNotNullField;
            }
            set {
                this.fldFilterNotNullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fldFilterNotNullSpecified {
            get {
                return this.fldFilterNotNullFieldSpecified;
            }
            set {
                this.fldFilterNotNullFieldSpecified = value;
            }
        }
    }
}