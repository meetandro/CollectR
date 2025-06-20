﻿using CollectR.Domain.Common;

namespace CollectR.Domain;

public class Image : Entity
{
    public string Uri { get; set; } = string.Empty;

    public string? Alt { get; set; }

    public Guid CollectibleId { get; set; }
    public Collectible? Collectible { get; set; }
}
