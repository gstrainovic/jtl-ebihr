using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStuecklisteBestand
{
    public int KArtikel { get; set; }

    public int KStueckliste { get; set; }

    public decimal? FLagerbestand { get; set; }

    public decimal? FLagerbestandEigen { get; set; }

    public decimal? FVerfuegbarGesperrt { get; set; }

    public decimal? FZulauf { get; set; }

    public decimal? FAufEinkaufsliste { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FAuslieferungGesperrt { get; set; }
}
