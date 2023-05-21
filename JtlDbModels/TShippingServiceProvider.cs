using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShippingServiceProvider
{
    public int KShippingServiceProvider { get; set; }

    public byte NShippingServiceProviderType { get; set; }

    public byte NTrackingServiceProviderType { get; set; }

    public byte NOrderNo { get; set; }

    public byte NBeta { get; set; }

    public byte NVisible { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
