using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelHistory
{
    public int KArtikelHistory { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int KArtikel { get; set; }

    public decimal FAnzahl { get; set; }

    public DateTime DGebucht { get; set; }

    public int KBenutzer { get; set; }

    public int? KWarenEingang { get; set; }

    public int? KBestellPos { get; set; }

    public int? KGutschriftPos { get; set; }

    public decimal FEknetto { get; set; }

    public string? CKommentar { get; set; }

    public int? KPlattform { get; set; }

    public decimal FLagerBestandGesamt { get; set; }

    public decimal FVerfuegbar { get; set; }

    public decimal FReserviert { get; set; }

    public int? KBuchungsart { get; set; }

    public decimal FLagerBestand { get; set; }

    public int? KLieferscheinPos { get; set; }

    public int? KLieferantenBestellungPos { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CChargenNr { get; set; }

    public DateTime? DMhd { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KLhm { get; set; }

    public decimal? FLagerBestandInLager { get; set; }

    public string? CSubsetNumber { get; set; }

    public string? CDimensionen { get; set; }
}
