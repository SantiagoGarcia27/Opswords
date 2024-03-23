using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class destrosamundos : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("Aniquila todo el terreno a su paso");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 290;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 40;
		((ModItem)this).get_item().height = 40;
		((ModItem)this).get_item().useTime = 2;
		((ModItem)this).get_item().useAnimation = 20;
		((ModItem)this).get_item().pick = 2909999;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().knockBack = 6f;
		((ModItem)this).get_item().value = 1999999000;
		((ModItem)this).get_item().rare = 6;
		((ModItem)this).get_item().UseSound = SoundID.Item1;
		((ModItem)this).get_item().autoReuse = true;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(2786, 1);
		val.AddIngredient(2781, 1);
		val.AddIngredient(3466, 1);
		val.AddIngredient(2776, 1);
		val.AddIngredient(1294, 1);
		val.AddIngredient(2798, 1);
		val.AddIngredient(2176, 1);
		val.AddTile(220);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (Main.rand.Next(10000) == 1000)
		{
			Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, ((ModItem)this).get_mod().DustType("Sparkle"));
		}
	}
}
