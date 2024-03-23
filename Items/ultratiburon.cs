using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class ultratiburon : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("ultratiburon");
		((ModItem)this).get_Tooltip().SetDefault("la hermana mayor de las 4");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 510;
		((ModItem)this).get_item().ranged = true;
		((ModItem)this).get_item().width = 100;
		((ModItem)this).get_item().height = 50;
		((ModItem)this).get_item().useTime = 2;
		((ModItem)this).get_item().useAnimation = 10;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 1f;
		((ModItem)this).get_item().value = 1000000000;
		((ModItem)this).get_item().rare = 6;
		((ModItem)this).get_item().UseSound = SoundID.Item12;
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().shoot = 5;
		((ModItem)this).get_item().shootSpeed = 100f;
		((ModItem)this).get_item().useAmmo = AmmoID.Bullet;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddIngredient(533, 1);
		val.AddIngredient(3475, 1);
		val.AddTile(77);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}
}
