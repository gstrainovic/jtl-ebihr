﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLand
{
    public string CIso { get; set; } = null!;

    public string? CName { get; set; }

    public string? CNameEng { get; set; }

    public byte? NEu { get; set; }

    public string? CKontinent { get; set; }

    public string? CNameFra { get; set; }

    public string? CIso3 { get; set; }

    public int NIsonumeric { get; set; }

    public string CWaehrung { get; set; } = null!;

    public string? CDefaultCulture { get; set; }
}
