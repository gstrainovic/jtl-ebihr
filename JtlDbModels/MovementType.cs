using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class MovementType
{
    public int MovementTypeId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
