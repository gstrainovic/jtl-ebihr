using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStandardLieferadresseCache
{
    public int KAuftrag { get; set; }

    public int? KLieferadresseKunde { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public string? CLieferadresseTitel { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadresseAdresszusatz { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseMobilTelefon { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadressePostId { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseLandIso { get; set; }

    public DateTime DErstellt { get; set; }
}
