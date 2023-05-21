using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkerInfo
{
    public int? NEbayPid { get; set; }

    public DateTime? DEbayStart { get; set; }

    public DateTime? DEbayEnde { get; set; }

    public int? NEbayOption { get; set; }

    public int? NAmazonPid { get; set; }

    public DateTime? DAmazonStart { get; set; }

    public DateTime? DAmazonEnde { get; set; }

    public int? NAmazonOption { get; set; }

    public int? NShopPid { get; set; }

    public DateTime? DShopStart { get; set; }

    public DateTime? DShopEnde { get; set; }

    public int? NShopOption { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
