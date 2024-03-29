﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SalesOrderAttribute
{
    public int InternalId { get; set; }

    public int SalesOrderInternalId { get; set; }

    public string AttributeName { get; set; } = null!;

    public string? AttributeValue { get; set; }
}
