﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBestellungAttribute
{
    public int KBestellungAttribute { get; set; }

    public int KBestellung { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
