using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonGroup
{
    public int KGroup { get; set; }

    public string CName { get; set; } = null!;

    public int KPlattform { get; set; }

    public byte? NAktiv { get; set; }
}
