using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace BossConfig
{
    class BossConfigure : ModConfig
    {
		public override ConfigScope Mode => ConfigScope.ServerSide;

		public static BossConfigure Instance;

		[Header("Boss Numerical Stats")]

		[Label("Boss Health")]
		[Tooltip("Changes the health of bosses | Set to -1 to not change health")]
		[Range(-1, 10000000)]
		public int NPCHealth;

		[Label("Boss Damage")]
		[Tooltip("Changes the damage that bosses deal | Set to -1 to not change damage")]
		[Range(-1, 10000000)]
		public int NPCDamage;

		[Label("Boss Defense")]
		[Tooltip("Changes the defense of bosses | Set to -1 to not change defense")]
		[Range(-1, 10000000)]
		public int NPCDefense;

		[Label("Boss Knockback Resistance")]
		[Tooltip("Changes the knockback resistance  of bosses | Set to -0.01 to not change knockback resistance")]
		[Range(-0.01f, 1f)]
		public float NPCKBResist;

		[Header("Boss Other Stats")]

		[Label("Boss AI")]
		[Range(-1, 579)]
		[Tooltip("How the boss acts | Set to -1 to not change AI")]
		public int NPCAIStyle;

		[Label("Boss Invincibility")]
		[Tooltip("Whether you can damage the boss")]
		public bool BossInvincible;

		[Label("Boss Tile Collision")]
		[Tooltip("Whether bosses collide with tiles or not")]
		public bool NPCTileCollision;

		[Label("Boss Gravity")]
		[Tooltip("Whether the boss is affected by gravity")]
		public bool BossGravity;
	}
}