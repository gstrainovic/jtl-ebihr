using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAbrechnungEinzelnachwei
{
    public int KAbrechnungEinzelnachweis { get; set; }

    public int KAbrechnung { get; set; }

    public int KAbrechnungPos { get; set; }

    public decimal? FAnzahl { get; set; }

    public int NObjekt { get; set; }

    public int KObjektPk { get; set; }

    public DateTime DErstellt { get; set; }

    public string? CHinweis { get; set; }
}
