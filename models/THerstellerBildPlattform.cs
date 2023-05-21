using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class THerstellerBildPlattform
{
    public int KHerstellerBildPlattform { get; set; }

    public int KHersteller { get; set; }

    public int? KPlattform { get; set; }

    public int? KShop { get; set; }

    public int? KBild { get; set; }

    public byte? NInet { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
