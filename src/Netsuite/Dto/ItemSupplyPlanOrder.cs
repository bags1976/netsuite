using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:demandplanning_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemSupplyPlanOrder {

        private long orderLineIdField;

        private bool orderLineIdFieldSpecified;

        private System.DateTime orderDateField;

        private bool orderDateFieldSpecified;

        private System.DateTime receiptDateField;

        private bool receiptDateFieldSpecified;

        private RecordRef sourceLocationField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private bool orderCreatedField;

        private bool orderCreatedFieldSpecified;

        private ItemSupplyPlanOrderType orderTypeField;

        private bool orderTypeFieldSpecified;

        /// <remarks/>
        public long orderLineId {
            get {
                return this.orderLineIdField;
            }
            set {
                this.orderLineIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderLineIdSpecified {
            get {
                return this.orderLineIdFieldSpecified;
            }
            set {
                this.orderLineIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime orderDate {
            get {
                return this.orderDateField;
            }
            set {
                this.orderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderDateSpecified {
            get {
                return this.orderDateFieldSpecified;
            }
            set {
                this.orderDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime receiptDate {
            get {
                return this.receiptDateField;
            }
            set {
                this.receiptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptDateSpecified {
            get {
                return this.receiptDateFieldSpecified;
            }
            set {
                this.receiptDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceLocation {
            get {
                return this.sourceLocationField;
            }
            set {
                this.sourceLocationField = value;
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
        public bool orderCreated {
            get {
                return this.orderCreatedField;
            }
            set {
                this.orderCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderCreatedSpecified {
            get {
                return this.orderCreatedFieldSpecified;
            }
            set {
                this.orderCreatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSupplyPlanOrderType orderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderTypeSpecified {
            get {
                return this.orderTypeFieldSpecified;
            }
            set {
                this.orderTypeFieldSpecified = value;
            }
        }
    }
}