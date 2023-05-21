using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerNumber { get; set; }

    public int? CustomerGroupId { get; set; }

    public int? CustomerCategoryId { get; set; }

    public DateTime? CreationDate { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
