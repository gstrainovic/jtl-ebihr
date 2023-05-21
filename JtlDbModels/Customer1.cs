using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Customer1
{
    /// <summary>
    /// Interne Kunden-ID
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Kundennummer
    /// </summary>
    public string? CustomerNumber { get; set; }

    /// <summary>
    /// Gibt den Rabatt in Prozent an
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Enthält die Debitorennummer
    /// </summary>
    public int? AccountsReceivableNumber { get; set; }

    /// <summary>
    /// Enthält die Handelsregisternr. des Kunden
    /// </summary>
    public string? CompanyRegistrationNumber { get; set; }

    /// <summary>
    /// URL der Website des Kunden
    /// </summary>
    public string? WebsiteUrl { get; set; }

    /// <summary>
    /// Gibt an, ob der Kunde aktiv oder inaktiv gesetzt ist
    /// </summary>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gibt an, ob der Kunde gesperrt ist
    /// </summary>
    public bool? IsLocked { get; set; }

    /// <summary>
    /// Gibt an, ob es sich um einen Kassenkunden handelt
    /// </summary>
    public bool? IsCashPayer { get; set; }

    /// <summary>
    /// Kunde von Firma?
    /// </summary>
    public bool? IsRepresentative { get; set; }

    /// <summary>
    /// Gibt das Kreditlimit des Kunden an
    /// </summary>
    public int? CreditLimit { get; set; }

    /// <summary>
    /// Enthält die Steuernummer des Kunden
    /// </summary>
    public string? FederalTaxId { get; set; }

    /// <summary>
    /// Gibt das Zahlungsziel des Kunden in Tagen an
    /// </summary>
    public int? TermOfPayment { get; set; }

    /// <summary>
    /// ISO-Code der Sprache des Kunden
    /// </summary>
    public string? LanguageIso { get; set; }

    /// <summary>
    /// Gibt die Herkunftsplattform (Amazon, eBay usw.) des Kunden an
    /// </summary>
    public string? Source { get; set; }

    /// <summary>
    /// Gibt das Shopguthaben des Kunden an
    /// </summary>
    public decimal? Credit { get; set; }

    /// <summary>
    /// Interne Kundengruppen-ID
    /// </summary>
    public int? CustomerGroupInternalId { get; set; }

    /// <summary>
    /// Geburtsdatum des Kunden
    /// </summary>
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// Erstelldatum des Kunden in der Datenbank
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Auftrags-ID des Kunden
    /// </summary>
    public string? OperationId { get; set; }

    /// <summary>
    /// Interne ID der Zahlungsart
    /// </summary>
    public int? PaymentMethodInternalId { get; set; }

    public int? LanguageInternalId { get; set; }
}
