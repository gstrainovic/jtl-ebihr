using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayBeschreibungstemplate
{
    public int KEbayBeschreibungsTemplate { get; set; }

    public int KEbayuser { get; set; }

    public int KItem { get; set; }

    public string? CTitel { get; set; }

    public string? CH1 { get; set; }

    public string? CH2 { get; set; }

    public string? CBody { get; set; }

    public string? CVersandhinweis { get; set; }

    public string? PaymentInstructions { get; set; }
}
