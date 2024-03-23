using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class clorodrax : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("clorodrax");
		((ModItem)this).get_Tooltip().SetDefault("el resultante de vendesir una planta.");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 45;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 60;
		((ModItem)this).get_item().height = 60;
		((ModItem)this).get_item().useTime = 15;
		((ModItem)this).get_item().useAnimation = 15;
		((ModItem)this).get_item().pick = 201;
		((ModItem)this).get_item().axe = 140;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().knockBack = 1f;
		((ModItem)this).get_item().value = 1000000;
		((ModItem)this).get_item().rare = 6;
		((ModItem)this).get_item().UseSound = SoundID.Item23;
		((ModItem)this).get_item().autoReuse = true;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(1232, 1);
		val.AddIngredient(579, 1);
		val.AddTile(134);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}
}
