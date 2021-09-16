namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class UnitsTypeUom {

        private string internalIdField;

        private string unitNameField;

        private string pluralNameField;

        private string abbreviationField;

        private string pluralAbbreviationField;

        private double conversionRateField;

        private bool conversionRateFieldSpecified;

        private bool baseUnitField;

        private bool baseUnitFieldSpecified;

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public string unitName {
            get {
                return this.unitNameField;
            }
            set {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        public string pluralName {
            get {
                return this.pluralNameField;
            }
            set {
                this.pluralNameField = value;
            }
        }

        /// <remarks/>
        public string abbreviation {
            get {
                return this.abbreviationField;
            }
            set {
                this.abbreviationField = value;
            }
        }

        /// <remarks/>
        public string pluralAbbreviation {
            get {
                return this.pluralAbbreviationField;
            }
            set {
                this.pluralAbbreviationField = value;
            }
        }

        /// <remarks/>
        public double conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conversionRateSpecified {
            get {
                return this.conversionRateFieldSpecified;
            }
            set {
                this.conversionRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool baseUnit {
            get {
                return this.baseUnitField;
            }
            set {
                this.baseUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseUnitSpecified {
            get {
                return this.baseUnitFieldSpecified;
            }
            set {
                this.baseUnitFieldSpecified = value;
            }
        }
    }
}