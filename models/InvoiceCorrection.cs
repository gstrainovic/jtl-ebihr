using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class InvoiceCorrection
{
    /// <summary>
    /// Interne ID der Rechnungskorrektur
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Rechnung zur Rechnungskorrektur
    /// </summary>
    public int? InvoiceInternalId { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Nummer der Rechnungskorrektur
    /// </summary>
    public string? InvoiceCorrectionNumber { get; set; }

    /// <summary>
    /// Druckdatum der Rechnungskorrektur
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Maildatum der Rechnungskorrektur
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Kurzer Drucktext zur Rechnungskorrektur
    /// </summary>
    public string? ShortText { get; set; }

    /// <summary>
    /// Drucktext zur Rechnungskorrektur
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Preis der Rechnungskorrektur
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gesamtbruttopreis der Rechnungskorrektur
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamtnettopreis der Rechnungskorrektur
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// ISO-Code der Währungsangabe
    /// </summary>
    public string? CurrencyIso { get; set; }

    /// <summary>
    /// Faktor zur Umrechnung der Währung
    /// </summary>
    public decimal CurrencyFactor { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int? CompanyInternalId { get; set; }

    /// <summary>
    /// Interne ID der Sprache
    /// </summary>
    public int? LanguageInternalId { get; set; }

    /// <summary>
    /// Interne ID des Benutzers
    /// </summary>
    public int? UserInternalId { get; set; }

    /// <summary>
    /// Status der Rechnungskorrektur
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Interne ID der Plattform
    /// </summary>
    public int? PlatformInternalId { get; set; }

    /// <summary>
    /// ISO-Code der Versandlandwährung
    /// </summary>
    public string ShipFromCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Faktor zur Umrechnung der Versandlandwährung
    /// </summary>
    public decimal ShipFromCountryCurrencyFactor { get; set; }

    /// <summary>
    /// Nummer der Rechnung
    /// </summary>
    public string InvoiceNumber { get; set; } = null!;

    /// <summary>
    /// Erstelldatum der Rechnungskorrektur
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Text zur Rechnungskorrektur
    /// </summary>
    public string? InvoiceCorrectionText { get; set; }

    /// <summary>
    /// Vargangs-ID der Rechnungskorrektur
    /// </summary>
    public string? OperationId { get; set; }

    /// <summary>
    /// ISO-Code der Sprache der Rechnungskorrektur
    /// </summary>
    public string LanguageIso { get; set; } = null!;

    /// <summary>
    /// Art der Steuerbefreiung in der Rechnungskorrektur
    /// </summary>
    public string ExemptFromVat { get; set; } = null!;

    /// <summary>
    /// ISO des Versandlandes der Rechnungskorrektur
    /// </summary>
    public string ShipFromCountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währung des Steuerlandes der Rechnungskorrektur
    /// </summary>
    public string? TaxCountryCurrencyIso { get; set; }

    /// <summary>
    /// Währungsfaktor des Steuerlandes der Rechnungskorrektur
    /// </summary>
    public decimal TaxCountryCurrencyFactor { get; set; }

    /// <summary>
    /// ISO-Code des Steuerlandes der Rechnungskorrektur
    /// </summary>
    public string TaxCountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code des Ziellandes der Rechnungskorrektur
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// Nettopreis benutzen (Kundengruppe)
    /// </summary>
    public bool? UseNetPrice { get; set; }

    /// <summary>
    /// Umsatzsteuer-ID der Rechnungskorrektur
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    public bool? IsProforma { get; set; }

    public string? SalesOrderNumbers { get; set; }

    public string? ExternalSalesOrderNumbers { get; set; }

    public bool IsCanceled { get; set; }

    public byte IsExternal { get; set; }

    public string? CancellationType { get; set; }

    public DateTime? InvoiceValutaDate { get; set; }

    public string CanceledInvoiceCorrectionNumber { get; set; } = null!;

    public DateTime CanceledInvoiceCorrectionCreationDate { get; set; }
}
