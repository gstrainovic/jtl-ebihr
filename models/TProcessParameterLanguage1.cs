using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProcessParameterLanguage1
{
    public int KProcessParameter { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameter1 KProcessParameterNavigation { get; set; } = null!;
}
