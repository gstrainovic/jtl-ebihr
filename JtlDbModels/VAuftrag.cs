using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftrag
{
    public int KBestellung { get; set; }

    public int KFirma { get; set; }

    public int KFulfillmentAuftrag { get; set; }

    public int? KLieferschein { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? COutboundId { get; set; }

    public string? CWaehrung { get; set; }

    public int? KKunde { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public bool NPremium { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CBestellHinweis { get; set; }

    public string CBestellNr { get; set; } = null!;

    public string? CExterneNummer { get; set; }

    public int NPrio { get; set; }

    public int? NPlatform { get; set; }

    public string PlattformName { get; set; } = null!;

    public string? CAnrede { get; set; }

    public string? CBundesland { get; set; }

    public string? CFirma { get; set; }

    public string? CLand { get; set; }

    public string? CMail { get; set; }

    public string? CTel { get; set; }

    public string? CName { get; set; }

    public string? COrt { get; set; }

    public string? CPlz { get; set; }

    public string? CStrasse { get; set; }

    public string? CVorname { get; set; }

    public string? CZusatz { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CMobil { get; set; }

    public string? CFax { get; set; }

    public int KWarenLager { get; set; }

    public string? CWarehouseId { get; set; }

    public int? KVersandart { get; set; }

    public int? KZielLager { get; set; }

    public int? KUmlagerung { get; set; }

    public byte? VersandartIsAmazonPrime { get; set; }
}
