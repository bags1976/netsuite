namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CouponCodeSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] codeField;

        private SearchColumnDateField[] dateSentField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnLongField[] idField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] promotionField;

        private SearchColumnStringField[] recipientField;

        private SearchColumnLongField[] useCountField;

        private SearchColumnBooleanField[] usedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("code")]
        public SearchColumnStringField[] code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateSent")]
        public SearchColumnDateField[] dateSent {
            get {
                return this.dateSentField;
            }
            set {
                this.dateSentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public SearchColumnLongField[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("promotion")]
        public SearchColumnStringField[] promotion {
            get {
                return this.promotionField;
            }
            set {
                this.promotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recipient")]
        public SearchColumnStringField[] recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useCount")]
        public SearchColumnLongField[] useCount {
            get {
                return this.useCountField;
            }
            set {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("used")]
        public SearchColumnBooleanField[] used {
            get {
                return this.usedField;
            }
            set {
                this.usedField = value;
            }
        }
    }
}