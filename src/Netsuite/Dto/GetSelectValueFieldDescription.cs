using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetSelectValueFieldDescription {

        private RecordType recordTypeField;

        private bool recordTypeFieldSpecified;

        private RecordRef customRecordTypeField;

        private RecordRef customTransactionTypeField;

        private string sublistField;

        private string fieldField;

        private RecordRef customFormField;

        private GetSelectValueFilter filterField;

        private GetSelectFilterByFieldValue[] filterByValueListField;

        /// <remarks/>
        public RecordType recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recordTypeSpecified {
            get {
                return this.recordTypeFieldSpecified;
            }
            set {
                this.recordTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef customRecordType {
            get {
                return this.customRecordTypeField;
            }
            set {
                this.customRecordTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef customTransactionType {
            get {
                return this.customTransactionTypeField;
            }
            set {
                this.customTransactionTypeField = value;
            }
        }

        /// <remarks/>
        public string sublist {
            get {
                return this.sublistField;
            }
            set {
                this.sublistField = value;
            }
        }

        /// <remarks/>
        public string field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public GetSelectValueFilter filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("filterBy", IsNullable=false)]
        public GetSelectFilterByFieldValue[] filterByValueList {
            get {
                return this.filterByValueListField;
            }
            set {
                this.filterByValueListField = value;
            }
        }
    }
}