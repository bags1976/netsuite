using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Netsuite.Enum
{
    [GeneratedCode("wsdl", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:types.accounting_2021_1.lists.webservices.netsuite.com")]
    public enum ItemOutOfStockBehavior
    {
        // _allowBackOrdersButDisplayOutOfStockMessage,
        ENABLENMSG,

        // _allowBackOrdersWithNoOutOfStockMessage,
        ENABLE,

        // _default,
        DEFAULT,

        // _disallowBackOrdersButDisplayOutOfStockMessage,
        DISABLE,

        // _removeItemWhenOutOfStock,
        REMOVE
    }
}