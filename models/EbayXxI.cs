using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayXxI
{
    public int SiteId { get; set; }

    public int CategoryId { get; set; }

    public int KName { get; set; }

    public string CHelpText { get; set; } = null!;

    public string CHelpUrl { get; set; } = null!;

    public byte NSelectionMode { get; set; }

    public byte NMaxValues { get; set; }

    public byte NMinValues { get; set; }

    public byte NSort { get; set; }

    public byte? IsRecommended { get; set; }
}
