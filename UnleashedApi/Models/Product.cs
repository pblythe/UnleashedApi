using System;

namespace UnleashedApi.Models
{
    public class Product : IKey
    {
        public Guid Guid { get;set; }
        public decimal? AverageLandPrice { get; set; }
        public string Barcode { get; set; }
        public string BinLocation { get;set; }
	    public bool CanAutoAssemble { get; set; }
	    public string CreatedBy { get; set; }
        public decimal? DefaultPurchasePrice { get; set; }
        public decimal? DefaultSellPrice { get; set; }
        public decimal? Depth { get;set; }
        public decimal? Height { get;set; }
        public bool IsAssembledProduct { get;set; }
        public bool IsComponent { get;set; }
        public decimal? LastCost { get; set; }
        public DateTime? LastModifiedOn { get;set; }	
        public decimal? MaxStockAlertLevel { get; set; }
        public decimal? MinStockAlertLevel { get; set; }
        public bool? NeverDiminishing { get; set; }
        public string Notes { get; set; }
        public bool Obsolete { get; set; }
        public decimal? PackSize { get; set; }
        public string ProductCode { get;set; }
        public string ProductDescription { get;set; }
        public ProductGroup ProductGroup { get; set; }
        public decimal? ReOrderPoint { get; set; }
        public SellPriceTier SellPriceTier1 { get; set; }
        public SellPriceTier SellPriceTier2 { get; set; }
        public SellPriceTier SellPriceTier3 { get; set; }
        public SellPriceTier SellPriceTier4 { get; set; }
        public SellPriceTier SellPriceTier5 { get; set; }
        public SellPriceTier SellPriceTier6 { get; set; }
        public SellPriceTier SellPriceTier7 { get; set; }
        public SellPriceTier SellPriceTier8 { get; set; }
        public SellPriceTier SellPriceTier9 { get; set; }
        public SellPriceTier SellPriceTier10 { get; set; }
		public string SourceId { get;set; }
        public string SourceVariantParentId { get;set; }
        public LinkedSupplier Supplier { get; set; }
        public bool? Taxable { get; set; }
        public bool? TaxableSales { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Width { get; set; }
        public string XeroSalesAccount { get; set; }
		public string XeroSalesTaxCode { get; set; }
        public decimal? XeroSalesTaxRate { get; set; }
        public string XeroTaxCode { get; set; }
        public decimal? XeroTaxRate { get; set; }		
    }
}
