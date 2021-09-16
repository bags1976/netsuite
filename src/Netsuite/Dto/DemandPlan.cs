namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:demandplanning_2021_1.transactions.webservices.netsuite.com")]
    public partial class DemandPlan {

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private double calculatedQuantityField;

        private bool calculatedQuantityFieldSpecified;

        private PeriodDemandPlan[] periodDemandPlanListField;

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
        public double calculatedQuantity {
            get {
                return this.calculatedQuantityField;
            }
            set {
                this.calculatedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculatedQuantitySpecified {
            get {
                return this.calculatedQuantityFieldSpecified;
            }
            set {
                this.calculatedQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("periodDemandPlan", IsNullable=false)]
        public PeriodDemandPlan[] periodDemandPlanList {
            get {
                return this.periodDemandPlanListField;
            }
            set {
                this.periodDemandPlanListField = value;
            }
        }
    }
}