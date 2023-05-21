using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantReturnItem
{
    public int KRmretourePos { get; set; }

    public int KRmretoure { get; set; }

    public string? Jfsku { get; set; }

    public string? MerchantSku { get; set; }

    public decimal WawiQuantity { get; set; }

    public decimal? ApiQuantity { get; set; }

    public string? OutboundId { get; set; }

    public string? OutboundItemId { get; set; }

    public int GrundPk { get; set; }

    public string? GrundKommentar { get; set; }
}
