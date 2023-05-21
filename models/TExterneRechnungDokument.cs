using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExterneRechnungDokument
{
    public int KExterneRechnungDokument { get; set; }

    public int KExterneRechnung { get; set; }

    public string CBeschreibung { get; set; } = null!;

    public string? CUrl { get; set; }

    public string? CContentType { get; set; }

    public byte[]? BContent { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TExterneRechnung KExterneRechnungNavigation { get; set; } = null!;
}
