namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class IssueRelatedIssues {

        private IssueRelationship relationshipField;

        private bool relationshipFieldSpecified;

        private RecordRef issueNumberField;

        private string relationshipCommentField;

        /// <remarks/>
        public IssueRelationship relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relationshipSpecified {
            get {
                return this.relationshipFieldSpecified;
            }
            set {
                this.relationshipFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef issueNumber {
            get {
                return this.issueNumberField;
            }
            set {
                this.issueNumberField = value;
            }
        }

        /// <remarks/>
        public string relationshipComment {
            get {
                return this.relationshipCommentField;
            }
            set {
                this.relationshipCommentField = value;
            }
        }
    }
}