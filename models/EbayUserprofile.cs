using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayUserprofile
{
    public int KUserProfile { get; set; }

    public int KEbayuser { get; set; }

    public int SiteId { get; set; }

    public string? ProfileType { get; set; }

    public string? ProfileId { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileDesc { get; set; }

    public string? CategoryName { get; set; }

    public byte NStandard { get; set; }
}
