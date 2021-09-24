using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Netsuite.Enum
{
    [GeneratedCode("wsdl", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:types.common_2021_1.platform.webservices.netsuite.com")]
    public enum ItemCostEstimateType
    {
        AVGCOST,
        CUSTOM,
        MEMBERDEFINED,
        ITEMDEFINED,
        LASTPURCHPRICE,
        PREFVENDORRATE,
        PURCHORDERRATE,
        PURCHPRICE,
    }
}