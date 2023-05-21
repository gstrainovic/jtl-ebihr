using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMandant
{
    public int KMandant { get; set; }

    public string? CName { get; set; }

    public string? CDb { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
