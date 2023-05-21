using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VProductAttribute
{
    public int KProduct { get; set; }

    public string CName { get; set; } = null!;

    public decimal FPrice { get; set; }

    public int NSort { get; set; }

    public int KType { get; set; }

    public string? CGroup { get; set; }
}
