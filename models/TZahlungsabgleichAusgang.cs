using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TZahlungsabgleichAusgang
{
    public int KZahlungsabgleichAusgang { get; set; }

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;

    public int KZahlungsabgleichUmsatzEingang { get; set; }

    public int KZahlungsabgleichUmsatzAusgang { get; set; }

    public int KKunde { get; set; }

    public int KLieferant { get; set; }

    public int KGutschrift { get; set; }

    public int KEingangsrechnung { get; set; }

    public decimal FBetrag { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CKonto { get; set; } = null!;

    public string CKontozusatz { get; set; } = null!;

    public string CVerwendungszweck { get; set; } = null!;

    public string CInternerKommentar { get; set; } = null!;

    public byte NVollstaendigerReferenzbetrag { get; set; }

    public DateTime DAnlagedatum { get; set; }

    public int KAnlagebenutzer { get; set; }

    public DateTime? DBuchungsdatum { get; set; }

    public int KBuchungsbenutzer { get; set; }

    public string CTransaktionId { get; set; } = null!;

    public int? KZahlungAusgang { get; set; }

    public int? KZahlungEingang { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
