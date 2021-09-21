using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PresentationItem {

        private RecordRef itemField;

        private PresentationItemType itemTypeField;

        private bool itemTypeFieldSpecified;

        private string descriptionField;

        private double onlinePriceField;

        private bool onlinePriceFieldSpecified;

        private double basePriceField;

        private bool basePriceFieldSpecified;

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public PresentationItemType itemType {
            get {
                return this.itemTypeField;
            }
            set {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemTypeSpecified {
            get {
                return this.itemTypeFieldSpecified;
            }
            set {
                this.itemTypeFieldSpecified = value;
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
        public double onlinePrice {
            get {
                return this.onlinePriceField;
            }
            set {
                this.onlinePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onlinePriceSpecified {
            get {
                return this.onlinePriceFieldSpecified;
            }
            set {
                this.onlinePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double basePrice {
            get {
                return this.basePriceField;
            }
            set {
                this.basePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool basePriceSpecified {
            get {
                return this.basePriceFieldSpecified;
            }
            set {
                this.basePriceFieldSpecified = value;
            }
        }
    }
}