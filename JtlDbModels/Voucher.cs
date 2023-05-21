using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Voucher
{
    /// <summary>
    /// Interne ID der Auftragsposition
    /// </summary>
    public int SalesOrderPositionInternalId { get; set; }

    /// <summary>
    /// Bezeichnung für den Gutschein
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Interne Id der Bestellung
    /// </summary>
    public int SalesOrderInternalId { get; set; }

    /// <summary>
    /// Interne Id der Firma
    /// </summary>
    public int CompanyInternalId { get; set; }

    /// <summary>
    /// Grußtext auf dem Gutschein
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Sender (Von) auf dem Gutschein
    /// </summary>
    public string? Sender { get; set; }
}
