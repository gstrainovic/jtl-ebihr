﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonXmlKat
{
    public int KId { get; set; }

    public int? KIdparent { get; set; }

    public string? CName { get; set; }

    public string? KBrowseNode { get; set; }

    public int? NPlattform { get; set; }

    public int? NEbene { get; set; }
}
