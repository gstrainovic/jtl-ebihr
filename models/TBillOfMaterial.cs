using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBillOfMaterial
{
    public int KBillOfMaterial { get; set; }

    public int KArtikel { get; set; }

    public int NVersion { get; set; }

    public string CName { get; set; } = null!;

    public byte NState { get; set; }

    public string CComment { get; set; } = null!;

    public string CHash { get; set; } = null!;

    public int? KParentBillOfMaterial { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset? DActive { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public DateTimeOffset? DLastChanged { get; set; }

    public int? KBenutzerLastChanged { get; set; }

    public byte NType { get; set; }

    public byte NComponentPostingsShelfLifeEndDateRequirements { get; set; }

    public byte NComponentPostingsBatchNumberRequirements { get; set; }

    public decimal FCalculatedStock { get; set; }

    public DateTimeOffset? DCalculatedStockTimeStamp { get; set; }

    public byte? NShelfLifeEndDateGenerationMode { get; set; }

    public long? NAdditionalShelfLifeEndDateTime { get; set; }

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;

    public virtual ICollection<TBillOfMaterialComponent> TBillOfMaterialComponents { get; set; } = new List<TBillOfMaterialComponent>();

    public virtual ICollection<TProductionOrderProducible> TProductionOrderProducibles { get; set; } = new List<TProductionOrderProducible>();

    public virtual ICollection<TWorkJob> TWorkJobs { get; set; } = new List<TWorkJob>();
}
