using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Vatclass
{
    public int VatclassId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
