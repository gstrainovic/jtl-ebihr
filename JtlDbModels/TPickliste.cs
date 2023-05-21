using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPickliste
{
    public int KPickliste { get; set; }

    public int? KWarenLager { get; set; }

    public int? KPicklistenVorlage { get; set; }

    public int? NStatus { get; set; }

    public int? KPicklisteStatus { get; set; }

    public int? KPicklisteStatusAngelegt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public int? KSessionId { get; set; }

    public int? KLieferant { get; set; }

    public int? KAnsprechpartner { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CPicklisteNr { get; set; }

    public int NType { get; set; }

    public virtual TLotPreparationLot? TLotPreparationLot { get; set; }

    public virtual ICollection<TWorkJobOperation> TWorkJobOperations { get; set; } = new List<TWorkJobOperation>();

    public virtual ICollection<TWorkProcessIteration> TWorkProcessIterations { get; set; } = new List<TWorkProcessIteration>();
}
