﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBundesland
{
    public string CIsoland { get; set; } = null!;

    public string CBundesland { get; set; } = null!;

    public string CKuerzelBundesland { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
