using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUserControlSetting
{
    public int KBenutzer { get; set; }

    public string CName { get; set; } = null!;

    public string CNameTopLevelControl { get; set; } = null!;

    public byte NSetting { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
