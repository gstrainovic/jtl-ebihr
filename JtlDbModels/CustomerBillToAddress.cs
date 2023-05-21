using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerBillToAddress
{
    /// <summary>
    /// Interne ID der Adresse
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Firmenname des Kunden
    /// </summary>
    public string Company { get; set; } = null!;

    /// <summary>
    /// Anrede des Kunden
    /// </summary>
    public string Salutation { get; set; } = null!;

    /// <summary>
    /// Titel des Kunden
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Vorname des Kunden
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Nachname des Kunden
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Strasse des Kunden
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// PLZ des Kunden
    /// </summary>
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// Wohnort des Kunden
    /// </summary>
    public string City { get; set; } = null!;

    /// <summary>
    /// Land des Kunden
    /// </summary>
    public string Country { get; set; } = null!;

    /// <summary>
    /// Telefonnummer des Kunden
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// Firmenzusatz
    /// </summary>
    public string CompanySupplement { get; set; } = null!;

    /// <summary>
    /// Adresszusatz
    /// </summary>
    public string AddressSupplement { get; set; } = null!;

    /// <summary>
    /// Mobilnummer des Kunden
    /// </summary>
    public string MobilePhone { get; set; } = null!;

    /// <summary>
    /// E-Mail-Adresse des Kunden
    /// </summary>
    public string EmailAddress { get; set; } = null!;

    /// <summary>
    /// Faxnummer des Kunden
    /// </summary>
    public string Fax { get; set; } = null!;

    /// <summary>
    /// Bundesland des Kunden
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// ISO-Code des Landes des Kunden
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// Kundennummer
    /// </summary>
    public string CustomerNumber { get; set; } = null!;

    /// <summary>
    /// USt-IdNr. des Kunden
    /// </summary>
    public string ValueAddedTaxId { get; set; } = null!;

    /// <summary>
    /// die hinterlegte Standardadresse des Kunden
    /// </summary>
    public bool? IsStandard { get; set; }
}
