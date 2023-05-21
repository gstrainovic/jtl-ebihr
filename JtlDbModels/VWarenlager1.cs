using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VWarenlager1
{
    public int KWarenLager { get; set; }

    public string? CName { get; set; }

    public string? CKuerzel { get; set; }

    public string? CLagerTyp { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public byte NFulfillment { get; set; }
}
