namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class Duration {

        private double timeSpanField;

        private DurationUnit unitField;

        /// <remarks/>
        public double timeSpan {
            get {
                return this.timeSpanField;
            }
            set {
                this.timeSpanField = value;
            }
        }

        /// <remarks/>
        public DurationUnit unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
    }
}