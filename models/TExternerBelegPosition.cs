using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExternerBelegPosition
{
    public int KExternerBelegPosition { get; set; }

    public int KExternerBelegTransaktion { get; set; }

    public int? KExternerBelegPositionVater { get; set; }

    public byte NKindtyp { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KBezugRechnungPosition { get; set; }

    public int? KBezugExternerBelegPosition { get; set; }

    public byte NPositionstyp { get; set; }

    public string CArtNr { get; set; } = null!;

    public int? KArtikel { get; set; }

    public string CText { get; set; } = null!;

    public decimal FAnzahl { get; set; }

    public decimal? FVkBrutto { get; set; }

    public decimal? FVkNetto { get; set; }

    public decimal? FMwStSatz { get; set; }

    public decimal? FRabattBrutto { get; set; }

    public decimal? FRabattNetto { get; set; }

    public string CRabatttext { get; set; } = null!;

    public decimal? FEkNetto { get; set; }

    public string CEinheit { get; set; } = null!;

    public long? KExterneId { get; set; }

    public virtual TArtikel? KArtikelNavigation { get; set; }

    public virtual TAuftragPosition? KAuftragPositionNavigation { get; set; }

    public virtual TExternerBelegTransaktion KExternerBelegTransaktionNavigation { get; set; } = null!;
}
