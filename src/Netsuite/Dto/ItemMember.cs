namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemMember {

        private string memberDescrField;

        private double componentYieldField;

        private bool componentYieldFieldSpecified;

        private double bomQuantityField;

        private bool bomQuantityFieldSpecified;

        private ItemSource itemSourceField;

        private bool itemSourceFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef memberUnitField;

        private VsoeDeferral vsoeDeferralField;

        private bool vsoeDeferralFieldSpecified;

        private VsoePermitDiscount vsoePermitDiscountField;

        private bool vsoePermitDiscountFieldSpecified;

        private bool vsoeDeliveredField;

        private bool vsoeDeliveredFieldSpecified;

        private RecordRef taxScheduleField;

        private string taxcodeField;

        private RecordRef itemField;

        private double taxrateField;

        private bool taxrateFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime obsoleteDateField;

        private bool obsoleteDateFieldSpecified;

        private RecordRef effectiveRevisionField;

        private RecordRef obsoleteRevisionField;

        private long lineNumberField;

        private bool lineNumberFieldSpecified;

        private string memberKeyField;

        /// <remarks/>
        public string memberDescr {
            get {
                return this.memberDescrField;
            }
            set {
                this.memberDescrField = value;
            }
        }

        /// <remarks/>
        public double componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool componentYieldSpecified {
            get {
                return this.componentYieldFieldSpecified;
            }
            set {
                this.componentYieldFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bomQuantitySpecified {
            get {
                return this.bomQuantityFieldSpecified;
            }
            set {
                this.bomQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSource itemSource {
            get {
                return this.itemSourceField;
            }
            set {
                this.itemSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemSourceSpecified {
            get {
                return this.itemSourceFieldSpecified;
            }
            set {
                this.itemSourceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef memberUnit {
            get {
                return this.memberUnitField;
            }
            set {
                this.memberUnitField = value;
            }
        }

        /// <remarks/>
        public VsoeDeferral vsoeDeferral {
            get {
                return this.vsoeDeferralField;
            }
            set {
                this.vsoeDeferralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeferralSpecified {
            get {
                return this.vsoeDeferralFieldSpecified;
            }
            set {
                this.vsoeDeferralFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoePermitDiscount vsoePermitDiscount {
            get {
                return this.vsoePermitDiscountField;
            }
            set {
                this.vsoePermitDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoePermitDiscountSpecified {
            get {
                return this.vsoePermitDiscountFieldSpecified;
            }
            set {
                this.vsoePermitDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool vsoeDelivered {
            get {
                return this.vsoeDeliveredField;
            }
            set {
                this.vsoeDeliveredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeliveredSpecified {
            get {
                return this.vsoeDeliveredFieldSpecified;
            }
            set {
                this.vsoeDeliveredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxSchedule {
            get {
                return this.taxScheduleField;
            }
            set {
                this.taxScheduleField = value;
            }
        }

        /// <remarks/>
        public string taxcode {
            get {
                return this.taxcodeField;
            }
            set {
                this.taxcodeField = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public double taxrate {
            get {
                return this.taxrateField;
            }
            set {
                this.taxrateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxrateSpecified {
            get {
                return this.taxrateFieldSpecified;
            }
            set {
                this.taxrateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime obsoleteDate {
            get {
                return this.obsoleteDateField;
            }
            set {
                this.obsoleteDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool obsoleteDateSpecified {
            get {
                return this.obsoleteDateFieldSpecified;
            }
            set {
                this.obsoleteDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef effectiveRevision {
            get {
                return this.effectiveRevisionField;
            }
            set {
                this.effectiveRevisionField = value;
            }
        }

        /// <remarks/>
        public RecordRef obsoleteRevision {
            get {
                return this.obsoleteRevisionField;
            }
            set {
                this.obsoleteRevisionField = value;
            }
        }

        /// <remarks/>
        public long lineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineNumberSpecified {
            get {
                return this.lineNumberFieldSpecified;
            }
            set {
                this.lineNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memberKey {
            get {
                return this.memberKeyField;
            }
            set {
                this.memberKeyField = value;
            }
        }
    }
}