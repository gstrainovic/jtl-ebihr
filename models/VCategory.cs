using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VCategory
{
    public int KCategory { get; set; }

    public string? CImageHash { get; set; }

    public string? CImageSource { get; set; }

    public string? CName { get; set; }

    public int? KParentCategoryId { get; set; }

    public decimal? FDiscount { get; set; }

    public int? NSort { get; set; }

    public DateTime? DUpdatedAt { get; set; }

    public DateTime? DCreatedAt { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
