namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class InboundShipmentSearchRow : SearchRow {

        private InboundShipmentSearchRowBasic basicField;

        private InventoryDetailSearchRowBasic inventoryDetailJoinField;

        private ItemSearchRowBasic itemJoinField;

        private TransactionSearchRowBasic itemReceiptJoinField;

        private TransactionSearchRowBasic purchaseOrderJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public InboundShipmentSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public InventoryDetailSearchRowBasic inventoryDetailJoin {
            get {
                return this.inventoryDetailJoinField;
            }
            set {
                this.inventoryDetailJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchRowBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic itemReceiptJoin {
            get {
                return this.itemReceiptJoinField;
            }
            set {
                this.itemReceiptJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic purchaseOrderJoin {
            get {
                return this.purchaseOrderJoinField;
            }
            set {
                this.purchaseOrderJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchRowBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
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