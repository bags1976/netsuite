using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class InventoryItemLocations {

        private string locationField;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double onHandValueMliField;

        private bool onHandValueMliFieldSpecified;

        private double averageCostMliField;

        private bool averageCostMliFieldSpecified;

        private double lastPurchasePriceMliField;

        private bool lastPurchasePriceMliFieldSpecified;

        private double reorderPointField;

        private bool reorderPointFieldSpecified;

        private bool locationAllowStorePickupField;

        private bool locationAllowStorePickupFieldSpecified;

        private double locationStorePickupBufferStockField;

        private bool locationStorePickupBufferStockFieldSpecified;

        private double locationQtyAvailForStorePickupField;

        private bool locationQtyAvailForStorePickupFieldSpecified;

        private double preferredStockLevelField;

        private bool preferredStockLevelFieldSpecified;

        private long leadTimeField;

        private bool leadTimeFieldSpecified;

        private double defaultReturnCostField;

        private bool defaultReturnCostFieldSpecified;

        private double safetyStockLevelField;

        private bool safetyStockLevelFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private RecordRef inventoryCostTemplateField;

        private double buildTimeField;

        private bool buildTimeFieldSpecified;

        private double fixedBuildTimeField;

        private bool fixedBuildTimeFieldSpecified;

        private double buildTimeLotSizeField;

        private bool buildTimeLotSizeFieldSpecified;

        private System.DateTime lastInvtCountDateField;

        private bool lastInvtCountDateFieldSpecified;

        private System.DateTime nextInvtCountDateField;

        private bool nextInvtCountDateFieldSpecified;

        private bool isWipField;

        private bool isWipFieldSpecified;

        private long invtCountIntervalField;

        private bool invtCountIntervalFieldSpecified;

        private ItemInvtClassification invtClassificationField;

        private bool invtClassificationFieldSpecified;

        private double costingLotSizeField;

        private bool costingLotSizeFieldSpecified;

        private double quantityOnOrderField;

        private bool quantityOnOrderFieldSpecified;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private RecordRef locationIdField;

        private RecordRef supplyReplenishmentMethodField;

        private RecordRef alternateDemandSourceItemField;

        private double fixedLotSizeField;

        private bool fixedLotSizeFieldSpecified;

        private PeriodicLotSizeType periodicLotSizeTypeField;

        private bool periodicLotSizeTypeFieldSpecified;

        private long periodicLotSizeDaysField;

        private bool periodicLotSizeDaysFieldSpecified;

        private RecordRef supplyTypeField;

        private RecordRef supplyLotSizingMethodField;

        private RecordRef demandSourceField;

        private long backwardConsumptionDaysField;

        private bool backwardConsumptionDaysFieldSpecified;

        private long forwardConsumptionDaysField;

        private bool forwardConsumptionDaysFieldSpecified;

        private long demandTimeFenceField;

        private bool demandTimeFenceFieldSpecified;

        private long supplyTimeFenceField;

        private bool supplyTimeFenceFieldSpecified;

        private long rescheduleInDaysField;

        private bool rescheduleInDaysFieldSpecified;

        private long rescheduleOutDaysField;

        private bool rescheduleOutDaysFieldSpecified;

        /// <remarks/>
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public double averageCostMli {
            get {
                return this.averageCostMliField;
            }
            set {
                this.averageCostMliField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageCostMliSpecified {
            get {
                return this.averageCostMliFieldSpecified;
            }
            set {
                this.averageCostMliFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double lastPurchasePriceMli {
            get {
                return this.lastPurchasePriceMliField;
            }
            set {
                this.lastPurchasePriceMliField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastPurchasePriceMliSpecified {
            get {
                return this.lastPurchasePriceMliFieldSpecified;
            }
            set {
                this.lastPurchasePriceMliFieldSpecified = value;
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
        public bool locationAllowStorePickup {
            get {
                return this.locationAllowStorePickupField;
            }
            set {
                this.locationAllowStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationAllowStorePickupSpecified {
            get {
                return this.locationAllowStorePickupFieldSpecified;
            }
            set {
                this.locationAllowStorePickupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double locationStorePickupBufferStock {
            get {
                return this.locationStorePickupBufferStockField;
            }
            set {
                this.locationStorePickupBufferStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationStorePickupBufferStockSpecified {
            get {
                return this.locationStorePickupBufferStockFieldSpecified;
            }
            set {
                this.locationStorePickupBufferStockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double locationQtyAvailForStorePickup {
            get {
                return this.locationQtyAvailForStorePickupField;
            }
            set {
                this.locationQtyAvailForStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationQtyAvailForStorePickupSpecified {
            get {
                return this.locationQtyAvailForStorePickupFieldSpecified;
            }
            set {
                this.locationQtyAvailForStorePickupFieldSpecified = value;
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
        public long leadTime {
            get {
                return this.leadTimeField;
            }
            set {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leadTimeSpecified {
            get {
                return this.leadTimeFieldSpecified;
            }
            set {
                this.leadTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double defaultReturnCost {
            get {
                return this.defaultReturnCostField;
            }
            set {
                this.defaultReturnCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultReturnCostSpecified {
            get {
                return this.defaultReturnCostFieldSpecified;
            }
            set {
                this.defaultReturnCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double safetyStockLevel {
            get {
                return this.safetyStockLevelField;
            }
            set {
                this.safetyStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool safetyStockLevelSpecified {
            get {
                return this.safetyStockLevelFieldSpecified;
            }
            set {
                this.safetyStockLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef inventoryCostTemplate {
            get {
                return this.inventoryCostTemplateField;
            }
            set {
                this.inventoryCostTemplateField = value;
            }
        }

        /// <remarks/>
        public double buildTime {
            get {
                return this.buildTimeField;
            }
            set {
                this.buildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildTimeSpecified {
            get {
                return this.buildTimeFieldSpecified;
            }
            set {
                this.buildTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double fixedBuildTime {
            get {
                return this.fixedBuildTimeField;
            }
            set {
                this.fixedBuildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedBuildTimeSpecified {
            get {
                return this.fixedBuildTimeFieldSpecified;
            }
            set {
                this.fixedBuildTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double buildTimeLotSize {
            get {
                return this.buildTimeLotSizeField;
            }
            set {
                this.buildTimeLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildTimeLotSizeSpecified {
            get {
                return this.buildTimeLotSizeFieldSpecified;
            }
            set {
                this.buildTimeLotSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastInvtCountDate {
            get {
                return this.lastInvtCountDateField;
            }
            set {
                this.lastInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastInvtCountDateSpecified {
            get {
                return this.lastInvtCountDateFieldSpecified;
            }
            set {
                this.lastInvtCountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextInvtCountDate {
            get {
                return this.nextInvtCountDateField;
            }
            set {
                this.nextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextInvtCountDateSpecified {
            get {
                return this.nextInvtCountDateFieldSpecified;
            }
            set {
                this.nextInvtCountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWip {
            get {
                return this.isWipField;
            }
            set {
                this.isWipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWipSpecified {
            get {
                return this.isWipFieldSpecified;
            }
            set {
                this.isWipFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long invtCountInterval {
            get {
                return this.invtCountIntervalField;
            }
            set {
                this.invtCountIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invtCountIntervalSpecified {
            get {
                return this.invtCountIntervalFieldSpecified;
            }
            set {
                this.invtCountIntervalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemInvtClassification invtClassification {
            get {
                return this.invtClassificationField;
            }
            set {
                this.invtClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invtClassificationSpecified {
            get {
                return this.invtClassificationFieldSpecified;
            }
            set {
                this.invtClassificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double costingLotSize {
            get {
                return this.costingLotSizeField;
            }
            set {
                this.costingLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costingLotSizeSpecified {
            get {
                return this.costingLotSizeFieldSpecified;
            }
            set {
                this.costingLotSizeFieldSpecified = value;
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
        public RecordRef locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyReplenishmentMethod {
            get {
                return this.supplyReplenishmentMethodField;
            }
            set {
                this.supplyReplenishmentMethodField = value;
            }
        }

        /// <remarks/>
        public RecordRef alternateDemandSourceItem {
            get {
                return this.alternateDemandSourceItemField;
            }
            set {
                this.alternateDemandSourceItemField = value;
            }
        }

        /// <remarks/>
        public double fixedLotSize {
            get {
                return this.fixedLotSizeField;
            }
            set {
                this.fixedLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedLotSizeSpecified {
            get {
                return this.fixedLotSizeFieldSpecified;
            }
            set {
                this.fixedLotSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PeriodicLotSizeType periodicLotSizeType {
            get {
                return this.periodicLotSizeTypeField;
            }
            set {
                this.periodicLotSizeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodicLotSizeTypeSpecified {
            get {
                return this.periodicLotSizeTypeFieldSpecified;
            }
            set {
                this.periodicLotSizeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long periodicLotSizeDays {
            get {
                return this.periodicLotSizeDaysField;
            }
            set {
                this.periodicLotSizeDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodicLotSizeDaysSpecified {
            get {
                return this.periodicLotSizeDaysFieldSpecified;
            }
            set {
                this.periodicLotSizeDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyType {
            get {
                return this.supplyTypeField;
            }
            set {
                this.supplyTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyLotSizingMethod {
            get {
                return this.supplyLotSizingMethodField;
            }
            set {
                this.supplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        public RecordRef demandSource {
            get {
                return this.demandSourceField;
            }
            set {
                this.demandSourceField = value;
            }
        }

        /// <remarks/>
        public long backwardConsumptionDays {
            get {
                return this.backwardConsumptionDaysField;
            }
            set {
                this.backwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool backwardConsumptionDaysSpecified {
            get {
                return this.backwardConsumptionDaysFieldSpecified;
            }
            set {
                this.backwardConsumptionDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long forwardConsumptionDays {
            get {
                return this.forwardConsumptionDaysField;
            }
            set {
                this.forwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forwardConsumptionDaysSpecified {
            get {
                return this.forwardConsumptionDaysFieldSpecified;
            }
            set {
                this.forwardConsumptionDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long demandTimeFence {
            get {
                return this.demandTimeFenceField;
            }
            set {
                this.demandTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool demandTimeFenceSpecified {
            get {
                return this.demandTimeFenceFieldSpecified;
            }
            set {
                this.demandTimeFenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long supplyTimeFence {
            get {
                return this.supplyTimeFenceField;
            }
            set {
                this.supplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool supplyTimeFenceSpecified {
            get {
                return this.supplyTimeFenceFieldSpecified;
            }
            set {
                this.supplyTimeFenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long rescheduleInDays {
            get {
                return this.rescheduleInDaysField;
            }
            set {
                this.rescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rescheduleInDaysSpecified {
            get {
                return this.rescheduleInDaysFieldSpecified;
            }
            set {
                this.rescheduleInDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long rescheduleOutDays {
            get {
                return this.rescheduleOutDaysField;
            }
            set {
                this.rescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rescheduleOutDaysSpecified {
            get {
                return this.rescheduleOutDaysFieldSpecified;
            }
            set {
                this.rescheduleOutDaysFieldSpecified = value;
            }
        }
    }
}