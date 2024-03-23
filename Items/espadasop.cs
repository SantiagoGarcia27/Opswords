using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class espadasop : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("garritas");
		((ModItem)this).get_Tooltip().SetDefault("Una prueba muy op.");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 99950;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 40;
		((ModItem)this).get_item().height = 40;
		((ModItem)this).get_item().useTime = 5;
		((ModItem)this).get_item().useAnimation = 5;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().knockBack = 60f;
		((ModItem)this).get_item().value = 10099900;
		((ModItem)this).get_item().rare = 7;
		((ModItem)this).get_item().UseSound = SoundID.Item1;
		((ModItem)this).get_item().autoReuse = true;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(173, 90);
		val.AddIngredient(3063, 2);
		val.AddIngredient(2176, 1);
		val.AddTile(77);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}
}
