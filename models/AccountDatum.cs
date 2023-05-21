using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AccountDatum
{
    /// <summary>
    /// Interne ID der Kontodeten
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Enthält die interne Kunden-ID zur Verknüpfung auf die Kundentabelle
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Enthält den Namen des Bankinstituts
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    /// Name des Kontoinhabers
    /// </summary>
    public string? AccountHolder { get; set; }

    /// <summary>
    /// Enthält die IBAN
    /// </summary>
    public string? Iban { get; set; }

    /// <summary>
    /// Enthält die BIC
    /// </summary>
    public string? Bic { get; set; }
}
