using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungPositionEckdaten
{
    public int KRechnungPosition { get; set; }

    public decimal FVkbrutto { get; set; }

    public decimal FVkbruttoGesamt { get; set; }

    public decimal FVknettoGesamt { get; set; }

    public decimal FMwStBetrag { get; set; }

    public decimal FRabattbetrag { get; set; }

    public decimal? FGewichtGesamt { get; set; }

    public decimal? FVersandgewichtGesamt { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
