using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SalesQuotation
{
    /// <summary>
    /// Interne ID des Angebots
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Nummer des Angebots
    /// </summary>
    public string SalesQuotationNumber { get; set; } = null!;

    /// <summary>
    /// Anmerkung zum Angebot
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Datum des Drucks des Angebots
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Datum des Mailversands
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Erstelldatum des Angebots
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Datum der Lieferung 
    /// </summary>
    public DateTime ServiceDate { get; set; }

    /// <summary>
    /// Zahlungsziel in Tagen
    /// </summary>
    public int? TermOfPayment { get; set; }

    /// <summary>
    /// ISO-Code des Versandlandes im Angebot
    /// </summary>
    public string? ShipFromCountryIso { get; set; }

    /// <summary>
    /// ISO-Code der Versandlandwährungsangabe
    /// </summary>
    public string ShipFromCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Faktor zur Umrechnung der Versandlandwährung
    /// </summary>
    public decimal ShipFromCountryCurrencyFactor { get; set; }

    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währungsangabe
    /// </summary>
    public string? CurrencyIso { get; set; }

    /// <summary>
    /// Faktor zur Umrechnung der Währung
    /// </summary>
    public decimal CurrencyFactor { get; set; }

    /// <summary>
    /// ISO-Code des Steuerlandes im Angebot
    /// </summary>
    public string? TaxCountryIso { get; set; }

    public string TaxCountryCurrencyIso { get; set; } = null!;

    /// <summary>
    /// Währungsfaktor des Steuerlandes im Angebot
    /// </summary>
    public decimal TaxCountryCurrencyFactor { get; set; }

    /// <summary>
    /// Status des Angebots
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Verwendungszweck des Angebots
    /// </summary>
    public string? PaymentReference { get; set; }

    /// <summary>
    /// Zusatzgewicht des Angebots
    /// </summary>
    public decimal ExtraWeight { get; set; }

    /// <summary>
    /// Drucktext für Rechnungskauf
    /// </summary>
    public string? PaymentInfo { get; set; }

    /// <summary>
    /// Kundenangebotsnummer
    /// </summary>
    public string? CustomerSalesQuotationNumber { get; set; }

    /// <summary>
    /// Interne ID der verwendeten Sprache
    /// </summary>
    public int LanguageInternalId { get; set; }

    /// <summary>
    /// Art des Vorgangs (hier Angebot)
    /// </summary>
    public string OperationId { get; set; } = null!;

    /// <summary>
    /// Gibt an, ob Nachnahme als Versandart angegeben ist
    /// </summary>
    public bool? IsShippingMethodCod { get; set; }

    /// <summary>
    /// Name der Zahlungsart
    /// </summary>
    public string? PaymentMethodName { get; set; }

    /// <summary>
    /// Umsatzsteuerfrei
    /// </summary>
    public string ExemptFromVat { get; set; } = null!;

    /// <summary>
    /// Gibt die Plattform an, von der das Angebot kommt
    /// </summary>
    public string Platform { get; set; } = null!;

    /// <summary>
    /// Finanzierungskosten
    /// </summary>
    public decimal FinancingCosts { get; set; }

    /// <summary>
    /// Kundennummer im Angebot
    /// </summary>
    public string? CustomerNumber { get; set; }

    /// <summary>
    /// Nettopreise benutzen
    /// </summary>
    public bool? UseNetPrice { get; set; }

    /// <summary>
    /// Gibt an, ob Rechnungs- und Lieferadresse unterschiedlich sind
    /// </summary>
    public bool? DifferentAddresses { get; set; }

    /// <summary>
    /// Gesamtbruttopreis des Angebots
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamtnettopreis des Angebots
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Kundentext
    /// </summary>
    public string? CustomerText { get; set; }

    /// <summary>
    /// Skontowert des Angebots
    /// </summary>
    public decimal? CashDiscountValue { get; set; }

    /// <summary>
    /// Skonto des Angebots
    /// </summary>
    public decimal? CashDiscount { get; set; }

    /// <summary>
    /// Skontogültigkeitszeitraum in Tagen
    /// </summary>
    public int? CashDiscountValidity { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int CompanyInternalId { get; set; }

    /// <summary>
    /// Interne ID des Kunden im Angebot
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// ISO-Code der Sprache des Angebots
    /// </summary>
    public string? LanguageIso { get; set; }

    /// <summary>
    /// Interne ID des Benutzers im Angebot
    /// </summary>
    public int UserInternalId { get; set; }

    /// <summary>
    /// USt-IdNr. des Angebots
    /// </summary>
    public string? ValueAddedTaxId { get; set; }
}
