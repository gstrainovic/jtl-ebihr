using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Warehouse1
{
    /// <summary>
    /// Interne ID des Warenlagers
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Name des Warenlagers
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Kürzel des Warenlagers
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Beschreibung des Warenlagers
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Strasse des Warenlagers
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// PLZ des Warenlagers
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Ort des Warenlagers
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Land des Warenlagers
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Bundesland des Warenlagers
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Anrede des Ansprechpartners
    /// </summary>
    public string? ContactSalutation { get; set; }

    /// <summary>
    /// Vorname des Ansprechpartners
    /// </summary>
    public string? ContactFirstName { get; set; }

    /// <summary>
    /// Nachname des Ansprechpartners
    /// </summary>
    public string? ContactLastName { get; set; }

    /// <summary>
    /// Telefonnummer des Ansprechpartners
    /// </summary>
    public string? ContactPhoneNumber { get; set; }

    /// <summary>
    /// Faxnummer des Ansprechpartners
    /// </summary>
    public string? ContactFax { get; set; }

    /// <summary>
    /// E-Mail-Adresse des Ansprechpartners
    /// </summary>
    public string? ContactEmailAddress { get; set; }

    /// <summary>
    /// Abteilung des Ansprechpartners
    /// </summary>
    public string? ContactDepartment { get; set; }

    /// <summary>
    /// Typ des Warenlagers (Fulfillment, JTL-Wawi, JTL-WMS usw.)
    /// </summary>
    public string WarehouseType { get; set; } = null!;
}
