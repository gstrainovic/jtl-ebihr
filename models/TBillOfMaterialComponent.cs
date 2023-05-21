using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBillOfMaterialComponent
{
    public int KBillOfMaterialComponent { get; set; }

    public int KBillOfMaterial { get; set; }

    public int? KArtikel { get; set; }

    public int? KOperation { get; set; }

    public decimal NQuantity { get; set; }

    public int NSort { get; set; }

    public int? KMassEinheit { get; set; }

    public bool NSharedPart { get; set; }

    public int? KParentBillOfMaterialComponent { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal FRestFactor { get; set; }

    public bool NDestroyable { get; set; }

    public bool NVariable { get; set; }

    public int? KSubsetDefinition { get; set; }

    public int? KOperationStep { get; set; }

    public byte NComponentPostingsShelfLifeEndDateRequirements { get; set; }

    public byte NComponentPostingsBatchNumberRequirements { get; set; }

    public virtual ICollection<TBillOfMaterialComponent> InverseKParentBillOfMaterialComponentNavigation { get; set; } = new List<TBillOfMaterialComponent>();

    public virtual TArtikel? KArtikelNavigation { get; set; }

    public virtual TBillOfMaterial KBillOfMaterialNavigation { get; set; } = null!;

    public virtual TOperationStep? KOperationStepNavigation { get; set; }

    public virtual TBillOfMaterialComponent? KParentBillOfMaterialComponentNavigation { get; set; }

    public virtual TDefinition? KSubsetDefinitionNavigation { get; set; }

    public virtual ICollection<TBillOfMaterialComponentsSubset> TBillOfMaterialComponentsSubsets { get; set; } = new List<TBillOfMaterialComponentsSubset>();

    public virtual ICollection<TLotPreparationComponent> TLotPreparationComponents { get; set; } = new List<TLotPreparationComponent>();

    public virtual ICollection<TWorkJobBillOfMaterialsComponent> TWorkJobBillOfMaterialsComponents { get; set; } = new List<TWorkJobBillOfMaterialsComponent>();

    public virtual ICollection<TWorkJobOperation> TWorkJobOperations { get; set; } = new List<TWorkJobOperation>();
}
