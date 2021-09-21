using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class InboundShipment : Record {

        private RecordRef customFormField;

        private string shipmentNumberField;

        private string externalDocumentNumberField;

        private InboundShipmentShipmentStatus shipmentStatusField;

        private bool shipmentStatusFieldSpecified;

        private System.DateTime expectedShippingDateField;

        private bool expectedShippingDateFieldSpecified;

        private System.DateTime actualShippingDateField;

        private bool actualShippingDateFieldSpecified;

        private System.DateTime expectedDeliveryDateField;

        private bool expectedDeliveryDateFieldSpecified;

        private System.DateTime actualDeliveryDateField;

        private bool actualDeliveryDateFieldSpecified;

        private string shipmentMemoField;

        private string vesselNumberField;

        private string billOfLadingField;

        private InboundShipmentLandedCostList landedCostListField;

        private InboundShipmentItemsList itemsListField;

        private RecordRef shipmentBaseCurrencyField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public string shipmentNumber {
            get {
                return this.shipmentNumberField;
            }
            set {
                this.shipmentNumberField = value;
            }
        }

        /// <remarks/>
        public string externalDocumentNumber {
            get {
                return this.externalDocumentNumberField;
            }
            set {
                this.externalDocumentNumberField = value;
            }
        }

        /// <remarks/>
        public InboundShipmentShipmentStatus shipmentStatus {
            get {
                return this.shipmentStatusField;
            }
            set {
                this.shipmentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentStatusSpecified {
            get {
                return this.shipmentStatusFieldSpecified;
            }
            set {
                this.shipmentStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedShippingDate {
            get {
                return this.expectedShippingDateField;
            }
            set {
                this.expectedShippingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedShippingDateSpecified {
            get {
                return this.expectedShippingDateFieldSpecified;
            }
            set {
                this.expectedShippingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime actualShippingDate {
            get {
                return this.actualShippingDateField;
            }
            set {
                this.actualShippingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualShippingDateSpecified {
            get {
                return this.actualShippingDateFieldSpecified;
            }
            set {
                this.actualShippingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedDeliveryDate {
            get {
                return this.expectedDeliveryDateField;
            }
            set {
                this.expectedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedDeliveryDateSpecified {
            get {
                return this.expectedDeliveryDateFieldSpecified;
            }
            set {
                this.expectedDeliveryDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime actualDeliveryDate {
            get {
                return this.actualDeliveryDateField;
            }
            set {
                this.actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualDeliveryDateSpecified {
            get {
                return this.actualDeliveryDateFieldSpecified;
            }
            set {
                this.actualDeliveryDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string shipmentMemo {
            get {
                return this.shipmentMemoField;
            }
            set {
                this.shipmentMemoField = value;
            }
        }

        /// <remarks/>
        public string vesselNumber {
            get {
                return this.vesselNumberField;
            }
            set {
                this.vesselNumberField = value;
            }
        }

        /// <remarks/>
        public string billOfLading {
            get {
                return this.billOfLadingField;
            }
            set {
                this.billOfLadingField = value;
            }
        }

        /// <remarks/>
        public InboundShipmentLandedCostList landedCostList {
            get {
                return this.landedCostListField;
            }
            set {
                this.landedCostListField = value;
            }
        }

        /// <remarks/>
        public InboundShipmentItemsList itemsList {
            get {
                return this.itemsListField;
            }
            set {
                this.itemsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipmentBaseCurrency {
            get {
                return this.shipmentBaseCurrencyField;
            }
            set {
                this.shipmentBaseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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