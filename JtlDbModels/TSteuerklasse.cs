using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSteuerklasse
{
    public int KSteuerklasse { get; set; }

    public string? CName { get; set; }

    public byte? NStandard { get; set; }

    public int NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftragPosition> TAuftragPositions { get; set; } = new List<TAuftragPosition>();

    public virtual ICollection<TRechnungPosition> TRechnungPositions { get; set; } = new List<TRechnungPosition>();
}
