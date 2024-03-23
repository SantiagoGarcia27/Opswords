using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class minigun : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("minigun");
		((ModItem)this).get_Tooltip().SetDefault("una pistola pequeña.");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 30;
		((ModItem)this).get_item().ranged = true;
		((ModItem)this).get_item().width = 8;
		((ModItem)this).get_item().height = 2;
		((ModItem)this).get_item().useTime = 30;
		((ModItem)this).get_item().useAnimation = 20;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 5f;
		((ModItem)this).get_item().value = 1000000;
		((ModItem)this).get_item().rare = 3;
		((ModItem)this).get_item().UseSound = SoundID.Item38;
		((ModItem)this).get_item().autoReuse = false;
		((ModItem)this).get_item().shoot = 10;
		((ModItem)this).get_item().shootSpeed = 2f;
		((ModItem)this).get_item().useAmmo = AmmoID.Bullet;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(95, 2);
		val.AddTile(18);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}
}
