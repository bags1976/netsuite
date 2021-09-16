namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:website_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategoryTranslationList {

        private SiteCategoryTranslation[] translationField;

        private bool replaceAllField;

        public SiteCategoryTranslationList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("translation")]
        public SiteCategoryTranslation[] translation {
            get {
                return this.translationField;
            }
            set {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool replaceAll {
            get {
                return this.replaceAllField;
            }
            set {
                this.replaceAllField = value;
            }
        }
    }
}