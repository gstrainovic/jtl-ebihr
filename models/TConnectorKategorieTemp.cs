using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TConnectorKategorieTemp
{
    public string? CVaterEndpointId { get; set; }

    public int? KKindKategorie { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
