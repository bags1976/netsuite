namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ProjectTaskAssignmentSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] actualWorkField;

        private SearchColumnDoubleField[] costField;

        private SearchColumnDoubleField[] costBaseField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnDoubleField[] estimatedWorkField;

        private SearchColumnDoubleField[] estimatedWorkBaselineField;

        private SearchColumnDoubleField[] grossProfitField;

        private SearchColumnDoubleField[] grossProfitBaseField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDoubleField[] plannedWorkField;

        private SearchColumnDoubleField[] plannedWorkBaselineField;

        private SearchColumnDoubleField[] priceField;

        private SearchColumnDoubleField[] priceBaseField;

        private SearchColumnSelectField[] resourceField;

        private SearchColumnStringField[] resourceNameField;

        private SearchColumnStringField[] serviceItemField;

        private SearchColumnStringField[] serviceItemDescField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnDoubleField[] unitCostField;

        private SearchColumnDoubleField[] unitCostBaseField;

        private SearchColumnDoubleField[] unitPriceField;

        private SearchColumnDoubleField[] unitPriceBaseField;

        private SearchColumnDoubleField[] unitsField;

        private SearchColumnSelectField[] workCalendarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualWork")]
        public SearchColumnDoubleField[] actualWork {
            get {
                return this.actualWorkField;
            }
            set {
                this.actualWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cost")]
        public SearchColumnDoubleField[] cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costBase")]
        public SearchColumnDoubleField[] costBase {
            get {
                return this.costBaseField;
            }
            set {
                this.costBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWork")]
        public SearchColumnDoubleField[] estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWorkBaseline")]
        public SearchColumnDoubleField[] estimatedWorkBaseline {
            get {
                return this.estimatedWorkBaselineField;
            }
            set {
                this.estimatedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grossProfit")]
        public SearchColumnDoubleField[] grossProfit {
            get {
                return this.grossProfitField;
            }
            set {
                this.grossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grossProfitBase")]
        public SearchColumnDoubleField[] grossProfitBase {
            get {
                return this.grossProfitBaseField;
            }
            set {
                this.grossProfitBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plannedWork")]
        public SearchColumnDoubleField[] plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plannedWorkBaseline")]
        public SearchColumnDoubleField[] plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("price")]
        public SearchColumnDoubleField[] price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priceBase")]
        public SearchColumnDoubleField[] priceBase {
            get {
                return this.priceBaseField;
            }
            set {
                this.priceBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public SearchColumnSelectField[] resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resourceName")]
        public SearchColumnStringField[] resourceName {
            get {
                return this.resourceNameField;
            }
            set {
                this.resourceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceItem")]
        public SearchColumnStringField[] serviceItem {
            get {
                return this.serviceItemField;
            }
            set {
                this.serviceItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceItemDesc")]
        public SearchColumnStringField[] serviceItemDesc {
            get {
                return this.serviceItemDescField;
            }
            set {
                this.serviceItemDescField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitCost")]
        public SearchColumnDoubleField[] unitCost {
            get {
                return this.unitCostField;
            }
            set {
                this.unitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitCostBase")]
        public SearchColumnDoubleField[] unitCostBase {
            get {
                return this.unitCostBaseField;
            }
            set {
                this.unitCostBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitPrice")]
        public SearchColumnDoubleField[] unitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitPriceBase")]
        public SearchColumnDoubleField[] unitPriceBase {
            get {
                return this.unitPriceBaseField;
            }
            set {
                this.unitPriceBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("units")]
        public SearchColumnDoubleField[] units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workCalendar")]
        public SearchColumnSelectField[] workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
            }
        }
    }
}