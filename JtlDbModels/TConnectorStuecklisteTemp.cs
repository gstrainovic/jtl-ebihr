using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TConnectorStuecklisteTemp
{
    public int? KStueckliste { get; set; }

    public string? CVaterId { get; set; }

    public int? KArtikelKind { get; set; }

    public decimal? FAnzahl { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
