using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayShopCategory
{
    public int KStoreCategory { get; set; }

    public int? KStore { get; set; }

    public int? KEbayUser { get; set; }

    public long? CategoryId { get; set; }

    public long? ParentCategory { get; set; }

    public string? Name { get; set; }

    public int? NOrder { get; set; }
}
