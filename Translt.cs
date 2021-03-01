using System.Linq;
public class Translt{
	
	public static string Translate(string displayName)
	{
		string result = displayName;
		string[] inputStr = { "door.double.hinged.wood", "wall.frame.shopfront","door.hinged.wood","door.hinged.toptier","door.hinged.metal","door.double.hinged.toptier","door.double.hinged.metal",
"wall.frame.garagedoor","wall.frame.cell.gate","wall.frame.fence.gate","gates.external.high.stone","gates.external.high.wood","door.hinged.vent","floor.ladder.hatch","door.hinged.industrial_a_a","door.hinged.industrial_a_b",
"door.hinged.industrial_a_c","door.hinged.industrial_a_d","door.hinged.industrial_a_e","door.hinged.industrial_a_f","door.hinged.industrial_a_g","door.hinged.industrial_a_h","door.hinged.garage_a",
"door.hinged.bunker.door","4x Zoom Scope","Assault Rifle","Beancan Grenade","Bolt Action Rifle","Bone Club","Bone Knife","Candy Cane Club","Crossbow","Custom SMG","Double Barrel Shotgun","Eoka Pistol",
"F1 Grenade","Flame Thrower","Holosight","Hunting Bow","Longsword","LR-300 Assault Rifle","M249","M92 Pistol","Mace","Machete","MP5A4","Muzzle Boost","Muzzle Brake","Nailgun","Pump Shotgun","Python Revolver",
"Revolver","Rocket Launcher","Salvaged Cleaver","Salvaged Sword","Semi-Automatic Pistol","Semi-Automatic Rifle","Silencer","Simple Handmade Sight","Snowball","Stone Spear","Thompson","Waterpipe Shotgun",
"Weapon Flashlight","Weapon Lasersight","Wooden Spear","Armored Door","Armored Double Door","Barbed Wooden Barricade","Building Plan","Chainlink Fence","Chainsaw","Chainlink Fence Gate","Code Lock",
"Concrete Barricade","Door Closer","Floor grill","Garage Door","High External Stone Gate","High External Stone Wall","High External Wooden Gate","High External Wooden Wall","Key Lock","Ladder Hatch",
"Large Water Catcher","Metal Barricade","Metal Horizontal embrasure","Metal Shop Front","Compound Bow","Spas-12 Shotgun","Metal Vertical embrasure","Metal Window Bars","Mining Quarry","Netting","Prison Cell Gate",
"Prison Cell Wall","Pump Jack","Reinforced Glass Window","Reinforced Window Bars","Sandbag Barricade","Sheet Metal Door","Sheet Metal Double Door","Shop Front","Small Water Catcher","Stone Barricade",
"Tool Cupboard","Watch Tower","Wind Turbine","Wood Double Door","Wood Shutters","Wooden Barricade","Wooden Door","Wooden Ladder","Wooden Window Bars","Barbeque","Bed","Bota Bag","Camp Fire","Chair",
"Drop Box","Fridge","Furnace","Large Furnace","Huge Wooden Sign","Landscape Picture Frame","metal-collectable","sulfur-collectable","wood-collectable","stone-collectable","corn-collectable","pumpkin-collectable","stag","loot_barrel_1","bradley_crate","loot_barrel_2",
		"loot_barrel_3","loot_barrel_4","loot_barrel_5","loot-barrel-1","loot-barrel-2","oil-barrel","oil_barrel","loot-barrel-3","hobobarrel_static","foodbox","trash-pile-1","trash-pile-2","trash-pile-3","trash-pile-4","trash-pile-5","fridge","crate_normal_2","crate-normal-2-medical","woodbox","crate_normal_2_medical",
		"crate_normal_2_food","crate-normal-2-food","heli_","heli_crate","explosive.timed.deployed","explosive.satchel.entity","rocket_basic","crate_normal","recycler_static","food","campfire","flameturret.deployed","landmine","beartrap","wolf","chicken","boar","bear","horse","Tech Trash", "Metal Pine"};
		string[] resStr = { "Деревянная", "Деревянная Калитка","Деревянная","МВК Дверь","Металлическая","МВК Дверь","Металлическая","Гаражка","Решетка","Калитка","Каменные Ворота","Деревянные Ворота",
" ","Люк"," "," "," "," "," "," "," "," "," "," ","4x Прицел","AK-47","Бобовая Граната","Болтовка","Кость","Нож","ЛЕДЕНЕЦ","Арбалет","СМГ","Двушка","Черкаш","Граната F1","Огнемёт","Коллиматорный Прицел",
"Охотничий Лук","Длинный Меч","LR-300 ","Пулемет","Беретта","Булава","Мачета","MP5","Дульный Ускоритель","Дульный Тормоз","Гвоздемёт","Помповый Дробовик","ПИТОН","Револьвер","Базука","Тесак","Меч",
"Пешка-Пистолет","Берданка","Глушитель","Самодельный Прицел","Нож","Каменное Копье","Томпсон","Пайп","Фонарик На Оружие","Лазер На Оружие","Копье","МВК Деврь","МВК Двойная Дверь","Колючая деревянная баррикада",
"План Строительства","Сетчатый забор","Бензопила","Сетчатая дверь","Кодовый Замок","Бетонная баррикада","Доводчик","Решётчатый Настил","Гаражка","Каменные Ворота","Каменная Стенка","Деревянные Ворота",
"Деревянная Стенка","Деревяный Замок","Люк с лестницей","Большой Вода сборник","Метал Брикада","Метал Окно (Защита)","Металл Магазин","Натяжной Лук","Спас-12 Дробовик","Метал Окно (Защита)","Метал Решетка",
"Карьер","Сетка","Тюремная Решётка (Дверь)","Тюремная Решётка","Нефте Качка","Броне окно","МВК Решётка (На Окно)","Песочная Брикада","Метал Дверь","Двойная Метал Дверь","Деревнная Фигня ;D","Вода Сборник",
"Каменная Брикада","Шкаф","Вышка","Мельница","Деревянная Двойная Дверь","Деревянные Ставни (На Окна","Деревянная Брикада","Деревянная Дверь","Штурмавая Лестница","Деревянная Решётка (На Окна)","Гриль",
"Кровать","Бурдюк","Костёр","Стул","Ящик Для Хранения","Холодильник","Печь","Большая Печь","Огромная деревянная табличка","Рамка (Маленькая)","Метал","Сера","Дерево","Камень","Кукуруза","Тыква","Олень","Бочка","Ящик Танка","Бочка"
,"Бочка","Бочка","Бочка","Бочка","Бочка","Бочка С Нефтью","Бочка С Нефтью","Бочка","Бочка С Огнём","Ящик С Едой","Ящик С Едой","Ящик С Едой","Ящик С Едой","Ящик С Едой","Ящик С Едой","Холодильник","Коробка","Медецина","Малый Сундук","Медецина",
		"Коробка С Едой","Коробка С Едой","Ящик Верта","Ящик Верта","C4","Сачелька","Ракета","Зелёный Ящик","Переработчик","Ящик с Едой","Костёр","Огненная Турель","Мина","Капкан","Волк","Курица","Кабан","Медведь","Лошадь","Микросхема","Метал Труба"};
		for (int i = 0; i < inputStr.Count(); i++)
		{
			if (displayName == inputStr[i])
			{
				result = resStr[i];
			}
		}
		return result;
	}
	public static string Translate1(string displayName)
	{
		string result = displayName;
		string[] inputStr = { "door.double.hinged.wood", "wall.frame.shopfront","door.hinged.wood","door.hinged.toptier","door.hinged.metal","door.double.hinged.toptier","door.double.hinged.metal",
"wall.frame.garagedoor","wall.frame.cell.gate","wall.frame.fence.gate","gates.external.high.stone","gates.external.high.wood","door.hinged.vent","floor.ladder.hatch","door.hinged.industrial_a_a","door.hinged.industrial_a_b",
"door.hinged.industrial_a_c","door.hinged.industrial_a_d","door.hinged.industrial_a_e","door.hinged.industrial_a_f","door.hinged.industrial_a_g","door.hinged.industrial_a_h","door.hinged.garage_a",
"door.hinged.bunker.door","4x Zoom Scope","Assault Rifle","Beancan Grenade","Bolt Action Rifle","Bone Club","Bone Knife","Candy Cane Club","Crossbow","Custom SMG","Double Barrel Shotgun","Eoka Pistol",
"F1 Grenade","Flame Thrower","Holosight","Hunting Bow","Longsword","LR-300 Assault Rifle","M249","M92 Pistol","Mace","Machete","MP5A4","Muzzle Boost","Muzzle Brake","Nailgun","Pump Shotgun","Python Revolver",
"Revolver","Rocket Launcher","Salvaged Cleaver","Salvaged Sword","Semi-Automatic Pistol","Semi-Automatic Rifle","Silencer","Simple Handmade Sight","Snowball","Stone Spear","Thompson","Waterpipe Shotgun",
"Weapon Flashlight","Weapon Lasersight","Wooden Spear","Armored Door","Armored Double Door","Barbed Wooden Barricade","Building Plan","Chainlink Fence","Chainsaw","Chainlink Fence Gate","Code Lock",
"Concrete Barricade","Door Closer","Floor grill","Garage Door","High External Stone Gate","High External Stone Wall","High External Wooden Gate","High External Wooden Wall","Key Lock","Ladder Hatch",
"Large Water Catcher","Metal Barricade","Metal Horizontal embrasure","Metal Shop Front","Compound Bow","Spas-12 Shotgun","Metal Vertical embrasure","Metal Window Bars","Mining Quarry","Netting","Prison Cell Gate",
"Prison Cell Wall","Pump Jack","Reinforced Glass Window","Reinforced Window Bars","Sandbag Barricade","Sheet Metal Door","Sheet Metal Double Door","Shop Front","Small Water Catcher","Stone Barricade",
"Tool Cupboard","Watch Tower","Wind Turbine","Wood Double Door","Wood Shutters","Wooden Barricade","Wooden Door","Wooden Ladder","Wooden Window Bars","Barbeque","Bed","Bota Bag","Camp Fire","Chair",
"Drop Box","Fridge","Furnace","Large Furnace","Huge Wooden Sign","Landscape Picture Frame","metal-collectable","sulfur-collectable","wood-collectable","stone-collectable","corn-collectable","pumpkin-collectable","stag","loot_barrel_1","bradley_crate","loot_barrel_2",
		"loot_barrel_3","loot_barrel_4","loot_barrel_5","loot-barrel-1","loot-barrel-2","oil-barrel","oil_barrel","loot-barrel-3","hobobarrel_static","foodbox","trash-pile-1","trash-pile-2","trash-pile-3","trash-pile-4","trash-pile-5","fridge","crate_normal_2","crate-normal-2-medical","woodbox","box.wooden.large",
		"crate_normal_2_food","crate-normal-2-food","heli_","heli_crate","explosive.timed.deployed","explosive.satchel.entity","rocket_basic","crate_normal","recycler_static","food","campfire","flameturret.deployed","landmine","beartrap","wolf","chicken","boar","bear","horse","Tech Trash", "Metal Pine"};
		string[] resStr = { "Wooden", "Wooden Gate","Wood","Armored Door","Metal","Armored Door","Metal","Garage","Lattice","Gate","Stone Gate","Wooden Gate",
"","Luke"," "," "," "," "," "," "," "," "," "," ","4x rifle Scope","AK-47","Legumes Grenade","Poltavka","Bone","Knife","LOLLIPOP","Crossbow","SMG","kopeck piece","Cherkash","F1 Grenade","Flamethrower","Reflex Sight",
"Hunting Bow","Long Sword","LR-300 ","Gun","Beretta","Mace","Macheta","MP5","Accelerator Muzzle","Muzzle Brake","Gvozdemet","Pump Shotgun","PYTHON","Revolver","Cannon","Hatchet","Sword",
"Pawn-Gun","Berdan Rifle","Silencer","a Homemade gun","Knife","Spear Stone","Thompson","Pipe","Flashlight On a Weapon","Laser Weapon","Spear","DeVry IAC","IAC Double Door","Spiky wooden barricade",
"Construction plan","Mesh fence","Chainsaw","a screen door","Combination Lock","Concrete barricade","Closer","grating","Garage","Stone Gate","Stone Wall","Wooden Gates",
"Wooden Wall","Wooden Castle","roof ladder","Large Water collection","Metal Brigade","Metal Window (Protection)","Metal Shop","tension a Bow","Spas-12 Shotgun","Metal Window (Protection)","Metal Lattice",
"Quarry","Grid","Prison Bars (Door)","Prison Bars","Oil Roll","armored window","the ERM Grid (At the Window)","Sand Brigade","Metal Door","Double Metal Door","Derevnya Garbage ;D"," Water Collection",
"Stone Brigade","Wardrobe","Tower","Mill","Wooden Double Door","Wooden Shutters (On The Windows","Wooden Brigada","Wooden Door","Sturmova Stairs","Wooden Lattice (For Windows)","Grill",
"Bed","Jar","Fire","Chair","Storage Box","Refrigerator","Oven","Large Oven","large wooden sign","Frame (Small)","Metal","Sulphur","Tree","Stone","Corn","Pumpkin","Deer","Barrel","Box Tank","Drum"
,"Barrel","Barrel","Barrel","Barrel","Barrel","Barrel Of Oil","Oil Barrel","Barrel","Barrel Fire","A Box Of Food"," Box Food"," Box Food"," Box Food"," Box Food"," Box Food","Refrigerator","Box","Natural Medicine","WoodBox","WoodBox Big",
"Box of Food","Food Box","Box Vert","Box Vert","C4","Sacele","Rocket","Green Box","Recycler","Box Food","Fire","Fire Sentry","Mina","Trap","Wolf","Chicken","Boar","Bear","Horse","IC","Metal Pipe"};
		for (int i = 0; i < inputStr.Count(); i++)
		{
			if (displayName == inputStr[i])
			{
				result = resStr[i];
			}
		}
		return result;
	}
}
