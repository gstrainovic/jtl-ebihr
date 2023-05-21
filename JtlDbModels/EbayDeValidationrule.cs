using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDeValidationrule
{
    public int? AttributeId { get; set; }

    public int? AttributeSetId { get; set; }

    public string? Name { get; set; }

    public int? PeerAttributeId { get; set; }

    public string? CSeparator { get; set; }

    public decimal FMin { get; set; }

    public decimal FMax { get; set; }

    public string? Mask { get; set; }

    public byte? Precistion { get; set; }

    public string? Regex { get; set; }

    public short? NLength { get; set; }
}
