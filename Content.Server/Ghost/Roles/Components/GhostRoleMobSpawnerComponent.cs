﻿using Robust.Shared.Prototypes;

namespace Content.Server.Ghost.Roles.Components
{
    /// <summary>
    ///     Allows a ghost to take this role, spawning a new entity.
    /// </summary>
    [RegisterComponent, EntityCategory("Spawner")]
    [Access(typeof(GhostRoleSystem))]
    public sealed partial class GhostRoleMobSpawnerComponent : Component
    {
        [DataField]
        public bool DeleteOnSpawn = false; /// Change for N14, needed for the ghost role follower traits.
        [DataField]
        public int AvailableTakeovers = 1;

        [ViewVariables]
        public int CurrentTakeovers = 0;

        [DataField]
        public EntProtoId? Prototype;

        /// <summary>
        ///     If this ghostrole spawner has multiple selectable ghostrole prototypes.
        /// </summary>
        [DataField]
        public List<string> SelectablePrototypes = [];
    }
}
