namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class UsageSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] customerField;

        private SearchColumnDateField[] dateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnStringField[] memoField;

        private SearchColumnDoubleField[] quantityField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnSelectField[] subscriptionLineField;

        private SearchColumnSelectField[] subscriptionPlanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date")]
        public SearchColumnDateField[] date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantity")]
        public SearchColumnDoubleField[] quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription")]
        public SearchColumnSelectField[] subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionLine")]
        public SearchColumnSelectField[] subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionPlan")]
        public SearchColumnSelectField[] subscriptionPlan {
            get {
                return this.subscriptionPlanField;
            }
            set {
                this.subscriptionPlanField = value;
            }
        }
    }
}