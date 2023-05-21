﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ProductName
{
    public int ProductId { get; set; }

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
