using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOauthToken
{
    public int KOauthToken { get; set; }

    public string CConfigId { get; set; } = null!;

    public DateTime DValidUntil { get; set; }

    public string CAccessToken { get; set; } = null!;

    public string? CRefreshToken { get; set; }

    public byte NInvalid { get; set; }

    public virtual TOauthConfig CConfig { get; set; } = null!;
}
