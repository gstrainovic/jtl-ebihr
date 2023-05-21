using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmretourenEtikett
{
    public int KRmretourenEtikett { get; set; }

    public int KRmretoure { get; set; }

    public string? CIdentCode { get; set; }

    public byte[]? BLabel { get; set; }

    public string? CHash { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? KVersandArt { get; set; }

    public int? KBenutzer { get; set; }

    public string? CVersandArtManuell { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
