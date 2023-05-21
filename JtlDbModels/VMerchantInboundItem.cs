using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantInboundItem
{
    public int KLieferantenBestellungPos { get; set; }

    public int KLieferantenBestellung { get; set; }

    public string? SupplierSku { get; set; }

    public string? SupplierProductName { get; set; }

    public decimal Quantity { get; set; }

    public string? Note { get; set; }

    public string? Jfsku { get; set; }

    public int KArtikel { get; set; }
}
