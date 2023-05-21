using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPaymentRule
{
    public int KPaymentRule { get; set; }

    public int KChannel { get; set; }

    public string CPaymentMethodId { get; set; } = null!;

    public string? CDisplayName { get; set; }

    public int KShop { get; set; }

    public int? KZahlungsart { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;
}
