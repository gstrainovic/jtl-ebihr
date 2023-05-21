using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tlagerbestand
{
    public int KArtikel { get; set; }

    public decimal FLagerbestand { get; set; }

    public decimal FVerfuegbar { get; set; }

    public decimal FVerfuegbarGesperrt { get; set; }

    public decimal FZulauf { get; set; }

    public decimal FAufEinkaufsliste { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public decimal FLagerbestandEigen { get; set; }

    public decimal FInAuftraegen { get; set; }

    public byte NLagerAktiv { get; set; }

    public byte NArtikelTyp { get; set; }

    public byte NTeilbar { get; set; }

    public byte NLagerKleinerNull { get; set; }

    public decimal FAuslieferungGesperrt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
