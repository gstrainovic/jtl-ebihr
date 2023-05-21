using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerCategory
{
    public int CustomerCategoryId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
