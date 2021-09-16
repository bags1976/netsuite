namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class SiteCategorySearchRowBasic : SearchRowBasic {

        private SearchColumnDateField[] dateViewedField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnBooleanField[] excludeFromSitemapField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] fullNameField;

        private SearchColumnBooleanField[] hiddenField;

        private SearchColumnLongField[] hitsField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] longDescriptionField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] pageTitleField;

        private SearchColumnEnumSelectField[] sitemapPriorityField;

        private SearchColumnStringField[] urlComponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateViewed")]
        public SearchColumnDateField[] dateViewed {
            get {
                return this.dateViewedField;
            }
            set {
                this.dateViewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("excludeFromSitemap")]
        public SearchColumnBooleanField[] excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fullName")]
        public SearchColumnStringField[] fullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hidden")]
        public SearchColumnBooleanField[] hidden {
            get {
                return this.hiddenField;
            }
            set {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hits")]
        public SearchColumnLongField[] hits {
            get {
                return this.hitsField;
            }
            set {
                this.hitsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("longDescription")]
        public SearchColumnStringField[] longDescription {
            get {
                return this.longDescriptionField;
            }
            set {
                this.longDescriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("pageTitle")]
        public SearchColumnStringField[] pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sitemapPriority")]
        public SearchColumnEnumSelectField[] sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("urlComponent")]
        public SearchColumnStringField[] urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
            }
        }
    }
}