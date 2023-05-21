using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProductAttrAndValue
{
    public int KAttribut { get; set; }

    public byte NIstFreifeld { get; set; }

    public byte NIstMehrsprachig { get; set; }

    public int KArtikel { get; set; }

    public string? CIso { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }
}
