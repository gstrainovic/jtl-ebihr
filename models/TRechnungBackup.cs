using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungBackup
{
    public int KRechnung { get; set; }

    public int TBenutzerKBenutzer { get; set; }

    public int TBestellungKBestellung { get; set; }

    public int TKundeKKunde { get; set; }

    public string? CRechnungsNr { get; set; }

    public string? CBezahlt { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte? NZahlungsziel { get; set; }

    public string? CStatus { get; set; }

    public string? CErloeskonto { get; set; }

    public int? KFirma { get; set; }

    public byte? NInkassoStatus { get; set; }

    public DateTime? DEmailversandt { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public byte NMahnstopp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
