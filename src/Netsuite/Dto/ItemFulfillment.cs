namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemFulfillment : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private RecordRef postingPeriodField;

        private RecordRef entityField;

        private RecordRef createdFromField;

        private RecordRef requestedByField;

        private long createdFromShipGroupField;

        private bool createdFromShipGroupFieldSpecified;

        private RecordRef partnerField;

        private Address shippingAddressField;

        private System.DateTime pickedDateField;

        private bool pickedDateFieldSpecified;

        private System.DateTime packedDateField;

        private bool packedDateFieldSpecified;

        private System.DateTime shippedDateField;

        private bool shippedDateFieldSpecified;

        private bool shipIsResidentialField;

        private bool shipIsResidentialFieldSpecified;

        private RecordRef shipAddressListField;

        private ItemFulfillmentShipStatus shipStatusField;

        private bool shipStatusFieldSpecified;

        private bool saturdayDeliveryUpsField;

        private bool saturdayDeliveryUpsFieldSpecified;

        private bool sendShipNotifyEmailUpsField;

        private bool sendShipNotifyEmailUpsFieldSpecified;

        private bool sendBackupEmailUpsField;

        private bool sendBackupEmailUpsFieldSpecified;

        private string shipNotifyEmailAddressUpsField;

        private string shipNotifyEmailAddress2UpsField;

        private string backupEmailAddressUpsField;

        private string shipNotifyEmailMessageUpsField;

        private string thirdPartyAcctUpsField;

        private string thirdPartyZipcodeUpsField;

        private Country thirdPartyCountryUpsField;

        private bool thirdPartyCountryUpsFieldSpecified;

        private ItemFulfillmentThirdPartyTypeUps thirdPartyTypeUpsField;

        private bool thirdPartyTypeUpsFieldSpecified;

        private bool partiesToTransactionUpsField;

        private bool partiesToTransactionUpsFieldSpecified;

        private ItemFulfillmentExportTypeUps exportTypeUpsField;

        private bool exportTypeUpsFieldSpecified;

        private ItemFulfillmentMethodOfTransportUps methodOfTransportUpsField;

        private bool methodOfTransportUpsFieldSpecified;

        private string carrierIdUpsField;

        private string entryNumberUpsField;

        private string inbondCodeUpsField;

        private bool isRoutedExportTransactionUpsField;

        private bool isRoutedExportTransactionUpsFieldSpecified;

        private string licenseNumberUpsField;

        private System.DateTime licenseDateUpsField;

        private bool licenseDateUpsFieldSpecified;

        private ItemFulfillmentLicenseExceptionUps licenseExceptionUpsField;

        private bool licenseExceptionUpsFieldSpecified;

        private string eccNumberUpsField;

        private string recipientTaxIdUpsField;

        private System.DateTime blanketStartDateUpsField;

        private bool blanketStartDateUpsFieldSpecified;

        private System.DateTime blanketEndDateUpsField;

        private bool blanketEndDateUpsFieldSpecified;

        private double shipmentWeightUpsField;

        private bool shipmentWeightUpsFieldSpecified;

        private bool saturdayDeliveryFedExField;

        private bool saturdayDeliveryFedExFieldSpecified;

        private bool saturdayPickupFedexField;

        private bool saturdayPickupFedexFieldSpecified;

        private bool sendShipNotifyEmailFedExField;

        private bool sendShipNotifyEmailFedExFieldSpecified;

        private bool sendBackupEmailFedExField;

        private bool sendBackupEmailFedExFieldSpecified;

        private bool signatureHomeDeliveryFedExField;

        private bool signatureHomeDeliveryFedExFieldSpecified;

        private string shipNotifyEmailAddressFedExField;

        private string backupEmailAddressFedExField;

        private System.DateTime shipDateFedExField;

        private bool shipDateFedExFieldSpecified;

        private ItemFulfillmentHomeDeliveryTypeFedEx homeDeliveryTypeFedExField;

        private bool homeDeliveryTypeFedExFieldSpecified;

        private System.DateTime homeDeliveryDateFedExField;

        private bool homeDeliveryDateFedExFieldSpecified;

        private string bookingConfirmationNumFedExField;

        private string intlExemptionNumFedExField;

        private ItemFulfillmentB13AFilingOptionFedEx b13aFilingOptionFedExField;

        private bool b13aFilingOptionFedExFieldSpecified;

        private string b13aStatementDataFedExField;

        private string thirdPartyAcctFedExField;

        private Country thirdPartyCountryFedExField;

        private bool thirdPartyCountryFedExFieldSpecified;

        private ItemFulfillmentThirdPartyTypeFedEx thirdPartyTypeFedExField;

        private bool thirdPartyTypeFedExFieldSpecified;

        private double shipmentWeightFedExField;

        private bool shipmentWeightFedExFieldSpecified;

        private ItemFulfillmentTermsOfSaleFedEx termsOfSaleFedExField;

        private bool termsOfSaleFedExFieldSpecified;

        private double termsFreightChargeFedExField;

        private bool termsFreightChargeFedExFieldSpecified;

        private double termsInsuranceChargeFedExField;

        private bool termsInsuranceChargeFedExFieldSpecified;

        private bool insideDeliveryFedExField;

        private bool insideDeliveryFedExFieldSpecified;

        private bool insidePickupFedExField;

        private bool insidePickupFedExFieldSpecified;

        private ItemFulfillmentAncillaryEndorsementFedEx ancillaryEndorsementFedExField;

        private bool ancillaryEndorsementFedExFieldSpecified;

        private bool holdAtLocationFedExField;

        private bool holdAtLocationFedExFieldSpecified;

        private string halPhoneFedExField;

        private string halAddr1FedExField;

        private string halAddr2FedExField;

        private string halAddr3FedExField;

        private string halCityFedExField;

        private string halZipFedExField;

        private string halStateFedExField;

        private string halCountryFedExField;

        private ItemFulfillmentHazmatTypeFedEx hazmatTypeFedExField;

        private bool hazmatTypeFedExFieldSpecified;

        private ItemFulfillmentAccessibilityTypeFedEx accessibilityTypeFedExField;

        private bool accessibilityTypeFedExFieldSpecified;

        private bool isCargoAircraftOnlyFedExField;

        private bool isCargoAircraftOnlyFedExFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef shipMethodField;

        private bool generateIntegratedShipperLabelField;

        private bool generateIntegratedShipperLabelFieldSpecified;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private string memoField;

        private RecordRef transferLocationField;

        private ItemFulfillmentPackageList packageListField;

        private ItemFulfillmentPackageUpsList packageUpsListField;

        private ItemFulfillmentPackageUspsList packageUspsListField;

        private ItemFulfillmentPackageFedExList packageFedExListField;

        private ItemFulfillmentItemList itemListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

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
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
            }
        }

        /// <remarks/>
        public RecordRef requestedBy {
            get {
                return this.requestedByField;
            }
            set {
                this.requestedByField = value;
            }
        }

        /// <remarks/>
        public long createdFromShipGroup {
            get {
                return this.createdFromShipGroupField;
            }
            set {
                this.createdFromShipGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdFromShipGroupSpecified {
            get {
                return this.createdFromShipGroupFieldSpecified;
            }
            set {
                this.createdFromShipGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        public Address shippingAddress {
            get {
                return this.shippingAddressField;
            }
            set {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        public System.DateTime pickedDate {
            get {
                return this.pickedDateField;
            }
            set {
                this.pickedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pickedDateSpecified {
            get {
                return this.pickedDateFieldSpecified;
            }
            set {
                this.pickedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime packedDate {
            get {
                return this.packedDateField;
            }
            set {
                this.packedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool packedDateSpecified {
            get {
                return this.packedDateFieldSpecified;
            }
            set {
                this.packedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime shippedDate {
            get {
                return this.shippedDateField;
            }
            set {
                this.shippedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippedDateSpecified {
            get {
                return this.shippedDateFieldSpecified;
            }
            set {
                this.shippedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool shipIsResidential {
            get {
                return this.shipIsResidentialField;
            }
            set {
                this.shipIsResidentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipIsResidentialSpecified {
            get {
                return this.shipIsResidentialFieldSpecified;
            }
            set {
                this.shipIsResidentialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shipAddressList {
            get {
                return this.shipAddressListField;
            }
            set {
                this.shipAddressListField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentShipStatus shipStatus {
            get {
                return this.shipStatusField;
            }
            set {
                this.shipStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipStatusSpecified {
            get {
                return this.shipStatusFieldSpecified;
            }
            set {
                this.shipStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool saturdayDeliveryUps {
            get {
                return this.saturdayDeliveryUpsField;
            }
            set {
                this.saturdayDeliveryUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saturdayDeliveryUpsSpecified {
            get {
                return this.saturdayDeliveryUpsFieldSpecified;
            }
            set {
                this.saturdayDeliveryUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sendShipNotifyEmailUps {
            get {
                return this.sendShipNotifyEmailUpsField;
            }
            set {
                this.sendShipNotifyEmailUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendShipNotifyEmailUpsSpecified {
            get {
                return this.sendShipNotifyEmailUpsFieldSpecified;
            }
            set {
                this.sendShipNotifyEmailUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sendBackupEmailUps {
            get {
                return this.sendBackupEmailUpsField;
            }
            set {
                this.sendBackupEmailUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendBackupEmailUpsSpecified {
            get {
                return this.sendBackupEmailUpsFieldSpecified;
            }
            set {
                this.sendBackupEmailUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string shipNotifyEmailAddressUps {
            get {
                return this.shipNotifyEmailAddressUpsField;
            }
            set {
                this.shipNotifyEmailAddressUpsField = value;
            }
        }

        /// <remarks/>
        public string shipNotifyEmailAddress2Ups {
            get {
                return this.shipNotifyEmailAddress2UpsField;
            }
            set {
                this.shipNotifyEmailAddress2UpsField = value;
            }
        }

        /// <remarks/>
        public string backupEmailAddressUps {
            get {
                return this.backupEmailAddressUpsField;
            }
            set {
                this.backupEmailAddressUpsField = value;
            }
        }

        /// <remarks/>
        public string shipNotifyEmailMessageUps {
            get {
                return this.shipNotifyEmailMessageUpsField;
            }
            set {
                this.shipNotifyEmailMessageUpsField = value;
            }
        }

        /// <remarks/>
        public string thirdPartyAcctUps {
            get {
                return this.thirdPartyAcctUpsField;
            }
            set {
                this.thirdPartyAcctUpsField = value;
            }
        }

        /// <remarks/>
        public string thirdPartyZipcodeUps {
            get {
                return this.thirdPartyZipcodeUpsField;
            }
            set {
                this.thirdPartyZipcodeUpsField = value;
            }
        }

        /// <remarks/>
        public Country thirdPartyCountryUps {
            get {
                return this.thirdPartyCountryUpsField;
            }
            set {
                this.thirdPartyCountryUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyCountryUpsSpecified {
            get {
                return this.thirdPartyCountryUpsFieldSpecified;
            }
            set {
                this.thirdPartyCountryUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentThirdPartyTypeUps thirdPartyTypeUps {
            get {
                return this.thirdPartyTypeUpsField;
            }
            set {
                this.thirdPartyTypeUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyTypeUpsSpecified {
            get {
                return this.thirdPartyTypeUpsFieldSpecified;
            }
            set {
                this.thirdPartyTypeUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool partiesToTransactionUps {
            get {
                return this.partiesToTransactionUpsField;
            }
            set {
                this.partiesToTransactionUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool partiesToTransactionUpsSpecified {
            get {
                return this.partiesToTransactionUpsFieldSpecified;
            }
            set {
                this.partiesToTransactionUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentExportTypeUps exportTypeUps {
            get {
                return this.exportTypeUpsField;
            }
            set {
                this.exportTypeUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exportTypeUpsSpecified {
            get {
                return this.exportTypeUpsFieldSpecified;
            }
            set {
                this.exportTypeUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentMethodOfTransportUps methodOfTransportUps {
            get {
                return this.methodOfTransportUpsField;
            }
            set {
                this.methodOfTransportUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool methodOfTransportUpsSpecified {
            get {
                return this.methodOfTransportUpsFieldSpecified;
            }
            set {
                this.methodOfTransportUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string carrierIdUps {
            get {
                return this.carrierIdUpsField;
            }
            set {
                this.carrierIdUpsField = value;
            }
        }

        /// <remarks/>
        public string entryNumberUps {
            get {
                return this.entryNumberUpsField;
            }
            set {
                this.entryNumberUpsField = value;
            }
        }

        /// <remarks/>
        public string inbondCodeUps {
            get {
                return this.inbondCodeUpsField;
            }
            set {
                this.inbondCodeUpsField = value;
            }
        }

        /// <remarks/>
        public bool isRoutedExportTransactionUps {
            get {
                return this.isRoutedExportTransactionUpsField;
            }
            set {
                this.isRoutedExportTransactionUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRoutedExportTransactionUpsSpecified {
            get {
                return this.isRoutedExportTransactionUpsFieldSpecified;
            }
            set {
                this.isRoutedExportTransactionUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string licenseNumberUps {
            get {
                return this.licenseNumberUpsField;
            }
            set {
                this.licenseNumberUpsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime licenseDateUps {
            get {
                return this.licenseDateUpsField;
            }
            set {
                this.licenseDateUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool licenseDateUpsSpecified {
            get {
                return this.licenseDateUpsFieldSpecified;
            }
            set {
                this.licenseDateUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentLicenseExceptionUps licenseExceptionUps {
            get {
                return this.licenseExceptionUpsField;
            }
            set {
                this.licenseExceptionUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool licenseExceptionUpsSpecified {
            get {
                return this.licenseExceptionUpsFieldSpecified;
            }
            set {
                this.licenseExceptionUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string eccNumberUps {
            get {
                return this.eccNumberUpsField;
            }
            set {
                this.eccNumberUpsField = value;
            }
        }

        /// <remarks/>
        public string recipientTaxIdUps {
            get {
                return this.recipientTaxIdUpsField;
            }
            set {
                this.recipientTaxIdUpsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime blanketStartDateUps {
            get {
                return this.blanketStartDateUpsField;
            }
            set {
                this.blanketStartDateUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool blanketStartDateUpsSpecified {
            get {
                return this.blanketStartDateUpsFieldSpecified;
            }
            set {
                this.blanketStartDateUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime blanketEndDateUps {
            get {
                return this.blanketEndDateUpsField;
            }
            set {
                this.blanketEndDateUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool blanketEndDateUpsSpecified {
            get {
                return this.blanketEndDateUpsFieldSpecified;
            }
            set {
                this.blanketEndDateUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shipmentWeightUps {
            get {
                return this.shipmentWeightUpsField;
            }
            set {
                this.shipmentWeightUpsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentWeightUpsSpecified {
            get {
                return this.shipmentWeightUpsFieldSpecified;
            }
            set {
                this.shipmentWeightUpsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool saturdayDeliveryFedEx {
            get {
                return this.saturdayDeliveryFedExField;
            }
            set {
                this.saturdayDeliveryFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saturdayDeliveryFedExSpecified {
            get {
                return this.saturdayDeliveryFedExFieldSpecified;
            }
            set {
                this.saturdayDeliveryFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool saturdayPickupFedex {
            get {
                return this.saturdayPickupFedexField;
            }
            set {
                this.saturdayPickupFedexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saturdayPickupFedexSpecified {
            get {
                return this.saturdayPickupFedexFieldSpecified;
            }
            set {
                this.saturdayPickupFedexFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sendShipNotifyEmailFedEx {
            get {
                return this.sendShipNotifyEmailFedExField;
            }
            set {
                this.sendShipNotifyEmailFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendShipNotifyEmailFedExSpecified {
            get {
                return this.sendShipNotifyEmailFedExFieldSpecified;
            }
            set {
                this.sendShipNotifyEmailFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sendBackupEmailFedEx {
            get {
                return this.sendBackupEmailFedExField;
            }
            set {
                this.sendBackupEmailFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendBackupEmailFedExSpecified {
            get {
                return this.sendBackupEmailFedExFieldSpecified;
            }
            set {
                this.sendBackupEmailFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool signatureHomeDeliveryFedEx {
            get {
                return this.signatureHomeDeliveryFedExField;
            }
            set {
                this.signatureHomeDeliveryFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool signatureHomeDeliveryFedExSpecified {
            get {
                return this.signatureHomeDeliveryFedExFieldSpecified;
            }
            set {
                this.signatureHomeDeliveryFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string shipNotifyEmailAddressFedEx {
            get {
                return this.shipNotifyEmailAddressFedExField;
            }
            set {
                this.shipNotifyEmailAddressFedExField = value;
            }
        }

        /// <remarks/>
        public string backupEmailAddressFedEx {
            get {
                return this.backupEmailAddressFedExField;
            }
            set {
                this.backupEmailAddressFedExField = value;
            }
        }

        /// <remarks/>
        public System.DateTime shipDateFedEx {
            get {
                return this.shipDateFedExField;
            }
            set {
                this.shipDateFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipDateFedExSpecified {
            get {
                return this.shipDateFedExFieldSpecified;
            }
            set {
                this.shipDateFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentHomeDeliveryTypeFedEx homeDeliveryTypeFedEx {
            get {
                return this.homeDeliveryTypeFedExField;
            }
            set {
                this.homeDeliveryTypeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool homeDeliveryTypeFedExSpecified {
            get {
                return this.homeDeliveryTypeFedExFieldSpecified;
            }
            set {
                this.homeDeliveryTypeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime homeDeliveryDateFedEx {
            get {
                return this.homeDeliveryDateFedExField;
            }
            set {
                this.homeDeliveryDateFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool homeDeliveryDateFedExSpecified {
            get {
                return this.homeDeliveryDateFedExFieldSpecified;
            }
            set {
                this.homeDeliveryDateFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string bookingConfirmationNumFedEx {
            get {
                return this.bookingConfirmationNumFedExField;
            }
            set {
                this.bookingConfirmationNumFedExField = value;
            }
        }

        /// <remarks/>
        public string intlExemptionNumFedEx {
            get {
                return this.intlExemptionNumFedExField;
            }
            set {
                this.intlExemptionNumFedExField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentB13AFilingOptionFedEx b13aFilingOptionFedEx {
            get {
                return this.b13aFilingOptionFedExField;
            }
            set {
                this.b13aFilingOptionFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool b13aFilingOptionFedExSpecified {
            get {
                return this.b13aFilingOptionFedExFieldSpecified;
            }
            set {
                this.b13aFilingOptionFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string b13aStatementDataFedEx {
            get {
                return this.b13aStatementDataFedExField;
            }
            set {
                this.b13aStatementDataFedExField = value;
            }
        }

        /// <remarks/>
        public string thirdPartyAcctFedEx {
            get {
                return this.thirdPartyAcctFedExField;
            }
            set {
                this.thirdPartyAcctFedExField = value;
            }
        }

        /// <remarks/>
        public Country thirdPartyCountryFedEx {
            get {
                return this.thirdPartyCountryFedExField;
            }
            set {
                this.thirdPartyCountryFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyCountryFedExSpecified {
            get {
                return this.thirdPartyCountryFedExFieldSpecified;
            }
            set {
                this.thirdPartyCountryFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentThirdPartyTypeFedEx thirdPartyTypeFedEx {
            get {
                return this.thirdPartyTypeFedExField;
            }
            set {
                this.thirdPartyTypeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyTypeFedExSpecified {
            get {
                return this.thirdPartyTypeFedExFieldSpecified;
            }
            set {
                this.thirdPartyTypeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shipmentWeightFedEx {
            get {
                return this.shipmentWeightFedExField;
            }
            set {
                this.shipmentWeightFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentWeightFedExSpecified {
            get {
                return this.shipmentWeightFedExFieldSpecified;
            }
            set {
                this.shipmentWeightFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentTermsOfSaleFedEx termsOfSaleFedEx {
            get {
                return this.termsOfSaleFedExField;
            }
            set {
                this.termsOfSaleFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool termsOfSaleFedExSpecified {
            get {
                return this.termsOfSaleFedExFieldSpecified;
            }
            set {
                this.termsOfSaleFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double termsFreightChargeFedEx {
            get {
                return this.termsFreightChargeFedExField;
            }
            set {
                this.termsFreightChargeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool termsFreightChargeFedExSpecified {
            get {
                return this.termsFreightChargeFedExFieldSpecified;
            }
            set {
                this.termsFreightChargeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double termsInsuranceChargeFedEx {
            get {
                return this.termsInsuranceChargeFedExField;
            }
            set {
                this.termsInsuranceChargeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool termsInsuranceChargeFedExSpecified {
            get {
                return this.termsInsuranceChargeFedExFieldSpecified;
            }
            set {
                this.termsInsuranceChargeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool insideDeliveryFedEx {
            get {
                return this.insideDeliveryFedExField;
            }
            set {
                this.insideDeliveryFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insideDeliveryFedExSpecified {
            get {
                return this.insideDeliveryFedExFieldSpecified;
            }
            set {
                this.insideDeliveryFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool insidePickupFedEx {
            get {
                return this.insidePickupFedExField;
            }
            set {
                this.insidePickupFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insidePickupFedExSpecified {
            get {
                return this.insidePickupFedExFieldSpecified;
            }
            set {
                this.insidePickupFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentAncillaryEndorsementFedEx ancillaryEndorsementFedEx {
            get {
                return this.ancillaryEndorsementFedExField;
            }
            set {
                this.ancillaryEndorsementFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ancillaryEndorsementFedExSpecified {
            get {
                return this.ancillaryEndorsementFedExFieldSpecified;
            }
            set {
                this.ancillaryEndorsementFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool holdAtLocationFedEx {
            get {
                return this.holdAtLocationFedExField;
            }
            set {
                this.holdAtLocationFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool holdAtLocationFedExSpecified {
            get {
                return this.holdAtLocationFedExFieldSpecified;
            }
            set {
                this.holdAtLocationFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string halPhoneFedEx {
            get {
                return this.halPhoneFedExField;
            }
            set {
                this.halPhoneFedExField = value;
            }
        }

        /// <remarks/>
        public string halAddr1FedEx {
            get {
                return this.halAddr1FedExField;
            }
            set {
                this.halAddr1FedExField = value;
            }
        }

        /// <remarks/>
        public string halAddr2FedEx {
            get {
                return this.halAddr2FedExField;
            }
            set {
                this.halAddr2FedExField = value;
            }
        }

        /// <remarks/>
        public string halAddr3FedEx {
            get {
                return this.halAddr3FedExField;
            }
            set {
                this.halAddr3FedExField = value;
            }
        }

        /// <remarks/>
        public string halCityFedEx {
            get {
                return this.halCityFedExField;
            }
            set {
                this.halCityFedExField = value;
            }
        }

        /// <remarks/>
        public string halZipFedEx {
            get {
                return this.halZipFedExField;
            }
            set {
                this.halZipFedExField = value;
            }
        }

        /// <remarks/>
        public string halStateFedEx {
            get {
                return this.halStateFedExField;
            }
            set {
                this.halStateFedExField = value;
            }
        }

        /// <remarks/>
        public string halCountryFedEx {
            get {
                return this.halCountryFedExField;
            }
            set {
                this.halCountryFedExField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentHazmatTypeFedEx hazmatTypeFedEx {
            get {
                return this.hazmatTypeFedExField;
            }
            set {
                this.hazmatTypeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hazmatTypeFedExSpecified {
            get {
                return this.hazmatTypeFedExFieldSpecified;
            }
            set {
                this.hazmatTypeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentAccessibilityTypeFedEx accessibilityTypeFedEx {
            get {
                return this.accessibilityTypeFedExField;
            }
            set {
                this.accessibilityTypeFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessibilityTypeFedExSpecified {
            get {
                return this.accessibilityTypeFedExFieldSpecified;
            }
            set {
                this.accessibilityTypeFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isCargoAircraftOnlyFedEx {
            get {
                return this.isCargoAircraftOnlyFedExField;
            }
            set {
                this.isCargoAircraftOnlyFedExField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCargoAircraftOnlyFedExSpecified {
            get {
                return this.isCargoAircraftOnlyFedExFieldSpecified;
            }
            set {
                this.isCargoAircraftOnlyFedExFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public bool generateIntegratedShipperLabel {
            get {
                return this.generateIntegratedShipperLabelField;
            }
            set {
                this.generateIntegratedShipperLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generateIntegratedShipperLabelSpecified {
            get {
                return this.generateIntegratedShipperLabelFieldSpecified;
            }
            set {
                this.generateIntegratedShipperLabelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shippingCost {
            get {
                return this.shippingCostField;
            }
            set {
                this.shippingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingCostSpecified {
            get {
                return this.shippingCostFieldSpecified;
            }
            set {
                this.shippingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double handlingCost {
            get {
                return this.handlingCostField;
            }
            set {
                this.handlingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingCostSpecified {
            get {
                return this.handlingCostFieldSpecified;
            }
            set {
                this.handlingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public RecordRef transferLocation {
            get {
                return this.transferLocationField;
            }
            set {
                this.transferLocationField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentPackageList packageList {
            get {
                return this.packageListField;
            }
            set {
                this.packageListField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentPackageUpsList packageUpsList {
            get {
                return this.packageUpsListField;
            }
            set {
                this.packageUpsListField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentPackageUspsList packageUspsList {
            get {
                return this.packageUspsListField;
            }
            set {
                this.packageUspsListField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentPackageFedExList packageFedExList {
            get {
                return this.packageFedExListField;
            }
            set {
                this.packageFedExListField = value;
            }
        }

        /// <remarks/>
        public ItemFulfillmentItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public AccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
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