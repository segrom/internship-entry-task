﻿using Segrom.СrossesProject.Domain.Entities;

namespace Segrom.СrossesProject.Application.Abstractions;

public interface IGameProvider
{
	Task<Game> Create(uint fieldSize, uint lengthForWin, CancellationToken cancellationToken);
	Task<Game?> Get(Guid gameId, CancellationToken cancellationToken);
	Task Update(Game game, CancellationToken cancellationToken);
}