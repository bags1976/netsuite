using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetAllRecord {

        private GetAllRecordType recordTypeField;

        private bool recordTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GetAllRecordType recordType {
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
    }
}