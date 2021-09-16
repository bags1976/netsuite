namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class InboundShipmentSearch : SearchRecord {

        private InboundShipmentSearchBasic basicField;

        private InventoryDetailSearchBasic inventoryDetailJoinField;

        private ItemSearchBasic itemJoinField;

        private TransactionSearchBasic itemReceiptJoinField;

        private TransactionSearchBasic purchaseOrderJoinField;

        private VendorSearchBasic vendorJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public InboundShipmentSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public InventoryDetailSearchBasic inventoryDetailJoin {
            get {
                return this.inventoryDetailJoinField;
            }
            set {
                this.inventoryDetailJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic itemReceiptJoin {
            get {
                return this.itemReceiptJoinField;
            }
            set {
                this.itemReceiptJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic purchaseOrderJoin {
            get {
                return this.purchaseOrderJoinField;
            }
            set {
                this.purchaseOrderJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}