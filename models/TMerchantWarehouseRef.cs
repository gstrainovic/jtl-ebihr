using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerchantWarehouseRef
{
    public int KWarenLagerRef { get; set; }

    public int KWarenLager { get; set; }

    public string CFfnWarehouseId { get; set; } = null!;

    public byte NLieferantenNameUebertragen { get; set; }

    public virtual TWarenLager KWarenLagerNavigation { get; set; } = null!;
}
