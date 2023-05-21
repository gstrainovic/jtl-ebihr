using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLizenzInfo
{
    public int KLizenzInfo { get; set; }

    public int KApplication { get; set; }

    public string? CShopType { get; set; }

    public DateTime DLastUsed { get; set; }

    public int KLicense { get; set; }
}
