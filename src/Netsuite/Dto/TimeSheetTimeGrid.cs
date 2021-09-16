namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeSheetTimeGrid {

        private TimeEntry sundayField;

        private TimeEntry mondayField;

        private TimeEntry tuesdayField;

        private TimeEntry wednesdayField;

        private TimeEntry thursdayField;

        private TimeEntry fridayField;

        private TimeEntry saturdayField;

        /// <remarks/>
        public TimeEntry sunday {
            get {
                return this.sundayField;
            }
            set {
                this.sundayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry monday {
            get {
                return this.mondayField;
            }
            set {
                this.mondayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry tuesday {
            get {
                return this.tuesdayField;
            }
            set {
                this.tuesdayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry wednesday {
            get {
                return this.wednesdayField;
            }
            set {
                this.wednesdayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry thursday {
            get {
                return this.thursdayField;
            }
            set {
                this.thursdayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry friday {
            get {
                return this.fridayField;
            }
            set {
                this.fridayField = value;
            }
        }

        /// <remarks/>
        public TimeEntry saturday {
            get {
                return this.saturdayField;
            }
            set {
                this.saturdayField = value;
            }
        }
    }
}