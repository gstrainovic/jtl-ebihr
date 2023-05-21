﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PaymentTypeName
{
    public int PaymentTypeId { get; set; }

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
