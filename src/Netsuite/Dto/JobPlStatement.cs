namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobPlStatement {

        private string costCategoryField;

        private double revenueField;

        private bool revenueFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private double profitField;

        private bool profitFieldSpecified;

        private double marginField;

        private bool marginFieldSpecified;

        /// <remarks/>
        public string costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        public double revenue {
            get {
                return this.revenueField;
            }
            set {
                this.revenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revenueSpecified {
            get {
                return this.revenueFieldSpecified;
            }
            set {
                this.revenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double profit {
            get {
                return this.profitField;
            }
            set {
                this.profitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool profitSpecified {
            get {
                return this.profitFieldSpecified;
            }
            set {
                this.profitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double margin {
            get {
                return this.marginField;
            }
            set {
                this.marginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool marginSpecified {
            get {
                return this.marginFieldSpecified;
            }
            set {
                this.marginFieldSpecified = value;
            }
        }
    }
}