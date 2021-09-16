namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:demandplanning_2021_1.transactions.webservices.netsuite.com")]
    public partial class PeriodDemandPlan {

        private double quantityField;

        private DayOfTheWeek dayOfTheWeekField;

        private bool dayOfTheWeekFieldSpecified;

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
        public DayOfTheWeek dayOfTheWeek {
            get {
                return this.dayOfTheWeekField;
            }
            set {
                this.dayOfTheWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dayOfTheWeekSpecified {
            get {
                return this.dayOfTheWeekFieldSpecified;
            }
            set {
                this.dayOfTheWeekFieldSpecified = value;
            }
        }
    }
}