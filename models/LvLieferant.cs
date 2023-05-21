using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvLieferant
{
    public int KLieferant { get; set; }

    public string? CLieferantennummer { get; set; }

    public string? CFirma { get; set; }

    public string? CFirmaZusatz { get; set; }

    public string? CKontakt { get; set; }

    public string? CTelZentrale { get; set; }

    public string? CTelDurchwahl { get; set; }

    public string? CFax { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CEigeneKundennummer { get; set; }

    public string? CPlz { get; set; }

    public string? CStrasse { get; set; }

    public string? CEmail { get; set; }

    public string CSprache { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public byte NIstJtlFulfillment { get; set; }
}
