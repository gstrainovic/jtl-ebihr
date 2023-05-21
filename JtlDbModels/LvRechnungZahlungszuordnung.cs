using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvRechnungZahlungszuordnung
{
    public int KRechnung { get; set; }

    public string CRechnungsnummer { get; set; } = null!;

    public decimal? FRechnungswert { get; set; }

    public DateTime DBelegdatum { get; set; }

    public string? CKundennummer { get; set; }

    public decimal? FBetrag { get; set; }

    public decimal FMahngebuehr { get; set; }

    public int? KZahlungsart { get; set; }

    public decimal FSkontowertInProzent { get; set; }

    public string? CZahlungsartbezeichnung { get; set; }

    public string? CFirma { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public decimal FOffenerWert { get; set; }

    public byte NZahlungStatus { get; set; }

    public string? CBestellnummer { get; set; }

    public decimal? FAuftragswert { get; set; }

    public DateTime? DBestelldatum { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? CExterneBestellNr { get; set; }

    public string? CVerwendungszweck { get; set; }

    public string? CUsername { get; set; }
}
