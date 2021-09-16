namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeHcmPosition {

        private RecordRef positionField;

        private bool primaryPositionField;

        private bool primaryPositionFieldSpecified;

        private string positionIdField;

        private double positionAllocationField;

        private bool positionAllocationFieldSpecified;

        private double fullTimeEquivalentField;

        private bool fullTimeEquivalentFieldSpecified;

        private RecordRef employmentCategoryField;

        private RecordRef reportsToField;

        private RecordRef subsidiaryField;

        private RecordRef locationField;

        /// <remarks/>
        public RecordRef position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public bool primaryPosition {
            get {
                return this.primaryPositionField;
            }
            set {
                this.primaryPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool primaryPositionSpecified {
            get {
                return this.primaryPositionFieldSpecified;
            }
            set {
                this.primaryPositionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string positionId {
            get {
                return this.positionIdField;
            }
            set {
                this.positionIdField = value;
            }
        }

        /// <remarks/>
        public double positionAllocation {
            get {
                return this.positionAllocationField;
            }
            set {
                this.positionAllocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool positionAllocationSpecified {
            get {
                return this.positionAllocationFieldSpecified;
            }
            set {
                this.positionAllocationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double fullTimeEquivalent {
            get {
                return this.fullTimeEquivalentField;
            }
            set {
                this.fullTimeEquivalentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fullTimeEquivalentSpecified {
            get {
                return this.fullTimeEquivalentFieldSpecified;
            }
            set {
                this.fullTimeEquivalentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef employmentCategory {
            get {
                return this.employmentCategoryField;
            }
            set {
                this.employmentCategoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef reportsTo {
            get {
                return this.reportsToField;
            }
            set {
                this.reportsToField = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
}