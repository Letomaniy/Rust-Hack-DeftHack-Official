using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ProtoBuf;
using UnityEngine;
using UnityEngine.UI;
using ConVar;
using System.Text;
using System.Diagnostics;

public class hack2 : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(autopick11());
		StartCoroutine(autopick1());
		StartCoroutine(autopick());
	}
	
	private IEnumerator autopick1()
	{
		while (true)
		{
			try
			{



				if (menu.bbf)
				{
					foreach (StashContainer r in companent.stashes)
					{
						
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 3f)
							{
								r.ServerRPC("RPC_WantsUnhide");
							}
						}

					}
				}
				


			}
			catch (Exception)
			{

			}
			yield return new WaitForSeconds(0.3f);
		}
	}
	private IEnumerator autopick11()
	{
		while (true)
		{
			try
			{



				if (menu.xyi)
				{
					foreach (TorchWeapon codeLock in companent.tor)
					{
						int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codeLock.transform.position);
						if (lock_distance <= 2f && !codeLock.IsOnFire() && !codeLock.IsOn())
						{
							codeLock.ServerRPC("Ignite");
						}
					}
				}
				foreach (BaseProjectile baseProjectile in companent.rojectile)
				{
					if (!(baseProjectile == null))
					{
						
						if (CFG.Aimbot.dgvcbb)
						{
							BaseProjectile heldGun = LocalPlayer.Entity.GetHeldEntity() as global::BaseProjectile;
							if (heldGun != null && heldGun.IsValid())
							{
								if (heldGun.primaryMagazine.contents <= 0)

								{
									baseProjectile.ServerRPC("Reload", null, null, null, null, null);

								}
							}
						}
						


					}

				}

			}
			catch (Exception)
			{

			}
			yield return new WaitForSeconds(0.8f);
		}
	}
	private IEnumerator autopick()
	{
		while (true)
		{
			try
			{

				

				if (CFG.Misc.asarwad)
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("hemp"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (menu.test411 && UnityEngine.Input.GetKey(KeyCode.Keypad5))
				{
					if (LocalPlayer.Entity != null)
					{
						LocalPlayer.Entity.ServerRPC("OnPlayerLanded", 10,null,null);
					}
				}
				if (CFG.Misc.nbnhg)
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("metal"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (CFG.Misc.vcgdcv)
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("stone") || r.name.Contains("wood"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (CFG.Misc.iopiop)
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("sulfur"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (CFG.Misc.ooppoo )
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("corn"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (CFG.Misc.mnbvc)
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("pumpkin"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				if (CFG.Misc.adfsaa )
				{
					foreach (CollectibleEntity r in companent.collectibles)
					{
						if (r.name.Contains("mushroom"))
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
							if (lock_distance <= 6f)
							{
								r.ServerRPC("pickup");
							}
						}

					}
				}
				
				if (CFG.Misc.adsfbc)
				{
					foreach (WorldItem r in companent.droppedItems)
					{
						int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
						if (lock_distance <= 4.3f)
						{
							r.ServerRPC("Pickup");
						}
					}
					foreach (TimedExplosive r in companent.yea)
					{
						int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
						if (lock_distance <= 4.3f)
						{
							r.ServerRPC("RPC_Pickup");
						}
					}
				}

				if (CFG.Misc.yyttrrfff)
				{
					foreach(BaseLiquidVessel build in companent.f)
					{
						
						if (build != null)
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, build.transform.position);
							if (build != null && lock_distance <= 4f)
							{
								build.ServerRPC("DoDrink");
							}
						}
					}
				}
				if (CFG.Misc.mmnb && UnityEngine.Input.GetKey(KeyCode.B))
				{
					foreach(Door f in companent.dorhackl)
					{
						
						if (f != null)
						{
							int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, f.transform.position);
							if (f != null && lock_distance <= 4f)
							{
								f.ServerRPC("RPC_OpenDoor");
								f.ServerRPC("RPC_CloseDoor");
								
								f.ServerRPC("RPC_KnockDoor");
							}
						}
					}
				}
				if (CFG.Misc.authh && UnityEngine.Input.GetKey(KeyCode.B))
				{
					foreach (LootableCorpse lootableCorpse in companent.corpses)
					{

						if (lootableCorpse != null)
						{
							
								int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, lootableCorpse.transform.position);
								if (lootableCorpse != null && lock_distance <= 5f)
								{
								lootableCorpse.ServerRPC("RPC_LootCorpse", null, null, null, null);
							}
							
						}
					}
				}
				
			}
			catch (Exception)
			{

			}
			yield return new WaitForSeconds(0.09f);
		}
	}
	
	

}

