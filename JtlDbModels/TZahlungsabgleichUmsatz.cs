using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsabgleichUmsatz
{
    public int KZahlungsabgleichUmsatz { get; set; }

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;

    public string CTransaktionId { get; set; } = null!;

    public DateTime DBuchungsdatum { get; set; }

    public decimal FBetrag { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CKonto { get; set; } = null!;

    public string CKontozusatz { get; set; } = null!;

    public string CVerwendungszweck { get; set; } = null!;

    public string CInternerKommentar { get; set; } = null!;

    public DateTime DAbgleichszeitpunkt { get; set; }

    public int KBenutzer { get; set; }

    public bool? NSichtbar { get; set; }

    public int NBuchungstyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
