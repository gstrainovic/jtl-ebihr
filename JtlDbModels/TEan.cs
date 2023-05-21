using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEan
{
    public string CEan { get; set; } = null!;

    public DateTime? DImportdatum { get; set; }

    public DateTime? DLockDate { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
