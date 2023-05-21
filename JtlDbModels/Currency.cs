using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Currency
{
    /// <summary>
    /// Interne ID der Währungs
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Name der Währung
    /// </summary>
    public string? CurrencyName { get; set; }

    /// <summary>
    /// Name der Währung für HTML-Ausgabe
    /// </summary>
    public string? CurrencyNameHtml { get; set; }

    /// <summary>
    /// Umrechnungsfaktor zur Fremdwährung
    /// </summary>
    public decimal Factor { get; set; }

    /// <summary>
    /// ISO-Code der Währungsangabe
    /// </summary>
    public string CurrencyIso { get; set; } = null!;

    /// <summary>
    /// Gibt an, ob es die Standardwährung ist
    /// </summary>
    public bool? Default { get; set; }
}
