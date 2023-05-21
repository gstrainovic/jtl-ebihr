using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TExternerBelegTransaktion
{
    public int KExternerBelegTransaktion { get; set; }

    public int KExternerBeleg { get; set; }

    public byte NTransaktionstyp { get; set; }

    public string CTransaktionId { get; set; } = null!;

    public string? CBezugstransaktionId { get; set; }

    public DateTime DTransaktionsdatumUtc { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public DateTime? DExternesAuftragsdatumUtc { get; set; }

    public string? CKundenAuftragsnummer { get; set; }

    public string CLaname { get; set; } = null!;

    public string CLaadresse1 { get; set; } = null!;

    public string CLaadresse2 { get; set; } = null!;

    public string CLaadresse3 { get; set; } = null!;

    public string CLaort { get; set; } = null!;

    public string CLastaat { get; set; } = null!;

    public string CLapostcode { get; set; } = null!;

    public string CLalandIso { get; set; } = null!;

    public string CLatelefon { get; set; } = null!;

    public string CVaort { get; set; } = null!;

    public string CVastaat { get; set; } = null!;

    public string CVapostcode { get; set; } = null!;

    public string CValandIso { get; set; } = null!;

    public virtual TExternerBeleg KExternerBelegNavigation { get; set; } = null!;

    public virtual ICollection<TExternerBelegPosition> TExternerBelegPositions { get; set; } = new List<TExternerBelegPosition>();
}
