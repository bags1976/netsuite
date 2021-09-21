using System.Runtime.Serialization;

namespace Netsuite.Enum
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:types.common_2021_1.platform.webservices.netsuite.com")]
    public enum ItemCostEstimateType {

        [EnumMember(Value = "AVGCOST")] 
        _averageCost,

        [EnumMember(Value = "CUSTOM")] 
        _custom,

        [EnumMember(Value = "MEMBERDEFINED")] 
        _derivedFromMemberItems,

        [EnumMember(Value = "ITEMDEFINED")] 
        _itemDefinedCost,

        [EnumMember(Value = "LASTPURCHPRICE")] 
        _lastPurchasePrice,

        [EnumMember(Value = "PREFVENDORRATE")] 
        _preferredVendorRate,

        [EnumMember(Value = "PURCHORDERRATE")] 
        _purchaseOrderRate,

        [EnumMember(Value = "PURCHPRICE")] 
        _purchasePrice,
    }
}