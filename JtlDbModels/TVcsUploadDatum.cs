using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVcsUploadDatum
{
    public int KVcsUploadData { get; set; }

    public byte[]? BData { get; set; }

    public int KBenutzer { get; set; }

    public int? KRechnung { get; set; }

    public int? KGutschrift { get; set; }

    public DateTime DErstellDatum { get; set; }

    public string? CFileHash { get; set; }

    public string? CFileName { get; set; }

    public int NFileSizeKb { get; set; }

    public byte NStatus { get; set; }
}
