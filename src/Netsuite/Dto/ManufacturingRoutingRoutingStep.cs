namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingRoutingStep {

        private long operationSequenceField;

        private bool operationSequenceFieldSpecified;

        private string operationNameField;

        private RecordRef manufacturingWorkCenterField;

        private double machineResourcesField;

        private bool machineResourcesFieldSpecified;

        private double laborResourcesField;

        private bool laborResourcesFieldSpecified;

        private RecordRef manufacturingCostTemplateField;

        private double setupTimeField;

        private bool setupTimeFieldSpecified;

        private double runRateField;

        private bool runRateFieldSpecified;

        private ManufacturingLagType lagTypeField;

        private bool lagTypeFieldSpecified;

        private long lagAmountField;

        private bool lagAmountFieldSpecified;

        private string lagUnitsField;

        /// <remarks/>
        public long operationSequence {
            get {
                return this.operationSequenceField;
            }
            set {
                this.operationSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationSequenceSpecified {
            get {
                return this.operationSequenceFieldSpecified;
            }
            set {
                this.operationSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string operationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef manufacturingWorkCenter {
            get {
                return this.manufacturingWorkCenterField;
            }
            set {
                this.manufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        public double machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool machineResourcesSpecified {
            get {
                return this.machineResourcesFieldSpecified;
            }
            set {
                this.machineResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool laborResourcesSpecified {
            get {
                return this.laborResourcesFieldSpecified;
            }
            set {
                this.laborResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef manufacturingCostTemplate {
            get {
                return this.manufacturingCostTemplateField;
            }
            set {
                this.manufacturingCostTemplateField = value;
            }
        }

        /// <remarks/>
        public double setupTime {
            get {
                return this.setupTimeField;
            }
            set {
                this.setupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool setupTimeSpecified {
            get {
                return this.setupTimeFieldSpecified;
            }
            set {
                this.setupTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double runRate {
            get {
                return this.runRateField;
            }
            set {
                this.runRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool runRateSpecified {
            get {
                return this.runRateFieldSpecified;
            }
            set {
                this.runRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ManufacturingLagType lagType {
            get {
                return this.lagTypeField;
            }
            set {
                this.lagTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lagTypeSpecified {
            get {
                return this.lagTypeFieldSpecified;
            }
            set {
                this.lagTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long lagAmount {
            get {
                return this.lagAmountField;
            }
            set {
                this.lagAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lagAmountSpecified {
            get {
                return this.lagAmountFieldSpecified;
            }
            set {
                this.lagAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string lagUnits {
            get {
                return this.lagUnitsField;
            }
            set {
                this.lagUnitsField = value;
            }
        }
    }
}