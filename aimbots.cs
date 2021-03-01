using System;
using System.Reflection;
using UnityEngine;

	internal class aimbots
	{
		public static BasePlayer GetTarget()
		{
			BasePlayer result = null;
			new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
			float num = 1000f;
			foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
			{
				if (!(basePlayer == null) && !basePlayer.IsLocalPlayer() && basePlayer.health > 0f && !basePlayer.IsDead())
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position);
					new Vector2(vector.x, (float)Screen.height - vector.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
					if (num2 <= 360 && num2 < num && basePlayer.IsAlive())
					{
						num = num2;
						result = basePlayer;
					}
				}
			}
			return result;
		}

    public static float BulletDrop(Vector3 v1, Vector3 v2, float BulletSpeed)
    {
        float num = Vector3.Distance(v1, v2);
        bool flag = (double)num < 0.001;
        bool flag2 = flag;
        float result;
        if (flag2)
        {
            result = 0f;
        }
        else
        {
            float num2 = num / BulletSpeed;
            result = (float)(4.90500020980835 * (double)num2 * (double)num2);
        }
        return result;
    }

    // Token: 0x06000086 RID: 134 RVA: 0x00007BF0 File Offset: 0x00005DF0
    public static void Aim()
		{
			Vector3 posTargetPlayer = aimbots.GetEnemyVector();
			if (!(posTargetPlayer == Vector3.zero))
			{
				Quaternion quaternion = Quaternion.LookRotation(posTargetPlayer - MainCamera.mainCamera.transform.position, Vector3.right);
				float num = quaternion.eulerAngles.x;
				num = ((MainCamera.mainCamera.transform.position.y < posTargetPlayer.y) ? (-360f + num) : num);
				num = Mathf.Clamp(num, -89f, 89f);
				LocalPlayer.Entity.input.SetViewVars(new Vector3(num, quaternion.eulerAngles.y, 0f));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public static Vector3 GetBonePosition(Model playerModel, string boneName)
		{
			Vector3 zero = Vector3.zero;
			Vector3 result;
			if (playerModel == null)
			{
				result = zero;
			}
			else if (boneName == "headCenter")
			{
				result = new Vector3(playerModel.headBone.position.x, playerModel.eyeBone.position.y, playerModel.headBone.position.z);
			}
			else
			{
				result = playerModel.FindBone(boneName).position;
			}
			return result;
		}
	private static FieldInfo fieldInfo_1 = typeof(PlayerModel).GetField("velocity", BindingFlags.Instance | BindingFlags.NonPublic);
    public static bool IsVisible(Vector3 vector3_0)
    {
        Vector3 a = MainCamera.mainCamera.transform.position - vector3_0;
        float magnitude = a.magnitude;
        bool flag = magnitude < Mathf.Epsilon;
        bool flag2 = flag;
        bool result;
        if (flag2)
        {
            result = true;
        }
        else
        {
            Vector3 vector = a / magnitude;
            Vector3 b = vector * Mathf.Min(magnitude, 0.01f);
            result = LocalPlayer.Entity.IsVisible(new Ray(vector3_0 + b, vector), magnitude);
        }
        return result;
    }
    public static float brmrds9r96ti6mj6ors()
    {
        HeldEntity held_entity = null;

        if (LocalPlayer.Entity.GetHeldEntity() == null)
        {
            return 375f;
        }
        else
            held_entity = LocalPlayer.Entity.GetHeldEntity();
        string itemname = held_entity.GetOwnerItemDefinition().shortname;
        float speed = 300f;
        if (held_entity.GetComponent<BaseProjectile>() != null)
        {
            Vector2 centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
            foreach (BasePlayer player in BasePlayer.visiblePlayerList)
            {

                if (player != null && !player.IsDead() && !player.IsSleeping())
                {
                    int distanceFromCenter = (int)(Vector2.Distance(MainCamera.mainCamera.WorldToScreenPoint(player.model.headBone.transform.position), centerScreen));
                    Vector3 onScreen = player.transform.position - MainCamera.mainCamera.transform.position;
                    if (!player.IsLocalPlayer() && player.health > 0f && Vector3.Dot(MainCamera.mainCamera.transform.TransformDirection(Vector3.forward), onScreen) > 0)
                       ;
                }

                if (player != null && !player.IsDead() && !player.IsSleeping())
                {
                    int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.model.headBone.transform.position);
                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(player.model.headBone.transform.position);
                    Vector3 screenPos = Players.GetScreenPos(player.transform.position);
                    if (screenPos.z > 0f)
                    {
                        if (itemname == "bow.hunting")
                        {
                            if (dist <= 41f)
                            {
                                speed = 60f;
                            }
                            else
                            if (dist <= 82f)
                            {
                                speed = 58f;
                            }
                            else
                             if (dist <= 102f)
                            {
                                speed = 57.5f;
                            }
                            else
                             if (dist <= 112f)
                            {
                                speed = 57.3f;
                            }
                            else
                             if (dist <= 127f)
                            {
                                speed = 57f;
                            }
                            else
                             if (dist <= 146f)
                            {
                                speed = 56.5f;
                            }
                            else
                             if (dist <= 153f)
                            {
                                speed = 56.3f;
                            }
                            else
                            if (dist <= 163f)
                            {
                                speed = 56f;
                            }
                            else
                            if (dist <= 172f)
                            {
                                speed = 55.7f;
                            }
                            else
                            if (dist <= 178f)
                            {
                                speed = 55.5f;
                            }
                            else
                            if (dist <= 184f)
                            {
                                speed = 55.3f;
                            }
                            else
                            if (dist <= 189f)
                            {
                                speed = 55.1f;
                            }
                            else
                            if (dist <= 196f)
                            {
                                speed = 54.9f;
                            }
                            else
                            if (dist <= 201f)
                            {
                                speed = 54.7f;
                            }
                            else
                            if (dist <= 206f)
                            {
                                speed = 54.5f;
                            }
                            else
                            if (dist <= 210f)
                            {
                                speed = 54.3f;
                            }
                            else
                            if (dist <= 215f)
                            {
                                speed = 54.1f;
                            }
                            else
                            if (dist <= 220f)
                            {
                                speed = 53.9f;
                            }
                            else
                            if (dist <= 225.1f)
                            {
                                speed = 53.7f;
                            }
                            else
                            if (dist <= 230.1f)
                            {
                                speed = 53.5f;
                            }
                            else
                            if (dist <= 233.1f)
                            {
                                speed = 53.3f;
                            }
                            else
                            if (dist <= 237.1f)
                            {
                                speed = 53.1f;
                            }
                            else
                            if (dist <= 241.1f)
                            {
                                speed = 52.9f;
                            }
                            else
                            if (dist <= 244.1f)
                            {
                                speed = 52.7f;
                            }
                            else
                            if (dist <= 248.1f)
                            {
                                speed = 52.5f;
                            }
                            else
                            if (dist <= 252.1f)
                            {
                                speed = 52.3f;
                            }
                            else
                            if (dist <= 255.1f)
                            {
                                speed = 52.1f;
                            }
                            else
                            if (dist <= 500f)
                            {
                                speed = 50f;
                            }
                        }
                        if (itemname == "crossbow")
                        {
                            if (dist <= 83f)
                            {
                                speed = 90f;
                            }
                            else
                            if (dist <= 123f)
                            {
                                speed = 88f;
                            }
                            else
                            if (dist <= 223f)
                            {
                                speed = 86f;
                            }
                            else
                            if (dist <= 254f)
                            {
                                speed = 85.5f;
                            }
                            else
                            if (dist <= 285f)
                            {
                                speed = 85f;
                            }
                            else
                            if (dist <= 500f)
                            {
                                speed = 84.7f;
                            }
                        }
                        if (itemname == "shotgun.pump")
                        {
                            if (dist <= 88f)
                            {
                                speed = 225f;
                            }
                            else
                            if (dist <= 112f)
                            {
                                speed = 201f;
                            }
                            else
                            if (dist <= 125f)
                            {
                                speed = 190f;
                            }
                            else
                            if (dist <= 130f)
                            {
                                speed = 186f;
                            }
                            else
                            if (dist <= 149f)
                            {
                                speed = 172f;
                            }
                            else
                            if (dist <= 154f)
                            {
                                speed = 168f;
                            }
                            else
                            if (dist <= 163f)
                            {
                                speed = 161f;
                            }
                            else
                            if (dist <= 168f)
                            {
                                speed = 157f;
                            }
                            else
                            if (dist <= 173f)
                            {
                                speed = 153f;
                            }
                            else
                            if (dist <= 177f)
                            {
                                speed = 150f;
                            }
                            else
                            if (dist <= 188f)
                            {
                                speed = 146f;
                            }
                            else
                            if (dist <= 198f)
                            {
                                speed = 131f;
                            }
                            else
                            if (dist <= 205f)
                            {
                                speed = 120f;
                            }
                        }

                        switch (itemname)
                        {
                            case " rifle.ak":
                                speed = 374.9f;
                                break;
                            case "rifle.lr300":
                                speed = 374.9f;
                                break;
                            case "lmg.m249":
                                speed = 487.4f;
                                break;
                            case "rifle.bolt":

                                speed = 656.2f;
                                break;
                            case "rifle.l96":
                                speed = 800.2f;
                                break;
                            case "smg.2":
                                speed = 240f;
                                break;
                            case "smg.mp5":
                                speed = 240f;
                                break;
                            case "pistol.python":
                                speed = 300f;
                                break;
                            case "pistol.m92":
                                speed = 300f;
                                break;
                            case "pistol.revolver":
                                speed = 300f;
                                break;
                            case "rifle.semiauto":
                                speed = 374.9f;
                                break;
                            case "pistol.semiauto":
                                speed = 300f;
                                break;
                            case "smg.thompson":
                                speed = 300f;
                                break;
                            case "pistol.nailgun":
                                speed = 60f;
                                break;
                            case "shotgun.double":
                                speed = 90f;
                                break;
                            case "shotgun.waterpipe":
                                speed = 90f;
                                break;
                            case "shotgun.spas12":
                                speed = 90f;
                                break;
                            case "rocket.launcher":
                                speed = 40.0f;
                                break;
                            case "bow.compound":
                                speed = 50.0f;
                                break;
                        }
                        foreach (ProjectileWeaponMod pwm in held_entity.GetComponent<BaseProjectile>().children)
                        {

                            if (pwm.isSilencer)
                                speed = speed * 0.75f;

                          
                        }
                        string ammo_type = held_entity.GetComponent<BaseProjectile>().primaryMagazine.ammoType.displayName.english;
                        switch (ammo_type)
                        {
                            case "HV 5.56 Rifle Ammo":
                                speed = speed * 1.2f;
                                break;
                            case "Explosive 5.56 Rifle Ammo":
                                speed = speed * 0.6f;
                                break;
                            case "Incendiary 5.56 Rifle Ammo":
                                speed = speed * 0.6f;
                                break;
                            case "HV Pistol Ammo":
                                speed = speed * 1.3333f;
                                break;
                            case "Incendiary Pistol Bullet":
                                speed = speed * 0.75f;
                                break;
                            case "High Velocity Arrow":
                                speed = speed * 1.6f;
                                break;
                            case "Fire Arrow":
                                speed = speed * 0.8f;
                                break;
                            case "Bone Arrow":
                                speed = speed * 0.8f;
                                break;
                            case "Handmade Shell":
                                speed = 90f;
                                break;
                            case "12 Gauge Incendiary Shell":
                                speed = 100f;
                                break;
                            case "12 Gauge Slug":
                                speed = 225f;
                                break;
                            case "12 Gauge Buckshot Shell":
                                speed = 225f;
                                break;
                        }
                    }
                    else
                    {
                        switch (itemname)
                        {
                            case "spear.wooden":
                                speed = 18.0f;
                                break;
                            case "spear.stone":
                                speed = 20.0f;
                                break;
                            case "rocket.launcher":
                                speed = 40.0f;
                                break;
                        }
                    }
                }
            }
        }
        return speed;
    }
    public bool validAimWeapon()
    {
        bool result;
        if (menu.localplayer.GetHeldEntity() == null)
        {
            result = false;
        }
        else
        {
            int itemid = menu.localplayer.GetHeldEntity().GetOwnerItemDefinition().itemid;
            bool flag = false;
            int num = itemid;
            if (num <= -55660037)
            {
                if (num <= -1716193401)
                {
                    if (num != -2094080303)
                    {
                        if (num != -1745053053)
                        {
                            if (num == -1716193401)
                            {
                                flag = true;
                            }
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else if (num <= -930579334)
                {
                    if (num != -1461508848)
                    {
                        if (num == -930579334)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else if (num != -853695669)
                {
                    if (num == -55660037)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = true;
                }
            }
            else if (num <= 371156815)
            {
                if (num != 109552593)
                {
                    if (num != 193190034)
                    {
                        if (num == 371156815)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = true;
                }
            }
            else if (num <= 548699316)
            {
                if (num != 456448245)
                {
                    if (num == 548699316)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = true;
                }
            }
            else if (num != 2033918259)
            {
                if (num == 2123300234)
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
            result = flag;
        }
        return result;
    }
    public static Vector3 GetEnemyVector()
	{
        Vector3 result = Vector3.zero;
        Vector3 vector = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2));
        float num = 300f;
        foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
        {
            bool flag = basePlayer != null && basePlayer.health > 0f && !basePlayer.IsSleeping() && !friend.friendsList.Contains(basePlayer.userID) && !basePlayer.IsLocalPlayer();
            if (flag)
            {
                Vector3 vector2 = aimbots.GetBonePosition(basePlayer.GetModel(), "Head") + new Vector3(0f, 0.05f, 0f);
                bool flag2 = vector2 != Vector3.zero;
                if (flag2)
                {
                    Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(vector2);
                    Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(aimbots.GetBonePosition(basePlayer.GetModel(), "headCenter") + new Vector3(0f, 0.05f, 0f));
                    Vector2 vector5 = new Vector2(vector3.x, (float)Screen.height - vector3.y);
                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector4.x, (float)Screen.height - vector4.y)));
                    bool flag3 = num2 <= menu.fov && num2 < num && basePlayer.IsAlive();
                    if (flag3)
                    {
                        result = vector2;
                        Item activeItem = LocalPlayer.Entity.belt.GetActiveItem();
                        bool flag4 = activeItem == null || (!activeItem.info.shortname.Contains("bow") && !activeItem.info.shortname.Contains("smg.") && !activeItem.info.shortname.Contains("pistol.") && !activeItem.info.shortname.Contains("lmg.") && !activeItem.info.shortname.Contains("rifle"));
                        if (flag4)
                        {
                        }
                        result.y += aimbots.BulletDrop(LocalPlayer.Entity.transform.position, vector2, aimbots.brmrds9r96ti6mj6ors());
                      

                    }
                    num = num2;
                }
            }
        }
        return result;
    }
    private static FieldInfo fieldInfo_11 = typeof(PlayerModel).GetField("velocity", BindingFlags.Instance | BindingFlags.NonPublic);
    public static bool hhh;
	}
