using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSfpversand
{
    public int KSfpversand { get; set; }

    public int KVersandArt { get; set; }

    public string CShippingOption { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public decimal FWarnIfLabelCostExceeds { get; set; }

    public bool NPrintErrorLabel { get; set; }

    public virtual Tversandart KVersandArtNavigation { get; set; } = null!;
}
