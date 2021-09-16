namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class LocationSearchBasic : SearchRecordBasic {

        private SearchStringField addressField;

        private SearchBooleanField allowStorePickupField;

        private SearchEnumMultiSelectField autoAssignmentRegionSettingField;

        private SearchLongField bufferStockField;

        private SearchStringField cityField;

        private SearchEnumMultiSelectField countryField;

        private SearchStringField countyField;

        private SearchLongField dailyShippingCapacityField;

        private SearchDateField endTimeField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField geolocationMethodField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isFridayField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isIncludeInCtField;

        private SearchBooleanField isMondayField;

        private SearchBooleanField isOfficeField;

        private SearchBooleanField isSaturdayField;

        private SearchBooleanField isSundayField;

        private SearchBooleanField isThursdayField;

        private SearchBooleanField isTuesdayField;

        private SearchBooleanField isWednesdayField;

        private SearchDoubleField latitudeField;

        private SearchEnumMultiSelectField locationTypeField;

        private SearchDoubleField longitudeField;

        private SearchBooleanField makeInventoryAvailableField;

        private SearchBooleanField makeInventoryAvailableStoreField;

        private SearchStringField nameField;

        private SearchStringField nameNoHierarchyField;

        private SearchDateField nextPickupCutOffTimeField;

        private SearchStringField phoneField;

        private SearchDateField sameDayPickupCutOffTimeField;

        private SearchDoubleField soPredConfidenceField;

        private SearchLongField soPredictedDaysField;

        private SearchDateField startTimeField;

        private SearchStringField stateField;

        private SearchDoubleField storePickupBufferStockField;

        private SearchMultiSelectField subsidiaryField;

        private SearchEnumMultiSelectField timeZoneField;

        private SearchLongField totalShippingCapacityField;

        private SearchStringField tranprefixField;

        private SearchBooleanField usesBinsField;

        private SearchStringField zipField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchStringField address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allowStorePickup {
            get {
                return this.allowStorePickupField;
            }
            set {
                this.allowStorePickupField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField autoAssignmentRegionSetting {
            get {
                return this.autoAssignmentRegionSettingField;
            }
            set {
                this.autoAssignmentRegionSettingField = value;
            }
        }

        /// <remarks/>
        public SearchLongField bufferStock {
            get {
                return this.bufferStockField;
            }
            set {
                this.bufferStockField = value;
            }
        }

        /// <remarks/>
        public SearchStringField city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public SearchLongField dailyShippingCapacity {
            get {
                return this.dailyShippingCapacityField;
            }
            set {
                this.dailyShippingCapacityField = value;
            }
        }

        /// <remarks/>
        public SearchDateField endTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField geolocationMethod {
            get {
                return this.geolocationMethodField;
            }
            set {
                this.geolocationMethodField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isFriday {
            get {
                return this.isFridayField;
            }
            set {
                this.isFridayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isIncludeInCt {
            get {
                return this.isIncludeInCtField;
            }
            set {
                this.isIncludeInCtField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isMonday {
            get {
                return this.isMondayField;
            }
            set {
                this.isMondayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isOffice {
            get {
                return this.isOfficeField;
            }
            set {
                this.isOfficeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSaturday {
            get {
                return this.isSaturdayField;
            }
            set {
                this.isSaturdayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSunday {
            get {
                return this.isSundayField;
            }
            set {
                this.isSundayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isThursday {
            get {
                return this.isThursdayField;
            }
            set {
                this.isThursdayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isTuesday {
            get {
                return this.isTuesdayField;
            }
            set {
                this.isTuesdayField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isWednesday {
            get {
                return this.isWednesdayField;
            }
            set {
                this.isWednesdayField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationType {
            get {
                return this.locationTypeField;
            }
            set {
                this.locationTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField makeInventoryAvailable {
            get {
                return this.makeInventoryAvailableField;
            }
            set {
                this.makeInventoryAvailableField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField makeInventoryAvailableStore {
            get {
                return this.makeInventoryAvailableStoreField;
            }
            set {
                this.makeInventoryAvailableStoreField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField nameNoHierarchy {
            get {
                return this.nameNoHierarchyField;
            }
            set {
                this.nameNoHierarchyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField nextPickupCutOffTime {
            get {
                return this.nextPickupCutOffTimeField;
            }
            set {
                this.nextPickupCutOffTimeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public SearchDateField sameDayPickupCutOffTime {
            get {
                return this.sameDayPickupCutOffTimeField;
            }
            set {
                this.sameDayPickupCutOffTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField soPredConfidence {
            get {
                return this.soPredConfidenceField;
            }
            set {
                this.soPredConfidenceField = value;
            }
        }

        /// <remarks/>
        public SearchLongField soPredictedDays {
            get {
                return this.soPredictedDaysField;
            }
            set {
                this.soPredictedDaysField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField storePickupBufferStock {
            get {
                return this.storePickupBufferStockField;
            }
            set {
                this.storePickupBufferStockField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField timeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public SearchLongField totalShippingCapacity {
            get {
                return this.totalShippingCapacityField;
            }
            set {
                this.totalShippingCapacityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField tranprefix {
            get {
                return this.tranprefixField;
            }
            set {
                this.tranprefixField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField usesBins {
            get {
                return this.usesBinsField;
            }
            set {
                this.usesBinsField = value;
            }
        }

        /// <remarks/>
        public SearchStringField zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}