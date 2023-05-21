using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonAngebot
{
    public string CSellerSku { get; set; } = null!;

    public int KUser { get; set; }

    public string? CItemName { get; set; }

    public string? CListingId { get; set; }

    public decimal FPrice { get; set; }

    public int? NQuantity { get; set; }

    public DateTime? DOpenDate { get; set; }

    public string? CItemIsMarketplace { get; set; }

    public byte? NProductIdType { get; set; }

    public byte? NItemCondition { get; set; }

    public string? CAsin1 { get; set; }

    public string? CAsin2 { get; set; }

    public string? CAsin3 { get; set; }

    public byte? NWillShipInternationally { get; set; }

    public string? CExpeditedShipping { get; set; }

    public string? CProductId { get; set; }

    public string? CFulfillmentChannel { get; set; }

    public byte? NChangedPrice { get; set; }

    public byte? NChangedQuantity { get; set; }

    public int NPlattform { get; set; }

    public string? CShippingGroup { get; set; }
}
