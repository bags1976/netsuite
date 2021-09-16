namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Translation {

        private Language localeField;

        private bool localeFieldSpecified;

        private string languageField;

        private string displayNameField;

        private string descriptionField;

        private string salesDescriptionField;

        private string storeDisplayNameField;

        private string storeDescriptionField;

        private string storeDetailedDescriptionField;

        private string featuredDescriptionField;

        private string specialsDescriptionField;

        private string pageTitleField;

        private string noPriceMessageField;

        private string outOfStockMessageField;

        /// <remarks/>
        public Language locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localeSpecified {
            get {
                return this.localeFieldSpecified;
            }
            set {
                this.localeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string salesDescription {
            get {
                return this.salesDescriptionField;
            }
            set {
                this.salesDescriptionField = value;
            }
        }

        /// <remarks/>
        public string storeDisplayName {
            get {
                return this.storeDisplayNameField;
            }
            set {
                this.storeDisplayNameField = value;
            }
        }

        /// <remarks/>
        public string storeDescription {
            get {
                return this.storeDescriptionField;
            }
            set {
                this.storeDescriptionField = value;
            }
        }

        /// <remarks/>
        public string storeDetailedDescription {
            get {
                return this.storeDetailedDescriptionField;
            }
            set {
                this.storeDetailedDescriptionField = value;
            }
        }

        /// <remarks/>
        public string featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
            }
        }

        /// <remarks/>
        public string specialsDescription {
            get {
                return this.specialsDescriptionField;
            }
            set {
                this.specialsDescriptionField = value;
            }
        }

        /// <remarks/>
        public string pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
            }
        }

        /// <remarks/>
        public string noPriceMessage {
            get {
                return this.noPriceMessageField;
            }
            set {
                this.noPriceMessageField = value;
            }
        }

        /// <remarks/>
        public string outOfStockMessage {
            get {
                return this.outOfStockMessageField;
            }
            set {
                this.outOfStockMessageField = value;
            }
        }
    }
}