using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VHealthCheckSchema
{
    public string? CObjectId { get; set; }

    public string? CObjectType { get; set; }

    public string? CObjectName { get; set; }

    public string? CSchemaName { get; set; }

    public string? CParentObjectName { get; set; }

    public string? CObjectTypeDesc { get; set; }

    public string? CCreateScript { get; set; }

    public string? CDropScript { get; set; }
}
