using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWebshopModule
{
    public string CApikey { get; set; } = null!;

    public string CLizenzkey { get; set; } = null!;

    public string? CName { get; set; }

    public string? CId { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
