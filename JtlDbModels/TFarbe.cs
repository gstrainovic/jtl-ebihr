using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFarbe
{
    public int KFarbe { get; set; }

    public int NFarbcode { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftrag> TAuftrags { get; set; } = new List<TAuftrag>();
}
