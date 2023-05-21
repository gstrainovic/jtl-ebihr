using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPreisExportVorlage
{
    public int KPreisExportVorlage { get; set; }

    public string? CName { get; set; }

    public int? KPlattform { get; set; }

    public int? KKundengruppe { get; set; }

    public string? SMapping { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
