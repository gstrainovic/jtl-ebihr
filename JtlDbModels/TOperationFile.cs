using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOperationFile
{
    public int KOperationFile { get; set; }

    public int KOperation { get; set; }

    public int KFile { get; set; }

    public string? CName { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TOperation KOperationNavigation { get; set; } = null!;
}
