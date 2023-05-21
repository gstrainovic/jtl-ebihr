using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class User
{
    /// <summary>
    /// Interne ID des Benutzers
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Name des Benutzers
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int CompanyInternalId { get; set; }

    /// <summary>
    /// Telefonnummer
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// E-Mail-Adresse
    /// </summary>
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Abteilung des Benutzers
    /// </summary>
    public string? Department { get; set; }

    /// <summary>
    /// Faxnummer
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Mobilnummer
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Hinweis zum Benutzer
    /// </summary>
    public string? Note { get; set; }
}
