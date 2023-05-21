using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VDeletableFile
{
    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DErstellDatum { get; set; }

    public string CFileHash { get; set; } = null!;

    public string CFileName { get; set; } = null!;

    public string CFileType { get; set; } = null!;

    public int NFileSizeKb { get; set; }
}
