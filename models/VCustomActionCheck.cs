using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VCustomActionCheck
{
    public string? CName { get; set; }

    public string? CDisplayName { get; set; }

    public string? CDescription { get; set; }

    public string? CObjekt { get; set; }

    public int? NObjekt { get; set; }

    public string? CPkCol { get; set; }

    public int? NParamCount { get; set; }

    public string? CNotAllowedParamTypesInAction { get; set; }

    public string Status { get; set; } = null!;
}
