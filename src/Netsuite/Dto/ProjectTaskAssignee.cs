namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ProjectTaskAssignee {

        private RecordRef resourceField;

        private double unitsField;

        private bool unitsFieldSpecified;

        private RecordRef serviceItemField;

        private double estimatedWorkField;

        private bool estimatedWorkFieldSpecified;

        private double unitCostField;

        private bool unitCostFieldSpecified;

        private double unitPriceField;

        private bool unitPriceFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private double priceField;

        private bool priceFieldSpecified;

        private double plannedWorkField;

        private bool plannedWorkFieldSpecified;

        /// <remarks/>
        public RecordRef resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        public double units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef serviceItem {
            get {
                return this.serviceItemField;
            }
            set {
                this.serviceItemField = value;
            }
        }

        /// <remarks/>
        public double estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedWorkSpecified {
            get {
                return this.estimatedWorkFieldSpecified;
            }
            set {
                this.estimatedWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unitCost {
            get {
                return this.unitCostField;
            }
            set {
                this.unitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitCostSpecified {
            get {
                return this.unitCostFieldSpecified;
            }
            set {
                this.unitCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitPriceSpecified {
            get {
                return this.unitPriceFieldSpecified;
            }
            set {
                this.unitPriceFieldSpecified = value;
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
        public double price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priceSpecified {
            get {
                return this.priceFieldSpecified;
            }
            set {
                this.priceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plannedWorkSpecified {
            get {
                return this.plannedWorkFieldSpecified;
            }
            set {
                this.plannedWorkFieldSpecified = value;
            }
        }
    }
}