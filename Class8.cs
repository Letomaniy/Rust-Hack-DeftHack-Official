using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class AutoFarm2 : MonoBehaviour
{
	private void Update()
	{
		if (CFG.Misc.hgf && LocalPlayer.Entity && LocalPlayer.Entity.IsValid() && Time.time >= this.nextAttack && global::BasePlayer.visiblePlayerList != null)
		{
			foreach (StorageContainer storageContainer in companent.containers)
			{
				if (storageContainer != null && storageContainer.IsValid() && storageContainer.ShortPrefabName.Contains("barrel"))
				{
					Vector3 position = storageContainer.transform.position;
					global::HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
					if (heldEntity != null && heldEntity.IsValid() && storageContainer.ShortPrefabName.Contains("barrel"))
					{
						float num = Vector3.Distance(LocalPlayer.Entity.transform.position, storageContainer.transform.position);
						BaseMelee baseMelee = heldEntity as BaseMelee;
						if (baseMelee != null && baseMelee.IsValid() && num < 7f && storageContainer.ShortPrefabName.Contains("barrel"))
						{
							using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
							{
										Effect.client.Run("assets/bundled/prefabs/fx/entities/loot_barrel/impact.prefab",storageContainer.gameObject);
								playerAttack.attack = new Attack
								{
									hitID = storageContainer.net.ID,
									hitBone = 0U,
									hitPartID = 0U,
									hitMaterialID = 0U,
									hitItem = 0U,
									hitPositionWorld = storageContainer.transform.position,
									hitPositionLocal = new Vector3(-0.1f, -1f, 0f),
									hitNormalLocal = new Vector3(0f, -1f, 0f),
									hitNormalWorld = (MainCamera.mainCamera.transform.position - storageContainer.transform.position).normalized,
									pointStart = MainCamera.mainCamera.transform.position,
									pointEnd = storageContainer.transform.position
								};
								baseMelee.ServerRPC("PlayerAttack", playerAttack,null,null,null,null);
							}
							this.nextAttack = Time.time + baseMelee.repeatDelay;
						}
					}
				}
			}
		}
		

	}
	
	public static bool Enabled;
	private float nextAttack;
	public static int g;
}
