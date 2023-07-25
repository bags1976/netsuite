using System;
using System.Collections.Generic;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    public class InboundShipment : Record
    {
        public string ShipmentNumber { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public InboundShipmentShipmentStatus ShipmentStatus { get; set; }
        public DateTime? ExpectedShippingDate { get; set; }
        public DateTime? ActualShippingDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string ShipmentMemo { get; set; }
        public string VesselNumber { get; set; }
        public string BillOfLading { get; set; }
        public string ShipmentBaseCurrency { get; set; }
        public string ExternalId { get; set; }
        public List<InboundShipmentItem> Lines { get; set; }
    }
}
