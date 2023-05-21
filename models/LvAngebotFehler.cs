using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAngebotFehler
{
    public int KOfferFailure { get; set; }

    public long KOffer { get; set; }

    public string CCode { get; set; } = null!;

    public string CMessage { get; set; } = null!;

    public string? CLongMessage { get; set; }

    public DateTime DCreatedAtUtc { get; set; }
}
