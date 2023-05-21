using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungPosition1
{
    public int? KRechnungPosition { get; set; }

    public int? KRechnung { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KAuftrag { get; set; }

    public int? KArtikel { get; set; }

    public decimal FMwst { get; set; }

    public byte NType { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal? FEkNetto { get; set; }

    public decimal? FVkBrutto { get; set; }

    public decimal? FVkBruttoGesamt { get; set; }

    public decimal? FVkNettoGesamt { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FRabatt { get; set; }
}
