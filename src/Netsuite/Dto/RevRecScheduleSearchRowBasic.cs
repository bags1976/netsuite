namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class RevRecScheduleSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] accountingBookField;

        private SearchColumnEnumSelectField[] amorStatusField;

        private SearchColumnStringField[] amorTemplateField;

        private SearchColumnDoubleField[] amortizedAmountField;

        private SearchColumnEnumSelectField[] amorTypeField;

        private SearchColumnDoubleField[] amountField;

        private SearchColumnStringField[] currencyField;

        private SearchColumnDoubleField[] deferredAmountField;

        private SearchColumnStringField[] destAcctField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnDoubleField[] initialAmtField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isRecognizedField;

        private SearchColumnStringField[] jeDocField;

        private SearchColumnLongField[] lineSequenceNumberField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] nameUrlField;

        private SearchColumnDoubleField[] pctCompleteField;

        private SearchColumnDoubleField[] pctRecognitionField;

        private SearchColumnLongField[] periodOffsetField;

        private SearchColumnDoubleField[] recurAmountField;

        private SearchColumnDoubleField[] recurFxAmountField;

        private SearchColumnDateField[] schedDateField;

        private SearchColumnStringField[] scheduleNumberField;

        private SearchColumnStringField[] sourceAcctField;

        private SearchColumnStringField[] srcDocLineField;

        private SearchColumnStringField[] srcTranField;

        private SearchColumnStringField[] srcTranPostPeriodField;

        private SearchColumnLongField[] startOffsetField;

        private SearchColumnBooleanField[] useForeignAmountsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnSelectField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorStatus")]
        public SearchColumnEnumSelectField[] amorStatus {
            get {
                return this.amorStatusField;
            }
            set {
                this.amorStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorTemplate")]
        public SearchColumnStringField[] amorTemplate {
            get {
                return this.amorTemplateField;
            }
            set {
                this.amorTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amortizedAmount")]
        public SearchColumnDoubleField[] amortizedAmount {
            get {
                return this.amortizedAmountField;
            }
            set {
                this.amortizedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amorType")]
        public SearchColumnEnumSelectField[] amorType {
            get {
                return this.amorTypeField;
            }
            set {
                this.amorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amount")]
        public SearchColumnDoubleField[] amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnStringField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferredAmount")]
        public SearchColumnDoubleField[] deferredAmount {
            get {
                return this.deferredAmountField;
            }
            set {
                this.deferredAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("destAcct")]
        public SearchColumnStringField[] destAcct {
            get {
                return this.destAcctField;
            }
            set {
                this.destAcctField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("initialAmt")]
        public SearchColumnDoubleField[] initialAmt {
            get {
                return this.initialAmtField;
            }
            set {
                this.initialAmtField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isRecognized")]
        public SearchColumnBooleanField[] isRecognized {
            get {
                return this.isRecognizedField;
            }
            set {
                this.isRecognizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jeDoc")]
        public SearchColumnStringField[] jeDoc {
            get {
                return this.jeDocField;
            }
            set {
                this.jeDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineSequenceNumber")]
        public SearchColumnLongField[] lineSequenceNumber {
            get {
                return this.lineSequenceNumberField;
            }
            set {
                this.lineSequenceNumberField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("nameUrl")]
        public SearchColumnStringField[] nameUrl {
            get {
                return this.nameUrlField;
            }
            set {
                this.nameUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pctComplete")]
        public SearchColumnDoubleField[] pctComplete {
            get {
                return this.pctCompleteField;
            }
            set {
                this.pctCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pctRecognition")]
        public SearchColumnDoubleField[] pctRecognition {
            get {
                return this.pctRecognitionField;
            }
            set {
                this.pctRecognitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodOffset")]
        public SearchColumnLongField[] periodOffset {
            get {
                return this.periodOffsetField;
            }
            set {
                this.periodOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurAmount")]
        public SearchColumnDoubleField[] recurAmount {
            get {
                return this.recurAmountField;
            }
            set {
                this.recurAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurFxAmount")]
        public SearchColumnDoubleField[] recurFxAmount {
            get {
                return this.recurFxAmountField;
            }
            set {
                this.recurFxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schedDate")]
        public SearchColumnDateField[] schedDate {
            get {
                return this.schedDateField;
            }
            set {
                this.schedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduleNumber")]
        public SearchColumnStringField[] scheduleNumber {
            get {
                return this.scheduleNumberField;
            }
            set {
                this.scheduleNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sourceAcct")]
        public SearchColumnStringField[] sourceAcct {
            get {
                return this.sourceAcctField;
            }
            set {
                this.sourceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("srcDocLine")]
        public SearchColumnStringField[] srcDocLine {
            get {
                return this.srcDocLineField;
            }
            set {
                this.srcDocLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("srcTran")]
        public SearchColumnStringField[] srcTran {
            get {
                return this.srcTranField;
            }
            set {
                this.srcTranField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("srcTranPostPeriod")]
        public SearchColumnStringField[] srcTranPostPeriod {
            get {
                return this.srcTranPostPeriodField;
            }
            set {
                this.srcTranPostPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startOffset")]
        public SearchColumnLongField[] startOffset {
            get {
                return this.startOffsetField;
            }
            set {
                this.startOffsetField = value;
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