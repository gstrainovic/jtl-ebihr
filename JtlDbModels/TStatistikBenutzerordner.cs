using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatistikBenutzerordner
{
    public int KStatistikBenutzerordner { get; set; }

    public int KStatistikBenutzerordnerVater { get; set; }

    public int KBenutzer { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
