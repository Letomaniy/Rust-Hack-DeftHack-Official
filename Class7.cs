using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

public class AUTO : MonoBehaviour
{
	private void Update()
	{
		
		if (CFG.Misc.bvbvn && Time.time >= this.nextAttack)
		{
			foreach (BaseResource ore in companent.orehotspot)
			{
				
				
				if (ore != null )
				{
					
						Vector3 position = ore.transform.position;
						HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
						if (heldEntity != null)
						{
							
								BaseMelee baseMelee = heldEntity as BaseMelee;
							if (baseMelee != null )
							{
								float num = Vector3.Distance(LocalPlayer.Entity.transform.position, ore.transform.position);
								global::Item activeItem = LocalPlayer.Entity.belt.GetActiveItem();
								if (num < 5 && !ore.isDestroyed && activeItem != null && (activeItem.info.shortname.Contains("bone.club") || activeItem.info.shortname.Contains("hammer.salvaged") || activeItem.info.shortname.Contains("icepick.salvaged") || activeItem.info.shortname.Contains("pickaxe") || activeItem.info.shortname.Contains("stone.pickaxe") || activeItem.info.shortname.Contains("rock") || activeItem.info.shortname.Contains("jackhammer")))
								{

									using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
									{
									Effect.client.Run("assets/bundled/prefabs/fx/impacts/blunt/metalore/slash_metalore_01.prefab", ore.gameObject);
									playerAttack.attack = new Attack
										{
									hitID = ore.net.ID,
											hitBone = 0U,
											hitItem = 0U,
											hitPartID = 0U,
											hitMaterialID = 97517300U,
											hitPositionWorld = position,
											hitPositionLocal = position,
											hitNormalLocal = position,
											hitNormalWorld = position,
											pointStart = position,
											pointEnd = position
								};
										baseMelee.ServerRPC("PlayerAttack", playerAttack, null, null, null, null);
									}
									this.nextAttack = Time.time + baseMelee.repeatDelay;
								}

							
						}
					}
				}
			}
		}
		if (menu.farm  && Time.time >= this.nextAttack )
		{
			foreach (TreeEntity tree in companent.trees)
			{

				if (tree != null )
				{
					if (tree != null )
					{
						Vector3 position = tree.transform.position;
						HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
						if (heldEntity != null)
						{
							BaseMelee baseMelee = heldEntity as BaseMelee;
							if (baseMelee != null )
							{
								global::Item activeItem = LocalPlayer.Entity.belt.GetActiveItem();
								if (Vector3.Distance(LocalPlayer.Entity.transform.position, tree.transform.position) < 3f && !tree.isDestroyed && activeItem != null && (activeItem.info.shortname.Contains("stonehatchet") || activeItem.info.shortname.Contains("hatchet") || activeItem.info.shortname.Contains("hammer.salvaged") || activeItem.info.shortname.Contains("chainsaw") || activeItem.info.shortname.Contains("bone.club") || activeItem.info.shortname.Contains("rock") || activeItem.info.shortname.Contains("axe.salvaged")))
								{


									using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
									{
										Effect.client.Run("assets/bundled/prefabs/fx/entities/tree/tree-impact.prefab", tree.gameObject);
										playerAttack.attack = new Attack
										{
											hitID = tree.net.ID,
											hitBone = 0U,
											hitItem = 0U,
											hitPartID = 0U,
											hitMaterialID = 97517300U,
											hitPositionWorld = position,
											hitPositionLocal = position,
											hitNormalLocal = position,
											hitNormalWorld = position,
											pointStart = position,
											pointEnd = position
										};
										baseMelee.ServerRPC("PlayerAttack", playerAttack, null, null, null, null);
									}
									this.nextAttack = Time.time + baseMelee.repeatDelay;
								}
							}
						
						}
					}
				}
			}
		}
	} 

// Token: 0x0400000B RID: 11
private float nextAttack;
}
