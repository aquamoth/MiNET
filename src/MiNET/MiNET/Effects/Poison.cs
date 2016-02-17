﻿namespace MiNET.Effects
{
	public class Poison : Effect
	{
		public Poison() : base(EffectType.Poison)
		{
		}

		public override void OnTick(Player player)
		{
			if (Duration%(Level == 1 ? 25 : 50) == 0)
			{
				if (player.HealthManager.Health > 10)
				{
					player.HealthManager.TakeHit(player, 2, DamageCause.Magic);
				}
			}

			base.OnTick(player);
		}
	}
}