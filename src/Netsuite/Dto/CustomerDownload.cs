namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class CustomerDownload {

        private RecordRef fileField;

        private string licenseCodeField;

        private long remainingDownloadsField;

        private bool remainingDownloadsFieldSpecified;

        private System.DateTime expirationField;

        private bool expirationFieldSpecified;

        /// <remarks/>
        public RecordRef file {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
            }
        }

        /// <remarks/>
        public string licenseCode {
            get {
                return this.licenseCodeField;
            }
            set {
                this.licenseCodeField = value;
            }
        }

        /// <remarks/>
        public long remainingDownloads {
            get {
                return this.remainingDownloadsField;
            }
            set {
                this.remainingDownloadsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool remainingDownloadsSpecified {
            get {
                return this.remainingDownloadsFieldSpecified;
            }
            set {
                this.remainingDownloadsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expiration {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationSpecified {
            get {
                return this.expirationFieldSpecified;
            }
            set {
                this.expirationFieldSpecified = value;
            }
        }
    }
}