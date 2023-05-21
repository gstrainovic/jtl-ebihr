using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBillOfMaterialComponent
{
    public int KBillOfMaterialComponent { get; set; }

    public int KBillOfMaterial { get; set; }

    public int? KArtikel { get; set; }

    public int? KOperation { get; set; }

    public decimal NQuantity { get; set; }

    public int NSort { get; set; }

    public int? KOperationStep { get; set; }

    public string? CNumber { get; set; }

    public string? CName { get; set; }

    public int? KMassEinheit { get; set; }

    public int? KArtikelMassEinheit { get; set; }

    public int? KVerkaufsEinheit { get; set; }

    public decimal? FUnitFactor { get; set; }

    public decimal? FMassMenge { get; set; }

    public int NTeilbar { get; set; }

    public bool NSharedPart { get; set; }

    public int? KParentBillOfMaterialComponent { get; set; }

    public byte? NComponentDiscriminator { get; set; }

    public decimal FRestFactor { get; set; }

    public bool NDestroyable { get; set; }

    public bool NVariable { get; set; }

    public byte? NMhd { get; set; }

    public byte? NCharge { get; set; }

    public byte? NSeriennummernVerfolgung { get; set; }

    public bool? NLagerAktiv { get; set; }

    public bool? NArtikelAktiv { get; set; }

    public bool? NSubsetManagement { get; set; }

    public int? KSubsetDefinition { get; set; }

    public decimal? FEknetto { get; set; }

    public decimal? BestandGesamt { get; set; }

    public decimal? BestandEigen { get; set; }

    public decimal? BestandImZulauf { get; set; }

    public decimal? BestandAufEinkaufsliste { get; set; }

    public decimal? BestandInAuftraegen { get; set; }

    public decimal? BestandVerfuegbar { get; set; }

    public decimal? Produzierbar { get; set; }

    public decimal? InProduktion { get; set; }

    public bool? NIsInternalOperation { get; set; }

    public bool? NComponentIsInactive { get; set; }

    public byte NComponentPostingsShelfLifeEndDateRequirements { get; set; }

    public byte NComponentPostingsBatchNumberRequirements { get; set; }
}
