namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachBasicReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachContactReference))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class AttachReference {

        private BaseRef attachToField;

        /// <remarks/>
        public BaseRef attachTo {
            get {
                return this.attachToField;
            }
            set {
                this.attachToField = value;
            }
        }
    }
}