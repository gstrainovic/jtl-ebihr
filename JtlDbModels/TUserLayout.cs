using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TUserLayout
{
    public int KUserLayout { get; set; }

    public int KBenutzer { get; set; }

    public string CName { get; set; } = null!;

    public string CWert { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
