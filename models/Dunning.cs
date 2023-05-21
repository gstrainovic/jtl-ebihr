using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Dunning
{
    /// <summary>
    /// Interne ID der Mahnung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Rechnung
    /// </summary>
    public int InvoiceInternalId { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int CompanyInternalId { get; set; }

    /// <summary>
    /// Interne ID der Kundengruppe
    /// </summary>
    public int CustomerGroupInternalId { get; set; }

    /// <summary>
    /// Datum der Zahlungsfrist der Mahnung
    /// </summary>
    public DateTime? PaymentTermDate { get; set; }

    /// <summary>
    /// Datum an dem die Mahnung erledigt wurde
    /// </summary>
    public DateTime? CompletionDate { get; set; }

    /// <summary>
    /// Zahlungsfrist in Tagen
    /// </summary>
    public int? PaymentTerm { get; set; }

    /// <summary>
    /// Datum der Mahung
    /// </summary>
    public DateTime? DunningDate { get; set; }

    /// <summary>
    /// Mahngebühr
    /// </summary>
    public decimal DunningFee { get; set; }

    /// <summary>
    /// Pauschale Mahngebühr
    /// </summary>
    public decimal FlatRateDunningFee { get; set; }

    /// <summary>
    /// Zinssatz der Mahngebühr
    /// </summary>
    public decimal FeeInterestRate { get; set; }

    /// <summary>
    /// Bruttobetrag der Mahnung
    /// </summary>
    public decimal? GrossValue { get; set; }

    /// <summary>
    /// Interne ID des Benutzers
    /// </summary>
    public int? UserInternalId { get; set; }

    /// <summary>
    /// ISO-Code der Währung
    /// </summary>
    public string CurrencyIso { get; set; } = null!;

    /// <summary>
    /// Name der Mahnstufe
    /// </summary>
    public string? DunningLevelName { get; set; }

    /// <summary>
    /// Level der Mahnstufe
    /// </summary>
    public byte NumberDunningRepitions { get; set; }

    /// <summary>
    /// Karenzzeit
    /// </summary>
    public int? GracePeriod { get; set; }

    /// <summary>
    /// Vorgangs-ID der Mahnung
    /// </summary>
    public string? OperationId { get; set; }

    /// <summary>
    /// Erstellungsdatum der Mahnung
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// USt-IdNr. der Mahnung
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    /// <summary>
    /// ISO-Code des Landes
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Sprache
    /// </summary>
    public string? LanguageIso { get; set; }
}
