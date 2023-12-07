using System;

namespace Netsuite.Dto
{
    public class Classification : Record
    {
        public bool IsInactive { get; set; }
        public string Parent { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public bool IncludeChildren { get; set; }
        public string Subsidiary { get; set; }
    }
}
