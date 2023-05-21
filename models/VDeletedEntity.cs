using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VDeletedEntity
{
    public int KEntityId { get; set; }

    public byte NEntityType { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }
}
