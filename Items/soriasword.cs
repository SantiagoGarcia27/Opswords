using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class soriasword : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("soria_sword");
		((ModItem)this).get_Tooltip().SetDefault("tester_Item                                                                                     empanadas:v ");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 950;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 190;
		((ModItem)this).get_item().height = 190;
		((ModItem)this).get_item().useTime = 7;
		((ModItem)this).get_item().useAnimation = 4;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().knockBack = 600f;
		((ModItem)this).get_item().value = 10099900;
		((ModItem)this).get_item().rare = 4;
		((ModItem)this).get_item().UseSound = SoundID.Item2;
		((ModItem)this).get_item().autoReuse = true;
	}
}
