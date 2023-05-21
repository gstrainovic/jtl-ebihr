using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklistePo
{
    public int KPicklistePos { get; set; }

    public int KPickliste { get; set; }

    public int? KWarenLager { get; set; }

    public int? KWarenLagerEingang { get; set; }

    public decimal FAnzahl { get; set; }

    public int? KBestellPos { get; set; }

    public int? KPicklistePosStatus { get; set; }

    public int? KArtikel { get; set; }

    public int? KWarenlagerPlatz { get; set; }

    public int? KPicklistePosUrsprung { get; set; }

    public int KLieferscheinPos { get; set; }

    public int KBestellung { get; set; }

    public int NPickPrio { get; set; }

    public int? NStatus { get; set; }

    public int? KAnsprechpartner { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte? NVorreserviert { get; set; }

    public virtual TLotPreparationStock? TLotPreparationStock { get; set; }
}
