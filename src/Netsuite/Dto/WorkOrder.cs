using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class WorkOrder : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private RecordRef manufacturingRoutingField;

        private bool autoCalculateLagField;

        private bool autoCalculateLagFieldSpecified;

        private string statusField;

        private string tranIdField;

        private RecordRef entityField;

        private RecordRef jobField;

        private RecordRef assemblyItemField;

        private bool expandAssemblyField;

        private bool expandAssemblyFieldSpecified;

        private bool isWipField;

        private bool isWipFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef billOfMaterialsField;

        private RecordRef unitsField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private WorkOrderOrderStatus orderStatusField;

        private bool orderStatusFieldSpecified;

        private bool firmedField;

        private bool firmedFieldSpecified;

        private string memoField;

        private RecordRef departmentField;

        private RecordRef classField;

        private WorkOrderItemList itemListField;

        private RecordRef locationField;

        private WorkOrderSchedulingMethod schedulingMethodField;

        private bool schedulingMethodFieldSpecified;

        private SalesTeamList salesTeamListField;

        private PartnersList partnersListField;

        private RecordRef createdFromField;

        private string sourceTransactionIdField;

        private long sourceTransactionLineField;

        private bool sourceTransactionLineFieldSpecified;

        private bool specialOrderField;

        private bool specialOrderFieldSpecified;

        private double buildableField;

        private bool buildableFieldSpecified;

        private CustomFieldRef[] optionsField;

        private double builtField;

        private bool builtFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private RecordRef revisionField;

        private RecordRef billOfMaterialsRevisionField;

        private RecordRef subsidiaryField;

        private AccountingBookDetailList accountingBookDetailListField;

        private System.DateTime requestedDateField;

        private bool requestedDateFieldSpecified;

        private System.DateTime actualProductionStartDateField;

        private bool actualProductionStartDateFieldSpecified;

        private System.DateTime actualProductionEndDateField;

        private bool actualProductionEndDateFieldSpecified;

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
        public RecordRef manufacturingRouting {
            get {
                return this.manufacturingRoutingField;
            }
            set {
                this.manufacturingRoutingField = value;
            }
        }

        /// <remarks/>
        public bool autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoCalculateLagSpecified {
            get {
                return this.autoCalculateLagFieldSpecified;
            }
            set {
                this.autoCalculateLagFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }

        /// <remarks/>
        public RecordRef assemblyItem {
            get {
                return this.assemblyItemField;
            }
            set {
                this.assemblyItemField = value;
            }
        }

        /// <remarks/>
        public bool expandAssembly {
            get {
                return this.expandAssemblyField;
            }
            set {
                this.expandAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expandAssemblySpecified {
            get {
                return this.expandAssemblyFieldSpecified;
            }
            set {
                this.expandAssemblyFieldSpecified = value;
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
        public RecordRef billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
            }
        }

        /// <remarks/>
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
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
        public WorkOrderOrderStatus orderStatus {
            get {
                return this.orderStatusField;
            }
            set {
                this.orderStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderStatusSpecified {
            get {
                return this.orderStatusFieldSpecified;
            }
            set {
                this.orderStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool firmed {
            get {
                return this.firmedField;
            }
            set {
                this.firmedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firmedSpecified {
            get {
                return this.firmedFieldSpecified;
            }
            set {
                this.firmedFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public WorkOrderItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public WorkOrderSchedulingMethod schedulingMethod {
            get {
                return this.schedulingMethodField;
            }
            set {
                this.schedulingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool schedulingMethodSpecified {
            get {
                return this.schedulingMethodFieldSpecified;
            }
            set {
                this.schedulingMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public PartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
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
        public string sourceTransactionId {
            get {
                return this.sourceTransactionIdField;
            }
            set {
                this.sourceTransactionIdField = value;
            }
        }

        /// <remarks/>
        public long sourceTransactionLine {
            get {
                return this.sourceTransactionLineField;
            }
            set {
                this.sourceTransactionLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sourceTransactionLineSpecified {
            get {
                return this.sourceTransactionLineFieldSpecified;
            }
            set {
                this.sourceTransactionLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool specialOrder {
            get {
                return this.specialOrderField;
            }
            set {
                this.specialOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool specialOrderSpecified {
            get {
                return this.specialOrderFieldSpecified;
            }
            set {
                this.specialOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double buildable {
            get {
                return this.buildableField;
            }
            set {
                this.buildableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildableSpecified {
            get {
                return this.buildableFieldSpecified;
            }
            set {
                this.buildableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        public double built {
            get {
                return this.builtField;
            }
            set {
                this.builtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool builtSpecified {
            get {
                return this.builtFieldSpecified;
            }
            set {
                this.builtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public RecordRef billOfMaterialsRevision {
            get {
                return this.billOfMaterialsRevisionField;
            }
            set {
                this.billOfMaterialsRevisionField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public System.DateTime requestedDate {
            get {
                return this.requestedDateField;
            }
            set {
                this.requestedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestedDateSpecified {
            get {
                return this.requestedDateFieldSpecified;
            }
            set {
                this.requestedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime actualProductionStartDate {
            get {
                return this.actualProductionStartDateField;
            }
            set {
                this.actualProductionStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualProductionStartDateSpecified {
            get {
                return this.actualProductionStartDateFieldSpecified;
            }
            set {
                this.actualProductionStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime actualProductionEndDate {
            get {
                return this.actualProductionEndDateField;
            }
            set {
                this.actualProductionEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualProductionEndDateSpecified {
            get {
                return this.actualProductionEndDateFieldSpecified;
            }
            set {
                this.actualProductionEndDateFieldSpecified = value;
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