using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProdItem
{
    public int KArtikel { get; set; }

    public byte NLotType { get; set; }

    public byte NProductType { get; set; }

    public bool NCustomOverUpload { get; set; }

    public bool NCustomOverAmazonCustoms { get; set; }

    public bool NCustomOverVariationen { get; set; }

    public bool NCustomOverKonfigurationen { get; set; }

    public int? KSharedLotSize { get; set; }

    public bool NUndefinedResultAllowed { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NDestructionMode { get; set; }

    public bool NProductionLine { get; set; }

    public bool NVariable { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastChanged { get; set; }

    public int? KBenutzerLastChange { get; set; }

    public bool NSubsetDivision { get; set; }

    public int? KItemLabelPrintTemplate { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TVorlagenset? KItemLabelPrintTemplateNavigation { get; set; }

    public virtual ICollection<TAdditionalResult> TAdditionalResults { get; set; } = new List<TAdditionalResult>();

    public virtual ICollection<TBillOfMaterial> TBillOfMaterials { get; set; } = new List<TBillOfMaterial>();

    public virtual ICollection<TDisposition> TDispositions { get; set; } = new List<TDisposition>();

    public virtual ICollection<TLotSize> TLotSizes { get; set; } = new List<TLotSize>();

    public virtual ICollection<TProdCondition> TProdConditions { get; set; } = new List<TProdCondition>();

    public virtual ICollection<TProductionOrderProducible> TProductionOrderProducibles { get; set; } = new List<TProductionOrderProducible>();

    public virtual ICollection<TWorkJob> TWorkJobs { get; set; } = new List<TWorkJob>();
}
