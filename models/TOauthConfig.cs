using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOauthConfig
{
    public string CId { get; set; } = null!;

    public string CName { get; set; } = null!;

    public byte NFlow { get; set; }

    public string CAuthorize { get; set; } = null!;

    public string CToken { get; set; } = null!;

    public string CClientId { get; set; } = null!;

    public string CClientCallback { get; set; } = null!;

    public string? CClientSecret { get; set; }

    public string? CScopes { get; set; }

    public virtual ICollection<TOauthToken> TOauthTokens { get; set; } = new List<TOauthToken>();
}
