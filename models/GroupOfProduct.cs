using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class GroupOfProduct
{
    public int GroupOfProductsId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
