using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBackup
{
    public byte? KBackup { get; set; }

    public string? DDatum { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
