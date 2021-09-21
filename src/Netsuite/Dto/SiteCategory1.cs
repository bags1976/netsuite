using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SiteCategory", Namespace="urn:website_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategory1 : Record {

        private RecordRef websiteField;

        private string itemIdField;

        private RecordRef parentCategoryField;

        private RecordRef categoryListLayoutField;

        private RecordRef itemListLayoutField;

        private RecordRef relatedItemsListLayoutField;

        private RecordRef correlatedItemsListLayoutField;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string descriptionField;

        private string storeDetailedDescriptionField;

        private RecordRef storeDisplayThumbnailField;

        private RecordRef storeDisplayImageField;

        private string pageTitleField;

        private string metaTagHtmlField;

        private bool excludeFromSitemapField;

        private bool excludeFromSitemapFieldSpecified;

        private string urlComponentField;

        private SitemapPriority sitemapPriorityField;

        private bool sitemapPriorityFieldSpecified;

        private string searchKeywordsField;

        private SiteCategoryPresentationItemList presentationItemListField;

        private SiteCategoryTranslationList translationsListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef website {
            get {
                return this.websiteField;
            }
            set {
                this.websiteField = value;
            }
        }

        /// <remarks/>
        public string itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef parentCategory {
            get {
                return this.parentCategoryField;
            }
            set {
                this.parentCategoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef categoryListLayout {
            get {
                return this.categoryListLayoutField;
            }
            set {
                this.categoryListLayoutField = value;
            }
        }

        /// <remarks/>
        public RecordRef itemListLayout {
            get {
                return this.itemListLayoutField;
            }
            set {
                this.itemListLayoutField = value;
            }
        }

        /// <remarks/>
        public RecordRef relatedItemsListLayout {
            get {
                return this.relatedItemsListLayoutField;
            }
            set {
                this.relatedItemsListLayoutField = value;
            }
        }

        /// <remarks/>
        public RecordRef correlatedItemsListLayout {
            get {
                return this.correlatedItemsListLayoutField;
            }
            set {
                this.correlatedItemsListLayoutField = value;
            }
        }

        /// <remarks/>
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
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
        public string storeDetailedDescription {
            get {
                return this.storeDetailedDescriptionField;
            }
            set {
                this.storeDetailedDescriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayThumbnail {
            get {
                return this.storeDisplayThumbnailField;
            }
            set {
                this.storeDisplayThumbnailField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayImage {
            get {
                return this.storeDisplayImageField;
            }
            set {
                this.storeDisplayImageField = value;
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
        public string metaTagHtml {
            get {
                return this.metaTagHtmlField;
            }
            set {
                this.metaTagHtmlField = value;
            }
        }

        /// <remarks/>
        public bool excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromSitemapSpecified {
            get {
                return this.excludeFromSitemapFieldSpecified;
            }
            set {
                this.excludeFromSitemapFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
            }
        }

        /// <remarks/>
        public SitemapPriority sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sitemapPrioritySpecified {
            get {
                return this.sitemapPriorityFieldSpecified;
            }
            set {
                this.sitemapPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string searchKeywords {
            get {
                return this.searchKeywordsField;
            }
            set {
                this.searchKeywordsField = value;
            }
        }

        /// <remarks/>
        public SiteCategoryPresentationItemList presentationItemList {
            get {
                return this.presentationItemListField;
            }
            set {
                this.presentationItemListField = value;
            }
        }

        /// <remarks/>
        public SiteCategoryTranslationList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}