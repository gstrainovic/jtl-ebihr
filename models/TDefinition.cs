using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDefinition
{
    public int KDefinition { get; set; }

    public string CName { get; set; } = null!;

    public string CStockFormula { get; set; } = null!;

    public string CPriceFormula { get; set; } = null!;

    public int? KBaseDefinition { get; set; }

    public int? KMassEinheit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TBillOfMaterialComponent> TBillOfMaterialComponents { get; set; } = new List<TBillOfMaterialComponent>();

    public virtual ICollection<TDefinitionSprache> TDefinitionSpraches { get; set; } = new List<TDefinitionSprache>();

    public virtual ICollection<TDimension> TDimensions { get; set; } = new List<TDimension>();
}
