using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantPendingLieferavi
{
    public int KLieferavis { get; set; }

    public int KLieferantenBestellung { get; set; }

    public DateTime DErstellt { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public string CNummer { get; set; } = null!;

    public string? CNotiz { get; set; }

    public string? CInboundId { get; set; }
}
