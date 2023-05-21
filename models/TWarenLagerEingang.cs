using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerEingang
{
    public int KWarenLagerEingang { get; set; }

    public int KArtikel { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int? KLieferantenBestellungPos { get; set; }

    public int KBenutzer { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEkeinzel { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CChargenNr { get; set; }

    public DateTime? DMhd { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGeliefertAm { get; set; }

    public string? CKommentar { get; set; }

    public int? KGutschriftPos { get; set; }

    public int? KWarenLagerAusgang { get; set; }

    public int? KLhm { get; set; }

    public decimal FAnzahlAktuell { get; set; }

    public decimal FAnzahlReserviertPickpos { get; set; }

    public int? KSessionId { get; set; }

    public int? KWarenLagerEingangUrsprung { get; set; }

    public int KBuchungsart { get; set; }

    public int? KBestellPosUmlagerung { get; set; }

    public int? KRmretourePos { get; set; }

    public byte NGldberechnungMitEingangsrechnung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public DateTime? DAusgebuchtAm { get; set; }

    public virtual ICollection<TWarenLagerEingangSubset> TWarenLagerEingangSubsets { get; set; } = new List<TWarenLagerEingangSubset>();
}
