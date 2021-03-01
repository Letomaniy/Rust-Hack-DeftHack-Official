using ConVar;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ESP : MonoBehaviour
{
	public static void f1()
	{
		try
		{
			if (CFG.ESP.dgdgd && companent.corpses != null)
			{
				foreach (LootableCorpse lootableCorpse in companent.corpses)
				{
					if (lootableCorpse != null)
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(lootableCorpse.transform.position);
						if (vector.z > 0f)
						{
							int corpse_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, lootableCorpse.transform.position);

							if (corpse_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format((menu.enru ? "[Corpse] {0}" : "[Труп] {0}"), lootableCorpse.playerName, corpse_distance),new Color32(214, 32, 132,255), true, 8);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{1}м]", lootableCorpse.playerName, corpse_distance), new Color32(214, 32, 132, 255), true, 8);
							}
						}
					}
				}
			}
			if (CFG.ESP.fgfddd)
			{

				{
					foreach (Door door in companent.dorhackl)
					{
						if (door != null)
						{
							Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(door.transform.position);
							if (vector.z > 0f)
							{
								int distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position,
									door.transform.position);
								if (distance <= WorldEspDistance)
								{
									vector.x += 3f;
									vector.y = Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y),
										string.Format("{0}",
											menu.enru ? Translt.Translate1(door.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", "")) : traah.Translate(door.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", "")),
											distance),new Color32(105, 153, 38,255), true, 9);
								}
							}
						}
					}
				}
			}
			
		}
		catch
		{
		}
	}
	public static void f2()
	{
		

		if (CFG.ESP.dsfsf)
		{
			foreach (BaseHelicopter b in companent.heli1)
				if (b != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(b.transform.position);
					Vector3 screenPos = Players.GetScreenPos(b.mainRotor.transform.position + new Vector3(0f, 0.3f, 0f));
					float num4 = Mathf.Abs(vector.y - screenPos.y);
					float width = num4 / 2f;
					//   if(RustInternal.Config.ESP.helialert)"[" + (int)basePlayer.health + "HP] ", new Color32(45, 186, 2, 255)
					Rendering.DrawString1(new Vector2(Screen.width / 2, Screen.height / 25), string.Format((menu.enru ? "[{0} HP]" : "[{0} HP]"), (int)b.health), new Color32(45, 186, 2, 255), true, 11);
					Rendering.DrawString1(new Vector2(Screen.width / 2, 4f), string.Format((menu.enru ? "[Heli Alert]" : "[Верт Вылетел]"), (int)b.health), Color.red, true, 11);
					if (vector.z > 0f)
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, b.transform.position);

						if (Distance <= 11111)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("{0}", (menu.enru ?  "Heli" : "Верт")), new Color32(51, 255, 0, 255), true, 9, FontStyle.Normal);
							Rendering.DrawString1(new Vector2(vector.x, vector.y + 10), string.Format(" [{0}м]",  Distance), new Color32(51, 255, 0, 255), true, 9, FontStyle.Normal);
							
							Rendering.Health(vector.x, vector.y  + 4, b.health,10000f, 45, 7, 1f);
							



						}
					
					}
				}
		}
		
		
		if (CFG.ESP.e)
		{
			foreach (StashContainer t in companent.stashes)
				if (t != null && t.IsHidden())
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
					if (vector.z > 0f)
					{
						int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);
						if (tc_distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "Stash" : "Стеш"), tc_distance), new Color32(255, 255, 255, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y-20), string.Format("{0}", (menu.enru ? "Closed" : "Закрыт"), tc_distance), Color.green, true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{1}м]", "Стеш-Закрыт", tc_distance), new Color32(255, 255, 255, 255), true, 8);
						}

					}
				}
		}
		if (CFG.ESP.e)
		{
			foreach (StashContainer t in companent.stashes)
				if (t != null && !t.IsHidden())
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
					if (vector.z > 0f)
					{
						int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);
						if (tc_distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "Stash" : "Стеш"), tc_distance),new Color32(255, 255, 255, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y-20), string.Format("{0}", (menu.enru ? "Open" : "Открыт"), tc_distance), Color.red, true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{1}м]", "Стеш-Открыт", tc_distance), new Color32(255, 255, 255, 255), true, 8);
						}

					}
				}
		}

		if (CFG.ESP.r)
		{
			foreach (SupplyDrop r in companent.airdrops)
				if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f)
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= 11111)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Supply Drop" : "АирДроп")), new Color32(48, 204, 0,255), true,10);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(48, 204, 0, 255), true,10);
						}
					}
				}
		}
		if (menu.bag)
		{
			foreach (SleepingBag r in companent.sleepingBags)
				if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f)
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= 11111)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format((menu.enru ? "Name:[{0}]" : "Название:[{0}]"), r.niceName), new Color32(48, 204, 0, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0} SteamID]", r.deployerUserID), new Color32(48, 204, 0, 255), true, 8);
						}
					}
				}
		}
		if (CFG.ESP.t)
		{
			foreach (DroppedItem r in companent.droppedItems)
				if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f)
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 20f), string.Format("[{0}шт]", r.item.amount), new Color32(163, 9, 184,255), true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? r.item.info.displayName.english : traah.Translate(r.item.info.displayName.english)), Distance), new Color32(163, 9, 184, 255), true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{1}м]", r.item.info.displayName.english, Distance), new Color32(163, 9, 184, 255), true, 9);

							if (CFG.ESP.corpse)
							{
								Texture2D text = r.item.info.iconSprite.texture;
								GUI.DrawTexture(new Rect(vector.x, vector.y + 10, 32f, 32f), text);
							}
						}
					}
				}
		}
		if (CFG.ESP.y)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("food") || t.PrefabName.Contains("trash-pile-1"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (tc_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y-10), string.Format("{0}", (menu.enru ? "Food" : "Ящик С Едой"), tc_distance), new Color32(67, 209, 81, 255), true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", tc_distance), new Color32(67, 209, 81, 255), true, 9);
							}
						}
					}
				}
		}
		if (menu.test4)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("recycler"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (tc_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "Recycler" : "Переработчик"), tc_distance), Color.yellow, true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", tc_distance), Color.yellow, true, 9);
								


							}
						}
					}
				}
		}
		if (CFG.ESP.u)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("crate_normal_2"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (tc_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "Crate" : "Коробка")), new Color32(40, 46, 19, 255), true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", tc_distance), new Color32(40, 46, 19, 255), true, 9);
							}
						}
					}
				}
		}
		if (CFG.ESP.i)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("crate_normal") && !t.PrefabName.Contains("crate_normal_2"))
					{

						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (tc_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "Green Crate" : "Зелёный Ящик")), new Color32(21, 255, 0, 255), true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", tc_distance), new Color32(21, 255, 0, 255), true, 9);
							}
						}
					}
				}
		}
		if (CFG.ESP.o)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("crate_elite"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (tc_distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y-10), string.Format("{0}", (menu.enru ? "Elite Crate" : "Элитный Ящик")), new Color32(21, 255, 0, 255), true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  tc_distance), new Color32(21, 255, 0, 255), true, 9);
							}
						}
					}
				}
		}
		if (CFG.ESP.p)
		{
			foreach (AutoTurret t in companent.autoturretsss)
				if (t != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
					if (vector.z > 0f)
					{
						int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

						if (tc_distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f); Rendering.DrawString1(new Vector2(vector.x, vector.y - 20), string.Format("{0}", (int)t.health), Color.green, true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10), string.Format("{0}", (menu.enru ? "AutoTurret" : "АвтоТурель")), new Color32(217, 92, 2, 255), true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", tc_distance), new Color32(217, 92, 2, 255), true, 9);
						}
						if (menu.turr)
						{
							List<ProtoBuf.PlayerNameID> list = new List<ProtoBuf.PlayerNameID>();
							list = t.authorizedPlayers;
							for (int i = 0; i < list.Count; i++)
							{

								Rendering.DrawString1(new Vector2(vector.x, vector.y -20f - (float)(i + 1) * 10f), list[i].username + " - " + list[i].userid, new Color32(153, 145, 0, 255), true, 8);
							}
						}
					}
				}
		}
		
		if (CFG.ESP.s)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.ShortPrefabName.Contains("barrel"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (Distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Barrel" : "Бочка"), Distance), new Color32(10, 51, 255, 255), true, 9);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), new Color32(10, 51, 255, 255), true, 9);
							}
						}
					}
				}
		}
		if (CFG.ESP.d)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if (t.PrefabName.Contains("bradley_crate") )
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (Distance <= WorldEspDistance)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								if (CFG.ESP.d && !t.IsOnFire())
								{
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 20), string.Format("{0}", (menu.enru ? "Tank Crate" : "Ящик Танк")), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("[{0}м]", Distance), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
								}
								if (t.IsOnFire() && CFG.ESP.d)
								{
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 20), string.Format("{0}", (menu.enru ? "Tank Crate" : "Ящик Танк")), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("[{0}м]", Distance), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
									Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}]", (menu.enru ? "On Fire" : "В Огне")), Color.red, true, 9, FontStyle.Normal);
								}
							}
						}
					}
				}
		}
		if (CFG.ESP.d)
		{
			foreach (StorageContainer t in companent.containers)
				if (t != null)
				{
					if ( t.PrefabName.Contains("heli_crate"))
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
						if (vector.z > 0f)
						{
							int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);

							if (Distance <= WorldEspDistance )
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								if(CFG.ESP.d && !t.IsOnFire())
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 20), string.Format("{0}", (menu.enru ? "Heli Crate" : "Ящик Верт")), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("[{0}м]",  Distance), new Color32(36, 255, 101, 255), true, 9,FontStyle.Normal);


								if(t.IsOnFire() && CFG.ESP.d)
                                {
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 20), string.Format("{0}", (menu.enru ? "Heli Crate" : "Ящик Верт")), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("[{0}м]", Distance), new Color32(36, 255, 101, 255), true, 9, FontStyle.Normal);
									Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}]", (menu.enru ? "On Fire" : "В Огне")), Color.red, true, 9, FontStyle.Normal);
								}
							}
						

						}
					}
				}
		}
		if (CFG.ESP.f)
		{
			foreach (TimedExplosive r in companent.yea)
				if (r != null)
				{
					{
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
						if (vector.z > 0f)
						{
							int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
							if (Distance <= 9999)
							{
								vector.x += 3f;
								vector.y = UnityEngine.Screen.height - (vector.y + 1f);
								Rendering.DrawString1(new Vector2(vector.x, vector.y-15), string.Format("{0}", "<size=20>✴</size>"), new Color32(219, 0, 44,255), true, 12, FontStyle.Normal);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(219, 0, 44, 255), true, 11, FontStyle.Normal);
							}
						}
					}
				}
		}
		if (CFG.ESP.g)
		{
			foreach (BaseNPC a in companent.ani)
				if (a != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(a.transform.position);
					if (vector.z > 0f)
					{
						int animal_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, a.transform.position);
						Vector3 screenPos = Players.GetScreenPos(a.transform.position + new Vector3(0f, 0.6f, 0f));
						float num4 = Mathf.Abs(vector.y - screenPos.y);
						float width = num4 / 2f;
						if (animal_distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", menu.enru ? Translt.Translate1(a.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", "")) : traah.Translate(a.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", ""))),new Color32(189, 124, 26, 255), true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  animal_distance),new Color32(189, 124, 26,255), true, 9);

							Rendering.DrawVerticalHealth(new Vector2(vector.x, vector.y), width, num4, a.health);
						}
					}
				}
		}
		if (CFG.ESP.rtfgd)
		{
			foreach (BaseResource r in companent.oretest) if (r != null)
				{

					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("stone"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);

						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f); 
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Stone" : "Камень")), new Color32(255, 255, 255, 255), true, 9);

							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(255, 255, 255, 255), true, 9);
						}
					}

				}
		}

		if (CFG.ESP.cvdfg)
		{
			foreach (BaseResource r in companent.oretest1) if (r != null)
				{

					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("metal"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);

						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Metal" : "Метал")), UnityEngine.Color.gray, true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), UnityEngine.Color.gray, true, 9);
						}
					}

				}
		}

		if (CFG.ESP.ytcbcv)
		{
			foreach (BaseResource r in companent.oretest2) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("sulfur"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);

						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Sulfur" : "Сера")), new Color32(255, 255, 75, 255), true, 9);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(255, 255, 75, 255), true, 9);
						}
					}
				}
		}
		if (CFG.ESP.fdgvcbd)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{

					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("hemp") && BaseEntityEx.IsValid(r))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Hemp" : "Ткань")), new Color32(1, 115, 9, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), new Color32(1, 115, 9, 255), true, 8);
						}
					}

				}
		}
		if (CFG.ESP.bvcbfdge)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("mushroom"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), string.Format("{0}", (menu.enru ? "Mushroom" : "Гриб")), new Color32(28, 36, 17, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(28, 36, 17, 255), true, 8);
						}
					}
				}
		}
		if (CFG.ESP.vbcbc)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("metal"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Metal" : "Метал")), UnityEngine.Color.gray, true, 6);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), UnityEngine.Color.gray, true, 6);
						}
					}
				}
		}
		if (CFG.ESP.iiii)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("sulfur"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Sulfur" : "Сера")), new Color32(255, 255, 75, 255), true, 6);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), new Color32(255, 255, 75, 255), true, 6);
						}
					}
				}
		}
		if (CFG.ESP.ytytf)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("stone-collectable"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Stone" : "Камень")), new Color32(255, 255, 255, 255), true, 6);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), new Color32(255, 255, 255, 255), true, 6);
						}
					}
				}
		}
		if (CFG.ESP.fdgdg)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("wood"))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Wood" : "Дерево")), new Color32(109, 120, 46, 255), true, 6);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]", Distance), new Color32(109, 120, 46, 255), true, 6);
						}
					}
				}
		}
		if (CFG.ESP.rererrr)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("pumpkin") && BaseEntityEx.IsValid(r))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Pumpkin" : "Тыква")), new Color32(188, 209, 0, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(188, 209, 0, 255), true, 8);
						}
					}
				}
		}
		if (CFG.ESP.gfgrttt)
		{
			foreach (CollectibleEntity r in companent.collectibles) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f && r.name.Contains("corn") && BaseEntityEx.IsValid(r))
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= range)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y - 7), string.Format("{0}", (menu.enru ? "Corn" : "Кукуруза")), new Color32(188, 209, 0, 255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y ), string.Format("[{0}м]", Distance), new Color32(188, 209, 0,255), true, 8);
						}
					}
				}
		}
		if (CFG.ESP.bvbcfd)
		{
			foreach (StorageContainer r in companent.containers) if (r != null)
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(r.transform.position);
					if (vector.z > 0f)
					{
						int Distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, r.transform.position);
						if (Distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							bool flag5 = r.ShortPrefabName.Contains("wood");
							if (flag5)
							{
								Rendering.DrawString1(new Vector2(vector.x, vector.y-10), string.Format("{0}", menu.enru ? Translt.Translate1(r.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", "")) : traah.Translate(r.ShortPrefabName.Replace(".prefab", "").Replace("_deployed", "")), Distance), new Color32(67, 204, 197, 255), true, 8);
								Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("[{0}м]",  Distance), new Color32(67, 204, 197,255), true, 8);
							}
						}
					}
				}
		}
		
		if (CFG.ESP.w)
		{
			foreach (BuildingPrivlidge t in companent.tcshit)
				if (t != null)
				{

					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(t.transform.position);
					if (vector.z > 0f)
					{
						Vector3 screenPos = Players.GetScreenPos(t.transform.position + new Vector3(0f, 0f, 0f));
						int tc_distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);
						int tc_distance1 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, t.transform.position);
						float num4 = Mathf.Abs(vector.y - screenPos.y);
						float width = num4 / 2f;
						if (tc_distance <= WorldEspDistance)
						{
							vector.x += 3f;
							vector.y = UnityEngine.Screen.height - (vector.y + 1f);
							Rendering.DrawString1(new Vector2(vector.x, vector.y), string.Format("{0}", (menu.enru ? "Cupboard" : "Шкаф"), tc_distance), new Color32(153, 145, 0,255), true, 8);
							Rendering.DrawString1(new Vector2(vector.x, vector.y+10), string.Format("[{1}м]", "Шкаф", tc_distance), new Color32(153, 145, 0, 255), true, 8);
							if(menu.h)
                            {
								Rendering.Health11(vector.x, vector.y + 20, t.health, 100, 45, 6, 1f);
							}

							List<ProtoBuf.PlayerNameID> list = new List<ProtoBuf.PlayerNameID>();
							list = t.authorizedPlayers;
							for (int i = 0; i < list.Count; i++)
							{
								Rendering.DrawString1(new Vector2(vector.x, vector.y- 10), string.Format((menu.enru ? "[AUTHORIZED]" : "[АВТОРИЗОВАННЫЕ]"), t.transform.position), Color.green, true, 8);
								Rendering.DrawString1(new Vector2(vector.x, vector.y - 10 - (float)(i + 1) * 10f), list[i].username + " - " + list[i].userid, new Color32(153, 145, 0, 255), true, 9);
							}
						}

					}
				}
		}
		
		bool data3 = menu.vvvv;
		if (data3)
		{
			bool flag9 = companent.bear != null;
			if (flag9)
			{
				foreach (BearTrap bearTrap in companent.bear)
				{
					bool flag10 = bearTrap != null;
					if (flag10)
					{
						Vector3 position4 = bearTrap.transform.position;
						Vector3 vector8 = MainCamera.mainCamera.WorldToScreenPoint(bearTrap.transform.position);
						Vector3 vector9 = MainCamera.mainCamera.WorldToScreenPoint(position4 + new Vector3(0f, 1f, 0f));
						bool flag11 = vector8.z > 0f;
						if (flag11)
						{
							int num7 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, bearTrap.transform.position);
							bool flag12 = (float)num7 <= WorldEspDistance;
							if (flag12)
							{
								float num8 = Mathf.Abs(vector8.y - vector9.y);
								vector8.x += 3f;
								vector8.y = (float)Screen.height - (vector8.y + 1f);
								Rendering.DrawString1(new Vector2(vector8.x, vector8.y - 10f), string.Format("{0}", (menu.enru ? "Trap" : "Капкан")), new Color32(207, 4, 75, 255), true, 8);
							}
						}
					}
				}
			}
		}
		
		bool data8 = menu.vvvv;
		if (data8)
		{
			bool flag29 = companent.land != null;
			if (flag29)
			{
				foreach (Landmine landmine in companent.land)
				{
					bool flag30 = landmine != null;
					if (flag30)
					{
						Vector3 position9 = landmine.transform.position;
						Vector3 vector18 = MainCamera.mainCamera.WorldToScreenPoint(landmine.transform.position);
						Vector3 vector19 = MainCamera.mainCamera.WorldToScreenPoint(position9 + new Vector3(0f, 1f, 0f));
						bool flag31 = vector18.z > 0f;
						if (flag31)
						{
							int num18 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, landmine.transform.position);
							bool flag32 = (float)num18 <= WorldEspDistance;
							if (flag32)
							{
								float num19 = Mathf.Abs(vector18.y - vector19.y);
								vector18.x += 3f;
								vector18.y = (float)Screen.height - (vector18.y + 1f);
								Rendering.DrawString1(new Vector2(vector18.x, vector18.y - 10f), string.Format("{0}", (menu.enru ? "Mine" : "Мина")), new Color32(207, 4, 75,255), true, 9);
							}
						}
					}
				}
			}
		}
		deltaTime += (UnityEngine.Time.deltaTime - deltaTime) * 0.1f;
		if (CFG.Misc.wertyu)
		{
			bool keyDown = UnityEngine.Input.GetKeyDown(KeyCode.Keypad1);
			if (keyDown)
			{
				UpdateLookAt();
				GameObject gameObject = lookingAt;
				bool flag = gameObject != null && !gameObject.name.Contains("player") && !gameObject.name.Contains("Water") && !gameObject.name.Contains("Terrain") && !gameObject.name.Contains("cupboard") && !gameObject.name.Contains("furnace");
				if (flag)
				{
					gameObject.SetActive(false);
					ViewerCaches.Add(gameObject);
				}
			}
			bool keyDown2 = UnityEngine.Input.GetKeyDown(KeyCode.Keypad2);
			if (keyDown2)
			{
				foreach (GameObject gameObject2 in ViewerCaches)
				{
					gameObject2.SetActive(true);
				}
				ViewerCaches.Clear();
			}
		}
		bool keyDown9 = UnityEngine.Input.GetKeyDown(KeyCode.F4);
		if (keyDown9)
		{
			UpdateLookAt();
			LocalPlayer.Entity.movement.TeleportTo(lookPoint, LocalPlayer.Entity);
		}
	}
	private static float deltaTime;
	public static List<GameObject> ViewerCaches = new List<GameObject>();
	public static GameObject lookingAt;
	public static void UpdateLookAt()
	{
		RaycastHit raycastHit = default(RaycastHit);
		bool flag = UnityEngine.Physics.Raycast(LocalPlayer.Entity.eyes.HeadRay(), out raycastHit);
		if (flag)
		{
			lookPoint = raycastHit.point;
			lookingAt = raycastHit.transform.gameObject;
		}
	}
	
	
	private static UnityEngine.Color youabitch = new UnityEngine.Color(0.4f, 0.4f, 0.4f, 0.4f);
	public static GameObject LightObject = null;

	public static Vector3 lookPoint;
	public static float range = 300;
	public static float WorldEspDistance = 500;
	public static Color32 WorldEspColor1 = new Color32(36, 255, 101, 255);
	public static Color32 WorldEspColor = new Color32(23, 191, 54, 255);
	public static Color32 CollectablEspColor = new Color32(23, 191, 54, 1);
	private void OnGUI()
	{
		try
		{
			if (CFG.Misc.HGHGH && DAFDSVCBFDG != null &&DAFDSVCBFDG.gravityMultiplier != AFRETRHGFBCV)
			{
				DAFDSVCBFDG.gravityMultiplier = AFRETRHGFBCV;
			}
			ESP.f1();
			ESP.f2();
		}
		catch
		{
		}
	}
	private static PlayerWalkMovement DAFDSVCBFDG;
	private static float AFRETRHGFBCV = 5f;
	public static bool свет;
	public static bool EnabledBox11;
}
