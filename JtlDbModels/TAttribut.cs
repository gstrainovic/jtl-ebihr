using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAttribut
{
    public int KAttribut { get; set; }

    public byte NIstMehrsprachig { get; set; }

    public byte NIstFreifeld { get; set; }

    public int NSortierung { get; set; }

    public string? CBeschreibung { get; set; }

    public byte NBezugstyp { get; set; }

    public byte NAusgabeweg { get; set; }

    public byte NIstStandard { get; set; }

    public int KFeldTyp { get; set; }

    public string? CRegEx { get; set; }

    public string? CGruppeName { get; set; }

    public byte NReadOnly { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool? NAktivFuerArtikelOhneWarengruppe { get; set; }

    public bool? NIstPflichtfeld { get; set; }

    public string CAttributId { get; set; } = null!;

    public virtual ICollection<TAttributWarengruppe> TAttributWarengruppes { get; set; } = new List<TAttributWarengruppe>();

    public virtual ICollection<TFulfillerAttributeMapping> TFulfillerAttributeMappings { get; set; } = new List<TFulfillerAttributeMapping>();

    public virtual ICollection<TKundeEigenesFeld> TKundeEigenesFelds { get; set; } = new List<TKundeEigenesFeld>();

    public virtual TMerchantProductAttributeMapping? TMerchantProductAttributeMapping { get; set; }

    public virtual ICollection<TResourceCustomField> TResourceCustomFields { get; set; } = new List<TResourceCustomField>();
}
