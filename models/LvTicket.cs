using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvTicket
{
    public int KTicket { get; set; }

    public int? KKunde { get; set; }

    public string CEindeutigeId { get; set; } = null!;

    public string? CTitel { get; set; }

    public string? CStatusName { get; set; }

    public byte NPrioritaet { get; set; }

    public DateTime? DErstellung { get; set; }

    public bool NIstInPapierkorb { get; set; }

    public bool NVollstaendigAngelegt { get; set; }
}
