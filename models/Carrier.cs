﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Carrier
{
    public int CarrierId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ChangeDate { get; set; }

    public byte[]? LastChange { get; set; }
}
