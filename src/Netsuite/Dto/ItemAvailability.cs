namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemAvailability {

        private RecordRef itemField;

        private System.DateTime lastQtyAvailableChangeField;

        private bool lastQtyAvailableChangeFieldSpecified;

        private RecordRef locationIdField;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double onHandValueMliField;

        private bool onHandValueMliFieldSpecified;

        private double reorderPointField;

        private bool reorderPointFieldSpecified;

        private double preferredStockLevelField;

        private bool preferredStockLevelFieldSpecified;

        private double quantityOnOrderField;

        private bool quantityOnOrderFieldSpecified;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

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
        public System.DateTime lastQtyAvailableChange {
            get {
                return this.lastQtyAvailableChangeField;
            }
            set {
                this.lastQtyAvailableChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastQtyAvailableChangeSpecified {
            get {
                return this.lastQtyAvailableChangeFieldSpecified;
            }
            set {
                this.lastQtyAvailableChangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double onHandValueMli {
            get {
                return this.onHandValueMliField;
            }
            set {
                this.onHandValueMliField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onHandValueMliSpecified {
            get {
                return this.onHandValueMliFieldSpecified;
            }
            set {
                this.onHandValueMliFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double reorderPoint {
            get {
                return this.reorderPointField;
            }
            set {
                this.reorderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reorderPointSpecified {
            get {
                return this.reorderPointFieldSpecified;
            }
            set {
                this.reorderPointFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double preferredStockLevel {
            get {
                return this.preferredStockLevelField;
            }
            set {
                this.preferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredStockLevelSpecified {
            get {
                return this.preferredStockLevelFieldSpecified;
            }
            set {
                this.preferredStockLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnOrder {
            get {
                return this.quantityOnOrderField;
            }
            set {
                this.quantityOnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnOrderSpecified {
            get {
                return this.quantityOnOrderFieldSpecified;
            }
            set {
                this.quantityOnOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityCommittedSpecified {
            get {
                return this.quantityCommittedFieldSpecified;
            }
            set {
                this.quantityCommittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityBackOrderedSpecified {
            get {
                return this.quantityBackOrderedFieldSpecified;
            }
            set {
                this.quantityBackOrderedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }
    }
}