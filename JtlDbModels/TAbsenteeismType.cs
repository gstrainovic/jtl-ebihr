using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAbsenteeismType
{
    public int KAbsenteeismType { get; set; }

    public string CName { get; set; } = null!;

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TResourceAbsenteeism> TResourceAbsenteeisms { get; set; } = new List<TResourceAbsenteeism>();
}
