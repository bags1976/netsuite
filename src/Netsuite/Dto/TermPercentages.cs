namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TermPercentages {

        private double percentageField;

        private bool percentageFieldSpecified;

        /// <remarks/>
        public double percentage {
            get {
                return this.percentageField;
            }
            set {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentageSpecified {
            get {
                return this.percentageFieldSpecified;
            }
            set {
                this.percentageFieldSpecified = value;
            }
        }
    }
}