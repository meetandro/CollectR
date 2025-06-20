﻿using CollectR.Application.Abstractions;
using CollectR.Application.Common.Result;

namespace CollectR.Application.Features.Collections.Queries.ExportCollection;

public sealed record ExportCollectionQuery(Guid Id, string Format)
    : IQuery<Result<ExportCollectionQueryResponse>>;
