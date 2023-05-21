using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Vatclass
{
    public int VatclassId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
