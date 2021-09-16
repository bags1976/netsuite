namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class CustomerCurrency {

        private RecordRef currencyField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private double consolBalanceField;

        private bool consolBalanceFieldSpecified;

        private double depositBalanceField;

        private bool depositBalanceFieldSpecified;

        private double consolDepositBalanceField;

        private bool consolDepositBalanceFieldSpecified;

        private double overdueBalanceField;

        private bool overdueBalanceFieldSpecified;

        private double consolOverdueBalanceField;

        private bool consolOverdueBalanceFieldSpecified;

        private double unbilledOrdersField;

        private bool unbilledOrdersFieldSpecified;

        private double consolUnbilledOrdersField;

        private bool consolUnbilledOrdersFieldSpecified;

        private bool overrideCurrencyFormatField;

        private bool overrideCurrencyFormatFieldSpecified;

        private string displaySymbolField;

        private CurrencySymbolPlacement symbolPlacementField;

        private bool symbolPlacementFieldSpecified;

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceSpecified {
            get {
                return this.balanceFieldSpecified;
            }
            set {
                this.balanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolBalance {
            get {
                return this.consolBalanceField;
            }
            set {
                this.consolBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolBalanceSpecified {
            get {
                return this.consolBalanceFieldSpecified;
            }
            set {
                this.consolBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double depositBalance {
            get {
                return this.depositBalanceField;
            }
            set {
                this.depositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositBalanceSpecified {
            get {
                return this.depositBalanceFieldSpecified;
            }
            set {
                this.depositBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolDepositBalance {
            get {
                return this.consolDepositBalanceField;
            }
            set {
                this.consolDepositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolDepositBalanceSpecified {
            get {
                return this.consolDepositBalanceFieldSpecified;
            }
            set {
                this.consolDepositBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double overdueBalance {
            get {
                return this.overdueBalanceField;
            }
            set {
                this.overdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overdueBalanceSpecified {
            get {
                return this.overdueBalanceFieldSpecified;
            }
            set {
                this.overdueBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolOverdueBalance {
            get {
                return this.consolOverdueBalanceField;
            }
            set {
                this.consolOverdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolOverdueBalanceSpecified {
            get {
                return this.consolOverdueBalanceFieldSpecified;
            }
            set {
                this.consolOverdueBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbilledOrdersSpecified {
            get {
                return this.unbilledOrdersFieldSpecified;
            }
            set {
                this.unbilledOrdersFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolUnbilledOrders {
            get {
                return this.consolUnbilledOrdersField;
            }
            set {
                this.consolUnbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolUnbilledOrdersSpecified {
            get {
                return this.consolUnbilledOrdersFieldSpecified;
            }
            set {
                this.consolUnbilledOrdersFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool overrideCurrencyFormat {
            get {
                return this.overrideCurrencyFormatField;
            }
            set {
                this.overrideCurrencyFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideCurrencyFormatSpecified {
            get {
                return this.overrideCurrencyFormatFieldSpecified;
            }
            set {
                this.overrideCurrencyFormatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string displaySymbol {
            get {
                return this.displaySymbolField;
            }
            set {
                this.displaySymbolField = value;
            }
        }

        /// <remarks/>
        public CurrencySymbolPlacement symbolPlacement {
            get {
                return this.symbolPlacementField;
            }
            set {
                this.symbolPlacementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolPlacementSpecified {
            get {
                return this.symbolPlacementFieldSpecified;
            }
            set {
                this.symbolPlacementFieldSpecified = value;
            }
        }
    }
}