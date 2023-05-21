using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PurchaseOrderBillToAddress
{
    /// <summary>
    /// Interne ID der Adresse
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Firma der Adresse
    /// </summary>
    public string Company { get; set; } = null!;

    /// <summary>
    /// Firmenzusatz des Empfängers
    /// </summary>
    public string CompanySupplement { get; set; } = null!;

    /// <summary>
    /// Anrede des Empfängers
    /// </summary>
    public string Salutation { get; set; } = null!;

    /// <summary>
    /// Titel des Empfängers
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Vorname des Empfängers
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Nachname des Empfängers
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Strasse des Empfängers
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Adresszusatz des Empfängers
    /// </summary>
    public string AddressSupplement { get; set; } = null!;

    /// <summary>
    /// PLZ des Empfängers
    /// </summary>
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// Ort des Empfängers
    /// </summary>
    public string City { get; set; } = null!;

    /// <summary>
    /// Bundesland des Empfängers
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// ISO-Code des Landes des Empfängers
    /// </summary>
    public string CountryIso { get; set; } = null!;

    /// <summary>
    /// Telefonnummer des Empfängers
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// Faxnummer des Empfängers
    /// </summary>
    public string Fax { get; set; } = null!;

    /// <summary>
    /// Mobilnummer des Empfängers
    /// </summary>
    public string MobilePhone { get; set; } = null!;

    /// <summary>
    /// E-Mail-Adresse des Empfängers
    /// </summary>
    public string EmailAddress { get; set; } = null!;
}
