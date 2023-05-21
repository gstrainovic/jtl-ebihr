using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VIduUpload
{
    public int KIduUploadQueue { get; set; }

    public int KBeleg { get; set; }

    public byte NBelegtyp { get; set; }

    public string CBelegnummer { get; set; } = null!;

    public string? CBezugsbelegnummer { get; set; }

    public string COrderId { get; set; } = null!;

    public int KUser { get; set; }

    public int NUploadVersuche { get; set; }

    public byte NStatus { get; set; }

    public int? KFile { get; set; }

    public byte[]? BData { get; set; }

    public DateTime? DFileErstelltUtc { get; set; }

    public string? CFileName { get; set; }
}
