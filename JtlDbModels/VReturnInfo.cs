using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VReturnInfo
{
    public int KRmretoure { get; set; }

    public int KKunde { get; set; }

    public int? KBestellung { get; set; }

    public int KFirma { get; set; }

    public string? CReturnId { get; set; }

    public byte NStatusTyp { get; set; }

    public int? KWarenlager { get; set; }

    public string? CFfnWarehouseId { get; set; }

    public string? CMerchantId { get; set; }
}
