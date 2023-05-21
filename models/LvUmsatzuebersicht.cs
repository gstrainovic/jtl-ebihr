using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvUmsatzuebersicht
{
    public int KZahlungsabgleichUmsatz { get; set; }

    public string CTransaktionId { get; set; } = null!;

    public DateTime DAbgleichszeitpunkt { get; set; }

    public int KAbgleichsbenutzer { get; set; }

    public string? CAbgleichsbenutzername { get; set; }

    public DateTime DBuchungsdatum { get; set; }

    public decimal FBetrag { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CKonto { get; set; } = null!;

    public string CKontozusatz { get; set; } = null!;

    public string CVerwendungszweck { get; set; } = null!;

    public string CInternerKommentar { get; set; } = null!;

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;

    public int NAnzahlZahlungszuweisungen { get; set; }

    public decimal FSummeZahlungszuweisungen { get; set; }

    public bool NSichtbar { get; set; }

    public int NBuchungstyp { get; set; }
}
