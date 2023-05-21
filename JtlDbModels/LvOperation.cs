using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvOperation
{
    public int KOperation { get; set; }

    public string COperationNumber { get; set; } = null!;

    public string CName { get; set; } = null!;

    public DateTimeOffset Erstelldatum { get; set; }

    public DateTimeOffset Bearbeitungsdatum { get; set; }

    public string? Bearbeiter { get; set; }

    public string? Labels { get; set; }

    public bool NIsInternal { get; set; }

    public bool NIsInactive { get; set; }

    public bool NIsCompletionMandatory { get; set; }
}
