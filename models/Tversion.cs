﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tversion
{
    public string? CVersion { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
