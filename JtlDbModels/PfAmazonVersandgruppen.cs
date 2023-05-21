using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonVersandgruppen
{
    public int KAmazonVersandgruppe { get; set; }

    public int KUser { get; set; }

    public string CName { get; set; } = null!;
}
