﻿using CollectR.Domain.Enums;

namespace CollectR.Application.Features.Collections.Queries.GetCollectiblesForCollection;

public sealed record GetCollectiblesForCollectionQueryResponse(
    Guid Id,
    string Title,
    string? Description,
    string? Currency,
    decimal? Value,
    DateTime? AcquiredDate,
    bool? IsCollected,
    int? SortIndex,
    Color? Color,
    Condition? Condition,
    string Metadata,
    Guid CategoryId,
    Guid CollectionId,
    IEnumerable<string> ImageUris,
    IEnumerable<Guid> TagIds
);
