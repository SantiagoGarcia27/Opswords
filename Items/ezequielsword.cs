using Terraria.ID;
using Terraria.ModLoader;

namespace prueba.Items;

public class ezequielsword : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("ezequiel_sword");
		((ModItem)this).get_Tooltip().SetDefault("tester_Item.");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 1950;
		((ModItem)this).get_item().melee = true;
		((ModItem)this).get_item().width = 20;
		((ModItem)this).get_item().height = 20;
		((ModItem)this).get_item().useTime = 6;
		((ModItem)this).get_item().useAnimation = 4;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().knockBack = 300f;
		((ModItem)this).get_item().value = 10099900;
		((ModItem)this).get_item().rare = 5;
		((ModItem)this).get_item().UseSound = SoundID.Item45;
		((ModItem)this).get_item().autoReuse = true;
	}
}
