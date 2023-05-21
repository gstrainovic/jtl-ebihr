using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLager
{
    public int KWarenLager { get; set; }

    public string? CName { get; set; }

    public string? CKuerzel { get; set; }

    public string? CLagerTyp { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CAnsprechpartnerAnrede { get; set; }

    public string? CAnsprechpartnerVorname { get; set; }

    public string? CAnsprechpartnerName { get; set; }

    public string? CAnsprechpartnerTel { get; set; }

    public string? CAnsprechpartnerFax { get; set; }

    public string? CAnsprechpartnerEmail { get; set; }

    public string? CAnsprechpartnerAbteilung { get; set; }

    public string? CBundesland { get; set; }

    public int? KFirma { get; set; }

    public int? KUser { get; set; }

    public byte NFulfillment { get; set; }

    public byte NLagerplatzVerwaltung { get; set; }

    public int? NAuslieferungsPrio { get; set; }

    public byte? NPackStationAktiv { get; set; }

    public string? CDimension1Name { get; set; }

    public string? CDimension1Trennzeichen { get; set; }

    public byte? NDimension1Laenge { get; set; }

    public byte? NDimension1Typ { get; set; }

    public string? CDimension2Name { get; set; }

    public string? CDimension2Trennzeichen { get; set; }

    public byte? NDimension2Laenge { get; set; }

    public byte? NDimension2Typ { get; set; }

    public string? CDimension3Name { get; set; }

    public string? CDimension3Trennzeichen { get; set; }

    public byte? NDimension3Laenge { get; set; }

    public byte? NDimension3Typ { get; set; }

    public string? CDimension4Name { get; set; }

    public string? CDimension4Trennzeichen { get; set; }

    public byte? NDimension4Laenge { get; set; }

    public byte? NDimension4Typ { get; set; }

    public string? CDimension5Name { get; set; }

    public string? CDimension5Trennzeichen { get; set; }

    public byte? NDimension5Laenge { get; set; }

    public byte? NDimension5Typ { get; set; }

    public string? CEmpfaengerFirma { get; set; }

    public int KQuellLager { get; set; }

    public int KZielLager { get; set; }

    public byte NAktiv { get; set; }

    public string? CFfnWarehouseId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CAdresszusatz { get; set; }

    public virtual ICollection<TArtikelMindestLagerbestandProLager> TArtikelMindestLagerbestandProLagers { get; set; } = new List<TArtikelMindestLagerbestandProLager>();

    public virtual TMerchantWarehouseRef? TMerchantWarehouseRef { get; set; }

    public virtual ICollection<TShippingMethodMapping> TShippingMethodMappings { get; set; } = new List<TShippingMethodMapping>();

    public virtual ICollection<TWorkbenchResource> TWorkbenchResources { get; set; } = new List<TWorkbenchResource>();
}
