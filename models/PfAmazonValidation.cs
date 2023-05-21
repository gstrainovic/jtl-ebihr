using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonValidation
{
    public string CName { get; set; } = null!;

    public int? MinLength { get; set; }

    public int? MaxLength { get; set; }

    public string? CPattern { get; set; }

    public string? CType { get; set; }

    public int? ArraySize { get; set; }

    public int? MinOccurs { get; set; }

    public int? MaxOccurs { get; set; }
}
