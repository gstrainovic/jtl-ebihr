﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOfferFailure
{
    public int KOfferFailure { get; set; }

    public long KOffer { get; set; }

    public string CCode { get; set; } = null!;

    public string CMessage { get; set; } = null!;

    public string? CLongMessage { get; set; }

    public DateTime DCreatedAtUtc { get; set; }

    public virtual TOffer KOfferNavigation { get; set; } = null!;
}
