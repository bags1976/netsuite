namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class RevRecTemplateSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] amorMethodField;

        private SearchColumnStringField[] amorPeriodField;

        private SearchColumnStringField[] amorStartOffsetField;

        private SearchColumnStringField[] amorTermSrcField;

        private SearchColumnStringField[] amorTypeField;

        private SearchColumnStringField[] contraAccountField;

        private SearchColumnStringField[] deferralAccountField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] isInactiveField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] periodOffsetField;

        private SearchColumnStringField[] targetAccountField;

        private SearchColumnBooleanField[] useForeignAmountsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorMethod")]
        public SearchColumnStringField[] amorMethod {
            get {
                return this.amorMethodField;
            }
            set {
                this.amorMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorPeriod")]
        public SearchColumnStringField[] amorPeriod {
            get {
                return this.amorPeriodField;
            }
            set {
                this.amorPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorStartOffset")]
        public SearchColumnStringField[] amorStartOffset {
            get {
                return this.amorStartOffsetField;
            }
            set {
                this.amorStartOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorTermSrc")]
        public SearchColumnStringField[] amorTermSrc {
            get {
                return this.amorTermSrcField;
            }
            set {
                this.amorTermSrcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorType")]
        public SearchColumnStringField[] amorType {
            get {
                return this.amorTypeField;
            }
            set {
                this.amorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contraAccount")]
        public SearchColumnStringField[] contraAccount {
            get {
                return this.contraAccountField;
            }
            set {
                this.contraAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferralAccount")]
        public SearchColumnStringField[] deferralAccount {
            get {
                return this.deferralAccountField;
            }
            set {
                this.deferralAccountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnStringField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodOffset")]
        public SearchColumnStringField[] periodOffset {
            get {
                return this.periodOffsetField;
            }
            set {
                this.periodOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("targetAccount")]
        public SearchColumnStringField[] targetAccount {
            get {
                return this.targetAccountField;
            }
            set {
                this.targetAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useForeignAmounts")]
        public SearchColumnBooleanField[] useForeignAmounts {
            get {
                return this.useForeignAmountsField;
            }
            set {
                this.useForeignAmountsField = value;
            }
        }
    }
}