namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CouponCode : Record {

        private RecordRef promotionField;

        private string codeField;

        private RecordRef recipientField;

        private System.DateTime dateSentField;

        private bool dateSentFieldSpecified;

        private bool usedField;

        private bool usedFieldSpecified;

        private long useCountField;

        private bool useCountFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef promotion {
            get {
                return this.promotionField;
            }
            set {
                this.promotionField = value;
            }
        }

        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public RecordRef recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateSent {
            get {
                return this.dateSentField;
            }
            set {
                this.dateSentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSentSpecified {
            get {
                return this.dateSentFieldSpecified;
            }
            set {
                this.dateSentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool used {
            get {
                return this.usedField;
            }
            set {
                this.usedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedSpecified {
            get {
                return this.usedFieldSpecified;
            }
            set {
                this.usedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long useCount {
            get {
                return this.useCountField;
            }
            set {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useCountSpecified {
            get {
                return this.useCountFieldSpecified;
            }
            set {
                this.useCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}