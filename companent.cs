using System;
using System.Collections;
using System.Collections.Generic;
using ProtoBuf;
using UnityEngine;

	public class companent : MonoBehaviour
	{
		private void Start()
	{
		companent.ani = new HashSet<BaseNPC>();
		companent.base1 = new HashSet<ThrownWeapon>();
		companent.mon1 = new HashSet<TOD_Sky>();
		companent.vv = new HashSet<ItemIcon>();
		companent.ss = new HashSet<Shader>();
		companent.ssss = new HashSet<GrenadeWeapon>(); 
		companent.f = new HashSet<BaseLiquidVessel>();
		companent.stashes = new HashSet<StashContainer>();
			companent.containers = new HashSet<StorageContainer>();
			companent.hempBushes = new HashSet<CollectibleEntity>();
			companent.collectibles = new HashSet<CollectibleEntity>();
			companent.stone = new HashSet<CollectibleEntity>();
			companent.mushroom = new HashSet<CollectibleEntity>();
			companent.heli1 = new HashSet<BaseHelicopter>();
			companent.door = new HashSet<global::CodeLock>();
		companent.land1 = new HashSet<global::BearTrap>();
		companent.gg = new HashSet<ItemModProjectile>();
		companent.land = new HashSet<global::Landmine>();
			companent.oretest1 = new HashSet<BaseResource>();
			companent.combatshit = new HashSet<BaseCorpse>();
			companent.oreandtrees = new HashSet<BaseResource>();
			companent.baseentity = new HashSet<global::BaseEntity>();
			companent.oretest2 = new HashSet<BaseResource>();
			companent.shit = new HashSet<global::BuildingBlock>();
			companent.shit1 = new HashSet<global::BuildingBlock>();
		companent.shit11 = new HashSet<global::BuildingBlock>();
		companent.shit2 = new HashSet<global::BuildingBlock>();
			companent.shit3 = new HashSet<global::BuildingBlock>();
			companent.tor = new HashSet<TorchWeapon>();
			companent.metal = new HashSet<CollectibleEntity>();
			companent.trees = new HashSet<TreeEntity>(); 
			companent.sulfur = new HashSet<CollectibleEntity>();
			companent.orehotspot = new HashSet<BaseResource>();
			companent.plan1 = new HashSet<global::BaseNetworkable>();
			companent.bear = new HashSet<BearTrap>();
			companent.airdrops = new HashSet<SupplyDrop>();
			companent.oretest = new HashSet<BaseResource>();
		companent.hhh = new HashSet<BuildingPrivlidge>();
		companent.tcshit = new HashSet<BuildingPrivlidge>();
			companent.oretest21 = new HashSet<BaseResource>();
			companent.treemarkerr = new HashSet<BaseResource>();
			companent.tool = new HashSet<BaseMelee>();
			companent.bow = new HashSet<BowWeapon>();
			companent.yea = new HashSet<TimedExplosive>();
			companent.plan = new HashSet<Planner>();
			companent.baseliquid = new HashSet<BaseLiquidVessel>();
			companent.fuck = new HashSet<MedicalTool>();
			companent.autoturretsss = new HashSet<global::AutoTurret>();
			companent.niggers = new HashSet<Planner>();
			companent.strike = new HashSet<FlintStrikeWeapon>();
			companent.baseentity2 = new HashSet<global::BaseEntity>();
			companent.eokt = new HashSet<FlintStrikeWeapon>();
			companent.corpses = new HashSet<global::LootableCorpse>();
			companent.baseentity4 = new HashSet<global::BaseEntity>();
			companent.dorhackl = new HashSet<Door>();
		companent.sss = new HashSet<BasePlayer>();
		companent.ffff = new HashSet<global::AttackEntity>();
		companent.sleepingBags = new HashSet<global::SleepingBag>();
			companent.droppedItems = new HashSet<global::WorldItem>();
		companent.rojectile = new HashSet<global::BaseProjectile>();
		companent.baseentity1 = new HashSet<global::BaseEntity>();
		companent.fff = new HashSet<global::Hammer>();
		companent.combat = new HashSet<BaseCombatEntity>();
		base.StartCoroutine(companent.GetEntities());
		base.StartCoroutine(companent.GetEntities1());
	}
		public static IEnumerator GetEntities()
		{
			for (; ; )
			{
				if (LocalPlayer.Entity != null && LocalPlayer.Entity.IsValid() && global::BaseNetworkable.clientEntities != null)
			{
				companent.gg.Clear();
				companent.base1.Clear();
				companent.ani.Clear();
				companent.combat.Clear();
				companent.mon1.Clear();
				companent.fff.Clear();
				companent.vv.Clear();
				companent.sss.Clear();
				companent.ssss.Clear();
				companent.ss.Clear();
				companent.f.Clear();
				companent.rojectile.Clear();
					companent.stashes.Clear();
					companent.containers.Clear();
					companent.hempBushes.Clear();
					companent.collectibles.Clear();
					companent.fuck.Clear();
					companent.airdrops.Clear();
					companent.bear.Clear();
					companent.strike.Clear();
				companent.land1.Clear();
				companent.land.Clear();
					companent.combatshit.Clear();
					companent.shit.Clear();
					companent.shit1.Clear();
				companent.shit11.Clear();
				companent.tor.Clear();
					companent.shit2.Clear();
					companent.shit3.Clear();
					companent.heli1.Clear();
					companent.eokt.Clear();
					companent.tool.Clear();
					companent.oretest1.Clear();
					companent.oretest2.Clear();
					companent.plan1.Clear();
					companent.door.Clear();
					companent.bow.Clear();
					companent.oreandtrees.Clear();
					companent.baseentity.Clear();
					companent.orehotspot.Clear();
					companent.plan.Clear();
					companent.baseentity2.Clear();
					companent.baseliquid.Clear();
					companent.tcshit.Clear();
					companent.stone.Clear();
					companent.dorhackl.Clear();
					companent.yea.Clear();
					companent.niggers.Clear();
					companent.autoturretsss.Clear();
					companent.baseentity1.Clear();
					companent.trees.Clear();
					companent.mushroom.Clear();
					companent.metal.Clear();
					companent.baseentity4.Clear();
					companent.oretest.Clear();
					companent.treemarkerr.Clear();
					companent.oretest21.Clear();
					companent.sulfur.Clear();
					companent.corpses.Clear();
					companent.sleepingBags.Clear();
					companent.droppedItems.Clear();
				companent.ffff.Clear();
				foreach (global::BaseNetworkable baseNetworkable in global::BaseNetworkable.clientEntities)
					{
					if (baseNetworkable is ThrownWeapon && baseNetworkable != null && companent.base1 != null && (baseNetworkable as ThrownWeapon).IsValid())
					{
						companent.base1.Add(baseNetworkable as ThrownWeapon);
					}
					if (baseNetworkable is BaseNPC && baseNetworkable != null && companent.ani != null && (baseNetworkable as BaseNPC).IsValid())
					{
						companent.ani.Add(baseNetworkable as BaseNPC);
					}
					
					if (baseNetworkable is BaseCombatEntity && baseNetworkable != null && companent.combat != null && (baseNetworkable as BaseCombatEntity).IsValid())
					{
						companent.combat.Add(baseNetworkable as BaseCombatEntity);
					}
					if (baseNetworkable is GrenadeWeapon && baseNetworkable != null && companent.ssss != null && (baseNetworkable as GrenadeWeapon).IsValid())
					{
						companent.ssss.Add(baseNetworkable as GrenadeWeapon);
					}
					if (baseNetworkable is BasePlayer && baseNetworkable != null && companent.sss != null && (baseNetworkable as BasePlayer).IsValid())
					{
						companent.sss.Add(baseNetworkable as BasePlayer);
					}
					if (baseNetworkable is BaseProjectile && baseNetworkable != null && companent.rojectile != null && (baseNetworkable as BaseProjectile).IsValid())
					{
						companent.rojectile.Add(baseNetworkable as BaseProjectile);
					}
				
					if (baseNetworkable is Hammer && baseNetworkable != null && companent.fff != null && (baseNetworkable as Hammer).IsValid())
					{
						companent.fff.Add(baseNetworkable as Hammer);
					}
					if (baseNetworkable is AttackEntity && baseNetworkable != null && companent.ffff != null && (baseNetworkable as AttackEntity).IsValid())
					{
						companent.ffff.Add(baseNetworkable as AttackEntity);
					}

					if (baseNetworkable is BaseLiquidVessel && baseNetworkable != null && companent.f != null && (baseNetworkable as BaseLiquidVessel).IsValid())
					{
						companent.f.Add(baseNetworkable as BaseLiquidVessel);
					}
					if (baseNetworkable is StashContainer && baseNetworkable != null && companent.stashes != null && (baseNetworkable as StashContainer).IsValid())
						{
							companent.stashes.Add(baseNetworkable as StashContainer);
						}

						if (baseNetworkable is StorageContainer && baseNetworkable != null && companent.containers != null && (baseNetworkable as StorageContainer).IsValid())
						{
							companent.containers.Add(baseNetworkable as StorageContainer);
						}
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.hempBushes != null && (baseNetworkable as CollectibleEntity).IsValid())
						{
							companent.hempBushes.Add(baseNetworkable as CollectibleEntity);
						}
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.stone != null && (baseNetworkable as CollectibleEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("stone"))
						{
							companent.stone.Add(baseNetworkable as CollectibleEntity);
						}
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.mushroom != null && (baseNetworkable as CollectibleEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("mushroom"))
						{
							companent.mushroom.Add(baseNetworkable as CollectibleEntity);
						}
					if (baseNetworkable is global::BearTrap && baseNetworkable != null && companent.land1 != null && (baseNetworkable as global::BearTrap).IsValid())
					{
						companent.land1.Add(baseNetworkable as global::BearTrap);
					}
					if (baseNetworkable is global::Landmine && baseNetworkable != null && companent.land != null && (baseNetworkable as global::Landmine).IsValid())
						{
							companent.land.Add(baseNetworkable as global::Landmine);
						}
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.metal != null && (baseNetworkable as CollectibleEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("metal"))
						{
							companent.metal.Add(baseNetworkable as CollectibleEntity);
						}
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.sulfur != null && (baseNetworkable as CollectibleEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("sulfur"))
						{
							companent.sulfur.Add(baseNetworkable as CollectibleEntity);
						}
					
						if (baseNetworkable is CollectibleEntity && baseNetworkable != null && companent.collectibles != null && (baseNetworkable as CollectibleEntity).IsValid())
						{
							companent.collectibles.Add(baseNetworkable as CollectibleEntity);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.tool1 != null && (baseNetworkable as BaseResource).IsValid())
						{
							companent.tool1.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is FlintStrikeWeapon && baseNetworkable != null && companent.strike != null && (baseNetworkable as FlintStrikeWeapon).IsValid())
						{
							companent.strike.Add(baseNetworkable as FlintStrikeWeapon);
						}
						if (baseNetworkable is SupplyDrop && baseNetworkable != null && companent.airdrops != null && (baseNetworkable as SupplyDrop).IsValid())
						{
							companent.airdrops.Add(baseNetworkable as SupplyDrop);
						}
						if (baseNetworkable is TreeEntity && baseNetworkable != null && companent.trees != null && (baseNetworkable as TreeEntity).IsValid())
						{
							companent.trees.Add(baseNetworkable as TreeEntity);
						}
						if (baseNetworkable is BaseMelee && baseNetworkable != null && companent.tool != null && (baseNetworkable as BaseMelee).IsValid())
						{
							companent.tool.Add(baseNetworkable as BaseMelee);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.oretest != null && (baseNetworkable as BaseResource).IsValid() && baseNetworkable.ShortPrefabName.Contains("stone"))
						{
							companent.oretest.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.oretest1 != null && (baseNetworkable as BaseResource).IsValid() && baseNetworkable.ShortPrefabName.Contains("metal"))
						{
							companent.oretest1.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is BearTrap && baseNetworkable != null && companent.bear != null && (baseNetworkable as BearTrap).IsValid())
						{
							companent.bear.Add(baseNetworkable as BearTrap);
						}
						if (baseNetworkable is TimedExplosive && baseNetworkable != null && companent.yea != null && (baseNetworkable as TimedExplosive).IsValid())
						{
							companent.yea.Add(baseNetworkable as TimedExplosive);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.oretest2 != null && (baseNetworkable as BaseResource).IsValid() && baseNetworkable.ShortPrefabName.Contains("sulfur"))
						{
							companent.oretest2.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.oretest21 != null && (baseNetworkable as BaseResource).IsValid())
						{
							companent.oretest21.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is MedicalTool && baseNetworkable != null && companent.fuck != null && (baseNetworkable as MedicalTool).IsValid())
						{
							companent.fuck.Add(baseNetworkable as MedicalTool);
						}
						if (baseNetworkable is global::BaseEntity && baseNetworkable != null && companent.baseentity != null && (baseNetworkable as global::BaseEntity).IsValid())
						{
							companent.baseentity.Add(baseNetworkable as global::BaseEntity);
						}
						if (baseNetworkable is global::BaseEntity && baseNetworkable != null && companent.baseentity4 != null && (baseNetworkable as global::BaseEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("collectableegg"))
						{
							companent.baseentity4.Add(baseNetworkable as global::BaseEntity);
						}
						if (baseNetworkable is global::BaseEntity && baseNetworkable != null && companent.baseentity1 != null && (baseNetworkable as global::BaseEntity).IsValid() && baseNetworkable.ShortPrefabName.Contains("stash"))
						{
							companent.baseentity1.Add(baseNetworkable as global::BaseEntity);
						}
						if (baseNetworkable is global::BaseEntity && baseNetworkable != null && companent.baseentity2 != null && (baseNetworkable as global::BaseEntity).IsValid())
						{
							companent.baseentity2.Add(baseNetworkable as global::BaseEntity);
						}
						if (baseNetworkable is BaseCorpse && baseNetworkable != null && companent.combatshit != null && (baseNetworkable as BaseCorpse).IsValid())
						{
							companent.combatshit.Add(baseNetworkable as BaseCorpse);
						}
						if (baseNetworkable is Planner && baseNetworkable != null && companent.plan != null && (baseNetworkable as Planner).IsValid())
						{
							companent.plan.Add(baseNetworkable as Planner);
						}
						if (baseNetworkable is TorchWeapon && baseNetworkable != null && companent.tor != null && (baseNetworkable as TorchWeapon).IsValid())
						{
							companent.tor.Add(baseNetworkable as TorchWeapon);
						}
						if (baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit11 != null && (baseNetworkable as global::BuildingBlock).IsValid() && baseNetworkable.ShortPrefabName.Contains("wall"))
						{
							companent.shit11.Add(baseNetworkable as global::BuildingBlock);
						}
						if (baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit11 != null && (baseNetworkable as global::BuildingBlock).IsValid() && baseNetworkable.ShortPrefabName.Contains("foundation"))
						{
							companent.shit11.Add(baseNetworkable as global::BuildingBlock);
						}
						if (baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit11 != null && (baseNetworkable as global::BuildingBlock).IsValid() && baseNetworkable.ShortPrefabName.Contains("block"))
						{
							companent.shit11.Add(baseNetworkable as global::BuildingBlock);
						}
						if (baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit11 != null && (baseNetworkable as global::BuildingBlock).IsValid() && baseNetworkable.ShortPrefabName.Contains("floor"))
						{
							companent.shit11.Add(baseNetworkable as global::BuildingBlock);
						}
					bool flag39 = baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit11 != null && (baseNetworkable as global::BuildingBlock).IsValid() && baseNetworkable.ShortPrefabName.Contains("roof");
					if (flag39)
					{
						companent.shit11.Add(baseNetworkable as global::BuildingBlock);
					}
				
						if (baseNetworkable is global::BuildingBlock && baseNetworkable != null && companent.shit != null && (baseNetworkable as global::BuildingBlock).IsValid() )
						{
							companent.shit.Add(baseNetworkable as global::BuildingBlock);
						}
						if (baseNetworkable is BaseHelicopter && baseNetworkable != null && companent.heli1 != null && (baseNetworkable as BaseHelicopter).IsValid())
						{
							companent.heli1.Add(baseNetworkable as BaseHelicopter);
						}
						if (baseNetworkable is BowWeapon && baseNetworkable != null && companent.bow != null && (baseNetworkable as BowWeapon).IsValid())
						{
							companent.bow.Add(baseNetworkable as BowWeapon);
						}
						if (baseNetworkable is Door && baseNetworkable != null && companent.dorhackl != null && (baseNetworkable as Door).IsValid())
						{
							companent.dorhackl.Add(baseNetworkable as Door);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.orehotspot != null && (baseNetworkable as BaseResource).IsValid())
						{
							companent.orehotspot.Add(baseNetworkable as BaseResource);
						}
						if (baseNetworkable is Planner && baseNetworkable != null && companent.niggers != null && (baseNetworkable as Planner).IsValid())
						{
							companent.niggers.Add(baseNetworkable as Planner);
						}
						if (baseNetworkable is BaseLiquidVessel && baseNetworkable != null && companent.baseliquid != null && (baseNetworkable as BaseLiquidVessel).IsValid())
						{
							companent.baseliquid.Add(baseNetworkable as BaseLiquidVessel);
						}
						if (baseNetworkable != null && baseNetworkable != null && companent.plan1 != null)
						{
							companent.plan1.Add(baseNetworkable);
						}
						if (baseNetworkable is BuildingPrivlidge && baseNetworkable != null && companent.tcshit != null)
						{
							companent.tcshit.Add(baseNetworkable as BuildingPrivlidge);
						}
						if (baseNetworkable is global::AutoTurret && baseNetworkable != null && companent.autoturretsss != null)
						{
							companent.autoturretsss.Add(baseNetworkable as global::AutoTurret);
						}
						if (baseNetworkable is FlintStrikeWeapon && baseNetworkable != null && companent.eokt != null && (baseNetworkable as FlintStrikeWeapon).IsValid())
						{
							companent.eokt.Add(baseNetworkable as FlintStrikeWeapon);
						}
						if (baseNetworkable is BaseResource && baseNetworkable != null && companent.treemarkerr != null && (baseNetworkable as BaseResource).IsValid())
						{
							companent.treemarkerr.Add(baseNetworkable as BaseResource);
						}
					BaseResource oreandtrees;
						if ((oreandtrees = (baseNetworkable as BaseResource)) != null && oreandtrees != null && oreandtrees.IsValid())
						{
							companent.oreandtrees.Add(oreandtrees);
						}
						global::LootableCorpse lootableCorpse;
						if ((lootableCorpse = (baseNetworkable as global::LootableCorpse)) != null && lootableCorpse != null && lootableCorpse.IsValid())
						{
							companent.corpses.Add(lootableCorpse);
						}
						global::SleepingBag sleepingBag;
						if ((sleepingBag = (baseNetworkable as global::SleepingBag)) != null && sleepingBag != null && sleepingBag.IsValid())
						{
							companent.sleepingBags.Add(sleepingBag);
						}
						global::CodeLock door;
						if ((door = (baseNetworkable as global::CodeLock)) != null && door != null && door.IsValid())
						{
							companent.door.Add(door);
						}
						global::WorldItem worldItem;
						if ((worldItem = (baseNetworkable as global::WorldItem)) != null && worldItem != null && worldItem.IsValid())
						{
							companent.droppedItems.Add(worldItem);
						}
					}
				}
				yield return new WaitForSeconds(0.5f);
			}
			yield break;
		}
	public static IEnumerator GetEntities1()
	{
		for (; ; )
		{
			if (LocalPlayer.Entity != null && LocalPlayer.Entity.IsValid() && global::BaseNetworkable.clientEntities != null)
			{
				companent.hhh.Clear();

				foreach (global::BaseNetworkable baseNetworkable in global::BaseNetworkable.clientEntities)
				{
					if (baseNetworkable is BuildingPrivlidge && baseNetworkable != null && companent.hhh != null && (baseNetworkable as BuildingPrivlidge).IsValid())
					{
						companent.hhh.Add(baseNetworkable as BuildingPrivlidge);
					}
				}
			}
			yield return new WaitForSeconds(10f);
		}
		yield break;
	}


	public static HashSet<BuildingPrivlidge> hhh;

	public static HashSet<ItemModProjectile> gg;
	 
	public static HashSet<ThrownWeapon> base1;
	public static HashSet<TOD_Sky> mon1;
	public static HashSet<TerrainPath> mon;
		public static HashSet<Planner> niggers;
		public static HashSet<BaseEntity> baseentity4;
		public static HashSet<BaseCombatEntity> combat;
		public static HashSet<AutoTurret> autoturretsss;
		public static HashSet<Door> dorhackl;
		public static HashSet<BaseLiquidVessel> baseliquid;
		public static HashSet<FlintStrikeWeapon> eokt;
		public static HashSet<TimedExplosive> yea;
	public static HashSet<Hammer> fff;
		public static HashSet<BowWeapon> bow;
		public static HashSet<TorchWeapon> tor;
		public static HashSet<StashContainer> stashes;
		public static HashSet<Planner> plan;
		public static HashSet<BaseNetworkable> plan1;
		public static HashSet<StorageContainer> containers;
		public static HashSet<BaseHelicopter> heli1;
		public static HashSet<BuildingBlock> shit;
	public static HashSet<ItemIcon> vv;
	public static HashSet<BuildingBlock> shit1;
	public static HashSet<BuildingBlock> shit11;
	public static HashSet<BuildingBlock> shit2;
		public static HashSet<BuildingBlock> shit3;
		public static HashSet<CollectibleEntity> hempBushes;
		public static HashSet<CollectibleEntity> collectibles;
	public static HashSet<AttackEntity> ffff;
	public static HashSet<CollectibleEntity> stone;
		public static HashSet<BaseResource> oreandtrees;
		public static HashSet<BaseCorpse> combatshit;
		public static HashSet<BaseResource> oretest21;
		public static HashSet<CollectibleEntity> mushroom;
		public static HashSet<BaseResource> oretest;
		public static HashSet<BaseResource> treemarkerr;
		public static HashSet<BaseResource> orehotspot;
		public static HashSet<BaseResource> oretest1; public static HashSet<BaseLiquidVessel> f;
	public static HashSet<BaseResource> oretest2;
		public static HashSet<CollectibleEntity> metal;
		public static HashSet<TreeEntity> trees;
		public static HashSet<BuildingPrivlidge> tcshit;
		public static HashSet<Landmine> land;
	public static HashSet<BearTrap> land1;
	public static HashSet<BaseEntity> baseentity2;
		public static HashSet<BaseEntity> baseentity;
		public static HashSet<BaseEntity> baseentity1;
		public static HashSet<CodeLock> door;
		public static HashSet<CollectibleEntity> sulfur;
		public static HashSet<SupplyDrop> airdrops;
		public static HashSet<LootableCorpse> corpses;
		public static HashSet<SleepingBag> sleepingBags;
		public static HashSet<MedicalTool> fuck;
		public static HashSet<BaseMelee> tool;
		public static HashSet<BaseResource> tool1;
		public static HashSet<BearTrap> bear;
		public static HashSet<FlintStrikeWeapon> strike;
		public static HashSet<PlayerProjectileAttack> attack;
	public static HashSet<BaseProjectile> rojectile;
	public static HashSet<WorldItem> droppedItems;
	public static HashSet<Shader> ss;
	public static HashSet<BasePlayer> sss;
	public static HashSet<GrenadeWeapon> ssss;
	public static HashSet<BaseNPC> ani;
}
