using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ProductCategory
{
    public int ProductId { get; set; }

    public int Id { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
