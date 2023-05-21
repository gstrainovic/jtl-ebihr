using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOffenerPostenEingangsrechnung
{
    public int KEingangsrechnung { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte? NDeleted { get; set; }

    public byte? NStatus { get; set; }

    public DateTime? DBelegdatum { get; set; }

    public decimal? FWert { get; set; }

    public decimal? FZahlung { get; set; }

    public decimal? FWertOffen { get; set; }

    public string CStandardWaehrungIso { get; set; } = null!;
}
