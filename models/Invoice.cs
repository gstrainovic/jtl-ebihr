using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Invoice
{
    /// <summary>
    /// Interne ID der Rechnung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Nummer der Rechnung
    /// </summary>
    public string InvoiceNumber { get; set; } = null!;

    /// <summary>
    /// Interne ID der Firma in der Rechnung
    /// </summary>
    public int? CompanyInternalId { get; set; }

    /// <summary>
    /// Druckdatum der Rechnung
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Maildatum der Rechnung
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Erstelldatum der Rechnung
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Drucktext zur Rechnung
    /// </summary>
    public string? InvoicePrintingText { get; set; }

    /// <summary>
    /// Mandatsreferenz des Kunden zur Rechnung
    /// </summary>
    public string? MandateReference { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Zu zahlender Gesamtbruttopreis der Rechnung
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamtnettopreis der Rechnung
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Offene Gesamtsumme der Rechnung
    /// </summary>
    public decimal? OpenGrossPrice { get; set; }

    /// <summary>
    /// Währung des Versandlandes
    /// </summary>
    public string? ShipFromCountryIso { get; set; }

    /// <summary>
    /// Faktor zur Umrechnung in die Versandlandwährung
    /// </summary>
    public string ShipFromCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Währungsfaktor des Versandlandes
    /// </summary>
    public decimal ShipFromCountryCurrencyFactor { get; set; }

    /// <summary>
    /// ISO-Code des Landes der Rechnung
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währung
    /// </summary>
    public string CurrencyIso { get; set; } = null!;

    /// <summary>
    /// Faktor zur Umrechnung in die angegeben Währung
    /// </summary>
    public decimal? CurrencyFactor { get; set; }

    /// <summary>
    /// ISO-Code des Steuerlandes der Rechnung
    /// </summary>
    public string? TaxCountryIso { get; set; }

    /// <summary>
    /// ISO-Code der Währung des Steuerlandes der Rechnung
    /// </summary>
    public string TaxCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Währungsfaktor des Steuerlandes
    /// </summary>
    public decimal TaxCountryCurrencyFactor { get; set; }

    /// <summary>
    /// Zahlungsziel in Tagen für die Rechnung
    /// </summary>
    public int? TermOfPayment { get; set; }

    /// <summary>
    /// Vorgangs-ID der Rechnung
    /// </summary>
    public string OperationId { get; set; } = null!;

    /// <summary>
    /// Skonto der Rechnung
    /// </summary>
    public decimal CashDiscount { get; set; }

    /// <summary>
    /// Skontozeitraum der Rechnung
    /// </summary>
    public int CashDiscountValidity { get; set; }

    /// <summary>
    /// Name der Zahlungsart
    /// </summary>
    public string? PaymentMethodName { get; set; }

    /// <summary>
    /// Ist eine externe Rechnung
    /// </summary>
    public bool? IsExternalInvoice { get; set; }

    /// <summary>
    /// Interne ID der Versandart der Rechnung
    /// </summary>
    public int? ShippingMethodInternalId { get; set; }

    /// <summary>
    /// Art der Steuerbefreiung in der Rechnung
    /// </summary>
    public string ExemptFromVat { get; set; } = null!;

    /// <summary>
    /// Finanzierungskosten
    /// </summary>
    public decimal? FinancingCosts { get; set; }

    /// <summary>
    /// Lieferdatum der Rechnung
    /// </summary>
    public DateTime? ServiceDate { get; set; }

    /// <summary>
    /// Interne ID des (JTL-Wawi) Bearbeiters der Rechnung
    /// </summary>
    public int? UserInternalId { get; set; }

    /// <summary>
    /// Ust-IdNr. der Rechnung
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    /// <summary>
    /// ISO-Code der Sprache der Rechnung
    /// </summary>
    public string? LanguageIso { get; set; }

    /// <summary>
    /// Erstelldatum der Rechnung
    /// </summary>
    public DateTime ValutaDate { get; set; }

    /// <summary>
    /// Name des Shops der Bestellung
    /// </summary>
    public string? ShopName { get; set; }

    /// <summary>
    /// Nettopreise benutzen (Kundengruppe)
    /// </summary>
    public bool? UseNetPrice { get; set; }

    /// <summary>
    /// Rechnung als PDF vorhanden
    /// </summary>
    public bool? HasInvoiceAsPdf { get; set; }

    /// <summary>
    /// Angehängte Dokumente der Rechnung
    /// </summary>
    public byte[]? InvoiceData { get; set; }

    /// <summary>
    /// Bemerkung zur Rechnung
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Hinweis in der Rechnung
    /// </summary>
    public string? InvoiceNote { get; set; }

    public bool IsProforma { get; set; }

    public string? SalesOrderNumbers { get; set; }

    public string? ExternalSalesOrderNumbers { get; set; }

    public bool IsCanceled { get; set; }

    public byte ExternalInvoiceType { get; set; }
}
