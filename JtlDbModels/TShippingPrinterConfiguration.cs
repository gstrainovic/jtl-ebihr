using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShippingPrinterConfiguration
{
    public int KShippingDruckDetaileinstellung { get; set; }

    public int NShippingServiceProviderType { get; set; }

    public string CRechnername { get; set; } = null!;

    public int KBenutzer { get; set; }

    public string CDruckerName { get; set; } = null!;

    public int NPageScaling { get; set; }

    public int NOrientation { get; set; }

    public int NExemplare { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte KPrintDocumentType { get; set; }
}
