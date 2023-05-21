using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDimension
{
    public int KDimension { get; set; }

    public int KDefinition { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual TDefinition KDefinitionNavigation { get; set; } = null!;

    public virtual ICollection<TArtikelDimension> TArtikelDimensions { get; set; } = new List<TArtikelDimension>();

    public virtual ICollection<TAuftragPositionTeilmengenKonfiguration> TAuftragPositionTeilmengenKonfigurations { get; set; } = new List<TAuftragPositionTeilmengenKonfiguration>();

    public virtual ICollection<TBillOfMaterialComponentsSubset> TBillOfMaterialComponentsSubsets { get; set; } = new List<TBillOfMaterialComponentsSubset>();

    public virtual ICollection<TDimensionSprache> TDimensionSpraches { get; set; } = new List<TDimensionSprache>();

    public virtual ICollection<TRechnungPositionTeilmengenKonfiguration> TRechnungPositionTeilmengenKonfigurations { get; set; } = new List<TRechnungPositionTeilmengenKonfiguration>();

    public virtual ICollection<TWarenLagerEingangSubsetDetail> TWarenLagerEingangSubsetDetails { get; set; } = new List<TWarenLagerEingangSubsetDetail>();
}
