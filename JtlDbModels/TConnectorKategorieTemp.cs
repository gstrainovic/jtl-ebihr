using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TConnectorKategorieTemp
{
    public string? CVaterEndpointId { get; set; }

    public int? KKindKategorie { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
