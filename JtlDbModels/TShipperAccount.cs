using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShipperAccount
{
    public int KShipperAccount { get; set; }

    public int? KShipperAccountParent { get; set; }

    public string CDisplayName { get; set; } = null!;

    public string CUserName { get; set; } = null!;

    public string CPassword { get; set; } = null!;

    public byte KShippingServiceProviderType { get; set; }

    public byte NAddressSourceType { get; set; }

    public int? KFirma { get; set; }

    public string? CSalutation { get; set; }

    public string? CTitle { get; set; }

    public string? CCompany { get; set; }

    public string? CCompanyAdd { get; set; }

    public string? CFirstname { get; set; }

    public string? CLastname { get; set; }

    public string? CStreetname { get; set; }

    public string? CStreetnumber { get; set; }

    public string? CAddressadd { get; set; }

    public string? CCountry { get; set; }

    public string? CCountryIso { get; set; }

    public string? CMobil { get; set; }

    public string? CMail { get; set; }

    public string? CZipCode { get; set; }

    public string? CCity { get; set; }

    public string? CBankName { get; set; }

    public string? CBankAccountOwner { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public string? CEkp { get; set; }

    public string? CInternationalEkp { get; set; }

    public string? CShipperNumber { get; set; }

    public string? CAccessLicenceNumber { get; set; }

    public string? CPhone { get; set; }

    public byte NAccountType { get; set; }

    public byte NTestAccount { get; set; }

    public decimal? FCodFee { get; set; }

    public string? CRetourenEkp { get; set; }

    public string? COrgUnitGuid { get; set; }

    public string? CGlsCustomerId { get; set; }

    public string? CGlsContactId { get; set; }

    public string? CMandatorId { get; set; }

    public string? CConsignerId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KOauthToken { get; set; }

    public string? CShipperReference { get; set; }

    public virtual ICollection<TDhlekp> TDhlekps { get; set; } = new List<TDhlekp>();
}
