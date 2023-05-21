using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExterneRechnung
{
    public int KExterneRechnung { get; set; }

    public int? KKunde { get; set; }

    public int? KBenutzer { get; set; }

    public int KFirmaHistory { get; set; }

    public int KPlattform { get; set; }

    public int? KAmazonUser { get; set; }

    public string CExterneRechnungsnr { get; set; } = null!;

    public DateTime DBelegzeitpunktUtc { get; set; }

    public string CVerkaeuferUstId { get; set; } = null!;

    public string CVerkaeuferUstLandIso { get; set; } = null!;

    public string CKaeuferUstId { get; set; } = null!;

    public string CKaeuferUstLandIso { get; set; } = null!;

    public byte NKaeuferUstIdArt { get; set; }

    public string? CSdIkontoNr { get; set; }

    public bool NUstIdBerechnungsadresse { get; set; }

    public string CSteuerbehoerdeEbene { get; set; } = null!;

    public string CSteuerbehoerde { get; set; } = null!;

    public string? CWaehrungIso { get; set; }

    public decimal FWaehrungsfaktor { get; set; }

    public DateTime? DWaehrungsfaktorZeitpunktUtc { get; set; }

    public decimal? FUmgerechneterGesamtUstBetrag { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseAnrede { get; set; }

    public string? CRechnungsadresseTitel { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CRechnungsadresseName { get; set; }

    public string? CRechnungsadresseStrasse { get; set; }

    public string? CRechnungsadresseOrt { get; set; }

    public string? CRechnungsadressePlz { get; set; }

    public string? CRechnungsadresseLand { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual PfUser? KAmazonUserNavigation { get; set; }

    public virtual TFirmaHistory KFirmaHistoryNavigation { get; set; } = null!;

    public virtual Tkunde? KKundeNavigation { get; set; }

    public virtual TPlattform KPlattformNavigation { get; set; } = null!;

    public virtual ICollection<TExterneRechnungDokument> TExterneRechnungDokuments { get; set; } = new List<TExterneRechnungDokument>();

    public virtual TExterneRechnungEckdaten? TExterneRechnungEckdaten { get; set; }

    public virtual ICollection<TExterneRechnungPosition> TExterneRechnungPositions { get; set; } = new List<TExterneRechnungPosition>();

    public virtual TExterneRechnungZusatzdaten? TExterneRechnungZusatzdaten { get; set; }
}
