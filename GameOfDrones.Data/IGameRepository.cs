﻿using GameOfDrones.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfDrones.Data
{
  /// <summary>
  /// Represents a game data repository.
  /// </summary>
  public interface IGameRepository
  {
    /// <summary>
    /// Returns the played games of a given player.
    /// </summary>
    /// <param name="playerName">Name of the player.</param>
    /// <returns>Collection of games played by the given player.</returns>
    IEnumerable<Game> getPlayedGames(string playerName);

    /// <summary>
    /// Persists the data of the given game.
    /// </summary>
    /// <param name="game">The game to persist.</param>
    void SaveGame(Game game);
  }
}
