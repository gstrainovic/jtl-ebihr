using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Company1
{
    /// <summary>
    /// Interne Firmen-ID der Tabelle tFirma
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Enthält den Firmennamen
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Enthält den Unternehmer der Firma
    /// </summary>
    public string? ManagingDirector { get; set; }

    /// <summary>
    /// Strasse der Firma
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// PLZ der Firma
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Ort der Firma
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Land der Firma
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Telefonnummer der Firma
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Faxnummer der Firma
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// E-Mail-Adresse der Firma
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// URL der Website der Firma
    /// </summary>
    public string? WebsiteUrl { get; set; }

    /// <summary>
    /// Name der Bank des Firmenkontos
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Steuernummer der Firma
    /// </summary>
    public string? FederalTaxId { get; set; }

    /// <summary>
    /// IBAN des Firmenkontos
    /// </summary>
    public string? Iban { get; set; }

    /// <summary>
    /// BIC des Firmenkontos
    /// </summary>
    public string? Bic { get; set; }

    /// <summary>
    /// Inhaber des Firmenkontos
    /// </summary>
    public string? AccountHolder { get; set; }

    /// <summary>
    /// ISO-Code des Firmenlandes
    /// </summary>
    public string? CountryIso { get; set; }

    /// <summary>
    /// USt-IdNr. der Firma
    /// </summary>
    public string? ValueAddedTaxId { get; set; }

    /// <summary>
    /// Gläubiger-ID
    /// </summary>
    public string? CreditorId { get; set; }

    /// <summary>
    /// E-Mail-Adresse des PayPal-Kontos
    /// </summary>
    public string? PayPalEmail { get; set; }
}
