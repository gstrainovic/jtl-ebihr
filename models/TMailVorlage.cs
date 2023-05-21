using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMailVorlage
{
    public int KMailVorlage { get; set; }

    public int KSprache { get; set; }

    public byte? NType { get; set; }

    public int KPlattform { get; set; }

    public byte? NStandard { get; set; }

    public string? CVorlagenname { get; set; }

    public string? CSubject { get; set; }

    public string? CText { get; set; }

    public byte? NHtml { get; set; }

    public string? CHtml { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
