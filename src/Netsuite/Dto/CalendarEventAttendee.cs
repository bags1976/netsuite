using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class CalendarEventAttendee {

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private RecordRef attendeeField;

        private CalendarEventAttendeeResponse responseField;

        private bool responseFieldSpecified;

        private CalendarEventAttendeeAttendance attendanceField;

        private bool attendanceFieldSpecified;

        /// <remarks/>
        public bool sendEmail {
            get {
                return this.sendEmailField;
            }
            set {
                this.sendEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendEmailSpecified {
            get {
                return this.sendEmailFieldSpecified;
            }
            set {
                this.sendEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef attendee {
            get {
                return this.attendeeField;
            }
            set {
                this.attendeeField = value;
            }
        }

        /// <remarks/>
        public CalendarEventAttendeeResponse response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool responseSpecified {
            get {
                return this.responseFieldSpecified;
            }
            set {
                this.responseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CalendarEventAttendeeAttendance attendance {
            get {
                return this.attendanceField;
            }
            set {
                this.attendanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attendanceSpecified {
            get {
                return this.attendanceFieldSpecified;
            }
            set {
                this.attendanceFieldSpecified = value;
            }
        }
    }
}