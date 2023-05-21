using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLlvorlage
{
    public int KLlvorlage { get; set; }

    public int? NTyp { get; set; }

    public string? DDatum { get; set; }

    public string? CKommentar { get; set; }

    public string? CName { get; set; }

    public byte[]? BData { get; set; }

    public int? NDatasize { get; set; }

    public byte[]? BPreview { get; set; }

    public int? NPreviewsize { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
