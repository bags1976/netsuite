namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class InventoryNumberLocations {

        private string locationField;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityOnOrderField;

        private bool quantityOnOrderFieldSpecified;

        private double quantityInTransitField;

        private bool quantityInTransitFieldSpecified;

        /// <remarks/>
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnOrder {
            get {
                return this.quantityOnOrderField;
            }
            set {
                this.quantityOnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnOrderSpecified {
            get {
                return this.quantityOnOrderFieldSpecified;
            }
            set {
                this.quantityOnOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityInTransit {
            get {
                return this.quantityInTransitField;
            }
            set {
                this.quantityInTransitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityInTransitSpecified {
            get {
                return this.quantityInTransitFieldSpecified;
            }
            set {
                this.quantityInTransitFieldSpecified = value;
            }
        }
    }
}