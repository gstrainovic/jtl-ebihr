using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VReturnItem
{
    public int KRmretourePos { get; set; }

    public int KRmretoure { get; set; }

    public int ArtikelPk { get; set; }

    public string? Jfsku { get; set; }

    public decimal WawiQuantity { get; set; }

    public decimal? ApiQuantity { get; set; }

    public string? OutboundId { get; set; }

    public string? OutboundItemId { get; set; }

    public string? GrundKommentar { get; set; }

    public string? ZustandKommentar { get; set; }

    public string? ReturnItemId { get; set; }

    public string? ReturnId { get; set; }

    public byte StatusTyp { get; set; }

    public int? LieferscheinPosPk { get; set; }

    public int GrundPk { get; set; }

    public int? ZustandPk { get; set; }

    public string ArtikelNummer { get; set; } = null!;

    public string? Artikelname { get; set; }
}
