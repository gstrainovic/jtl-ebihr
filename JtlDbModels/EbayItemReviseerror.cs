﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayItemReviseerror
{
    public int KItemReviseError { get; set; }

    public int KEbayuser { get; set; }

    public int KItem { get; set; }

    public string? ShortMessage { get; set; }

    public string? LongMessage { get; set; }

    public string? CAbhilfe { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public string? EpidSuggestion { get; set; }
}
