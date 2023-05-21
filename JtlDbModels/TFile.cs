using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFile
{
    public int KFile { get; set; }

    public byte[] BFile { get; set; } = null!;

    public int KBenutzer { get; set; }

    public DateTime DErstellDatum { get; set; }

    public string CFileHash { get; set; } = null!;

    public string CFileName { get; set; } = null!;

    public string CFileType { get; set; } = null!;

    public int NFileSizeKb { get; set; }

    public virtual ICollection<TArtikelVerkaufskanalFeldWert> TArtikelVerkaufskanalFeldWerts { get; set; } = new List<TArtikelVerkaufskanalFeldWert>();

    public virtual ICollection<TAuftragFile> TAuftragFiles { get; set; } = new List<TAuftragFile>();

    public virtual ICollection<TAuftragPositionFile> TAuftragPositionFiles { get; set; } = new List<TAuftragPositionFile>();

    public virtual ICollection<TAusgangskanalEmailBenutzerSignatur> TAusgangskanalEmailBenutzerSignaturs { get; set; } = new List<TAusgangskanalEmailBenutzerSignatur>();

    public virtual ICollection<TNachrichtEntwurfAnhang> TNachrichtEntwurfAnhangs { get; set; } = new List<TNachrichtEntwurfAnhang>();

    public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurves { get; set; } = new List<TNachrichtEntwurf>();

    public virtual ICollection<TNachrichtenanhang> TNachrichtenanhangs { get; set; } = new List<TNachrichtenanhang>();

    public virtual ICollection<TNachricht> TNachrichts { get; set; } = new List<TNachricht>();

    public virtual ICollection<TNotiz1> TNotiz1s { get; set; } = new List<TNotiz1>();

    public virtual ICollection<TNotizAnhang> TNotizAnhangs { get; set; } = new List<TNotizAnhang>();

    public virtual ICollection<TNotizEntwurfAnhang> TNotizEntwurfAnhangs { get; set; } = new List<TNotizEntwurfAnhang>();

    public virtual ICollection<TNotizEntwurf> TNotizEntwurves { get; set; } = new List<TNotizEntwurf>();

    public virtual ICollection<TProcessParameterValue> TProcessParameterValues { get; set; } = new List<TProcessParameterValue>();

    public virtual ICollection<TRechnungFile> TRechnungFiles { get; set; } = new List<TRechnungFile>();

    public virtual ICollection<TRechnungPositionFile> TRechnungPositionFiles { get; set; } = new List<TRechnungPositionFile>();

    public virtual ICollection<TTelefonatAnhang> TTelefonatAnhangs { get; set; } = new List<TTelefonatAnhang>();

    public virtual ICollection<TTelefonatEntwurfAnhang> TTelefonatEntwurfAnhangs { get; set; } = new List<TTelefonatEntwurfAnhang>();

    public virtual ICollection<TTelefonatEntwurf> TTelefonatEntwurves { get; set; } = new List<TTelefonatEntwurf>();

    public virtual ICollection<TTelefonat> TTelefonats { get; set; } = new List<TTelefonat>();

    public virtual ICollection<TTextbausteinInhaltSprache> TTextbausteinInhaltSpraches { get; set; } = new List<TTextbausteinInhaltSprache>();

    public virtual ICollection<TVerkaufskanalCategoryFeldWert> TVerkaufskanalCategoryFeldWerts { get; set; } = new List<TVerkaufskanalCategoryFeldWert>();

    public virtual ICollection<TVerkaufskanalChannelFeldWert> TVerkaufskanalChannelFeldWerts { get; set; } = new List<TVerkaufskanalChannelFeldWert>();

    public virtual ICollection<TVordefinierteAntwort> TVordefinierteAntworts { get; set; } = new List<TVordefinierteAntwort>();
}
