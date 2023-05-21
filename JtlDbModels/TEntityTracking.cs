using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEntityTracking
{
    public int KEntityId { get; set; }

    public byte NEntityType { get; set; }

    public byte NSyncType { get; set; }

    public DateTime? DCreated { get; set; }

    public DateTime? DLastModified { get; set; }

    public byte[] BLastChanged { get; set; } = null!;
}
