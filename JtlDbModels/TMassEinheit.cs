using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMassEinheit
{
    public int KMassEinheit { get; set; }

    public string? CCode { get; set; }

    public string? CDisplayCode { get; set; }

    public int? KBezugsMassEinheit { get; set; }

    public decimal FBezugsMassEinheitFaktor { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TArtikelDimension> TArtikelDimensions { get; set; } = new List<TArtikelDimension>();

    public virtual ICollection<TAuftragPositionTeilmengenKonfiguration> TAuftragPositionTeilmengenKonfigurations { get; set; } = new List<TAuftragPositionTeilmengenKonfiguration>();

    public virtual ICollection<TBillOfMaterialComponentsSubset> TBillOfMaterialComponentsSubsets { get; set; } = new List<TBillOfMaterialComponentsSubset>();

    public virtual ICollection<TRechnungPositionTeilmengenKonfiguration> TRechnungPositionTeilmengenKonfigurations { get; set; } = new List<TRechnungPositionTeilmengenKonfiguration>();
}
