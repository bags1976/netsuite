using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class UpdateInviteeStatusReference {

        private RecordRef eventIdField;

        private CalendarEventAttendeeResponse responseCodeField;

        /// <remarks/>
        public RecordRef eventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
            }
        }

        /// <remarks/>
        public CalendarEventAttendeeResponse responseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
            }
        }
    }
}