namespace Netsuite.Dto
{
    public class Subsidiary : Record
    {
        public string LanguageLocale { get; set; }
        public string LastModifiedDate { get; set; }
        public string Fullname { get; set; }
        public bool IsElimination { get; set; }
        public string Name { get; set; }
        public bool IsInactive { get; set; }
        public string LegalName { get; set; }
        public string Parent{ get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Nkey { get; set; }
        public string City { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string DropDownState { get; set; }
        public string AddrPhone { get; set; }
        public string Addressee { get; set; }
        public string State { get; set; }
        public string Attention { get; set; }
        public string Override { get; set; }
        public string AddrText { get; set; }
    }
}
