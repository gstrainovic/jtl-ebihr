using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SalesOrder
{
    /// <summary>
    /// Interne ID des Auftrags
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Nummer des Auftrags
    /// </summary>
    public string SalesOrderNumber { get; set; } = null!;

    /// <summary>
    /// Externe Nummer des Auftrags
    /// </summary>
    public string? ExternalSalesOrderNumber { get; set; }

    /// <summary>
    /// Anmerkung zum Auftrag
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Datum an dem der Auftag gedruckt wurde
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Datum an dem die Email zum Auftrag gesendet wurde
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Erstelldatum des Auftrags
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Zahlungsziel des Auftrags in Tagen
    /// </summary>
    public int? TermOfPayment { get; set; }

    /// <summary>
    /// Status des Auftrags
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Verwendungszweck des Auftrags
    /// </summary>
    public string? PaymentReference { get; set; }

    /// <summary>
    /// Zustäztliches Gewicht des Auftrags
    /// </summary>
    public decimal ExtraWeight { get; set; }

    /// <summary>
    /// ISO-Code des Versandland des Auftrags
    /// </summary>
    public string? ShipFromCountryIso { get; set; }

    /// <summary>
    /// ISO-Code der Versandlandwährung
    /// </summary>
    public string ShipFromCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Faktor zur Umrechnung der Versandlandwährung
    /// </summary>
    public decimal ShipFromCountryCurrencyFactor { get; set; }

    /// <summary>
    /// ISO-Code des Ziellandes des Auftrags
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währung 
    /// </summary>
    public string? CurrencyIso { get; set; }

    /// <summary>
    /// Faktor zur Umrechnung der Währung
    /// </summary>
    public decimal CurrencyFactor { get; set; }

    /// <summary>
    /// Noch zu zahlender Betrag
    /// </summary>
    public decimal? OpenGrossPrice { get; set; }

    /// <summary>
    /// ISO-Code des Steuerlandes des Auftrags
    /// </summary>
    public string? TaxCountryIso { get; set; }

    /// <summary>
    /// ISO-Code der Währung des Steuerlandes im Auftrag
    /// </summary>
    public string TaxCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code des Währungfaktors des Steuerlandes im Auftrag
    /// </summary>
    public decimal TaxCountryCurrencyFactor { get; set; }

    /// <summary>
    /// Kundenauftragsnummer
    /// </summary>
    public string? CustomerSalesOrderNumber { get; set; }

    /// <summary>
    /// Datum der Zahlungsbenachrichtigung per Mail
    /// </summary>
    public DateTime? PaymentNotificationDateByEmail { get; set; }

    /// <summary>
    /// Datum, an dem die Zahlung zum Auftrag gesetzt wurde
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Datum der Lieferung
    /// </summary>
    public DateTime? ServiceDate { get; set; }

    /// <summary>
    /// Auftrags-ID des Vorgangs
    /// </summary>
    public string OperationId { get; set; } = null!;

    /// <summary>
    /// Name der Zahlungsart des Auftrags
    /// </summary>
    public string? PaymentMethodName { get; set; }

    /// <summary>
    /// Interne ID der verwendeten Sprache
    /// </summary>
    public int LanguageInternalId { get; set; }

    /// <summary>
    /// Art der Steuerbefreiung Typfeld
    /// </summary>
    public string ExemptFromVat { get; set; } = null!;

    /// <summary>
    /// Plattform, aus der der Auftrag kommt
    /// </summary>
    public string Platform { get; set; } = null!;

    /// <summary>
    /// Interne ID der Plattform aus der der Auftrag kommt
    /// </summary>
    public int? PlatformInternalId { get; set; }

    /// <summary>
    /// Gibt an, ob Rechnungs- und Lieferadresse unterschiedlich sind
    /// </summary>
    public bool? DifferentAddresses { get; set; }

    /// <summary>
    /// Gesamtbruttopreis des Auftrags
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Nettopreis Gesamt des Auftrags
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Kundendrucktext des Auftrags
    /// </summary>
    public string? CustomerText { get; set; }

    /// <summary>
    /// Es werden Nettopreise angezeigt
    /// </summary>
    public bool? UseNetPrice { get; set; }

    /// <summary>
    /// Skonto in Prozent
    /// </summary>
    public decimal? CashDiscount { get; set; }

    /// <summary>
    /// Gültigkeit des Skonto in Tagen
    /// </summary>
    public int? CashDiscountValidity { get; set; }

    /// <summary>
    /// Wert des Skontos
    /// </summary>
    public decimal? CashDiscountValue { get; set; }

    /// <summary>
    /// Interne Id der Firma
    /// </summary>
    public int? CompanyInternalId { get; set; }

    /// <summary>
    /// Gibt an, ob die Zahlungsart des Auftrags Nachnahme ist
    /// </summary>
    public bool? IsShippingMethodCod { get; set; }

    /// <summary>
    /// Gibt an, ob der Auftrag bezahlt ist
    /// </summary>
    public bool? IsPaid { get; set; }

    /// <summary>
    /// Name des Rückhaltegrundes
    /// </summary>
    public string? ReasonForRetention { get; set; }

    /// <summary>
    /// Gibt an, ob der Auftrag storniert ist
    /// </summary>
    public bool? IsCancelled { get; set; }

    /// <summary>
    /// Finanzierungskosten
    /// </summary>
    public decimal FinancingCosts { get; set; }

    /// <summary>
    /// PDF-Pfad der Rechnung des Händlers im Auftrag
    /// </summary>
    public byte[]? InvoiceAsPdfpath { get; set; }

    /// <summary>
    /// PDF-Pfad des Lieferscheins des Händlers im Auftrag
    /// </summary>
    public byte[]? DeliveryNoteAsPdfpath { get; set; }

    /// <summary>
    /// Versandbox für WMS-Auftrag
    /// </summary>
    public string? ShippingBox { get; set; }

    /// <summary>
    /// Externe Rechnung des Auftrags
    /// </summary>
    public byte IstExterneRechnung { get; set; }

    /// <summary>
    /// Interne ID der Versandart
    /// </summary>
    public int? ShippingMethodInternalId { get; set; }

    /// <summary>
    /// ISO der Sprache
    /// </summary>
    public string? LanguageIso { get; set; }

    /// <summary>
    /// Anmerkung zum Auftrag
    /// </summary>
    public string? SalesOrderNote { get; set; }

    /// <summary>
    /// Mit Expressversand
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Interne Benutzer-ID
    /// </summary>
    public int UserInternalId { get; set; }

    /// <summary>
    /// Umsatzsteuer-ID des Auftrags
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    /// <summary>
    /// Rechnung als PDF vorhanden
    /// </summary>
    public bool? HasInvoiceAsPdf { get; set; }

    /// <summary>
    /// Versandanmerkung als PDF vorhanden
    /// </summary>
    public bool? HasDeliveryNoteAsPdf { get; set; }

    public string SalesQuotationNumber { get; set; } = null!;
}
