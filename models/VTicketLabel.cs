using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VTicketLabel
{
    public int TicketLabelKey { get; set; }

    public int TicketKey { get; set; }

    public int LabelKey { get; set; }

    public string Displayname { get; set; } = null!;

    public string? ColorCode { get; set; }
}
