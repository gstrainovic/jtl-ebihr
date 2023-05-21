using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PurchaseOrderSupplier
{
    /// <summary>
    /// Interne ID des Lieferanten der Lieferantenbestellung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Lieferanten
    /// </summary>
    public int SupplierInternalId { get; set; }

    /// <summary>
    /// Firmenname
    /// </summary>
    public string? Company { get; set; }

    /// <summary>
    /// Firmenzusatz des Lieferanten
    /// </summary>
    public string? FirmenSupplement { get; set; }

    /// <summary>
    /// Strasse des Lieferanten
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Adresszusatz des Lieferanten
    /// </summary>
    public string? AddressSupplement { get; set; }

    /// <summary>
    /// PLZ des Lieferanten
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Ort des Lieferanten
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Bundesland des Lieferanten
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// ISO-Code des Landes
    /// </summary>
    public string? CountryIso { get; set; }

    /// <summary>
    /// Telefonnummer des Lieferanten
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Faxnummer des Lieferanten
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Mobilnumme des Lieferanten
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Emailadresse des Lieferanten
    /// </summary>
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Anrede des Ansprechpartners beim Lieferanten
    /// </summary>
    public string? ContactSalutation { get; set; }

    /// <summary>
    /// Vorname des Ansprechpartners beim Lieferanten
    /// </summary>
    public string? ContactFirstName { get; set; }

    /// <summary>
    /// Nachname des Ansprechpartners beim Lieferanten
    /// </summary>
    public string? ContactLastName { get; set; }
}
