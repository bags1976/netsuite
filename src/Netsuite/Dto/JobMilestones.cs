namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobMilestones {

        private string milestoneNameField;

        private string milestoneOrderField;

        private System.DateTime milestoneEstCompleteField;

        private bool milestoneEstCompleteFieldSpecified;

        private bool milestoneCompletedField;

        private bool milestoneCompletedFieldSpecified;

        private string milestoneCommentsField;

        /// <remarks/>
        public string milestoneName {
            get {
                return this.milestoneNameField;
            }
            set {
                this.milestoneNameField = value;
            }
        }

        /// <remarks/>
        public string milestoneOrder {
            get {
                return this.milestoneOrderField;
            }
            set {
                this.milestoneOrderField = value;
            }
        }

        /// <remarks/>
        public System.DateTime milestoneEstComplete {
            get {
                return this.milestoneEstCompleteField;
            }
            set {
                this.milestoneEstCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneEstCompleteSpecified {
            get {
                return this.milestoneEstCompleteFieldSpecified;
            }
            set {
                this.milestoneEstCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool milestoneCompleted {
            get {
                return this.milestoneCompletedField;
            }
            set {
                this.milestoneCompletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneCompletedSpecified {
            get {
                return this.milestoneCompletedFieldSpecified;
            }
            set {
                this.milestoneCompletedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string milestoneComments {
            get {
                return this.milestoneCommentsField;
            }
            set {
                this.milestoneCommentsField = value;
            }
        }
    }
}