using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProductTakeBack
{
    public int KEbayuser { get; set; }

    public int NSiteId { get; set; }

    public string? CProfileType { get; set; }

    public string? CProfileId { get; set; }

    public string? CProfileName { get; set; }

    public string? CProfileDesc { get; set; }
}
