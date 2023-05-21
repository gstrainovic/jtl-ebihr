using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungEckdaten
{
    public int KRechnung { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public bool NIstAngemahnt { get; set; }

    public byte? NMahnstufe { get; set; }

    public DateTime? DMahndatum { get; set; }

    public DateTime? DZahlungsziel { get; set; }

    public decimal FOffenerWert { get; set; }

    public DateTime? DBezahlt { get; set; }

    public decimal? FVkBruttoGesamt { get; set; }

    public decimal? FVkNettoGesamt { get; set; }

    public decimal FZahlung { get; set; }

    public DateTime? DZahlungsMail { get; set; }

    public decimal FGutschrift { get; set; }

    public byte NZahlungStatus { get; set; }

    public byte NRechnungTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CAuftragsnummern { get; set; }

    public bool NHasRechnungskorrektur { get; set; }

    public bool NKorrigiert { get; set; }
}
