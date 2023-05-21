using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VExterneRechnungTransaktionstyp
{
    public int? Verkauf { get; set; }

    public int? Ruecksendung { get; set; }

    public int? Erstattung { get; set; }
}
