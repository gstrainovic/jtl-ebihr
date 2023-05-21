using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvZahlungsausgangLogeintrag
{
    public int KZahlungsausgangLogeintrag { get; set; }

    public int KZahlungsabgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;

    public int KKunde { get; set; }

    public string? CKundenNr { get; set; }

    public int KGutschrift { get; set; }

    public string? CGutschriftNr { get; set; }

    public decimal FBetrag { get; set; }

    public string CVerwendungszweck { get; set; } = null!;

    public DateTime DAnlagedatum { get; set; }

    public int KAnlagebenutzer { get; set; }

    public string? CAnlagebenutzerName { get; set; }

    public DateTime DBuchungsdatum { get; set; }

    public int KBuchungsbenutzer { get; set; }

    public string? CBuchungsbenutzerName { get; set; }
}
