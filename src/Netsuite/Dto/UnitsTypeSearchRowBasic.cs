namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class UnitsTypeSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] abbreviationField;

        private SearchColumnBooleanField[] baseUnitField;

        private SearchColumnStringField[] conversionRateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInActiveField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] pluralAbbreviationField;

        private SearchColumnStringField[] pluralNameField;

        private SearchColumnStringField[] unitNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abbreviation")]
        public SearchColumnStringField[] abbreviation {
            get {
                return this.abbreviationField;
            }
            set {
                this.abbreviationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseUnit")]
        public SearchColumnBooleanField[] baseUnit {
            get {
                return this.baseUnitField;
            }
            set {
                this.baseUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conversionRate")]
        public SearchColumnStringField[] conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isInActive")]
        public SearchColumnBooleanField[] isInActive {
            get {
                return this.isInActiveField;
            }
            set {
                this.isInActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pluralAbbreviation")]
        public SearchColumnStringField[] pluralAbbreviation {
            get {
                return this.pluralAbbreviationField;
            }
            set {
                this.pluralAbbreviationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pluralName")]
        public SearchColumnStringField[] pluralName {
            get {
                return this.pluralNameField;
            }
            set {
                this.pluralNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitName")]
        public SearchColumnStringField[] unitName {
            get {
                return this.unitNameField;
            }
            set {
                this.unitNameField = value;
            }
        }
    }
}