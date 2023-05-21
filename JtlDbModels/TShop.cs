using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShop
{
    public int KShop { get; set; }

    public string? CApikey { get; set; }

    public string? CName { get; set; }

    public string? CServerWeb { get; set; }

    public string? CBenutzerWeb { get; set; }

    public string? CPasswortWeb { get; set; }

    public byte? NHttpPut { get; set; }

    public byte? NShopAuftragsNr { get; set; }

    public byte? NGesperrt { get; set; }

    public int? KFirma { get; set; }

    public byte? NAngebot { get; set; }

    public int? KKategorie { get; set; }

    public byte NTyp { get; set; }

    public int? KAlterShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KWarenlager { get; set; }

    public int? KWarenlagerRetoure { get; set; }

    public int? KWarenlagerRetourePlatz { get; set; }

    public int? KWarenlagerPlatz { get; set; }

    public byte? NWarenlagerPlatztyp { get; set; }

    public byte? NWarenlagerRetourePlatztyp { get; set; }

    public string? CBelegDrucker { get; set; }

    public bool? NAktiv { get; set; }

    public string? CGutscheinDrucker { get; set; }

    public virtual ICollection<TChannelPriceType> TChannelPriceTypes { get; set; } = new List<TChannelPriceType>();

    public virtual ICollection<TSellerAttribute> TSellerAttributes { get; set; } = new List<TSellerAttribute>();

    public virtual ICollection<TShopKundenGruppe> TShopKundenGruppes { get; set; } = new List<TShopKundenGruppe>();

    public virtual ICollection<TShopUeberverkaeufeMoeglich> TShopUeberverkaeufeMoegliches { get; set; } = new List<TShopUeberverkaeufeMoeglich>();

    public virtual ICollection<Tkonfigshop> Tkonfigshops { get; set; } = new List<Tkonfigshop>();
}
