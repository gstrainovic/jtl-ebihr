using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMedienFile
{
    public int KMedienFile { get; set; }

    public int KMedienDir { get; set; }

    public string CName { get; set; } = null!;

    public int? NSize { get; set; }

    public DateTime? DTime { get; set; }

    public short? NDel { get; set; }

    public int KShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
