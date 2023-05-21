using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAuftragZahlungszuordnung
{
    public int KBestellung { get; set; }

    public string CBestellnummer { get; set; } = null!;

    public decimal FAuftragswert { get; set; }

    public DateTime DBelegdatum { get; set; }

    public string? CEbayBuyerUserId { get; set; }

    public string? CKundennummer { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public decimal FBetrag { get; set; }

    public int? KZahlungsart { get; set; }

    public decimal? FSkontowertInProzent { get; set; }

    public string? CZahlungsartbezeichnung { get; set; }

    public string? CExterneBestellNr { get; set; }

    public string? CVerwendungszweck { get; set; }

    public string? CFirma { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public decimal FOffenerWert { get; set; }

    public byte NRechnungStatus { get; set; }

    public byte NZahlungStatus { get; set; }
}
