using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VXsellGruppe
{
    public int KXsellGruppe { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }
}
