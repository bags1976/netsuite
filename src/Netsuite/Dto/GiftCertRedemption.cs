namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class GiftCertRedemption {

        private RecordRef authCodeField;

        private double authCodeAppliedField;

        private bool authCodeAppliedFieldSpecified;

        private double authCodeAmtRemainingField;

        private bool authCodeAmtRemainingFieldSpecified;

        private double giftCertAvailableField;

        private bool giftCertAvailableFieldSpecified;

        /// <remarks/>
        public RecordRef authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        public double authCodeApplied {
            get {
                return this.authCodeAppliedField;
            }
            set {
                this.authCodeAppliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool authCodeAppliedSpecified {
            get {
                return this.authCodeAppliedFieldSpecified;
            }
            set {
                this.authCodeAppliedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double authCodeAmtRemaining {
            get {
                return this.authCodeAmtRemainingField;
            }
            set {
                this.authCodeAmtRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool authCodeAmtRemainingSpecified {
            get {
                return this.authCodeAmtRemainingFieldSpecified;
            }
            set {
                this.authCodeAmtRemainingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double giftCertAvailable {
            get {
                return this.giftCertAvailableField;
            }
            set {
                this.giftCertAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giftCertAvailableSpecified {
            get {
                return this.giftCertAvailableFieldSpecified;
            }
            set {
                this.giftCertAvailableFieldSpecified = value;
            }
        }
    }
}