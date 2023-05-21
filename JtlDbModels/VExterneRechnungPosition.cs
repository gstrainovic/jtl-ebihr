using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VExterneRechnungPosition
{
    public int KExterneRechnungPosition { get; set; }

    public int? KExterneRechnungPositionVater { get; set; }

    public int KExterneRechnung { get; set; }

    public DateTime DAuftragszeitpunktUtc { get; set; }

    public string CAuftragsnr { get; set; } = null!;

    public string CAuftragswaehrungIso { get; set; } = null!;

    public DateTime? DVersandzeitpunktUtc { get; set; }

    public byte NTransaktionstyp { get; set; }

    public byte NPositionstyp { get; set; }

    public int? KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CTransaktionstext { get; set; }

    public decimal FAnzahl { get; set; }

    public DateTime DSteuerberechnungszeitpunktUtc { get; set; }

    public decimal FSteuersatz { get; set; }

    public decimal FSummeBrutto { get; set; }

    public decimal FSummeNetto { get; set; }

    public decimal FSummeSteuer { get; set; }

    public decimal FSummeRabattBrutto { get; set; }

    public decimal FSummeRabattNetto { get; set; }

    public decimal FSummeRabattSteuer { get; set; }

    public string CVersandadresseOrt { get; set; } = null!;

    public string? CVersandadresseRegion { get; set; }

    public string CVersandadresseLandIso { get; set; } = null!;

    public string CVersandadressePlz { get; set; } = null!;

    public string? CVersandadresseSteuercode { get; set; }

    public string CLieferadresseOrt { get; set; } = null!;

    public string? CLieferadresseRegion { get; set; }

    public string CLieferadresseLandIso { get; set; } = null!;

    public string CLieferadressePlz { get; set; } = null!;

    public string? CLieferadresseSteuercode { get; set; }

    public int? KAmazonVcsbestellungPos { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KAuftrag { get; set; }
}
