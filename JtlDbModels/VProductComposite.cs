using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProductComposite
{
    public int KProduct { get; set; }

    public int KProductIdComponent { get; set; }

    public decimal FQuantity { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
