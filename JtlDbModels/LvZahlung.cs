using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvZahlung
{
    public int KZahlung { get; set; }

    public string? CName { get; set; }

    public DateTime? DDatum { get; set; }

    public decimal FBetrag { get; set; }

    public int? KBestellung { get; set; }

    public string? CBestellNr { get; set; }

    public string? CRechnungsNr { get; set; }

    public int? KRechnung { get; set; }

    public int KBenutzer { get; set; }

    public string? CBenutzerName { get; set; }

    public byte NIstAnzahlung { get; set; }

    public string? CHinweis { get; set; }

    public int KZahlungsart { get; set; }

    public string? CZahlungsartName { get; set; }

    public byte NIstKeinExport { get; set; }

    public string? CSkrmanuell { get; set; }

    public string? CExterneTransaktionsid { get; set; }

    public int? KZahlungsabgleichUmsatz { get; set; }

    public byte NZuweisungstyp { get; set; }

    public byte NZahlungstyp { get; set; }

    public string? CZuweisungsinfo { get; set; }

    public int? NZuweisungswertung { get; set; }

    public string? CUmsatzVerwendungszweck { get; set; }

    public string? CUmsatzTransaktionsid { get; set; }

    public string? CKundenNr { get; set; }

    public string? CRechnungsName { get; set; }

    public string? CRechnungsVorname { get; set; }

    public string? CRechnungsFirma { get; set; }

    public string? CRechnungsStrasse { get; set; }

    public string? CRechnungsPlz { get; set; }

    public string? CRechnungsOrt { get; set; }
}
