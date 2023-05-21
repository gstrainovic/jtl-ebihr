using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerPlatzDefault
{
    public int KWarenLager { get; set; }

    public int KWarenLagerGroesse { get; set; }

    public decimal FGewichtMax { get; set; }

    public int? NAnzahlMax { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FHoehe { get; set; }

    public decimal FBreite { get; set; }

    public string? CKommentar { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
