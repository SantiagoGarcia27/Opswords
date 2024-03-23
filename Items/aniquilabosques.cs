using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class aniquilabosques : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("Aniquilabosques");
		((ModItem)this).get_Tooltip().SetDefault("destruira toda la madera y pared a su alcanse.");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 85;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 40;
		((ModItem)this).get_item().height = 40;
		((ModItem)this).get_item().useTime = 15;
		((ModItem)this).get_item().useAnimation = 15;
		((ModItem)this).get_item().axe = 500;
		((ModItem)this).get_item().hammer = 590;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().knockBack = 600f;
		((ModItem)this).get_item().value = 10000;
		((ModItem)this).get_item().rare = 6;
		((ModItem)this).get_item().UseSound = SoundID.Item1;
		((ModItem)this).get_item().autoReuse = true;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(1305, 1);
		val.AddIngredient(3518, 1);
		val.AddIngredient(3517, 1);
		val.AddTile(77);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}
}
