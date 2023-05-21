using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CostType
{
    public int CostTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Comment { get; set; }

    public DateTime ChangeDate { get; set; }

    public DateTime CreationDate { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
