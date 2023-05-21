using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenlagerOptionenAuftragDetail
{
    public int KWarenlagerOptionenAuftragDetails { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public string? CCustomName { get; set; }

    public int NSprache { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
