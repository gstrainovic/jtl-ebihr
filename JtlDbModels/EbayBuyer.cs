using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayBuyer
{
    public int KBuyer { get; set; }

    public byte? AboutMePage { get; set; }

    public string? CityName { get; set; }

    public string? Country { get; set; }

    public string? CountryName { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? Street { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? Phone { get; set; }

    public string? SaCityName { get; set; }

    public string? SaCountry { get; set; }

    public string? SaCountryName { get; set; }

    public string? SaExternalAddressId { get; set; }

    public string? SaName { get; set; }

    public string? SaPostalCode { get; set; }

    public string? SaStateOrProvince { get; set; }

    public string? SaStreet { get; set; }

    public string? SaStreet1 { get; set; }

    public string? SaStreet2 { get; set; }

    public string? SaPhone { get; set; }

    public string? CharityId { get; set; }

    public byte? EBayGoodStanding { get; set; }

    public string? Eiastoken { get; set; }

    public string? Email { get; set; }

    public byte? FeedbackPrivate { get; set; }

    public string? FeedbackRatingStar { get; set; }

    public int? FeedbackScore { get; set; }

    public byte? Idverified { get; set; }

    public byte? NewUser { get; set; }

    public decimal PositiveFeedbackPercent { get; set; }

    public string? RegistrationDate { get; set; }

    public string? Site { get; set; }

    public byte? SiteVerified { get; set; }

    public string? Status { get; set; }

    public string? UserId { get; set; }

    public byte? UserIdchanged { get; set; }

    public string? UserIdlastChanged { get; set; }

    public string? Vatstatus { get; set; }
}
