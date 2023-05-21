using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class DeliveryNoteFbabarcode
{
    public int DeliveryNoteInternalId { get; set; }

    public string? Fbabarcode { get; set; }
}
