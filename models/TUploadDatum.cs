using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUploadDatum
{
    public int KUploadData { get; set; }

    public byte[]? BData { get; set; }

    public int? KRechnung { get; set; }

    public byte NType { get; set; }

    public int NFileSizeKb { get; set; }

    public byte NCount { get; set; }

    public string? CName { get; set; }

    public int? KGutschrift { get; set; }
}
