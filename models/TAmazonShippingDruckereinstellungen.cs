using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAmazonShippingDruckereinstellungen
{
    public int KAmazonShippingDruckereinstellungen { get; set; }

    public int? KVersandart { get; set; }

    public string CRechnername { get; set; } = null!;

    public int? KBenutzer { get; set; }

    public string CDruckername { get; set; } = null!;

    public int? NPageScaling { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
