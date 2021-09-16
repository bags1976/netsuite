namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class SolutionSearchRow : SearchRow {

        private SolutionSearchRowBasic basicField;

        private SupportCaseSearchRowBasic caseJoinField;

        private SolutionSearchRowBasic relatedSolutionJoinField;

        private TopicSearchRowBasic topicJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public SolutionSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SupportCaseSearchRowBasic caseJoin {
            get {
                return this.caseJoinField;
            }
            set {
                this.caseJoinField = value;
            }
        }

        /// <remarks/>
        public SolutionSearchRowBasic relatedSolutionJoin {
            get {
                return this.relatedSolutionJoinField;
            }
            set {
                this.relatedSolutionJoinField = value;
            }
        }

        /// <remarks/>
        public TopicSearchRowBasic topicJoin {
            get {
                return this.topicJoinField;
            }
            set {
                this.topicJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }

        /// <remarks/>
        public NoteSearchRowBasic userNotesJoin {
            get {
                return this.userNotesJoinField;
            }
            set {
                this.userNotesJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}