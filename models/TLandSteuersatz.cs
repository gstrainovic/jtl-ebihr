using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLandSteuersatz
{
    public string CIsoland { get; set; } = null!;

    public string CKuerzelBundesland { get; set; } = null!;

    public decimal? FStarkErmaessigterSatz { get; set; }

    public decimal? FErmaessigterSatzNiedrig { get; set; }

    public decimal? FErmaessigterSatz { get; set; }

    public decimal? FNormalerSatz { get; set; }

    public decimal? FZwischensatz { get; set; }

    public decimal? FLieferschwelle { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
