namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemFulfillmentPackage {

        private double packageWeightField;

        private bool packageWeightFieldSpecified;

        private string packageDescrField;

        private string packageTrackingNumberField;

        /// <remarks/>
        public double packageWeight {
            get {
                return this.packageWeightField;
            }
            set {
                this.packageWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool packageWeightSpecified {
            get {
                return this.packageWeightFieldSpecified;
            }
            set {
                this.packageWeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string packageDescr {
            get {
                return this.packageDescrField;
            }
            set {
                this.packageDescrField = value;
            }
        }

        /// <remarks/>
        public string packageTrackingNumber {
            get {
                return this.packageTrackingNumberField;
            }
            set {
                this.packageTrackingNumberField = value;
            }
        }
    }
}