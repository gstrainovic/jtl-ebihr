using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VUnkownConditionProduct
{
    public int StockRefPk { get; set; }

    public string? ParentJfsku { get; set; }

    public byte? ParentCondition { get; set; }

    public int ChildProduct { get; set; }

    public string ArtNr { get; set; } = null!;

    public int ChildFfnCondition { get; set; }
}
