using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMessage
{
    public int KMessages { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferant { get; set; }

    public string? SBereff { get; set; }

    public string? SText { get; set; }

    public string? SSentMailDate { get; set; }

    public string? SSentFaxDate { get; set; }

    public byte? NType { get; set; }

    public string? SHtmltext { get; set; }

    public string? SAttachment { get; set; }

    public int? KFirma { get; set; }

    public int? KAnsprechpartner { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
