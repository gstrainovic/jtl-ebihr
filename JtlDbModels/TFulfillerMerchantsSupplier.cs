using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFulfillerMerchantsSupplier
{
    public int KFulfillerMerchantsSupplier { get; set; }

    public int KFulfillerEinstellungen { get; set; }

    public int KLieferant { get; set; }

    public int KLieferantenSupplier { get; set; }

    public string? CMerchantSupplierNumber { get; set; }

    public string? CMerchantSupplierName { get; set; }

    public virtual TFulfillerEinstellungen KFulfillerEinstellungenNavigation { get; set; } = null!;
}
