using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVouchersToken
{
    public int KVouchers { get; set; }

    public string? CAccessToken { get; set; }

    public virtual TVoucher KVouchersNavigation { get; set; } = null!;
}
