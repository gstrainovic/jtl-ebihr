﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellungAttribute
{
    public int KBestellungAttribute { get; set; }

    public int KBestellung { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }
}
