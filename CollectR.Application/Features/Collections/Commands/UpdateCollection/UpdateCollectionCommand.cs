﻿using CollectR.Application.Abstractions;
using CollectR.Application.Common;
using CollectR.Application.Common.Result;

namespace CollectR.Application.Features.Collections.Commands.UpdateCollection;

public sealed record UpdateCollectionCommand(Guid Id, string Name, string? Description)
    : ICommand<Result<Unit>>;
