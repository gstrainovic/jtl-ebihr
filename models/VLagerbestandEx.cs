using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLagerbestandEx
{
    public int KArtikel { get; set; }

    public decimal FLagerbestand { get; set; }

    public decimal FVerfuegbar { get; set; }

    public decimal FReserviert { get; set; }

    public decimal FVerfuegbarGesperrt { get; set; }

    public decimal FZulauf { get; set; }

    public decimal? FZulaufVerfuegbar { get; set; }

    public decimal FAufEinkaufsliste { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public decimal FEigenerBestand { get; set; }

    public decimal? FVerfuegbarExtern { get; set; }

    public decimal FInAuftraegen { get; set; }
}
