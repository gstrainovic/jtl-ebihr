using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZustand
{
    public int KZustand { get; set; }

    public string CSuffix { get; set; } = null!;

    public byte NAktiv { get; set; }

    public string? CColor { get; set; }

    public byte NTyp { get; set; }

    public byte NEinschraenkung { get; set; }

    public int NCode { get; set; }

    public int NEbayCode { get; set; }

    public int NAmazonCode { get; set; }

    public int? NSort { get; set; }

    public byte NLieferantenEntfernen { get; set; }

    public int NFfncode { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool? NDeletableByUser { get; set; }

    public int? KScxcondition { get; set; }

    public virtual TCondition? KScxconditionNavigation { get; set; }

    public virtual ICollection<TProdCondition> TProdConditions { get; set; } = new List<TProdCondition>();

    public virtual ICollection<TWorkJobResult> TWorkJobResults { get; set; } = new List<TWorkJobResult>();
}
