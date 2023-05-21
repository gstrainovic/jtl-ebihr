using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMetaDataChanged
{
    public int KMetaDataChanged { get; set; }

    public string? CType { get; set; }

    public string? CResource { get; set; }

    public string? CSellerId { get; set; }

    public int? KChannel { get; set; }

    public DateTime? DCreatedAfter { get; set; }

    public byte NApiModeType { get; set; }
}
