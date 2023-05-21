using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SalesOrderPayment
{
    /// <summary>
    /// Interne ID der Zahlung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Auftrags
    /// </summary>
    public int? SalesOrderInternalId { get; set; }

    /// <summary>
    /// Transaktions-ID
    /// </summary>
    public string? ExternalTransactionId { get; set; }

    /// <summary>
    /// Hinweis zur Zahlung
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Name der Zahlung
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Betrag der Zahlung
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Zahlungsdatum
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Gibt den Typ der Zahlung an
    /// </summary>
    public string PaymentType { get; set; } = null!;

    /// <summary>
    /// Name der Zahlungsart
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Standardkontenrahmen DATEV-Kontenrahmen
    /// </summary>
    public string? StandardChartOfAccountsManual { get; set; }
}
