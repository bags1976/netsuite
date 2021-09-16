namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class TopicSearch : SearchRecord {

        private TopicSearchBasic basicField;

        private SolutionSearchBasic solutionJoinField;

        private EmployeeSearchBasic userJoinField;

        /// <remarks/>
        public TopicSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SolutionSearchBasic solutionJoin {
            get {
                return this.solutionJoinField;
            }
            set {
                this.solutionJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}