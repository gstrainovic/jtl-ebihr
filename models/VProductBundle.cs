using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VProductBundle
{
    public int KArtikel { get; set; }

    public string? Name { get; set; }

    public decimal Quantity { get; set; }

    public string? Ean { get; set; }

    public string? Upc { get; set; }
}
