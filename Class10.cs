using System;
using System.Collections;
using System.Reflection;

using UnityEngine;

public class radar2D : MonoBehaviour
{
    private void radar()
    {
        if (CFG.Setting.radarrrrr)
        {
            bool rar = CFG.Setting.size % 2 != 0;
            if (rar)
            {
                CFG.Setting.size--;
            }

            GUI.color = Color.white;
            if (CFG.Setting.skin)

            {

                GUI.DrawTexture(new Rect(CFG.Setting.left, CFG.Setting.up, CFG.Setting.size, CFG.Setting.size), HukTexture.mTex);
            }
            if (!CFG.Setting.skin)
            {
                GUI.DrawTexture(new Rect(CFG.Setting.left, CFG.Setting.up, CFG.Setting.size, CFG.Setting.size), HukTexture.mTex6);
            }
            GUI.color = Color.white;
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer.health > 0f && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer() && CFG.Setting.radar && CFG.Setting.radarrrrr && basePlayer.userID > 10000000000U)
                {
                    Vector3 centerPos = menu.localplayer.transform.position;
                    Vector3 extPos = basePlayer.transform.position;
                    float dist = Vector3.Distance(centerPos, extPos);
                    float dx = centerPos.x - extPos.x;
                    float dz = centerPos.z - extPos.z;
                    float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
                    float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
                    float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
                    bX = bX * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                    bY = bY * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                    if (dist <= CFG.Setting.dist)
                    {
                        GUI.color = Color.white;
                        if (CFG.Setting.skin && CFG.Setting.friendsList.Contains(basePlayer.userID))
                        {
                            GUI.DrawTexture(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f, 6, 6), HukTexture.merr1);
                        }

                        if (CFG.Setting.skin && !CFG.Setting.friendsList.Contains(basePlayer.userID))
                        {
                            GUI.DrawTexture(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f, 6, 6), HukTexture.merr);
                        }
                        if (!CFG.Setting.skin && CFG.Setting.friendsList.Contains(basePlayer.userID))
                        {
                            Rendering.BoxRect(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 2f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 2f, 4, 4), Color.green);
                        }
                        if (!CFG.Setting.skin && !CFG.Setting.friendsList.Contains(basePlayer.userID))
                        {
                            Rendering.BoxRect(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 2f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 2f, 4, 4), Color.red);
                        }



                        GUI.color = Color.white;

                        Rendering.DrawString1(new Vector2((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f), string.Format("  [{0}m]", (int)dist), Color.white, true, 7, FontStyle.Bold, 1);
                    }
                }
            }
            if (CFG.Setting.sleep && CFG.Setting.radarrrrr)
            {
                foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
                {
                    if (basePlayer2.health > 0f && basePlayer2.IsSleeping() && !basePlayer2.IsLocalPlayer())
                    {
                        Vector3 centerPos = menu.localplayer.transform.position;
                        Vector3 extPos = basePlayer2.transform.position;
                        float dist = Vector3.Distance(centerPos, extPos);
                        float dx = centerPos.x - extPos.x;
                        float dz = centerPos.z - extPos.z;
                        float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
                        float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
                        float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
                        bX = bX * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                        bY = bY * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                        if (dist <= CFG.Setting.dist)
                        {
                            GUI.color = Color.white;
                            if (CFG.Setting.skin)
                            {
                                GUI.DrawTexture(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f, 6, 6), HukTexture.merr2);
                            }
                            if (!CFG.Setting.skin)
                            {
                                Rendering.BoxRect(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 2f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 2f, 4, 4), Color.black);
                            }
                            GUI.color = Color.white;
                        }
                    }
                }
            }
            if (CFG.Setting.radarnpc && CFG.Setting.radarrrrr)
            {
                foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
                {
                    if (basePlayer2.health > 0f && !basePlayer2.IsSleeping() && !basePlayer2.IsLocalPlayer() && CFG.Setting.radarnpc && basePlayer2.userID < 10000000000U)
                    {
                        Vector3 centerPos = menu.localplayer.transform.position;
                        Vector3 extPos = basePlayer2.transform.position;
                        float dist = Vector3.Distance(centerPos, extPos);
                        float dx = centerPos.x - extPos.x;
                        float dz = centerPos.z - extPos.z;
                        float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
                        float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
                        float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
                        bX = bX * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                        bY = bY * (CFG.Setting.size / CFG.Setting.dist) / 2f;
                        if (dist <= CFG.Setting.dist)
                        {
                            GUI.color = Color.white;
                            if (CFG.Setting.skin)
                            {
                                GUI.DrawTexture(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f, 6, 6), HukTexture.merr3);
                            }

                            if (!CFG.Setting.skin)
                            {
                                Rendering.BoxRect(new Rect((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 2f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 2f, 4, 4), Color.blue);
                            }
                            Rendering.DrawString1(new Vector2((float)(CFG.Setting.left + CFG.Setting.size / 2) + bX - 3f, (float)(CFG.Setting.up + CFG.Setting.size / 2) + bY - 3f), string.Format("  [{0}m]", (int)dist), Color.white, true, 7, FontStyle.Bold, 1);
                            GUI.color = Color.white;
                        }
                    }
                }
            }

        }
    }
    private IEnumerator aim()
    {
        Vector3 targetLastPosition = Vector3.zero;
        Vector3 targetVelocity = Vector3.zero;
        BasePlayer aimTarget = null;
        float currenttime = 0f;
        float lasttime = 0f;
        Vector2 centerScreen = Vector2.zero;
        Vector3 target_AimPos = Vector3.zero;



        while (true)
        {
            while (HACK.localplayer == null || !HACK.localplayer || !UnityEngine.Input.GetKey(KeyCode.X) || !CFG.Setting.asdas)
            {
                aimTarget = null;
                yield return new WaitForSeconds(0.0f);
            }
            MethodInfo point2point = HACK.localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
            centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
            if (!aimTarget.IsValid() || aimTarget.health == 0f)
            {
                aimTarget = null;
            }
            if (aimTarget == null)
            {
                targetLastPosition = Vector3.zero;
                targetVelocity = Vector3.zero;
                currenttime = 0f;
                lasttime = 0f;
                BasePlayer basePlayer = null;
                Vector2 a = new Vector2(Screen.width / 2, Screen.height / 2);
                float num = 7000f;
                foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
                {
                    if (!CFG.Setting.friendsList.Contains(player.userID) && player != null && !player.IsLocalPlayer() && !player.IsDead())
                    {
                        Vector3 position = player.model.headBone.transform.position;
                        if (!(position == Vector3.zero))
                        {
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(position);
                            if (vector.z > 0f)
                            {
                                Vector2 b = new Vector2(vector.x, Screen.height - vector.y);
                                float num2 = Mathf.Abs(Vector2.Distance(a, b));
                                if (num2 <= CFG.Setting.fov && num2 < num)
                                {
                                    num = num2;
                                    basePlayer = player;
                                    aimTarget = player;
                                }
                            }
                        }
                    }
                }


            }
            if (aimTarget != null && !aimTarget.IsDead() && !aimTarget.IsSleeping() && !aimTarget.IsLocalPlayer())
            {
                Vector3 unlerped = Vector3.zero;
                Vector3 inverse;
                inverse = base.transform.InverseTransformDirection(aimTarget.transform.position - targetLastPosition);
                currenttime = UnityEngine.Time.time;
                if (lasttime != 0F && currenttime != lasttime)
                {
                    unlerped = inverse / (currenttime - lasttime);
                    targetVelocity = Vector3.Lerp(targetVelocity, unlerped, 0.1f);
                }
                lasttime = currenttime;
                targetLastPosition = aimTarget.transform.position;
                target_AimPos = CFG.Setting.head ? aimTarget.GetModel().rootBone.position + new Vector3(0f, 0.05f, 0f) : aimTarget.GetModel().headBone.position;
                float traveltime = Vector3.Distance(LocalPlayer.Entity.transform.position, target_AimPos) / brmrds9r96ti6mj6ors();
                target_AimPos.x += targetVelocity.x * traveltime;
                target_AimPos.y += targetVelocity.y * traveltime;
                target_AimPos.z += targetVelocity.z * traveltime;
                target_AimPos.y += (float)(0.5 * 9.81f * traveltime * traveltime);
                Vector3 relative = MainCamera.mainCamera.transform.position - target_AimPos;
                double pitch = Math.Asin(relative.y / relative.magnitude);
                double yaw = -Math.Atan2(relative.x, -relative.z);
                yaw = yaw * Mathf.Rad2Deg;
                pitch = pitch * Mathf.Rad2Deg;
                Vector3 viewangles = new Vector3((float)pitch, (float)yaw, 0f);
                viewangles = ClampAngles(viewangles);
                LocalPlayer.Entity.input.SetViewVars(viewangles);
            }
            yield return new WaitForSeconds(0.0f);
        }
    }
    private IEnumerator aim_heli()
    {
        Vector3 targetLastPosition = Vector3.zero;
        Vector3 targetVelocity = Vector3.zero;
        BaseHelicopter aimTarget = null;
        float currenttime = 0f;
        float lasttime = 0f;
        Vector2 centerScreen = Vector2.zero;
        Vector3 target_AimPos = Vector3.zero;



        while (true)
        {
            while (HACK.localheli == null || !HACK.localheli || !UnityEngine.Input.GetKey(KeyCode.X) || !CFG.Setting.bvbgfg)
            {
                aimTarget = null;
                yield return new WaitForSeconds(0.0f);
            }
            MethodInfo point2point = HACK.localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
            centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
            if (!aimTarget.IsValid() || aimTarget.health == 0f)
            {
                aimTarget = null;
            }
            if (aimTarget == null)
            {
                targetLastPosition = Vector3.zero;
                targetVelocity = Vector3.zero;
                currenttime = 0f;
                lasttime = 0f;
                foreach (BaseHelicopter player in companent.heli1)
                {
                    BaseHelicopter basePlayer = null;
                    float num = 999f;
                    if (player != null)
                    {


                        {
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(player.transform.position + new Vector3(0f, 1.7f, 0f));
                            float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                            if (num2 <= CFG.Setting.fov && num2 < num)
                            {
                                num = num2;
                                basePlayer = player;
                                aimTarget = player;
                            }
                        }

                    }
                }
            }
            if (aimTarget != null && !aimTarget.IsDead())
            {
                Vector3 unlerped = Vector3.zero;
                Vector3 inverse;
                inverse = base.transform.InverseTransformDirection(aimTarget.transform.position - targetLastPosition);
                currenttime = UnityEngine.Time.time;
                if (lasttime != 0F && currenttime != lasttime)
                {
                    unlerped = inverse / (currenttime - lasttime);
                    targetVelocity = Vector3.Lerp(targetVelocity, unlerped, 0.1f);
                }
                lasttime = currenttime;
                targetLastPosition = aimTarget.transform.position;
                target_AimPos = (aimTarget.health > 5000 ? aimTarget.mainRotor.transform.position + new Vector3(0f, -0.1f, 0f) : aimTarget.tailRotor.transform.position);
                float traveltime = Vector3.Distance(LocalPlayer.Entity.transform.position, target_AimPos) / brmrds9r96ti6mj6ors1();
                target_AimPos.x += targetVelocity.x * traveltime;
                target_AimPos.y += targetVelocity.y * traveltime;
                target_AimPos.z += targetVelocity.z * traveltime;
                target_AimPos.y += (float)(0.5 * 9.81f * traveltime * traveltime);
                Vector3 relative = MainCamera.mainCamera.transform.position - target_AimPos;
                double pitch = Math.Asin(relative.y / relative.magnitude);
                double yaw = -Math.Atan2(relative.x, -relative.z);
                yaw = yaw * Mathf.Rad2Deg;
                pitch = pitch * Mathf.Rad2Deg;
                Vector3 viewangles = new Vector3((float)pitch, (float)yaw, 0f);
                viewangles = ClampAngles(viewangles);
                LocalPlayer.Entity.input.SetViewVars(viewangles);
            }
            yield return new WaitForSeconds(0.0f);
        }
    }
    public static float brmrds9r96ti6mj6ors1()
    {
        HeldEntity held_entity = null;

        if (LocalPlayer.Entity.GetHeldEntity() == null)
        {
            return 375f;
        }
        else
        {
            held_entity = LocalPlayer.Entity.GetHeldEntity();
        }

        string itemname = held_entity.GetOwnerItemDefinition().shortname;
        float speed = 300f;
        if (held_entity.GetComponent<BaseProjectile>() != null)
        {
            Vector2 centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
            foreach (BaseHelicopter player in companent.heli1)
            {

                if (player != null && !player.IsDead())
                {
                    int distanceFromCenter = (int)(Vector2.Distance(MainCamera.mainCamera.WorldToScreenPoint(player.mainRotor.transform.position), centerScreen));
                    Vector3 onScreen = player.transform.position - MainCamera.mainCamera.transform.position;
                    if (player.health > 0f && Vector3.Dot(MainCamera.mainCamera.transform.TransformDirection(Vector3.forward), onScreen) > 0)
                    {
                        ;
                    }
                }

                if (player != null && !player.IsDead())
                {
                    int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.mainRotor.transform.position);
                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(player.mainRotor.transform.position);
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
                            {
                                speed = speed * 0.75f;
                            }

                            if (pwm.isMuzzleBoost)
                            {
                                speed = speed * 0.9f;
                            }

                            if (pwm.isMuzzleBrake)
                            {
                                speed = speed * 0.8f;
                            }
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
    private void Start()
    {
        base.StartCoroutine(aim_heli());
        base.StartCoroutine(aim());

    }
    public static Vector3 ClampAngles(Vector3 angles)
    {
        if (angles.x > 89f)
        {
            angles.x -= 360f;
        }
        else if (angles.x < -89f)
        {
            angles.x += 360f;
        }

        if (angles.y > 180f)
        {
            angles.y -= 360f;
        }
        else if (angles.y < -180f)
        {
            angles.y += 360f;
        }

        angles.z = 0f;
        return angles;
    }

    public static float brmrds9r96ti6mj6ors()
    {
        HeldEntity held_entity = null;

        if (LocalPlayer.Entity.GetHeldEntity() == null)
        {
            return 375f;
        }
        else
        {
            held_entity = LocalPlayer.Entity.GetHeldEntity();
        }

        string itemname = held_entity.GetOwnerItemDefinition().shortname;
        float speed = 300f;
        if (held_entity.GetComponent<BaseProjectile>() != null)
        {
            Vector2 centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
            foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
            {

                if (player != null && !player.IsDead() && !player.IsSleeping())
                {
                    int distanceFromCenter = (int)(Vector2.Distance(MainCamera.mainCamera.WorldToScreenPoint(player.model.headBone.transform.position), centerScreen));
                    Vector3 onScreen = player.transform.position - MainCamera.mainCamera.transform.position;
                    if (!player.IsLocalPlayer() && player.health > 0f && Vector3.Dot(MainCamera.mainCamera.transform.TransformDirection(Vector3.forward), onScreen) > 0)
                    {
                        ;
                    }
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
                            {
                                speed = speed * 0.75f;
                            }

                            if (pwm.isMuzzleBoost)
                            {
                                speed = speed * 0.9f;
                            }

                            if (pwm.isMuzzleBrake)
                            {
                                speed = speed * 0.8f;
                            }
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


    private void OnGUI()
    {
        radar();

    }
}
