using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMarktplatz
{
    public int KMarktplatz { get; set; }

    public int KUser { get; set; }

    public int NPlattform { get; set; }

    public byte NAktiv { get; set; }

    public virtual PfUser KUserNavigation { get; set; } = null!;
}
