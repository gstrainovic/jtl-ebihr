using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEntityPlatform
{
    public int KEntityId { get; set; }

    public byte NEntityType { get; set; }

    public int KShop { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }

    public byte[] BLastChanged { get; set; } = null!;
}
