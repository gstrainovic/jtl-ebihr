using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTextbausteinInhaltSprache
{
    public int KTextbausteinInhaltSprache { get; set; }

    public int KTextbaustein { get; set; }

    public int KFile { get; set; }

    public int KSprache { get; set; }

    public virtual TFile KFileNavigation { get; set; } = null!;

    public virtual TSpracheUsed KSpracheNavigation { get; set; } = null!;

    public virtual TTextbaustein KTextbausteinNavigation { get; set; } = null!;
}
