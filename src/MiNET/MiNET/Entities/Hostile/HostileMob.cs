﻿using MiNET.Worlds;

namespace MiNET.Entities.Hostile
{
	public abstract class HostileMob : Mob
	{
		protected HostileMob(int entityTypeId, Level level)
			: base(entityTypeId, level)
		{
		}
	}
}