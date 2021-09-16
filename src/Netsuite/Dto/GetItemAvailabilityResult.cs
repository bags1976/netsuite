namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetItemAvailabilityResult {

        private Status statusField;

        private ItemAvailability[] itemAvailabilityListField;

        /// <remarks/>
        public Status status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("itemAvailability", IsNullable=false)]
        public ItemAvailability[] itemAvailabilityList {
            get {
                return this.itemAvailabilityListField;
            }
            set {
                this.itemAvailabilityListField = value;
            }
        }
    }
}