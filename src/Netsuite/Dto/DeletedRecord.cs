using System;

namespace Netsuite.Dto
{
    public class DeletedRecord
    {
        public string ScriptId { get; set; }
        public string DeletedBy { get; set; }
        public bool IsCustomList { get; set; }
        public string RecordId { get; set; }
        public bool IsCustomRecord { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool IsCustomTransaction { get; set; }
        public string RecordTypeId { get; set; }
        public string Context { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
