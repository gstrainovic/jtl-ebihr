using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmretoureAustauschArtikel
{
    public int KRmretoureAustauschArtikel { get; set; }

    public int KRmretoure { get; set; }

    public int KArtikel { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FVkPreis { get; set; }

    public decimal FVkNetto { get; set; }

    public string? CHinweis { get; set; }

    public decimal FRabatt { get; set; }

    public decimal FMwSt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
