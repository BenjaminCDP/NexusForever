﻿using NexusForever.Database.Character;

namespace NexusForever.Game.Entity
{
    public interface ICustomisation : IDatabaseCharacter
    {
        ulong CharacterId { get; }
        uint Label { get; }
        uint Value { get; set; }

        bool PendingDelete { get; }

        void Delete();
    }
}