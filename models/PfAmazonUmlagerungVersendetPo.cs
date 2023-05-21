using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonUmlagerungVersendetPo
{
    public int KAmazonUmlagerungVersendetPos { get; set; }

    public int KAmazonUmlagerungVersendet { get; set; }

    public string? CTrackingId { get; set; }

    public byte NDimensionUnit { get; set; }

    public decimal FLength { get; set; }

    public decimal FWidth { get; set; }

    public decimal FHeight { get; set; }

    public byte NWeightUnit { get; set; }

    public decimal FWeight { get; set; }

    public virtual PfAmazonUmlagerungVersendet KAmazonUmlagerungVersendetNavigation { get; set; } = null!;
}
