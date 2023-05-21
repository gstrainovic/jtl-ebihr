using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDownload
{
    public int KDownload { get; set; }

    public string? CId { get; set; }

    public string? CPfad { get; set; }

    public string? CPfadVorschau { get; set; }

    public int? NAnzahl { get; set; }

    public int? NTage { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
