using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbrechnungPo
{
    public int KAbrechnungPos { get; set; }

    public int KAbrechnung { get; set; }

    public int KArtikel { get; set; }

    public int KAbrechnungStueckliste { get; set; }

    public string? CBezeichnung { get; set; }

    public string? CArtNr { get; set; }

    public string? CEinheit { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FVknetto { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FVkpreis { get; set; }

    public decimal FRabatt { get; set; }

    public int NSort { get; set; }

    public string? CHinweis { get; set; }

    public byte? NType { get; set; }
}
