using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class DeliveryNote1
{
    /// <summary>
    /// Interne ID des Lieferscheins
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne IDpass des Benutzers
    /// </summary>
    public int UserInternalId { get; set; }

    /// <summary>
    /// Nummer des Lieferscheins
    /// </summary>
    public string? DeliveryNoteNumber { get; set; }

    /// <summary>
    /// Hinweisfeld zum Lieferschein
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Bemerkung zum Lieferschein
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Drucktext für den Lieferschein
    /// </summary>
    public string? DeliveryNoteText { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int? CompanyInternalId { get; set; }

    /// <summary>
    /// Nummer der Bestellung
    /// </summary>
    public string SalesOrderNumber { get; set; } = null!;

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Vorgangsnummer im Lieferschein
    /// </summary>
    public string? OperationId { get; set; }

    /// <summary>
    /// Versanddatum
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Erstellungsdatum des Lieferscheins
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Druckdatum des Lieferscheins
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// ISO-Code des Landes im Lieferschein
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währung im Lieferschein
    /// </summary>
    public string? CurrencyIso { get; set; }

    /// <summary>
    /// ISO-Code der Sprache im Lieferschein
    /// </summary>
    public string? LanguageIso { get; set; }

    /// <summary>
    /// Lieferdatum des Lieferscheins
    /// </summary>
    public DateTime? ServiceDate { get; set; }

    /// <summary>
    /// Lieferschein als PDF vorhanden
    /// </summary>
    public bool? HasDeliveryNoteAsPdf { get; set; }

    /// <summary>
    /// Lieferscheindaten
    /// </summary>
    public byte[]? DeliveryNoteData { get; set; }

    /// <summary>
    /// Art der Zahlungsmethode im Lieferschein
    /// </summary>
    public string PaymentMethodType { get; set; } = null!;

    /// <summary>
    /// Umsatzsteuer-ID im Lieferschein
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    /// <summary>
    /// Gesamter Nettopreis
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Gesamtgewicht der Lieferung
    /// </summary>
    public decimal? TotalShippingWeight { get; set; }

    /// <summary>
    /// Versandkosten der Lieferung
    /// </summary>
    public decimal ShippingCosts { get; set; }

    /// <summary>
    /// Interne ID der Versandart
    /// </summary>
    public int? ShippingMethodInternalId { get; set; }
}
