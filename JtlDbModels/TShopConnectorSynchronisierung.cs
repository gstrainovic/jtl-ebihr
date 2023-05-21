using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopConnectorSynchronisierung
{
    public int KShop { get; set; }

    public int NEntity { get; set; }

    public byte? NPush { get; set; }

    public byte? NPull { get; set; }

    public byte NDelete { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
