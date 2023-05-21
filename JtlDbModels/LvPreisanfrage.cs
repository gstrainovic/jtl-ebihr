using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvPreisanfrage
{
    public int KLieferantenBestellung { get; set; }

    public string? CPreisanfrage { get; set; }

    public string CLieferant { get; set; } = null!;

    public string CLieferantFirmenZusatz { get; set; } = null!;

    public string CLieferantennummer { get; set; } = null!;

    public string CLieferantEigeneKundennummer { get; set; } = null!;

    public DateTime? DErstellt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DGemailt { get; set; }

    public DateTime? DGefaxt { get; set; }

    public string? CKommentar { get; set; }

    public byte NBestaetigt { get; set; }

    public string CLieferadresseFirma { get; set; } = null!;

    public string CLieferadresseVorname { get; set; } = null!;

    public string CLieferadresseName { get; set; } = null!;

    public string CRechnungsadresseFirma { get; set; } = null!;

    public string CRechnungsadresseVorname { get; set; } = null!;

    public string CRechnungsadresseName { get; set; } = null!;

    public string CLieferadressePlz { get; set; } = null!;

    public string CLieferadresseOrt { get; set; } = null!;

    public string CLieferadresseLand { get; set; } = null!;

    public string CLieferadresseStrasse { get; set; } = null!;

    public string CLieferadresseMail { get; set; } = null!;
}
