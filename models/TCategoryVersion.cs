using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCategoryVersion
{
    public int KCategoryVersion { get; set; }

    public string CChannel { get; set; } = null!;

    public string CCategoryTreeVersion { get; set; } = null!;

    public bool NVersionChanged { get; set; }
}
