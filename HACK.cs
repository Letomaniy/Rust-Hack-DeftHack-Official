using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Facepunch;
using Facepunch.Steamworks;

using Network;

using ProtoBuf;

using UnityEngine;
using UnityEngine.Rendering;
public class HACK : MonoBehaviour
{

    public static Vector3 GetScreenPos(Vector3 position)
    {
        return MainCamera.mainCamera.WorldToScreenPoint(position);
    }
    public static string string_1;








    private void OnGUI()
    {
        if (CFG.Setting.ZALYPA && UnityEngine.Input.GetKeyDown(KeyCode.L))
        {
            biglootdrop();
        }
        bool flag212 = targ == null;
        if (flag212)
        {
            foreach (BuildingPrivlidge basePlayer in companent.tcshit)
            {

                targ = basePlayer;

            }
        }
        bool flag22 = localplayer == null;
        if (flag22)
        {
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                bool flag2 = basePlayer.IsLocalPlayer();
                if (flag2)
                {
                    localplayer = basePlayer;
                }
            }
        }
        bool flag = localheli == null;
        if (flag)
        {
            foreach (BaseHelicopter basePlayer in companent.heli1)
            {

                localheli = basePlayer;

            }
        }
    }
    public void biglootdrop()
    {
        if (LocalPlayer.Entity != null && BaseEntityEx.IsValid(LocalPlayer.Entity) && LocalPlayer.Entity.inventory != null)
        {
            base.StartCoroutine(biggerboobs(LocalPlayer.Entity.inventory));
        }
    }
    private bool u0014;
    private readonly WaitForSeconds u001D = new WaitForSeconds(0.4f);

    private IEnumerator u001A(ItemContainer A_1)
    {
        List<Item> list = Facepunch.Pool.GetList<Item>();
        list.AddRange(A_1.itemList);
        foreach (Item item in list)
        {
            for (int i = 1; i <= item.amount; i++)
            {
                LocalPlayer.ItemCommandEx<int>(item.uid, "drop", CFG.Setting.ZALYPA ? 1 : 0);
                yield return u001D;
            }
        }
        Facepunch.Pool.Free<List<Item>>(ref list);

        u0014 = false;
        yield break;

    }
    private IEnumerator biggerboobs(PlayerInventory A_1)
    {
        if (A_1.containerBelt != null)
        {
            u0014 = true;
            base.StartCoroutine(u001A(A_1.containerBelt));
        }
        while (u0014)

        {
            yield return u001D;
        }
        if (A_1.containerMain != null)

        {
            u0014 = true;
            base.StartCoroutine(u001A(A_1.containerMain));
        }
        while (u0014)

        {
            yield return u001D;
        }
        if (A_1.containerWear != null)

        {
            u0014 = true;
            base.StartCoroutine(u001A(A_1.containerWear));
        }
        while (u0014)

        {
            yield return u001D;
        }
        if (A_1.loot != null && A_1.loot.containers.Count > 0)

        {
            foreach (ItemContainer itemContainer in A_1.loot.containers)
            {
                u0014 = true;
                base.StartCoroutine(u001A(itemContainer));
                while (u0014)
                {
                    yield return u001D;
                }
            }
        }
        yield break;
    }
    public static string targetp = "Захват цели [C]";
    private readonly float distance; private float float_0;
    private IEnumerator hoook()
    {
        bool debugcam = false;
        bool debugcam11 = false;
        bool aimwhilesprinting = false;
        bool noaimcone = false;
        bool asaaa = false;
        bool shotgunspread = false;
        float oldswimshit = 0f;
        float oldshit = 0f;
        float oldshit2 = 0f;
        while (true)
        {
            try
            {
                bool flag = false;
                bool flag2 = false;
                bool flag3 = false;
                bool flag4 = false;
                if (HACK.localplayer != null)
                {
                    if (CFG.Setting.debug)
                    {
                        if (!debugcam11)
                        {
                            debug.Hook();
                            debugcam11 = true;
                        }
                    }
                    else
                    {
                        if (debugcam11)
                        {
                            debug.Unhook();
                            debugcam11 = false;
                        }
                    }
                    if ((CFG.Setting.cahh || CFG.Setting.qewqefdsf || CFG.Setting.BulletDropPrediction || CFG.Setting.dfertwdf))
                    {
                        boredasf1.Hook();
                    }
                    if (CFG.Setting.hghtrhf)
                    {
                        if (!debugcam)
                        {
                            boredaaaasf1.Hook();
                            debugcam = true;
                        }
                    }
                    else if (debugcam)
                    {
                        boredaaaasf1.Unhook();
                        debugcam = false;
                    }
                    if (CFG.Setting.eeeeeeeee)
                    {
                        if (!aimwhilesprinting)
                        {
                            canaim.Hook();
                            canaim1.Hook();
                            aimwhilesprinting = true;
                        }
                    }
                    else if (aimwhilesprinting)
                    {
                        canaim.Unhook();
                        canaim1.Unhook();
                        aimwhilesprinting = false;
                    }

                    if (CFG.Setting.podgs)
                    {
                        if (oldshit2 == 0f)
                        {
                            oldshit2 = HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier;
                        }
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit2 / 2f;
                    }
                    else if (oldshit2 != 0f)
                    {
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit2;
                    }
                    if (CFG.Setting.nnnn)
                    {
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().SetPrivateField("sprintForced", true);
                    }
                    if (CFG.Setting.cdddeee && !noaimcone)
                    {
                        aimcone.Hook();
                        noaimcone = true;
                    }
                    if (CFG.Setting.sfwewwww && !shotgunspread)
                    {
                        shotgunspread1.Hook();
                        shotgunspread = true;
                    }
                    if (CFG.Setting.dfdswe)
                    {
                        if (!flag4)
                        {
                            canAttack.Hook();
                            flag4 = true;
                        }
                    }
                    else if (flag4)
                    {
                        canAttack.Unhook();
                        flag4 = false;
                    }
                    if (CFG.Setting.mmmm)
                    {
                        if (!flag3)
                        {
                            canAttack.Hook();
                            flag3 = true;
                        }
                    }
                    else if (flag3)
                    {
                        canAttack.Unhook();
                        flag3 = false;
                    }
                    if (menu.test)
                    {
                        if (!flag2)
                        {
                            canAttack.Hook();
                            flag2 = false;
                        }
                    }
                    else if (flag2)
                    {
                        canAttack.Unhook();
                        flag2 = false;
                    }
                    if (CFG.Setting.hyk)
                    {
                        BowWeapon component = HACK.localplayer.GetHeldEntity().GetComponent<BowWeapon>();
                        if (component != null)
                        {
                            component.recoil = null;
                            component.automatic = true;
                            component.aiming = true;
                            component.aimCone = 0f;
                            HACK.nig.SetValue(component, true);
                        }
                    }

                    if (CFG.Setting.df && UnityEngine.Input.GetKey(KeyCode.Z))
                    {
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().SetPrivateField("flying", true);
                        if (oldshit == 0f)
                        {
                            oldshit = HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier;
                        }
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = 0f;
                    }
                    else if (oldshit != 0f)
                    {
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit;
                    }
                    if (menu.asd)
                    {
                        if (!asaaa)
                        {
                            dfdsf.Hook();
                            VoiceRecvHook(true);
                            SendP2PHook(true);
                            P2PUpdate(true);
                            asaaa = true;
                        }
                    }
                    else if (asaaa)
                    {
                        dfdsf.Unhook();
                        VoiceRecvHook(false);
                        SendP2PHook(false);
                        P2PUpdate(false);
                        asaaa = false;
                    }

                    if (CFG.Setting.spin || CFG.Setting.govno2)
                    {
                        if (!flag)
                        {
                            spin.Hook();
                            flag = true;
                        }
                    }
                    else if (flag)
                    {
                        spin.Unhook();
                        flag = false;
                    }

                    if (CFG.Setting.ASDADAD)
                    {
                        if (oldswimshit == 0f)
                        {
                            oldswimshit = HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming;
                        }
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming = oldswimshit / -1f;
                    }
                    else if (oldswimshit != 0f)
                    {
                        HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming = oldswimshit;
                    }
                    if (CFG.Setting.dfdf)
                    {
                        Vector2 b = new Vector2(Screen.width / 2f, Screen.height / 2f);
                        foreach (SupplyDrop supplyDrop in companent.airdrops)
                        {
                            if (supplyDrop != null)
                            {
                                float num4 = (int)Vector2.Distance(MainCamera.mainCamera.WorldToScreenPoint(supplyDrop.transform.position), b);
                                Vector3 rhs = supplyDrop.transform.position - MainCamera.mainCamera.transform.position;
                                if (num4 <= CFG.Setting.fov)
                                {
                                    Vector3.Dot(MainCamera.mainCamera.transform.TransformDirection(Vector3.forward), rhs);
                                }
                            }
                            if (supplyDrop != null)
                            {
                                int num2 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, supplyDrop.transform.position);
                                MainCamera.mainCamera.WorldToScreenPoint(supplyDrop.transform.position);
                                if (Players.GetScreenPos(supplyDrop.transform.position).z > 0f && num2 <= HACK.player1 && UnityEngine.Input.GetKey(KeyCode.X))
                                {
                                    bool arg = false;
                                    uint arg2 = 0U;
                                    Vector3 arg3 = LocalPlayer.Entity.transform.position = supplyDrop.transform.position + new Vector3(0f, HACK.teleportheight, 0f);
                                    LocalPlayer.Entity.ServerRPC<bool, Vector3, uint>("RPC_StartClimb", arg, arg3, arg2);
                                }
                            }
                        }
                    }
                    if (CFG.Setting.ahahahha)
                    {
                        Vector2 b2 = new Vector2(Screen.width / 2f, Screen.height / 2f);
                        foreach (global::BasePlayer basePlayer in global::BasePlayer.VisiblePlayerList)
                        {
                            if (basePlayer != null && !basePlayer.IsSleeping() && !basePlayer.IsDead())
                            {
                                Vector2.Distance(MainCamera.mainCamera.WorldToScreenPoint(basePlayer.model.headBone.transform.position), b2);
                                Vector3 rhs2 = basePlayer.transform.position - MainCamera.mainCamera.transform.position;
                                if (!basePlayer.IsLocalPlayer() && basePlayer.health > 0f)
                                {
                                    Vector3.Dot(MainCamera.mainCamera.transform.TransformDirection(Vector3.forward), rhs2);
                                }
                            }
                            int num3 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, basePlayer.transform.position);
                            if (Players.GetScreenPos(basePlayer.transform.position).z > 0f && basePlayer != null && !basePlayer.IsDead() && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer() && num3 <= HACK.player1 && UnityEngine.Input.GetKey(KeyCode.X))
                            {
                                bool arg4 = false;
                                uint arg5 = 0U;
                                Vector3 arg6 = LocalPlayer.Entity.transform.position = basePlayer.transform.position + new Vector3(0f, HACK.teleportheight, 0f);
                                LocalPlayer.Entity.ServerRPC<bool, Vector3, uint>("RPC_StartClimb", arg4, arg6, arg5);
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
    private IEnumerator gravityandwalk()
    {
        float oldshit2 = 0f;
        bool darkness = false;
        bool time = false;
        bool fdfg = false;
        while (true)
        {
            try
            {
                if (LocalPlayer.Entity != null)
                {
                    ffffff.Hook();
                }
                else
                {
                    ffffff.Unhook();
                }
                if (CFG.Setting.cdddeee)
                {
                    aimcone.Hook();
                }
                if (CFG.Setting.sfwewwww)
                {
                    if (!fdfg)
                    {
                        shotgunspread1.Hook();
                        fdfg = true;
                    }
                }
                else if (fdfg)
                {
                    shotgunspread1.Unhook();

                    fdfg = false;
                }
                if (LocalPlayer.Entity != null && CFG.Setting.hyk)
                {
                    BowWeapon component = localplayer.GetHeldEntity().GetComponent<BowWeapon>();
                    if (component != null)
                    {
                        component.recoil = null;
                        component.automatic = true;
                        component.aiming = true;
                        component.aimCone = 0f;
                        HACK.nig.SetValue(component, true);
                    }
                }
                if (LocalPlayer.Entity != null && CFG.Setting.time)
                {
                    if (!time)
                    {
                        tt(true);
                        time = true;
                    }
                    TOD_Sky.Instance.Cycle.Hour = CFG.Setting.dfd;
                }
                else if (time)
                {
                    tt(false);
                    time = false;
                }
                if (LocalPlayer.Entity != null && CFG.Setting.свет)
                {
                    if (!darkness)
                    {
                        resetter.Hook();
                        darkness = true;
                    }
                }
                else if (darkness)
                {
                    resetter.Hook();
                    darkness = false;
                }
                if (LocalPlayer.Entity != null && CFG.Setting.HGHGH)
                {
                    if (oldshit2 == 0f)
                    {
                        oldshit2 = HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier;
                    }
                    HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit2 / 2f;
                }
                else if (oldshit2 != 0f)
                {
                    HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit2;
                }

                if (LocalPlayer.Entity != null)
                {
                    ConVar.Graphics.fov = CFG.Setting.vov;
                }
            }
            catch
            {
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void Update()
    {
        bool darkness = false;
        bool multiJump_Hooked = false;
        bool speed = false;
        bool fdfg = false;
        bool fd11fg = false;
        bool aimwhilesprinting = false;
        if (CFG.Setting.cdddeee)
        {
            aimcone.Hook();
        }
        if (LocalPlayer.Entity != null)
        {
            ffffff.Hook();
        }
        else
        {
            ffffff.Unhook();
        }

        if (CFG.Setting.spin || CFG.Setting.govno2)
        {
            if (!fd11fg)
            {
                spin.Hook();
                fd11fg = true;
            }
        }
        else if (fd11fg)
        {
            spin.Unhook();
            fd11fg = false;
        }

        if (CFG.Setting.sfwewwww)
        {
            if (!fdfg)
            {
                shotgunspread1.Hook();
                fdfg = true;
            }
        }
        else if (fdfg)
        {
            shotgunspread1.Unhook();

            fdfg = false;
        }
        if (LocalPlayer.Entity != null && CFG.Setting.eeeeeeeee)
        {
            if (!aimwhilesprinting)
            {
                canaim.Hook();
                canaim1.Hook();
                aimwhilesprinting = true;
            }
        }
        else if (aimwhilesprinting)
        {
            canaim.Unhook();
            canaim1.Unhook();
            aimwhilesprinting = false;
        }


        if (LocalPlayer.Entity != null && CFG.Setting.asawersffd)
        {
            if (!multiJump_Hooked)
            {
                jump.Hook();
                multiJump_Hooked = true;
            }
            else if (multiJump_Hooked)
            {
                jump.Unhook();
                multiJump_Hooked = false;
            }
        }
        if (LocalPlayer.Entity != null && CFG.Setting.blats)
        {
            if (!speed)
            {
                ggdsfdf.Hook();
                speed = true;
            }
            else if (speed)
            {
                ggdsfdf.Unhook();
                speed = false;
            }
        }
        if (LocalPlayer.Entity != null && CFG.Setting.свет)
        {
            if (!darkness)
            {
                resetter.Hook();
                darkness = true;
            }
        }
        else if (darkness)
        {
            resetter.Hook();
            darkness = false;
        }
        if (LocalPlayer.Entity != null && CFG.Setting.mbnbnm && HACK.localplayer.modelState != null)
        {
            HACK.localplayer.modelState.waterLevel = 99999f;
        }
        if (LocalPlayer.Entity != null && CFG.Setting.mmmm && HACK.localplayer.modelState != null)
        {
            HACK.localplayer.modelState.waterLevel = 0f;
        }

        if (LocalPlayer.Entity != null && BaseEntityEx.IsValid(LocalPlayer.Entity) && CFG.Setting.tree)
        {
            Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
            if (activeItem != null && (activeItem.info.shortname.Contains("stonehatchet") || activeItem.info.shortname.Contains("hatchet") || activeItem.info.shortname.Contains("hammer.salvaged") || activeItem.info.shortname.Contains("chainsaw") || activeItem.info.shortname.Contains("bone.club") || activeItem.info.shortname.Contains("rock") || activeItem.info.shortname.Contains("axe.salvaged")))
            {
                Vector3 vector = LocalPlayer.Entity.transform.position;
                HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
                if (heldEntity != null)
                {
                    BaseEntity baseEntity = null;
                    BaseEntity baseEntity2 = null;
                    float num = float.MaxValue;
                    float num2 = float.MaxValue;

                    foreach (TreeEntity treeEntity in companent.trees)
                    {
                        BaseEntity baseEntity3 = treeEntity;
                        if (!(baseEntity3 == null) && baseEntity3.IsValid())
                        {
                            if (baseEntity3.prefabID == 954334883)
                            {
                                float num3 = Vector3.Distance(vector, baseEntity3.transform.position);
                                if (num3 <= 5f && num3 < num)
                                {
                                    baseEntity = baseEntity3;
                                    num = num3;
                                }
                            }
                            else if (baseEntity3 is TreeEntity)
                            {
                                Vector3 position = baseEntity3.transform.position;
                                position.y = vector.y;
                                float num4 = Vector3.Distance(vector, position);
                                if (num4 <= 3.5f && num4 < num2)
                                {
                                    baseEntity2 = baseEntity3;
                                    num2 = num4;
                                }
                            }
                        }
                    }
                    if (baseEntity2 != null)
                    {
                        Vector3 a_;
                        if (baseEntity != null)
                        {
                            Vector3 b = baseEntity2.transform.position - baseEntity.transform.position;
                            b.y = 0f;
                            b.Normalize();
                            vector = baseEntity.transform.position - b;
                            a_ = baseEntity.transform.position;
                        }
                        else if (GamePhysics.Trace(new Ray(LocalPlayer.Entity.transform.position, (baseEntity2.transform.position - LocalPlayer.Entity.transform.position).normalized), 0f, out RaycastHit raycastHit, 15f, 1101212417, QueryTriggerInteraction.UseGlobal))
                        {
                            a_ = raycastHit.point;
                        }
                        else
                        {
                            a_ = baseEntity2.transform.position;
                        }
                        AttackEntity attackEntity = heldEntity as AttackEntity;
                        if (attackEntity == null)
                        {
                            return;
                        }
                        if (UnityEngine.Time.time - float_0 < attackEntity.repeatDelay)
                        {
                            return;
                        }

                        Ray ray = new Ray(vector, (a_ - vector));
                        using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                        {
                            using (Attack attack = Facepunch.Pool.Get<Attack>())
                            {
                                playerAttack.attack = attack;
                                playerAttack.attack.hitMaterialID = 3655341;
                                playerAttack.attack.hitID = baseEntity2.net.ID;
                                playerAttack.attack.hitPositionWorld = a_;
                                playerAttack.attack.hitNormalWorld = ray.direction;
                                playerAttack.attack.pointStart = vector;
                                playerAttack.attack.pointEnd = a_;
                                attackEntity.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
                            }
                        }
                        float_0 = UnityEngine.Time.time;

                    }
                }
            }
        }
        if (CFG.Setting.frre && UnityEngine.Input.GetKeyDown(KeyCode.Alpha9))
        {
            friend.AddFriend();
        }
        if (CFG.Setting.adsfdgrege)
        {
            try
            {
                foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
                {
                    if (basePlayer2.IsLocalPlayer())
                    {
                        typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("maxAngleClimbing", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 999f);
                        typeof(PlayerWalkMovement).GetField("maxAngleWalking", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 999f);
                        typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        if (CFG.Setting.winrar && LocalPlayer.Entity != null && BaseEntityEx.IsValid(LocalPlayer.Entity))
        {
            HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
            BaseMelee baseMelee = heldEntity as BaseMelee;
            if (baseMelee == null)
            {
                return;
            }
            if (UnityEngine.Time.time - float_0 < baseMelee.repeatDelay)
            {
                return;
            }
            {
                bool f1lag = false;
                int itemid = heldEntity.GetItem().info.itemid;
                if (itemid == -1506397857 || itemid == 1711033574 || itemid == -1780802565 || itemid == 171931394 || itemid == -1302129395 || itemid == 1488979457 || itemid == 963906841)
                {
                    f1lag = true;
                }
                if (f1lag)
                {
                    foreach (OreHotSpot player in companent.orehotspot)
                    {
                        if (player != null && !player && BaseEntityEx.IsValid(player) && BaseEntityEx.IsValid(baseMelee))
                        {

                            {
                                using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                                {
                                    using (Attack attack = Facepunch.Pool.Get<Attack>())
                                    {
                                        playerAttack.attack = attack;
                                        playerAttack.attack.hitID = player.net.ID;
                                        playerAttack.attack.hitBone = 0;
                                        playerAttack.attack.hitPositionWorld = player.transform.position;
                                        playerAttack.attack.hitNormalWorld = (MainCamera.mainCamera.transform.position - player.transform.position).normalized;
                                        playerAttack.attack.pointStart = localplayer.eyes.position;
                                        playerAttack.attack.pointEnd = player.transform.position;
                                        playerAttack.attack = attack;

                                        baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);

                                    }
                                };
                                float_0 = UnityEngine.Time.time;
                            }
                        }
                    }
                }
            }





        }

    }
    private IEnumerator heal()
    {
        while (true)
        {
            try
            {

                if (CFG.Setting.NAXYI)
                {
                    foreach (MedicalTool codelock in companent.fuck)
                    {

                        Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
                        if (codelock != null && !codelock.IsDestroyed && activeItem != null && (activeItem.info.shortname.Contains("syringe.medical")))
                        {
                            HeldEntity entity = LocalPlayer.Entity.GetHeldEntity();
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codelock.transform.position);
                            MethodInfo point2point = localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                            bool canSeeLock = (bool)point2point.Invoke(localplayer, new object[] { localplayer.GetModel().eyeBone.position, codelock.transform.position, 0f, false });
                            if (lock_distance <= 3f && canSeeLock && HACK.localplayer.health < 87)
                            {
                                codelock.ServerRPC("UseSelf");
                            }
                        }
                    }
                }
                if (CFG.Setting.NAXYI)
                {
                    foreach (MedicalTool codelock in companent.fuck)
                    {
                        Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
                        if (codelock != null && !codelock.IsDestroyed && activeItem != null && (activeItem.info.shortname.Contains("bandage")))
                        {
                            HeldEntity entity = LocalPlayer.Entity.GetHeldEntity();
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codelock.transform.position);
                            MethodInfo point2point = localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                            bool canSeeLock = (bool)point2point.Invoke(localplayer, new object[] { localplayer.GetModel().eyeBone.position, codelock.transform.position, 0f, false });
                            if (lock_distance <= 3f && canSeeLock && HACK.localplayer.health < 99)
                            {
                                codelock.ServerRPC("UseSelf");
                            }
                        }
                    }
                }

            }
            catch
            {
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    private IEnumerator brr()
    {
        while (true)
        {
            try
            {


                if (CFG.Setting.AASDD && UnityEngine.Input.GetKey(KeyCode.F))
                {
                    foreach (GrenadeWeapon nigger in companent.ssss)
                    {
                        HeldEntity ff = LocalPlayer.Entity.GetHeldEntity();
                        int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, ff.transform.position);
                        if (ff is GrenadeWeapon && lock_distance <= 4f)
                        {
                            ff.ServerRPC("DoThrow", ff.transform.position, LocalPlayer.Entity.eyes.BodyForward(), 0.5f);
                        }
                    }
                }
                if (CFG.Setting.test3 && UnityEngine.Input.GetKey(KeyCode.F))
                {
                    foreach (GrenadeWeapon nigger in companent.ssss)
                    {
                        HeldEntity ff = LocalPlayer.Entity.GetHeldEntity();
                        int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, ff.transform.position);
                        if (ff is GrenadeWeapon && lock_distance <= 4f)
                        {
                            ff.ServerRPC("DoDrop", ff.transform.position, LocalPlayer.Entity.eyes.BodyForward(), 0.5f);
                        }
                    }
                }



            }
            catch
            {
            }
            yield return new WaitForSeconds(0.4f);
        }
    }


    private IEnumerator winer()
    {
        while (true)
        {
            try
            {
                if (CFG.Setting.ZAEB && UnityEngine.Input.GetKey(KeyCode.F))
                {

                    {
                        HeldEntity entity = LocalPlayer.Entity.GetHeldEntity();
                        MedicalTool nigger = localplayer.GetHeldEntity().GetComponent<MedicalTool>();
                        int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, entity.transform.position);
                        BasePlayer target = nigger.GetTarget();
                        if (entity is MedicalTool && lock_distance <= 4f)
                        {
                            entity.ServerRPC<uint>("UseOther", target.net.ID);
                        }
                    }
                }
                if (UnityEngine.Input.GetKey(KeyCode.U) && CFG.Setting.oiuytgbmnb)
                {
                    foreach (BuildingPrivlidge buildingPrivlidge in companent.tcshit)
                    {
                        if (buildingPrivlidge != null)
                        {

                            if (Vector3.Distance(localplayer.transform.position, buildingPrivlidge.transform.position) <= 5f)
                            {
                                buildingPrivlidge.ServerRPC("ClearList");
                                buildingPrivlidge.ServerRPC("AddSelfAuthorize");
                            }
                        }
                    }
                }
                if (CFG.Setting.vbfgcvvcv)
                {
                    foreach (Landmine land in companent.land)
                    {
                        if (land != null)
                        {
                            if (Vector3.Distance(localplayer.transform.position, land.transform.position) <= 5f)
                            {
                                land.ServerRPC("RPC_Disarm");
                            }
                        }
                    }
                }
                if (CFG.Setting.vbfgcvvcv)
                {
                    foreach (BearTrap land1 in companent.land1)
                    {
                        if (land1 != null)
                        {
                            if (Vector3.Distance(localplayer.transform.position, land1.transform.position) <= 5f)
                            {

                                land1.ServerRPC("RPC_PickupStart");
                            }
                        }
                    }
                }
                if (CFG.Setting.adsafsddvcvc)
                {
                    foreach (AutoTurret autoTurret in companent.autoturretsss)
                    {
                        if (Vector3.Distance(localplayer.transform.position, autoTurret.transform.position) <= 5f)
                        {
                            autoTurret.ServerRPC("AddSelfAuthorize");
                        }
                    }
                }

            }

            catch
            {
            }
            yield return new WaitForSeconds(0.4f);
        }
    }
    public IEnumerator yasssss4t()
    {
        Vector2 centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
        foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
        {





            if (player != null && !player.IsDead() && !player.IsSleeping())
            {
                int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.model.headBone.transform.position);
                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(player.model.headBone.transform.position);
                Vector3 screenPos = Players.GetScreenPos(player.transform.position);
                if (screenPos.z > 0f && LocalPlayer.Entity && UnityEngine.Input.GetKey(KeyCode.X))
                {
                    {
                        GameManager.client.CreatePrefab("assets/prefabs/misc/supply drop/supply_drop.prefab", player.model.headBone.transform.position + new Vector3(0f, 25f, 0f), Quaternion.Euler(player.model.transform.rotation.x, 100f, 0f), true);
                    }
                }

            }
            yield return new WaitForSeconds(0.100f);
        }
    }
    public bool HasLocalControls()
    {
        return localplayer;// && !EnemyPlayer.IsSpectating() && !EnemyPlayer.IsDead() && !EnemyPlayer.IsSleeping() && !EnemyPlayer.IsWounded() && (SingletonComponent<CameraMan>.Instance == null || !SingletonComponent<CameraMan>.Instance.enabled);
    }

    public bool HasLocalControlsTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return localplayer;// && !EnemyPlayer.IsSpectating() && !EnemyPlayer.IsDead() && !EnemyPlayer.IsSleeping() && !EnemyPlayer.IsWounded() && (SingletonComponent<CameraMan>.Instance == null || !SingletonComponent<CameraMan>.Instance.enabled);
    }
    private IEnumerator hok()
    {
        while (true)
        {
            try

            {

                bool flag = localplayer != null;
                if (flag)
                {


                    if (CFG.Setting.nnn)
                    {
                        LocalPlayer.Entity.SendSignalBroadcast(BaseEntity.Signal.Gesture, "drop_item");
                        LocalPlayer.Entity.SendSignalBroadcast(BaseEntity.Signal.Gesture, "pickup_item");

                        LocalPlayer.Entity.SendSignalBroadcast(BaseEntity.Signal.Gesture, "drink");



                    }


                }
            }
            catch
            {
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    private IEnumerator hook()
    {
        while (true)
        {
            try
            {

                bool flag = localplayer != null;
                if (flag)
                {


                    if (CFG.Setting.test41)
                    {



                        LocalPlayer.Entity.SendSignalBroadcast(BaseEntity.Signal.Reload);


                    }

                }


            }
            catch
            {
            }
            yield return new WaitForSeconds(0.25f);
        }
    }
    public static float dfd;

    private unsafe void VoiceRecvHook(bool set)
    {
        try
        {
            MethodInfo p2p_req = typeof(Facepunch.Steamworks.Networking).GetMethod("onP2PConnectionRequest", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, new Type[] { typeof(ValueType), typeof(bool) }, null);
            RuntimeHelpers.PrepareMethod(p2p_req.MethodHandle);
            IntPtr recvptr = p2p_req.MethodHandle.GetFunctionPointer();
            DumbHook.Import.VirtualProtect(recvptr, 1, 0x40, out uint oldProt);
            if (set == true)
            {
                {
                    byte* ptr = (byte*)recvptr;
                    *(ptr) = 0xc3;
                }
            }
            else
            {
                {
                    byte* ptr = (byte*)recvptr;
                    *(ptr) = 0x55;
                }
            }
            DumbHook.Import.VirtualProtect(recvptr, 1, oldProt, out oldProt);

            UnityEngine.Debug.Log(recvptr.ToString("X"));
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.Log(ex.Message);
        }
    }

    private unsafe void SendP2PHook(bool set)
    {
        MethodInfo p2p_req = typeof(Facepunch.Steamworks.Networking).GetMethod("SendP2PPacket", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, new Type[] { typeof(ulong), typeof(byte[]), typeof(int), typeof(Networking.SendType), typeof(int) }, null);
        RuntimeHelpers.PrepareMethod(p2p_req.MethodHandle);
        IntPtr recvptr = p2p_req.MethodHandle.GetFunctionPointer();
        DumbHook.Import.VirtualProtect(recvptr, 1, 0x40, out uint oldProt);
        if (set == true)
        {
            {
                byte* ptr = (byte*)recvptr;
                *(ptr) = 0xc3;
            }
        }
        else
        {
            {
                byte* ptr = (byte*)recvptr;
                *(ptr) = 0x55;
            }
        }
        DumbHook.Import.VirtualProtect(recvptr, 1, oldProt, out oldProt);
        UnityEngine.Debug.Log(recvptr.ToString("X"));
    }

    [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll")]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    private unsafe void P2PUpdate(bool set)
    {



    }
    public static Color32 TargetColor = new Color32(255, 255, 255, 255);
    public static Color32 ScientistColor = new Color32(255, 255, 255, 255);
    public static Color32 CollectablEspColor = new Color32(255, 255, 255, 255);
    public static Color32 PlayerColor = new Color32(255, 255, 255, 255);
    public static Color32 WorldEspColor = new Color32(255, 255, 255, 255);

    public static Dictionary<string, Shader> dictShaders = new Dictionary<string, Shader> { };
    private static readonly FieldInfo nig = typeof(BowWeapon).GetField("attackReady", BindingFlags.Instance | BindingFlags.NonPublic);
    public static BufferList<BaseNetworkable> amnigga()
    {
        ListDictionary<uint, BaseNetworkable> listDictionary = (ListDictionary<uint, BaseNetworkable>)test11111.GetValue(BaseNetworkable.clientEntities);
        return listDictionary.Values;
    }
    public static Shader chamShader1;
    public static FieldInfo _multiMesh = null;
    private IEnumerator chamstest()
    {
        while (true)
        {
            try
            {
                if (LocalPlayer.Entity != null && BaseEntityEx.IsValid(LocalPlayer.Entity) && CFG.Setting.cahh)
                {
                    if (_multiMesh == null)
                    {
                        _multiMesh = typeof(PlayerModel).GetField("_multiMesh", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
                    }
                    if (chamShader1 != null)
                    {
                        foreach (BasePlayer player_chams in BasePlayer.VisiblePlayerList)
                        {
                            SkinnedMultiMesh smm = (SkinnedMultiMesh)_multiMesh.GetValue(player_chams.playerModel);
                            foreach (Renderer r in smm.Renderers)
                            {
                                if (r.name.Contains("hair") && player_chams != null && r != null && !player_chams.IsLocalPlayer() && !player_chams.IsSleeping() && smm != null && player_chams.IsAlive())
                                {
                                    if (CFG.Setting.cahh)
                                    {
                                        if (r.enabled == true)
                                        {
                                            r.enabled = false;
                                        }
                                    }
                                    else
                                    {
                                        if (r.enabled == false)
                                        {
                                            r.enabled = true;
                                        }
                                    }

                                }
                                else
                                {
                                    if (CFG.Setting.cahh)
                                    {
                                        if (!dictShaders.ContainsKey(r.material.name))
                                        {
                                            dictShaders.Add(r.material.name, r.material.shader);
                                        }

                                        if (r.material.shader != chamShader1)
                                        {
                                            r.material.shader = chamShader1;
                                        }
                                    }
                                    else
                                    {
                                        if (dictShaders.ContainsKey(r.material.name))
                                        {
                                            if (r.material.shader == chamShader1)
                                            {
                                                r.material.shader = dictShaders[r.material.name];
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

            }
            yield return new WaitForSeconds(1f);
        }
    }
    private Projectile CreateProjectileBaseMelee(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity)
    {
        GameObject gameObject = GameManager.client.CreatePrefab(prefabPath, pos, Quaternion.LookRotation(forward), true);
        if (gameObject == null)
        {
            return null;
        }
        Projectile component = gameObject.GetComponent<Projectile>();
        if (CFG.Setting.hhhh)
        {
            component.gravityModifier = 0f;
        }
        if (CFG.Setting.uuyyttrrr)
        {
            component.thickness = 100;
        }
        component.InitializeVelocity(velocity);
        return component;
    }
    private Projectile CreateProjectileBaseMeleeTrampoline(string prefabPath, Vector3 pos, Vector3 foward, Vector3 velocity)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return new Projectile();
    }
    private BaseEntity CreateOrUpdateEntity(ProtoBuf.Entity info, long size)
    {
        return CreateOrUpdateEntityTrampoline(info, size);
    }

    private unsafe void tt(bool set)
    {
        MethodInfo envSync = typeof(EnvSync).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null);
        System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(envSync.MethodHandle);
        IntPtr envPtr = envSync.MethodHandle.GetFunctionPointer();
        DumbHook.Import.VirtualProtect(envPtr, 1, 0x40, out uint oldProt);
        if (set == true)
        {
            {
                byte* ptr = (byte*)envPtr;
                *(ptr) = 0xc3;
            }
        }
        else
        {
            {
                byte* ptr = (byte*)envPtr;
                *(ptr) = 0x55;
            }
        }
        DumbHook.Import.VirtualProtect(envPtr, 1, oldProt, out oldProt);
    }
    private BaseEntity CreateOrUpdateEntityTrampoline(ProtoBuf.Entity info, long size)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return new BaseEntity(); //arbitrary return value
    }

    private readonly DumbHook CreateOrUpdate;
    private DumbHook boredasf1;
    private DumbHook boredasf111111;
    private static readonly FieldInfo test11111 = typeof(BaseNetworkable.EntityRealm).GetField("entityList", BindingFlags.Instance | BindingFlags.NonPublic); public static Shader chamShader;

    private void Movement_NoclipTrampoline(InputState input, ModelState modelState)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    private void UpdateCameraTrampoline(Camera cam)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

    private DumbHook spin;
    private readonly DumbHook boredaaaasf1;
    private void Start()
    {

        byte[] yeahhh111111 = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        spin = new DumbHook(typeof(BasePlayer), "SendClientTick", typeof(HACK), "SendClientTick", typeof(HACK), "SendClientTickTrampoline", yeahhh111111);

        byte[] throwithardreee = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        shotgunspread1 = new DumbHook(typeof(ItemModProjectile), "GetIndexedSpreadScalar", typeof(HACK), "GetIndexedSpreadScalar", typeof(HACK), "GetIndexedSpreadScalarTrampoline", throwithardreee);
        byte[] younigger = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x48, 0x83, 0xec, 0x08, 0x48, 0x8b, 0xf1 };
        canaim1 = new DumbHook(typeof(PlayerWalkMovement), "CanSprint", typeof(HACK), "CanSprint", typeof(HACK), "CanSprintTrampoline", younigger);

        byte[] noper = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x48, 0x83, 0xec, 0x08, 0x48, 0x8b, 0xf1 };
        canaim = new DumbHook(typeof(BaseProjectile), "CanAim", typeof(HACK), "CanAim", typeof(HACK), "CanAimTrampoline", noper);

        base.StartCoroutine(hook());
        base.StartCoroutine(hok());
        base.StartCoroutine(heal());
        base.StartCoroutine(brr());
        base.StartCoroutine(winer());
        base.StartCoroutine(hoook());
        base.StartCoroutine(gravityandwalk());

        byte[] yeahhh11111 = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x57, 0x48, 0x83, 0xec, 0x28 };
        boredasf111111 = new DumbHook(typeof(BaseMelee), "CreateProjectile", typeof(HACK), "CreateProjectileBaseMelee", typeof(HACK), "CreateProjectileBaseMeleeTrampoline", yeahhh11111);
        boredasf111111.Hook();


        byte[] canJumpBytes = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x48, 0x83, 0xec, 0x08, 0x48, 0x8b, 0xf1 };
        jump = new DumbHook(typeof(PlayerWalkMovement), "CanJump", typeof(HACK), "CanJump", typeof(HACK), "CanJumpTrampoline", canJumpBytes);


        byte[] CanAttackBytes = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x48, 0x83, 0xec, 0x08, 0x48, 0x8b, 0xf1 };
        canAttack = new DumbHook(typeof(BasePlayer), "CanAttack", typeof(HACK), "CanAttack", typeof(HACK), "CanAttackTrampoline", CanAttackBytes);
        canAttack.Hook();


        byte[] orig9 = new byte[]
{
           0x55, 0x48, 0x8b, 0xec, 0x48, 0x83, 0xec, 0x20, 0xf3, 0x0f, 0x11, 0x4d, 0xf0, 0x90
};
        proj = new DumbHook(typeof(global::BasePlayer), "SendProjectileAttack", typeof(HACK), "SendProjectileAttack", typeof(HACK), "SendProjectileAttackTrampoline", orig9);
        proj.Hook();


        byte[] aimco = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        aimcone = new DumbHook(typeof(BaseProjectile), "GetAimCone", typeof(HACK), "GetAimCone", typeof(HACK), "GetAimConeTrampoline", aimco);

        byte[] gavu = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        ggdsfdf = new DumbHook(typeof(BasePlayer), "GetSpeed", typeof(HACK), "GetSpeed", typeof(HACK), "GetSpeedTrampoline", gavu);


        byte[] byt = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x57, 0x48, 0x83, 0xec, 0x28 };
        projshit = new DumbHook(typeof(BaseProjectile), "CreateProjectile", typeof(HACK), "CreateProjectile", typeof(HACK), "CreateProjectileTrampoline", byt);
        projshit.Hook();


        byte[] fuckyou = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        resetter = new DumbHook(typeof(TOD_Sky), "UpdateAmbient", typeof(HACK), "UpdateAmbient", typeof(HACK), "UpdateAmbientTrampoline", fuckyou);

        byte[] yeahhh1 = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        boredasf1 = new DumbHook(typeof(Projectile), "FixedUpdate", typeof(HACK), "FixedUpdate", typeof(HACK), "UpdateTrampoline", yeahhh1);







        byte[] dasdasdasdasd = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        dfdsf1 = new DumbHook(typeof(Client), "OnRequestUserInformation", typeof(HACK), "OnRequestUserInformation", typeof(HACK), "OnRequestUserInformationTrampoline", dasdasdasdasd);
        dfdsf1.Hook();
        byte[] ffffffff = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        ffffff = new DumbHook(typeof(AppDomain), "GetAssemblies", typeof(HACK), "GetAssemblies", typeof(HACK), "GetAssembliesTrampoline", ffffffff);

    }

    private DumbHook ffffff;
    public Assembly[] GetAssemblies()
    {
        bool refOnly = false;
        MethodInfo nGetAssemblies = typeof(AppDomain).GetMethod("GetAssemblies", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
        Assembly[] assemblies = (Assembly[])nGetAssemblies.Invoke(null, new object[] { refOnly });
        int index = Array.IndexOf(assemblies, "ApexAI");
        assemblies[index] = null;
        return assemblies;
    }


    public Assembly[] GetAssembliesTrampoline()
    {

        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return gameObject.GetComponent<AppDomain>().GetAssemblies();
    }
    public static void noclipTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    private bool CanSprint()
    {
        return true;
    }
    private bool CanSprintTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return true;
    }

    public static uint dev;
    public static string faked = "vk.com/Deft.solutions - Privat Hack";
    private DumbHook dfdsf1;
    private readonly DumbHook dfdsf;
    private readonly DumbHook dfsffdsf;

    private void OnRequestUserInformation(Message packet)
    {
        LoadingScreen.Show();
        if (SingletonComponent<LoadingScreen>.Instance)
        {
            SingletonComponent<LoadingScreen>.Instance.UpdateFromServer("CONNECTING", "NEGOTIATING CONNECTION");
        }
        if (packet.peer.write.Start())
        {
            packet.peer.write.PacketID(Message.Type.GiveUserInformation);
            packet.peer.write.UInt8(228);
            packet.peer.write.UInt64(Client.Steam.SteamId);
            packet.peer.write.UInt32(dev);
            packet.peer.write.String(gameObject.GetComponent<Client>().GetOSName());
            packet.peer.write.String(CFG.Setting.spoof ? CFG.Setting.faked : Client.Steam.Username);
            packet.peer.write.String(SteamUtil.betaBranch);
            Auth.Ticket ticket = gameObject.GetComponent<Client>().GetAuthTicket();
            if (ticket == null)
            {
                UnityEngine.Debug.LogWarning("No Token Data!");
                Network.Net.cl.Disconnect("No Token Data", true);
                return;
            }
            packet.peer.write.BytesWithSize(ticket.Data);
            packet.peer.write.Send(new SendInfo(packet.connection));
        }
    }
    public static void yff()
    {
        int ggc = menu.df;
        switch (ggc)
        {
            case 0:
                dev = 2062U;
                break;
            case 1:
                dev = 2054U;
                break;

        }
    }
    private void OnRequestUserInformationTrampoline(Message packet)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }




    public bool ShouldReceiveVoice()
    {
        return true;
    }
    public bool ShouldReceiveVoiceTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return false;
    }
    protected void StartAttackCooldown(float cooldown)
    {
        if (menu.fast)
        {
            Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();

            if (activeItem != null && (activeItem.info.shortname.Contains("hammer")))
            {
                cooldown = cooldown * CFG.Setting.dfd;
            }
        }

        StartAttackCooldownTrampoline(cooldown);
    }

    protected void StartAttackCooldownTrampoline(float cooldown)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

    private void SendClientTick()
    {

        System.Random rand1 = new System.Random();

        localplayer.lastSentTickTime = Time.realtimeSinceStartup;
        using (PlayerTick playerTick = Pool.Get<PlayerTick>())
        {
            Item activeItem = localplayer.Belt.GetActiveItem();
            playerTick.activeItem = ((activeItem == null) ? 0U : activeItem.uid);
            playerTick.inputState = localplayer.input.state.current;
            playerTick.position = base.transform.position;
            playerTick.eyePos = localplayer.eyes.position;
            if (playerTick.modelState == null)
            {
                playerTick.modelState = Pool.Get<ModelState>();
                playerTick.modelState.onground = true;
            }
            if (CFG.Setting.govno2 && !LocalPlayer.Entity.IsSleeping())
            {
                playerTick.inputState.buttons = 1;
            }

            if (CFG.Setting.spin)
            {

                menu.hh += CFG.Setting.sped;
                if (menu.hh > 360f)
                {
                    menu.hh = 0f;
                }

                playerTick.inputState.aimAngles = new Vector3(menu.hhh, menu.hh, 0);


            }

            if (playerTick.modelState != null)
            {
                playerTick.modelState.CopyTo(playerTick.modelState);
            }
            if (Net.cl.write.Start())
            {
                Net.cl.write.PacketID(Message.Type.Tick);
                playerTick.WriteToStreamDelta(Net.cl.write, localplayer.lastSentTick);
                Net.cl.write.Send(new SendInfo(Net.cl.Connection)
                {
                    priority = Priority.Immediate
                });
            }
            if (Net.cl.IsRecording)
            {
                byte[] array = playerTick.ToProtoBytes();
                Net.cl.ManualRecordPacket(15, array, array.Length);
            }
            if (localplayer.lastSentTick == null)
            {
                localplayer.lastSentTick = Pool.Get<PlayerTick>();
            }
            playerTick.CopyTo(localplayer.lastSentTick);
        }
    }

    private void SendClientTickTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }



    public static void debugcamera()
    {
        if (SingletonComponent<CameraMan>.Instance == null)
        {
            GameManager.client.CreatePrefab("assets/bundled/prefabs/system/debug/debug_camera.prefab", default(Vector3), default(Quaternion), true);
        }
        else
        {
            SingletonComponent<CameraMan>.Instance.enabled = true;
        }
        if (!Client.IsPlayingDemo)
        {
            LocalPlayer.Entity.OnViewModeChanged();
        }
    }
    public static void debugcameraTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    public void UpdateAmbient()
    {
        if (CFG.Setting.свет)
        {
            RenderSettings.ambientMode = AmbientMode.Flat;
            RenderSettings.ambientLight = youabitch;
            RenderSettings.ambientIntensity = 1f;
        }
        if (!CFG.Setting.свет)
        {
            float saturation = gameObject.GetComponent<TOD_Sky>().Ambient.Saturation;
            float num = Mathf.Lerp(gameObject.GetComponent<TOD_Sky>().Night.AmbientMultiplier, gameObject.GetComponent<TOD_Sky>().Day.AmbientMultiplier, gameObject.GetComponent<TOD_Sky>().LerpValue);
            TOD_AmbientType mode = gameObject.GetComponent<TOD_Sky>().Ambient.Mode;
            if (mode != TOD_AmbientType.Color)
            {
                if (mode != TOD_AmbientType.Gradient)
                {
                    if (mode == TOD_AmbientType.Spherical)
                    {
                        UnityEngine.Color ambientLight = TOD_Util.AdjustRGB(gameObject.GetComponent<TOD_Sky>().AmbientColor, num, saturation);
                        RenderSettings.ambientMode = AmbientMode.Skybox;
                        RenderSettings.ambientLight = ambientLight;
                        RenderSettings.ambientIntensity = num;
                        RenderSettings.ambientProbe = gameObject.GetComponent<TOD_Sky>().RenderToSphericalHarmonics(num, saturation);
                    }
                }
                else
                {
                    UnityEngine.Color ambientGroundColor = TOD_Util.AdjustRGB(gameObject.GetComponent<TOD_Sky>().AmbientColor, num, saturation);
                    UnityEngine.Color ambientEquatorColor = TOD_Util.AdjustRGB(gameObject.GetComponent<TOD_Sky>().SampleEquatorColor(), num, saturation);
                    UnityEngine.Color ambientSkyColor = TOD_Util.AdjustRGB(gameObject.GetComponent<TOD_Sky>().SampleSkyColor(), num, saturation);
                    RenderSettings.ambientMode = AmbientMode.Trilight;
                    RenderSettings.ambientSkyColor = ambientSkyColor;
                    RenderSettings.ambientEquatorColor = ambientEquatorColor;
                    RenderSettings.ambientGroundColor = ambientGroundColor;
                    RenderSettings.ambientIntensity = num;
                }
            }
            else
            {
                UnityEngine.Color ambientLight2 = TOD_Util.AdjustRGB(gameObject.GetComponent<TOD_Sky>().AmbientColor, num, saturation);
                RenderSettings.ambientMode = AmbientMode.Flat;
                RenderSettings.ambientLight = ambientLight2;
                RenderSettings.ambientIntensity = num;
            }
        }

    }
    private static UnityEngine.Color youabitch = new UnityEngine.Color(0.42f, 0.42f, 0.42f, 0.42f);
    private static UnityEngine.Color youabitch1 = new UnityEngine.Color(0.1f, 0.1f, 0.1f, 0.1f);
    public void UpdateAmbientTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }



    private bool CanJump()
    {
        if (CFG.Setting.asawersffd)
        {
            return true;
        }
        return UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().jumpTime >= 0.5f && (gameObject.GetComponent<PlayerWalkMovement>().ladder != null ||
            (UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().groundTime <= 0.1f && UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().landTime >= 0.1f && (UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().landTime >= 0.2f || !gameObject.GetComponent<PlayerWalkMovement>().sliding)));
    }

    private bool CanJumpTrampoline()
    {
        int num = 12;
        int num2 = 9;
        int num3 = 104;
        int num4 = num3 * num - 15;
        int num5 = num4 + num;
        int num6 = num2 + num3;
        num = num2 + 12;
        num2 = num3 - 4;
        num4 = num + num2;
        num5 = num + num3 + num4;
        return UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().jumpTime >= 0.5f && (gameObject.GetComponent<PlayerWalkMovement>().ladder != null ||
            (UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().groundTime <= 0.1f && UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().landTime >= 0.1f && (UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().landTime >= 0.2f || !gameObject.GetComponent<PlayerWalkMovement>().sliding)));

    }
    public void SetNetworkPositionTrampoline(Vector3 vPos)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    public virtual bool CanHoldItems()
    {
        return true;
    }
    public virtual bool CanHoldItemsTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return true;
    }
    public bool CanAttackTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return false;
    }
    public bool CanAttack()
    {
        return true;
    }

    public void OnLand(float fVelocity)
    {
        fVelocity = 0f;
    }

    public void OnLandTrampoline(float fVelocity)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    public static float GetAimCone()
    {
        return (CFG.Setting.cdddeee ? 0f : 1f);
    }
    public static float GetAimConeTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return 0f;
    }
    public float GetSpeed(float running, float ducking)
    {
        if (CFG.Setting.blats)
        {
            return CFG.Setting.speedhackspeed;
        }
        return Mathf.Lerp(Mathf.Lerp(2.8f, 5.5f, running), 1.7f, ducking);
    }

    public float GetSpeedTrampoline(float running, float ducking)
    {
        //trash code
        int num = 12;
        int num2 = 9;
        int num3 = 104;
        int num4 = num3 * num - 15;
        int num5 = num4 + num;
        int num6 = num2 + num3;
        num = num2 + 12;
        num2 = num3 - 4;
        num4 = num + num2;
        num5 = num + num3 + num4;
        return Mathf.Lerp(Mathf.Lerp(2.8f, 5.5f, running), 1.7f, ducking); //arbitrary return value
    }
    public static float speedhackspeed = 6f;

    private Projectile CreateProjectileTrampoline(string prefabPath, Vector3 pos, Vector3 foward, Vector3 velocity)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return new Projectile();
    }
    private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity)
    {
        GameObject gameObject = GameManager.client.CreatePrefab(prefabPath, pos, Quaternion.LookRotation(forward), true);
        if (gameObject == null)
        {
            return null;
        }
        Projectile component = gameObject.GetComponent<Projectile>();


        if (CFG.Setting.cvvcv && LocalPlayer.Entity != null)
        {
            Vector2 vector = new Vector2(Screen.width / 2, Screen.height / 2);
            float num = 150f;
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                if (!CFG.Setting.friendsList.Contains(basePlayer.userID) && basePlayer != null && !basePlayer.IsLocalPlayer() && basePlayer.health > 0f && !basePlayer.IsDead() && !basePlayer.IsSleeping())
                {
                    Vector3 positionBone = basePlayer.model.headBone.transform.position;
                    if (!(positionBone == Vector3.zero))
                    {
                        Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(positionBone);
                        if (vector2.z > 0f)
                        {
                            Vector2 vector3 = new Vector2(vector2.x, Screen.height - vector2.y);
                            float num2 = Mathf.Abs(Vector2.Distance(vector, vector3));
                            if (num2 <= CFG.Setting.fov1 && num2 < num && basePlayer.IsAlive())
                            {
                                num = num2;
                                HACK.localplayer = basePlayer;
                            }
                        }
                    }
                }
            }
            if (HACK.localplayer != null && HACK.localplayer.IsAlive() && !HACK.localplayer.IsLocalPlayer())
            {
                int randomSpot = new System.Random().Next(199, 999999999);
                int randomSpot2 = new System.Random().Next(1, 50);
                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(component, CFG.Setting.gggggg ? randomSpot2 : randomSpot);

                component.transform.position = HACK.localplayer.model.rootBone.position + new Vector3(0f, 0.2f, 0f);
            }
        }










        if (CFG.Setting.dffs && LocalPlayer.Entity != null)
        {
            Vector2 vector4 = new Vector2(Screen.width / 2, Screen.height / 2);
            float num3 = 150f;
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (!CFG.Setting.friendsList.Contains(basePlayer2.userID) && basePlayer2 != null && !basePlayer2.IsLocalPlayer() && basePlayer2.health > 0f && !basePlayer2.IsDead() && !basePlayer2.IsSleeping())
                {
                    Vector3 positionBone2 = basePlayer2.model.headBone.transform.position;
                    if (!(positionBone2 == Vector3.zero))
                    {
                        Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(positionBone2);
                        if (vector5.z > 0f)
                        {
                            Vector2 vector6 = new Vector2(vector5.x, Screen.height - vector5.y);
                            float num4 = Mathf.Abs(Vector2.Distance(vector4, vector6));
                            if (num4 <= CFG.Setting.fov1 && num4 < num3 && basePlayer2.IsAlive())
                            {
                                num3 = num4;
                                HACK.localplayer = basePlayer2;
                            }
                        }
                    }
                }
            }
            if (HACK.localplayer != null && HACK.localplayer.IsAlive() && !HACK.localplayer.IsLocalPlayer())
            {
                int randomSpot = new System.Random().Next(199, 999999999);
                int randomSpot2 = new System.Random().Next(1, 50);
                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(component, CFG.Setting.gggggg ? randomSpot : randomSpot2);

                component.transform.position = HACK.localplayer.model.headBone.position + new Vector3(0f, 0.05f, 0f);
            }
        }
        if (CFG.Setting.vcgrrrr)
        {
            component.gravityModifier = 0f;
        }
        if (CFG.Setting.sdfewewdff)
        {
            component.thickness = 100f;
        }
        if (CFG.Setting.asdas)
        {
            component.thickness = 0.35f;
        }
        component.ricochetChance = 0f;
        Projectile.Modifier fastasfuckboi = Projectile.Modifier.Default;
        component.InitializeVelocity(velocity);
        component.modifier = fastasfuckboi;
        return component;
    }

    public float GetIndexedSpreadScalar(int shotIndex, int maxShots)
    {
        if (CFG.Setting.sfwewwww)
        {
            float time1;
            if (shotIndex != 0)
            {
                float num = 0f / maxShots;
                time1 = shotIndex * num;
            }
            else
            {
                time1 = UnityEngine.Random.Range(0f, 0f);
            }
            return 0f;
        }
        float time;
        if (shotIndex != -1)
        {
            float num = 1f / maxShots;
            time = shotIndex * num;
        }
        else
        {
            time = UnityEngine.Random.Range(0f, 1f);
        }
        return gameObject.GetComponent<ItemModProjectile>().spreadScalar.Evaluate(time);
    }
    public float GetProjectileSpeed()
    {

        if (localplayer.GetHeldEntity() == null)
        {
            return 375f;
        }


        int itemID = localplayer.GetHeldEntity().GetOwnerItemDefinition().itemid;
        float speed = 300f;

        switch (itemID)
        {
            case -1461508848:
                speed = 375f;
                break;
            case -1716193401:
                speed = 375f;
                break;
            case 193190034:
                speed = 375f;
                break;
            case -55660037:

                break;
            case 109552593:
                speed = 240f;
                break;
            case -2094080303:
                speed = 240f;
                break;
            case 2033918259:
                speed = 300f;
                break;
            case 371156815:
                speed = 300f;
                break;
            case -930579334:
                speed = 300f;
                break;
            case -1745053053:
                speed = 375f;
                break;
            case 548699316:
                speed = 300f;
                break;
            case 456448245:
                speed = 300f;
                break;
            case -853695669:
                speed = 59f;
                break;
            case 2123300234:
                speed = 59f;
                break;
        }

        if (localplayer.GetHeldEntity().GetComponent<BaseProjectile>().IsSilenced())
        {
            speed = speed * 0.745f;
        }

        return speed;
    }

    public float GetIndexedSpreadScalarTrampoline(int shotIndex, int maxShots)
    {
        int num = 12;
        int num2 = 9;
        int num3 = 104;
        int num4 = num3 * num - 15;
        num = num2 + 12;
        num2 = num3 - 4;
        num4 = num + num2;

        return 0f;
    }



    public virtual bool CanAim()
    {
        return true;
    }
    public virtual bool CanAimTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
        return true;
    }



    public BaseNetworkable net;
    private DumbHook jump;
    private readonly DumbHook updateee;
    private DumbHook canAttack;
    private readonly DumbHook instantloot;
    private readonly DumbHook hahyea;
    private readonly DumbHook nofall;
    private DumbHook aimcone;
    private DumbHook ggdsfdf;
    private DumbHook projshit;
    private DumbHook proj;
    private DumbHook shotgunspread1;
    private readonly DumbHook seeinv;
    private DumbHook resetter;
    private readonly DumbHook holditems;
    private readonly DumbHook debug;
    private DumbHook canaim;
    private DumbHook canaim1;
    private readonly DumbHook build;
    private readonly DumbHook spread1;
    private readonly DumbHook namespoof;


    public static float player1;
    public static float teleportheight;
    public void SendProjectileAttackTrampoline(PlayerProjectileAttack attack)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;

    }


    public static BasePlayer getbaseplayertest()
    {
        BasePlayer result = null;
        Vector2 vector = new Vector2(Screen.width / 2f, Screen.height / 2f);
        float num = 10000f;
        foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
        {
            if (!(basePlayer == null) && !basePlayer.IsLocalPlayer() && basePlayer.health > 0f && !basePlayer.IsDead() && !basePlayer.IsDead())
            {
                Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position);
                Vector2 vector3 = new Vector2(vector2.x, Screen.height - vector2.y);
                float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector2.x, Screen.height - vector2.y)));
                if (num2 <= CFG.Setting.fov1 && num2 < num && basePlayer.IsAlive())
                {
                    num = num2;
                    result = basePlayer;
                }
            }
        }
        return result;
    }

    public static Vector3 target()
    {
        Vector3 result = Vector3.zero;
        Vector2 vector = new Vector2(Screen.width / 2, Screen.height / 2);
        float num = 7000f;
        foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
        {
            if (!CFG.Setting.friendsList.Contains(basePlayer.userID) && basePlayer != null && !basePlayer.IsLocalPlayer() && basePlayer.health > 0f && !basePlayer.IsDead())
            {
                Vector3 positionBone;
                if (CFG.Setting.bbccvvdd)
                {
                    positionBone = basePlayer.model.rootBone.transform.position;
                }
                else
                {
                    positionBone = basePlayer.model.headBone.transform.position + new Vector3(0f, 0.05f, 0f);
                }
                if (!(positionBone == Vector3.zero))
                {
                    Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(positionBone);
                    if (vector2.z > 0f)
                    {
                        Vector2 vector3 = new Vector2(vector2.x, Screen.height - vector2.y);
                        float num2 = Mathf.Abs(Vector2.Distance(vector, vector3));
                        if (num2 <= CFG.Setting.fov1 && num2 <= num)
                        {
                            result = positionBone;
                            num = num2;
                        }
                    }
                }
            }
        }
        return result;
    }

    public static BasePlayer targetaimkill;
    public static Vector3 giva()
    {
        Vector3 result = Vector3.zero;
        Vector2 vector = new Vector2(Screen.width / 2, Screen.height / 2);
        float num = 7000f;
        foreach (BaseNpc b in BaseNpc.VisibleNpcList)
        {
            if (b != null && b.health > 0f)
            {
                Vector3 positionBone;

                positionBone = b.FindBone("head").position;

                if (!(positionBone == Vector3.zero))
                {
                    Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(positionBone);
                    if (vector2.z > 0f)
                    {
                        Vector2 vector3 = new Vector2(vector2.x, Screen.height - vector2.y);
                        float num2 = Mathf.Abs(Vector2.Distance(vector, vector3));
                        if (num2 <= 720 && num2 <= num)
                        {
                            result = positionBone;
                            num = num2;
                        }
                    }
                }

            }
        }

        return result;
    }
    public static Vector3 tank()
    {
        Vector3 result = Vector3.zero;
        Vector2 vector = new Vector2(Screen.width / 2, Screen.height / 2);
        foreach (BradleyAPC b in companent.tank)
        {
            if (b != null && b.health > 0f)
            {
                Vector3 positionBone = b.myRigidBody.transform.position;




                result = positionBone;
            }
        }

        return result;
    }
    public static Vector3 targetheli()
    {
        Vector3 result = Vector3.zero;
        Vector2 vector = new Vector2(Screen.width / 2, Screen.height / 2);
        foreach (BaseHelicopter b in companent.heli1)
        {
            if (b != null && b.health > 0f)
            {
                Vector3 positionBone = b.mainRotor.transform.position;



                if (b.health > 5000)
                {
                    positionBone = b.mainRotor.transform.position;
                }
                else
                {
                    positionBone = b.tailRotor.transform.position;
                }
                result = positionBone;
            }
        }

        return result;
    }
    private void FixedUpdate()
    {
        Projectile projectile = gameObject.GetComponent<Projectile>();
        if (LocalPlayer.Entity != null && projectile != null)
        {

            {
                projectile.UpdateVelocity(UnityEngine.Time.fixedDeltaTime);
                if (CFG.Setting.cahh || CFG.Setting.qewqefdsf || CFG.Setting.BulletDropPrediction || CFG.Setting.dfertwdf)
                {
                    HeldEntity HeldShits = LocalPlayer.Entity.GetHeldEntity();

                    if (BaseEntityEx.IsValid(HeldShits))
                    {
                        if (HeldShits is BaseMelee)
                        {
                            BaseMelee basemelee = LocalPlayer.Entity.GetHeldEntity().GetComponent<BaseMelee>();

                            if (BaseEntityEx.IsValid(basemelee))
                            {
                                Item item = basemelee.GetItem();

                                if (item != null)
                                {
                                    ItemModProjectile itemmodproj = item.info.GetComponent<ItemModProjectile>();
                                    if (itemmodproj != null)
                                    {
                                        int targetdistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.target());

                                        int targetdistanceheli = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.tank());
                                        int targetdistance2 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.targetheli());
                                        int targetdistance3 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.giva());


                                        int projectiledistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, projectile.currentPosition);
                                        {

                                            if (UnityEngine.Input.GetKey(KeyCode.X))
                                            {
                                                if (projectile.isAlive && projectile.isAuthoritative)
                                                {
                                                    if (CFG.Setting.cahh)
                                                    {
                                                        int randomSpot = new System.Random().Next(199, 999999999);
                                                        int randomSpot2 = new System.Random().Next(1, 50);
                                                        typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);

                                                        Vector3 asd = (target() - projectile.currentPosition).normalized;
                                                        Vector3 vector2 = asd * itemmodproj.GetRandomVelocity();
                                                        projectile.currentVelocity = vector2;
                                                    }
                                                    if (CFG.Setting.dfertwdf)
                                                    {
                                                        int randomSpot = new System.Random().Next(199, 999999999);
                                                        int randomSpot2 = new System.Random().Next(1, 50);
                                                        typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);


                                                        Vector3 asd = (tank() - projectile.currentPosition).normalized;
                                                        Vector3 vector2 = asd * itemmodproj.GetRandomVelocity();
                                                        projectile.currentVelocity = vector2;

                                                    }

                                                    if (CFG.Setting.qewqefdsf)
                                                    {
                                                        int randomSpot = new System.Random().Next(199, 999999999);
                                                        int randomSpot2 = new System.Random().Next(1, 50);
                                                        typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);
                                                        Vector3 asd = (giva() - projectile.currentPosition).normalized;
                                                        Vector3 vector2 = asd * itemmodproj.GetRandomVelocity();
                                                        projectile.currentVelocity = vector2;
                                                    }
                                                    if (CFG.Setting.BulletDropPrediction)
                                                    {
                                                        int randomSpot = new System.Random().Next(199, 999999999);
                                                        int randomSpot2 = new System.Random().Next(1, 50);
                                                        typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);
                                                        Vector3 asd = (targetheli() - projectile.currentPosition).normalized;
                                                        Vector3 vector2 = asd * itemmodproj.GetRandomVelocity();
                                                        projectile.currentVelocity = vector2;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        BaseProjectile bp = LocalPlayer.Entity.GetHeldEntity().GetComponent<BaseProjectile>();

                        if (LocalPlayer.Entity != null && BaseEntityEx.IsValid(bp))
                        {
                            if (HeldShits is BaseProjectile)
                            {
                                ItemDefinition bp1 = bp.primaryMagazine.ammoType;

                                if (bp1 != null)
                                {
                                    ItemModProjectile test = bp1.GetComponent<ItemModProjectile>();

                                    if (test != null)
                                    {
                                        int targetdistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.target());

                                        int targetdistanceheli = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.tank());
                                        int targetdistance2 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.targetheli());

                                        int targetdistanceheli2 = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, HACK.giva());

                                        int projectiledistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, projectile.currentPosition);

                                        if (UnityEngine.Input.GetKey(KeyCode.X))
                                        {
                                            if (CFG.Setting.cahh)
                                            {
                                                int randomSpot = new System.Random().Next(199, 999999999);
                                                int randomSpot2 = new System.Random().Next(1, 50);
                                                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);
                                                Vector3 asd = (target() - projectile.currentPosition).normalized;
                                                Vector3 vector2 = asd * test.GetRandomVelocity() * bp.projectileVelocityScale;
                                                projectile.currentVelocity = vector2;
                                            }
                                            if (CFG.Setting.dfertwdf)
                                            {
                                                int randomSpot = new System.Random().Next(199, 999999999);
                                                int randomSpot2 = new System.Random().Next(1, 50);
                                                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);
                                                Vector3 asd = (tank() - projectile.currentPosition).normalized;
                                                Vector3 vector2 = asd * test.GetRandomVelocity() * bp.projectileVelocityScale;
                                                projectile.currentVelocity = vector2;
                                            }

                                            if (CFG.Setting.qewqefdsf)
                                            {
                                                int randomSpot = new System.Random().Next(199, 999999999);
                                                int randomSpot2 = new System.Random().Next(1, 50);
                                                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, CFG.Setting.gggggg ? randomSpot : randomSpot2);
                                                Vector3 asd = (giva() - projectile.currentPosition).normalized;
                                                Vector3 vector2 = asd * test.GetRandomVelocity() * bp.projectileVelocityScale;
                                                projectile.currentVelocity = vector2;
                                            }
                                            if (CFG.Setting.BulletDropPrediction)
                                            {
                                                typeof(Projectile).GetField("traveledDistance", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(projectile, 0f);
                                                Vector3 asd = (targetheli() - projectile.currentPosition).normalized;
                                                Vector3 vector2 = asd * test.GetRandomVelocity() * bp.projectileVelocityScale;
                                                projectile.currentVelocity = vector2;
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }
                }
            }
        }
    }
    private void UpdateTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

    public void SendProjectileAttack(PlayerProjectileAttack attack)
    {


        if (CFG.Setting.qewqefdsf)
        {
            foreach (BaseNpc b in BaseNpc.VisibleNpcList)
            {
                if (b != null)
                {

                    attack.playerAttack.attack.hitBone = 698017942;

                    attack.hitDistance = 0f;
                    attack.playerAttack.attack.hitID = b.net.ID;
                    attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
                }
            }
        }
        bool enabled1113 = CFG.Setting.heli;
        if (enabled1113)
        {
            foreach (BaseHelicopter b in companent.heli1)
            {
                if (b != null)
                {
                    bool flag19 = Vector3.Distance(LocalPlayer.Entity.transform.position, b.transform.position) > 2f;
                    if (flag19)
                    {
                        attack.hitDistance = 0f;
                        attack.playerAttack.attack.hitID = b.net.ID;
                        attack.playerAttack.attack.hitBone = (b.health > 5000 ? 621403276U : 566410933U);
                        attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
                        attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);

                        Effect.client.Run(CFG.Setting.cbvcbcd ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/hit_notify.prefab", LocalPlayer.Entity.eyes.gameObject);
                    }
                    else
                    {
                        attack.hitDistance = 0f;
                        attack.playerAttack.attack.hitID = b.net.ID;
                        attack.playerAttack.attack.hitBone = (b.health > 5000 ? 621403276U : 566410933U);
                        attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
                        attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
                        attack.playerAttack.attack.hitPositionWorld = LocalPlayer.Entity.transform.position;
                        attack.playerAttack.attack.pointStart = LocalPlayer.Entity.transform.position;
                        attack.playerAttack.attack.pointEnd = LocalPlayer.Entity.transform.position;
                        Effect.client.Run(CFG.Setting.cbvcbcd ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/hit_notify.prefab", LocalPlayer.Entity.eyes.gameObject);
                    }
                }
            }
        }
        if (CFG.Setting.heli)
        {
            foreach (BaseHelicopter b in companent.heli1)
            {
                if (b != null)
                {
                    if (b.health > 5000)
                    {
                        attack.playerAttack.attack.hitBone = 566410933;
                    }
                    else
                    {
                        attack.playerAttack.attack.hitBone = 621403276;
                    }
                    attack.hitDistance = 0f;
                    attack.playerAttack.attack.hitID = b.net.ID;
                    attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
                }
            }
        }
        if (UnityEngine.Input.GetKey(KeyCode.X) && CFG.Setting.BulletDropPrediction)
        {
            foreach (BaseHelicopter baseHelicopter in companent.heli1)
            {
                if (baseHelicopter != null)
                {
                    if (baseHelicopter.health > 5000f)
                    {
                        attack.playerAttack.attack.hitBone = 566410933U;
                    }
                    else
                    {
                        attack.playerAttack.attack.hitBone = 621403276U;
                    }
                    attack.hitDistance = 0f;
                    attack.playerAttack.attack.hitID = baseHelicopter.net.ID;
                    attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
                    LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
                }
            }
        }
        if (CFG.Setting.uytgff)
        {
            if (LocalPlayer.Entity != null)
            {
                global::BasePlayer basePlayer = null;
                Vector2 a = new Vector2(Screen.width / 2, Screen.height / 2);
                float num = 7000f;
                foreach (global::BasePlayer basePlayer2 in global::BasePlayer.VisiblePlayerList)
                {
                    if (!CFG.Setting.friendsList.Contains(basePlayer2.userID) && basePlayer2 != null && !basePlayer2.IsLocalPlayer() && !basePlayer2.IsDead())
                    {
                        Vector3 position = basePlayer2.model.headBone.transform.position;
                        if (!(position == Vector3.zero))
                        {
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(position);
                            if (vector.z > 0f)
                            {
                                Vector2 b = new Vector2(vector.x, Screen.height - vector.y);
                                float num2 = Mathf.Abs(Vector2.Distance(a, b));
                                if (num2 <= CFG.Setting.fov1 && num2 < num)
                                {
                                    num = num2;
                                    basePlayer = basePlayer2;
                                }
                            }
                        }
                    }
                }
                if (basePlayer != null && basePlayer.IsAlive() && !basePlayer.IsLocalPlayer())
                {
                    Vector3 position2 = basePlayer.transform.position;
                    Vector3 ptr = MainCamera.mainCamera.WorldToScreenPoint(position2);
                    Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(position2 + new Vector3(0f, 1.7f, 0f));
                    Mathf.Abs(ptr.y - vector2.y);
                    if (MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position).z > 0f)
                    {
                        int num3 = new System.Random().Next(199, 999999999);
                        int num4 = new System.Random().Next(1, 50);
                        attack.hitDistance = CFG.Setting.gggggg ? num3 : num4;
                        attack.playerAttack.attack.hitID = basePlayer.net.ID;
                        attack.playerAttack.attack.hitBone = (CFG.Setting.fdsfdsfew ? 3399023664U : 3198432U);
                        attack.playerAttack.attack.hitPartID = (CFG.Setting.fdsfdsfew ? 1890214305U : 1744899316U);
                        attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
                        attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                        LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
                        Effect.client.Run(CFG.Setting.fdsfdsfew ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                    }
                }
            }
            if (LocalPlayer.Entity != null)
            {
                global::BasePlayer basePlayer3 = null;
                Vector2 a2 = new Vector2(Screen.width / 2, Screen.height / 2);
                float num5 = 7000f;
                foreach (global::BasePlayer basePlayer4 in global::BasePlayer.VisiblePlayerList)
                {
                    if (!CFG.Setting.friendsList.Contains(basePlayer4.userID) && basePlayer4 != null && !basePlayer4.IsLocalPlayer() && !basePlayer4.IsDead())
                    {
                        Vector3 position3 = basePlayer4.model.headBone.transform.position;
                        if (!(position3 == Vector3.zero))
                        {
                            Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(position3);
                            if (vector3.z > 0f)
                            {
                                Vector2 b2 = new Vector2(vector3.x, Screen.height - vector3.y);
                                float num6 = Mathf.Abs(Vector2.Distance(a2, b2));
                                if (num6 <= CFG.Setting.fov1 && num6 < num5)
                                {
                                    num5 = num6;
                                    basePlayer3 = basePlayer4;
                                }
                            }
                        }
                    }
                }
                if (basePlayer3 != null && !basePlayer3.IsLocalPlayer() && !basePlayer3.IsDead())
                {
                    Vector3 position4 = basePlayer3.transform.position;
                    Vector3 ptr2 = MainCamera.mainCamera.WorldToScreenPoint(position4);
                    Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(position4 + new Vector3(0f, 1.7f, 0f));
                    Mathf.Abs(ptr2.y - vector4.y);
                    if (MainCamera.mainCamera.WorldToScreenPoint(HACK.localplayer.transform.position).z > 0f)
                    {
                        int num7 = new System.Random().Next(199, 999999999);
                        int num8 = new System.Random().Next(1, 50);
                        attack.hitDistance = CFG.Setting.gggggg ? num7 : num8;
                        attack.playerAttack.attack.hitID = basePlayer3.net.ID;
                        attack.playerAttack.attack.hitBone = (CFG.Setting.fdsfdsfew ? 3399023664U : 3198432U);
                        attack.playerAttack.attack.hitPartID = (CFG.Setting.fdsfdsfew ? 1890214305U : 1744899316U);
                        attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
                        attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                        LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
                        Effect.client.Run(CFG.Setting.fdsfdsfew ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                    }
                }
            }
        }
        if (CFG.Setting.ssddd)
        {
            global::BasePlayer basePlayer5 = null;
            Vector2 a3 = new Vector2(Screen.width / 2, Screen.height / 2);
            float num9 = 7000f;
            foreach (global::BasePlayer basePlayer6 in global::BasePlayer.VisiblePlayerList)
            {
                if (!CFG.Setting.friendsList.Contains(basePlayer6.userID) && basePlayer6 != null && !basePlayer6.IsLocalPlayer() && !basePlayer6.IsDead())
                {
                    Vector3 position5 = basePlayer6.model.headBone.transform.position;
                    if (!(position5 == Vector3.zero))
                    {
                        Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(position5);
                        if (vector5.z > 0f)
                        {
                            Vector2 b3 = new Vector2(vector5.x, Screen.height - vector5.y);
                            float num10 = Mathf.Abs(Vector2.Distance(a3, b3));
                            if (num10 <= CFG.Setting.fov1 && num10 < num9)
                            {
                                num9 = num10;
                                basePlayer5 = basePlayer6;
                            }
                        }
                    }
                }
            }
            if (LocalPlayer.Entity != null && basePlayer5 != null && attack != null && !basePlayer5.IsWounded() && !basePlayer5.IsLocalPlayer())
            {
                if (Vector3.Distance(LocalPlayer.Entity.transform.position, basePlayer5.transform.position) > 2f)
                {
                    int num11 = new System.Random().Next(199, 999999999);
                    int num12 = new System.Random().Next(1, 50);
                    attack.hitDistance = CFG.Setting.gggggg ? num11 : num12;
                    attack.playerAttack.attack.hitID = basePlayer5.net.ID;
                    attack.playerAttack.attack.hitBone = (CFG.Setting.cbvcbcd ? 3399023664U : 3198432U);
                    attack.playerAttack.attack.hitPartID = (CFG.Setting.cbvcbcd ? 1890214305U : 1744899316U);
                    attack.playerAttack.attack.hitItem = 0U;
                    attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
                    attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                    attack.playerAttack.attack.hitPositionWorld = basePlayer5.FindBone("head").position;
                    Effect.client.Run(CFG.Setting.cbvcbcd ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                }
                else
                {
                    int num13 = new System.Random().Next(199, 999999999);
                    int num14 = new System.Random().Next(1, 50);
                    attack.hitDistance = CFG.Setting.gggggg ? num13 : num14;
                    attack.playerAttack.attack.hitID = basePlayer5.net.ID;
                    attack.playerAttack.attack.hitBone = (CFG.Setting.cbvcbcd ? 3399023664U : 3198432U);
                    attack.playerAttack.attack.hitPartID = (CFG.Setting.cbvcbcd ? 1890214305U : 1744899316U);
                    attack.playerAttack.attack.hitItem = 0U;
                    attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
                    attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                    attack.playerAttack.attack.hitPositionWorld = LocalPlayer.Entity.transform.position;
                    attack.playerAttack.attack.pointStart = LocalPlayer.Entity.transform.position;
                    attack.playerAttack.attack.pointEnd = LocalPlayer.Entity.transform.position;
                    Effect.client.Run(CFG.Setting.cbvcbcd ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                }
            }
        }
        LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);

    }
    private static global::BuildingPrivlidge targ;
    public static BaseHelicopter localheli;
    public static BasePlayer localplayer; public static Vector3 ClampAngles(Vector3 angles)
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
    public static class Chams
    {
        public static byte[] chams = { 0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x0, 0x0, 0x0, 0x0, 0x6, 0x35, 0x2E, 0x78, 0x2E, 0x78, 0x0, 0x32, 0x30, 0x31, 0x37, 0x2E, 0x32, 0x2E, 0x31, 0x66, 0x31, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x13, 0x2D, 0x0, 0x0, 0x0, 0x41, 0x0, 0x0, 0x0, 0x5B, 0x0, 0x0, 0x0, 0x43, 0x1E, 0x0, 0x1, 0x0, 0xB2, 0x1, 0x0, 0x0, 0x92, 0x68, 0x0, 0x0, 0x12, 0xBB, 0x0, 0x41, 0xE, 0x0, 0x8, 0x1D, 0x0, 0x0, 0x1A, 0x0, 0xF0, 0x18, 0x0, 0x4, 0x43, 0x41, 0x42, 0x2D, 0x64, 0x62, 0x33, 0x34, 0x36, 0x64, 0x36, 0x39, 0x31, 0x64, 0x37, 0x61, 0x63, 0x63, 0x34, 0x64, 0x63, 0x32, 0x36, 0x32, 0x35, 0x64, 0x62, 0x31, 0x39, 0x66, 0x39, 0x65, 0x33, 0x66, 0x35, 0x32, 0x0, 0x5D, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x61, 0xEA, 0x8B, 0x50, 0x1D, 0x58, 0x86, 0xAF, 0x6A, 0x5B, 0x2A, 0x62, 0xBE, 0x8B, 0x7D, 0xF1, 0x9A, 0x72, 0x2A, 0x46, 0xFF, 0x98, 0xEB, 0x8C, 0x40, 0xFD, 0xCE, 0x90, 0x26, 0x77, 0x18, 0xD6, 0xB6, 0x19, 0x81, 0xF4, 0x87, 0x68, 0xD1, 0xB6, 0x4, 0x4B, 0xFE, 0x3, 0x25, 0x19, 0xE2, 0x85, 0xEA, 0x6F, 0x61, 0x65, 0xD6, 0x7F, 0xEC, 0x75, 0x9E, 0x33, 0x32, 0x9C, 0x4, 0x98, 0x1D, 0xA1, 0xF9, 0x8, 0xF8, 0xA6, 0xF9, 0xD9, 0xE7, 0x9E, 0xE5, 0x7C, 0xD5, 0xDF, 0x1D, 0x6B, 0x3, 0x54, 0xAF, 0xA5, 0x1, 0xF6, 0xA5, 0x16, 0x21, 0x4C, 0x33, 0xE, 0x66, 0x4A, 0x94, 0x11, 0xA6, 0xD5, 0x8E, 0x2A, 0x9, 0xD6, 0x75, 0x3E, 0x62, 0xBC, 0x7E, 0x1C, 0xB1, 0xB1, 0xE3, 0xDC, 0x64, 0x97, 0x47, 0x48, 0x11, 0x22, 0x35, 0xEF, 0xDC, 0x83, 0xF3, 0x1, 0xFF, 0xE7, 0x93, 0x47, 0xF7, 0x62, 0xCA, 0xDA, 0xB0, 0x14, 0xBF, 0x51, 0x8A, 0xC1, 0x30, 0x6E, 0x1B, 0xC2, 0xC4, 0xD2, 0x80, 0xF3, 0xB2, 0x4, 0x8F, 0x65, 0xD6, 0xF, 0xE8, 0xA, 0xFD, 0xB0, 0xD7, 0xDE, 0x1E, 0x48, 0xC1, 0x64, 0x11, 0x25, 0xAA, 0x31, 0xA1, 0x47, 0x51, 0x4, 0xE6, 0x40, 0x7D, 0x64, 0x16, 0xC9, 0x94, 0x77, 0x1, 0x8E, 0x92, 0xA6, 0x15, 0xBB, 0x2, 0xA8, 0xF3, 0x80, 0xCB, 0x23, 0xC, 0xA8, 0x76, 0x7E, 0xF8, 0x3F, 0xD2, 0x5E, 0x1D, 0x88, 0xF1, 0xFA, 0x65, 0x5A, 0x72, 0xDD, 0xA7, 0xD6, 0x5E, 0x4F, 0xF5, 0x7A, 0x4D, 0xC1, 0x8A, 0xC5, 0x11, 0xC0, 0xD8, 0xE7, 0x25, 0x19, 0xD2, 0xF8, 0x41, 0xDF, 0x6C, 0xAF, 0xA0, 0x90, 0x1D, 0xAE, 0x23, 0xE3, 0xA, 0x20, 0xB3, 0x79, 0xE0, 0xF1, 0x9E, 0x20, 0x99, 0x62, 0x6D, 0x33, 0xAB, 0xE8, 0xDE, 0x1E, 0xA9, 0x8E, 0xEF, 0x76, 0x71, 0x1, 0x96, 0x4B, 0x2B, 0xA5, 0xC3, 0xAE, 0xE5, 0xD4, 0x46, 0xAA, 0xBD, 0x4F, 0xAA, 0x9B, 0x87, 0x14, 0xF9, 0x66, 0xD0, 0x7B, 0xD6, 0x58, 0x32, 0xD9, 0x83, 0xBF, 0xE5, 0x86, 0x4D, 0x8C, 0xA5, 0xA, 0x92, 0xEB, 0x4C, 0x46, 0xCF, 0x56, 0x95, 0xE, 0xC6, 0x75, 0x7C, 0x11, 0x2C, 0xF5, 0x5, 0xA1, 0xC2, 0x39, 0xEA, 0x80, 0xF3, 0x65, 0xFA, 0xD4, 0x7E, 0xB3, 0x4D, 0x95, 0xC2, 0x94, 0x9, 0x91, 0x57, 0x71, 0x99, 0xF2, 0x6, 0x61, 0x51, 0x56, 0x58, 0x41, 0xD4, 0xCB, 0x4B, 0xAD, 0x73, 0xE0, 0x87, 0xAC, 0xF6, 0xED, 0xD7, 0x6D, 0x37, 0x57, 0xA, 0x6, 0x14, 0xFB, 0xD5, 0x7C, 0xA1, 0xD9, 0xC3, 0x2C, 0xE9, 0x37, 0xEE, 0xA1, 0x9D, 0x80, 0x7C, 0x30, 0xB3, 0xE0, 0x85, 0xB3, 0xDE, 0x99, 0x64, 0x11, 0xED, 0x93, 0x7A, 0x63, 0xB6, 0xDE, 0xD6, 0xA7, 0xC9, 0xA5, 0xD2, 0x49, 0xC8, 0xDE, 0x37, 0x50, 0x5F, 0x31, 0xDF, 0x9D, 0xC3, 0x11, 0xF0, 0x9D, 0x77, 0x64, 0xC, 0xE5, 0xCF, 0x39, 0xA1, 0x73, 0xEF, 0x62, 0x52, 0x7B, 0x23, 0x5B, 0xF6, 0xB7, 0x6A, 0x39, 0xB3, 0x3, 0xFA, 0x48, 0x63, 0xFF, 0xAC, 0x3, 0x72, 0x44, 0xC8, 0x36, 0xBE, 0xD3, 0xEB, 0xDD, 0x9, 0x36, 0x77, 0xAE, 0xEB, 0xE3, 0xE1, 0x66, 0xC3, 0x53, 0x1B, 0xBD, 0x46, 0x24, 0x31, 0x69, 0x87, 0xED, 0xD8, 0x24, 0x5F, 0x47, 0xB6, 0xAB, 0x9F, 0xF2, 0xBA, 0x88, 0xFB, 0x84, 0x5D, 0x3A, 0x38, 0x8C, 0x6A, 0x1F, 0xF5, 0x58, 0xE4, 0x7, 0x47, 0x14, 0x99, 0xBE, 0xCC, 0x29, 0x78, 0xBB, 0xBF, 0xB8, 0x9D, 0xB6, 0x65, 0xC6, 0xCF, 0xB5, 0x79, 0x7F, 0x63, 0xB8, 0xE5, 0x80, 0x5B, 0x2, 0xDF, 0xA4, 0xF5, 0x69, 0xBE, 0x79, 0xD3, 0xDD, 0x59, 0x31, 0xD8, 0x41, 0x23, 0x85, 0xA0, 0x72, 0x27, 0x4, 0xB0, 0x5C, 0x3C, 0x34, 0x83, 0xA8, 0x54, 0x35, 0xD5, 0x7A, 0x57, 0x1, 0x55, 0x2F, 0xF1, 0xA9, 0x1, 0x6E, 0xFA, 0x94, 0x45, 0x6B, 0x62, 0x7E, 0x60, 0xF3, 0x3, 0x5B, 0x9C, 0xC1, 0x7A, 0x3F, 0x73, 0x78, 0x48, 0x74, 0x1F, 0xFC, 0xDC, 0xC6, 0xBA, 0x2D, 0x14, 0x1C, 0xD5, 0x5F, 0xCB, 0xB7, 0xD0, 0x2A, 0x97, 0xCF, 0xF2, 0x5A, 0x4F, 0xF, 0xA6, 0x51, 0x9F, 0xAC, 0xE8, 0x28, 0xE8, 0xF2, 0x11, 0xD7, 0x68, 0x2F, 0x2D, 0x2B, 0x2A, 0xF6, 0x95, 0xFD, 0xD8, 0x50, 0x2C, 0x1D, 0x31, 0xD6, 0xE3, 0xC4, 0xEB, 0xF0, 0x95, 0x6, 0xD4, 0xC0, 0x51, 0x20, 0x65, 0x21, 0x71, 0x99, 0x6E, 0xF4, 0xFA, 0xF4, 0xCC, 0x46, 0x71, 0xBB, 0x4F, 0x5D, 0x3E, 0xCC, 0x0, 0x47, 0x19, 0xA2, 0xE3, 0xE9, 0xC, 0x10, 0xE7, 0x70, 0x72, 0xDE, 0xE7, 0xA5, 0x86, 0x53, 0x25, 0x37, 0x72, 0x42, 0xE3, 0xDA, 0xBF, 0xFA, 0x16, 0xF6, 0x25, 0xB0, 0xE8, 0x6D, 0xA, 0x5E, 0x83, 0x66, 0xAD, 0x43, 0xC8, 0xA4, 0x9A, 0xA0, 0x15, 0x34, 0xCE, 0xFA, 0xD7, 0x98, 0x5A, 0x48, 0x32, 0x34, 0x2A, 0x50, 0x5, 0xD7, 0xC5, 0xC6, 0xD7, 0x7F, 0x3E, 0xE2, 0xD6, 0x70, 0xCB, 0xBC, 0xD5, 0x21, 0xAF, 0xDB, 0x53, 0x69, 0x6C, 0x93, 0xD6, 0xC8, 0xB5, 0x88, 0xAF, 0xA, 0xDF, 0x24, 0xF9, 0xD8, 0x5, 0x4C, 0x54, 0x95, 0x25, 0x4A, 0x32, 0xD9, 0x5A, 0x5B, 0x7C, 0xD9, 0x89, 0xE0, 0xA5, 0x8E, 0x14, 0x22, 0x21, 0x6B, 0xD5, 0x7F, 0x14, 0xB2, 0x58, 0x44, 0x10, 0x75, 0xAD, 0x2F, 0xAD, 0x98, 0x33, 0xD9, 0x72, 0xD9, 0x6E, 0x48, 0xF9, 0x94, 0x70, 0x63, 0x2B, 0x37, 0x34, 0x81, 0xB7, 0x94, 0x2A, 0xD3, 0x6F, 0x4C, 0xF0, 0x9F, 0xD3, 0x0, 0x9B, 0x1, 0x16, 0x43, 0x4A, 0xA, 0xB0, 0x11, 0x1E, 0xA4, 0x27, 0x7E, 0x9, 0x85, 0x97, 0xFF, 0xAA, 0xF7, 0x1D, 0xB3, 0x64, 0xDB, 0x74, 0xA1, 0xD1, 0x2F, 0xF0, 0xB4, 0x68, 0x8E, 0x16, 0xD, 0x8E, 0x4B, 0x29, 0xFC, 0xB1, 0xA6, 0x8E, 0xC6, 0x88, 0xC2, 0x7D, 0x1E, 0x1C, 0xB3, 0x63, 0x80, 0x24, 0x1F, 0x74, 0xAD, 0x60, 0x54, 0x6A, 0x7A, 0x1A, 0xED, 0x9F, 0xDD, 0x29, 0xFF, 0x7F, 0x41, 0x78, 0x5A, 0x20, 0xF9, 0xBD, 0x6A, 0xD0, 0xAB, 0x2A, 0x2, 0x2, 0x1D, 0xE6, 0xFC, 0x3B, 0xE6, 0x13, 0x15, 0x9E, 0xF5, 0x32, 0x79, 0x59, 0xFA, 0xD6, 0x59, 0x5D, 0xF2, 0x40, 0x17, 0xBA, 0xCC, 0xD7, 0xA5, 0x6E, 0xA0, 0x59, 0xA9, 0xDC, 0x8, 0x6F, 0x81, 0x77, 0x31, 0x13, 0x4E, 0x54, 0x28, 0x5E, 0xF6, 0xEA, 0xB9, 0x18, 0x1B, 0x31, 0xE8, 0xFF, 0x7D, 0xFB, 0xDE, 0xB4, 0x53, 0xA1, 0xD5, 0xF3, 0xF2, 0x59, 0x4C, 0x91, 0x0, 0x39, 0x90, 0x6F, 0x85, 0xD0, 0xC, 0xF4, 0x43, 0x6F, 0x94, 0x48, 0xA3, 0x8, 0x8D, 0x7F, 0xCD, 0xFA, 0x6F, 0xB4, 0x38, 0x93, 0xC0, 0x44, 0xA7, 0xFC, 0xEF, 0x81, 0x93, 0xD3, 0x1, 0x7E, 0x98, 0xA5, 0x6C, 0x35, 0x75, 0x5B, 0xF0, 0xA5, 0xF1, 0x76, 0xA4, 0x87, 0x2B, 0xAA, 0x1F, 0x23, 0xB6, 0xFC, 0xAF, 0x22, 0x2C, 0x72, 0xA8, 0xD7, 0xE7, 0xDA, 0xE0, 0x5B, 0x61, 0x1B, 0xA0, 0x21, 0x62, 0xB7, 0x4F, 0x14, 0x24, 0x57, 0x7E, 0xD0, 0xA1, 0x9C, 0x22, 0x68, 0x3B, 0xB1, 0x22, 0x1A, 0x45, 0x1A, 0x72, 0xDC, 0xE3, 0x42, 0x50, 0xC9, 0x41, 0x88, 0x2D, 0xE6, 0x5F, 0x3B, 0x89, 0x20, 0x67, 0x1C, 0x7E, 0x16, 0xA1, 0x84, 0x66, 0xCD, 0x3D, 0xA6, 0x80, 0xB5, 0xA1, 0x95, 0x38, 0xCD, 0x4, 0xF0, 0x1F, 0x31, 0x59, 0x59, 0xDB, 0x86, 0x20, 0xB8, 0xB3, 0xA4, 0x20, 0xA5, 0x76, 0xC4, 0x39, 0x2, 0x5, 0xED, 0x9A, 0xB7, 0xA6, 0x31, 0xE3, 0x38, 0x99, 0xEF, 0x96, 0x2A, 0xA3, 0xC6, 0xC9, 0x11, 0x6E, 0x64, 0xF3, 0xFE, 0xF1, 0x7E, 0xE7, 0x50, 0x21, 0x15, 0xC3, 0x34, 0x71, 0x9A, 0x4A, 0x50, 0xE1, 0x68, 0x4B, 0xB8, 0x4, 0x8D, 0xE4, 0x2B, 0x7E, 0x8E, 0x3F, 0xEC, 0x99, 0x93, 0x4C, 0x41, 0x1F, 0xD9, 0x18, 0x35, 0x3F, 0x8A, 0xFC, 0xC9, 0xE, 0xDD, 0x17, 0x89, 0x64, 0xC8, 0x76, 0x13, 0xE8, 0xEC, 0x15, 0xC, 0x7E, 0xF7, 0x75, 0x5, 0x51, 0xAF, 0x5D, 0xA7, 0x52, 0xBC, 0xBF, 0x87, 0xC5, 0xFE, 0x78, 0xC5, 0x10, 0xB3, 0xC9, 0xD, 0xFD, 0xF3, 0x3E, 0xE2, 0xA9, 0x47, 0x1E, 0xF9, 0x33, 0x8B, 0xB7, 0x73, 0xA0, 0x92, 0xB4, 0xE9, 0xF1, 0xC0, 0xCE, 0xF0, 0x7C, 0x71, 0x21, 0x1C, 0xF8, 0x9A, 0xE9, 0x32, 0x33, 0x18, 0x3, 0xA7, 0x1F, 0x4, 0x6, 0xD3, 0x87, 0x53, 0xD, 0x2F, 0x74, 0xAC, 0x48, 0x7, 0x15, 0xD5, 0xE2, 0xC8, 0xE8, 0xE0, 0xEE, 0x2A, 0x7A, 0x84, 0xF, 0xED, 0x1D, 0xC0, 0x33, 0xB, 0x66, 0x6E, 0x41, 0xF3, 0xE9, 0x65, 0x1D, 0x9D, 0xB0, 0xF7, 0x80, 0xA0, 0xC, 0x82, 0xC0, 0xD2, 0x8E, 0x62, 0x70, 0x2F, 0x43, 0x3F, 0x8, 0x6B, 0x2A, 0x4F, 0x9E, 0x0, 0x97, 0x65, 0x4C, 0xAB, 0x46, 0x4F, 0x74, 0x4C, 0xA0, 0x59, 0xD2, 0x22, 0x43, 0x67, 0x5, 0x55, 0x3B, 0x4F, 0xEA, 0xB9, 0x13, 0x6A, 0x9B, 0xC, 0xAB, 0xF2, 0x97, 0x47, 0x7B, 0xA1, 0x64, 0xE0, 0x6C, 0x90, 0xD3, 0xA, 0xBB, 0x65, 0xD0, 0xCD, 0x57, 0xF4, 0x2A, 0xDE, 0xE2, 0x88, 0x6C, 0xD, 0x6, 0xF7, 0x1A, 0xDC, 0x15, 0x86, 0xF, 0xB3, 0x32, 0x73, 0xC2, 0xD9, 0xA0, 0x45, 0x57, 0x51, 0x5B, 0x89, 0xCC, 0x9A, 0xBC, 0xD3, 0x52, 0x52, 0x90, 0xD9, 0x40, 0xD5, 0x2F, 0x46, 0x8E, 0x51, 0x28, 0x5F, 0x70, 0x52, 0x88, 0x7C, 0x28, 0xF2, 0x5E, 0xDC, 0x7B, 0x52, 0x8C, 0x7A, 0x4E, 0x83, 0x45, 0x41, 0x71, 0x27, 0x1A, 0x33, 0x80, 0xA8, 0xB0, 0xCC, 0xD6, 0x6F, 0x28, 0xE7, 0x98, 0x5A, 0xFA, 0x8E, 0xC1, 0xA9, 0xE0, 0x2C, 0x63, 0x99, 0xE0, 0xAC, 0xBE, 0x97, 0xBF, 0x54, 0x4E, 0x6D, 0x26, 0x7, 0x17, 0xF9, 0xBD, 0x1E, 0x10, 0xCA, 0x38, 0x7F, 0xF0, 0x3D, 0xC0, 0x14, 0xB7, 0x2A, 0x75, 0x7B, 0xB3, 0x9B, 0xB8, 0xE2, 0x11, 0xF1, 0xEE, 0xC6, 0x32, 0xA2, 0xB8, 0x56, 0x70, 0x36, 0xA8, 0xFC, 0x9D, 0x83, 0x63, 0xC8, 0x26, 0xB1, 0xDC, 0xC8, 0x77, 0x8E, 0x2E, 0xD9, 0x66, 0x43, 0x3A, 0x66, 0x50, 0xE7, 0xF9, 0x82, 0xC9, 0x2B, 0x79, 0xB5, 0xED, 0x73, 0x4D, 0xB3, 0xDC, 0x8E, 0x16, 0x5D, 0x7C, 0x27, 0xD2, 0xBC, 0xD1, 0x1D, 0x80, 0x87, 0x49, 0x63, 0xEC, 0x49, 0x99, 0xF2, 0xC1, 0x65, 0xD1, 0x43, 0x91, 0x48, 0xC2, 0x2C, 0xAF, 0xEB, 0x86, 0xC6, 0xD9, 0x7B, 0x55, 0xF9, 0xCC, 0x7D, 0x39, 0x84, 0x4D, 0x26, 0x6B, 0xCE, 0x3B, 0x7A, 0xA8, 0x4B, 0x66, 0xD8, 0xD, 0xBA, 0xBE, 0xBE, 0x91, 0xF7, 0x8D, 0xFF, 0x4F, 0xF3, 0xFB, 0xB4, 0x6, 0xFF, 0x70, 0x95, 0x52, 0x64, 0xBD, 0x38, 0x7D, 0xD, 0x15, 0xD0, 0x37, 0x73, 0xC4, 0xDC, 0xBA, 0x2F, 0x1F, 0x88, 0xDA, 0x6, 0xB6, 0xA0, 0x96, 0xC7, 0x99, 0xF5, 0x74, 0xD3, 0x7C, 0xF7, 0x9F, 0x13, 0x37, 0xF6, 0x6, 0xB3, 0x7A, 0xD3, 0x58, 0x25, 0x50, 0x3A, 0x70, 0x98, 0x4D, 0xA7, 0x64, 0x9, 0x44, 0x5E, 0x6E, 0xD5, 0x36, 0xCF, 0x3, 0x3, 0x6A, 0xE, 0x2F, 0x3, 0xB5, 0xBA, 0x39, 0x67, 0xEB, 0x28, 0x4F, 0x91, 0x2A, 0x8, 0x9B, 0xE1, 0xAE, 0xFB, 0x9B, 0x2F, 0x50, 0x5A, 0x91, 0xAE, 0x1F, 0xD3, 0xB0, 0x47, 0x3B, 0xB6, 0x83, 0x87, 0xB1, 0x62, 0x4D, 0x14, 0xDC, 0x91, 0x28, 0xE7, 0xC, 0x3C, 0xCE, 0x94, 0x4B, 0x25, 0x8, 0x71, 0xA8, 0x5F, 0x3D, 0xC2, 0xA6, 0x34, 0xDE, 0x44, 0xB4, 0xC9, 0x74, 0x58, 0x7B, 0x63, 0x4E, 0x17, 0x24, 0x3D, 0xE1, 0x1F, 0xD, 0x2A, 0x74, 0x6F, 0xFF, 0x8B, 0xFD, 0xDD, 0xFD, 0x3A, 0xC9, 0xDE, 0xEF, 0xAC, 0x18, 0xAF, 0x12, 0x4D, 0x81, 0xE7, 0x27, 0x67, 0x47, 0x6C, 0xD2, 0x20, 0x8A, 0x3D, 0x92, 0x9B, 0x5D, 0x73, 0x7D, 0x8B, 0x2, 0x19, 0x30, 0x91, 0x7A, 0x8, 0xC1, 0x82, 0xB7, 0xDA, 0x53, 0x63, 0xCD, 0xC7, 0xA3, 0x9, 0x9, 0x35, 0xE9, 0xD8, 0x6B, 0x30, 0xED, 0xF1, 0xAD, 0x57, 0x2F, 0xF6, 0x40, 0xA5, 0x1E, 0xB9, 0x7, 0xCC, 0x76, 0x7D, 0x82, 0x5B, 0x1, 0x1E, 0xED, 0xA5, 0x11, 0x9B, 0x8C, 0x2, 0xCD, 0xD0, 0xFA, 0x77, 0x99, 0xBB, 0x29, 0x37, 0x67, 0x95, 0x28, 0xD1, 0xC0, 0x55, 0xDF, 0x2E, 0x48, 0xD6, 0x0, 0x26, 0xC7, 0x18, 0x7E, 0x54, 0xC, 0x13, 0xC6, 0xDF, 0xE1, 0x5, 0x6A, 0x60, 0x8C, 0x55, 0x7D, 0x49, 0x3B, 0xEB, 0xD2, 0x76, 0xFB, 0xA5, 0xE1, 0xBB, 0x9B, 0xD0, 0xE, 0x6E, 0x6F, 0xF5, 0xBC, 0xB7, 0xD8, 0x45, 0x8A, 0x92, 0xD8, 0xD1, 0x2D, 0x62, 0xFE, 0x83, 0xA3, 0x25, 0x54, 0x52, 0x57, 0x64, 0x68, 0x51, 0xE9, 0x6E, 0xE4, 0xDA, 0x22, 0xFB, 0x4D, 0x6C, 0x35, 0xA6, 0xE9, 0xB2, 0xEE, 0xF4, 0xC1, 0x41, 0xC9, 0xAC, 0x11, 0x78, 0x3E, 0x0, 0xF3, 0xC0, 0x73, 0x16, 0x36, 0x5, 0xC3, 0xB, 0xAE, 0xA6, 0xDA, 0x70, 0xA4, 0xE1, 0x8E, 0x3E, 0x9F, 0x3, 0x9B, 0x1E, 0x28, 0xAA, 0xB9, 0xA5, 0x5E, 0x2A, 0xE9, 0x46, 0x37, 0xD6, 0x3C, 0xCF, 0x21, 0xAC, 0x14, 0xB6, 0x3D, 0xA9, 0xF9, 0xBA, 0x8A, 0x17, 0x19, 0x4D, 0xCC, 0xFC, 0xEF, 0xD9, 0x30, 0x69, 0x64, 0xCF, 0xEC, 0xB9, 0x24, 0xB, 0x6, 0xEC, 0xBE, 0x30, 0x9A, 0x97, 0x40, 0x8, 0xB1, 0x26, 0xAC, 0xBF, 0xFC, 0xEC, 0xE6, 0xB5, 0x52, 0x7B, 0xB7, 0x4, 0xCD, 0x48, 0xDB, 0x3F, 0x70, 0xAC, 0x51, 0x4C, 0x73, 0x7E, 0xCD, 0x7C, 0x23, 0x65, 0x95, 0xB7, 0x7A, 0xF5, 0x7F, 0x43, 0x9A, 0x5D, 0xCF, 0x66, 0x16, 0x14, 0xFC, 0x55, 0xDD, 0x7E, 0x2D, 0x8, 0xEC, 0xE2, 0x2, 0x29, 0x8E, 0x8D, 0x9F, 0xA0, 0xDD, 0x9, 0x81, 0x4, 0x94, 0xA9, 0xFA, 0x9B, 0x2C, 0x7E, 0x4D, 0xB2, 0x31, 0x4F, 0x79, 0x30, 0x6E, 0x3F, 0x69, 0xB2, 0x2B, 0x16, 0xDE, 0xF6, 0x5E, 0x86, 0x3, 0xC1, 0x85, 0xFA, 0xCD, 0x3D, 0xB5, 0x46, 0x67, 0xDC, 0x68, 0x69, 0xE5, 0xEB, 0xC6, 0x71, 0x6D, 0x4A, 0x7C, 0x4, 0x82, 0xB7, 0xA1, 0xB3, 0x5A, 0x69, 0xC5, 0xE6, 0x72, 0xCF, 0xB2, 0x8, 0x2F, 0xE4, 0x16, 0xCD, 0xE6, 0x50, 0x6A, 0xC6, 0xF6, 0xFA, 0xA1, 0xEA, 0xA, 0xD1, 0xB, 0x97, 0x6F, 0x7C, 0xBB, 0x32, 0x85, 0x60, 0x23, 0xFD, 0x87, 0xF5, 0x26, 0x84, 0xA4, 0x90, 0xE6, 0xE6, 0xB4, 0xA5, 0x16, 0x92, 0x86, 0xBE, 0x99, 0x1A, 0x16, 0xAE, 0x26, 0xE4, 0x70, 0xBF, 0x48, 0xCC, 0x26, 0xEB, 0xBF, 0x37, 0xF8, 0x97, 0xF5, 0xE0, 0xB6, 0x25, 0x8F, 0x70, 0x38, 0x3B, 0x39, 0x22, 0xBC, 0xB1, 0xE2, 0x2E, 0x6E, 0xD1, 0xFB, 0x28, 0x4E, 0x44, 0xE, 0x73, 0xC2, 0xDE, 0xFB, 0xC6, 0xC0, 0xD9, 0x88, 0xF, 0x74, 0xA7, 0xD4, 0xAB, 0xC5, 0xFB, 0x9E, 0xED, 0x33, 0x53, 0x66, 0x32, 0xC4, 0xF5, 0xD1, 0x14, 0xFF, 0x84, 0x65, 0xDB, 0x59, 0xBE, 0xEC, 0x41, 0x45, 0xF5, 0x17, 0x6E, 0xA5, 0xED, 0x21, 0x85, 0xF7, 0x8B, 0x82, 0xDB, 0xA7, 0x31, 0x5F, 0x60, 0x4E, 0xF4, 0xC2, 0x64, 0x84, 0x58, 0x9D, 0x3F, 0x6C, 0xDF, 0x84, 0xAB, 0x5, 0x11, 0x8E, 0xE4, 0xC0, 0xD9, 0xA6, 0x5A, 0x93, 0x15, 0x27, 0x75, 0x95, 0x35, 0xC9, 0x9B, 0x2C, 0x14, 0xF7, 0x17, 0xBF, 0xAF, 0x13, 0xD, 0x52, 0xC6, 0xF, 0xE1, 0xE7, 0x63, 0xF2, 0x4E, 0xB4, 0x2C, 0x39, 0x8F, 0x6A, 0x34, 0x27, 0x8E, 0x7, 0xA9, 0x19, 0xD8, 0x26, 0x4A, 0xD2, 0xED, 0x33, 0xAD, 0x8A, 0xFD, 0xFB, 0x2A, 0xE4, 0xFA, 0xF1, 0x7, 0xC4, 0xDC, 0x57, 0x6F, 0xA5, 0x31, 0x92, 0xC4, 0x26, 0x10, 0x46, 0x60, 0x4, 0x74, 0x51, 0xE0, 0xF6, 0xC1, 0xD, 0x80, 0x77, 0x2B, 0x6C, 0x66, 0x3F, 0xD1, 0xE1, 0xC6, 0xFF, 0x7E, 0x36, 0xC0, 0x18, 0x47, 0xF1, 0xFA, 0x92, 0x4C, 0xB, 0x21, 0x67, 0xAC, 0xC2, 0x84, 0x62, 0xB3, 0x22, 0xF9, 0x98, 0x48, 0xF3, 0x21, 0x9E, 0x45, 0xDD, 0x0, 0xB1, 0xF0, 0x88, 0xF4, 0xED, 0x65, 0x93, 0x2B, 0xE0, 0xBC, 0xBC, 0xED, 0x80, 0x7, 0x3E, 0x7B, 0xA9, 0xA7, 0x75, 0xC3, 0x48, 0x6A, 0x48, 0x0, 0xAD, 0x38, 0x1A, 0x73, 0x65, 0xA7, 0x40, 0x2B, 0xB0, 0x18, 0x37, 0xA5, 0x9C, 0x75, 0x85, 0x21, 0xE6, 0xE, 0x3A, 0x2C, 0xFF, 0x39, 0x4A, 0x5D, 0xD6, 0x10, 0x81, 0x69, 0x2C, 0x7C, 0x60, 0x25, 0x1, 0x2C, 0xA, 0xB2, 0xFE, 0x72, 0xAF, 0x2, 0xC, 0x25, 0xCC, 0x60, 0x26, 0x36, 0x8A, 0x6A, 0x32, 0x3F, 0x4E, 0xFD, 0xDC, 0x6C, 0xB5, 0x13, 0x5D, 0x95, 0x71, 0x60, 0x73, 0x5D, 0x22, 0x3A, 0x1, 0x5A, 0x24, 0x84, 0x25, 0x79, 0xB3, 0xAA, 0xA9, 0x43, 0xCE, 0x92, 0x25, 0xCA, 0x37, 0x64, 0xF7, 0x8B, 0x1D, 0x5A, 0x8C, 0x7F, 0xB, 0x23, 0x78, 0x16, 0x6A, 0x88, 0x4C, 0xDD, 0x9B, 0x5E, 0xA7, 0xDC, 0xBF, 0x49, 0x5, 0xD5, 0x3D, 0x52, 0xAC, 0x45, 0x34, 0x14, 0x83, 0x57, 0x39, 0x41, 0x8D, 0x21, 0xBC, 0xDF, 0xEF, 0x5D, 0x8C, 0xC7, 0xC2, 0xFD, 0xBE, 0x43, 0xF9, 0x5C, 0xB3, 0x59, 0xAA, 0x65, 0xEC, 0xED, 0x16, 0x80, 0x6E, 0xF4, 0x36, 0x3C, 0x84, 0xEA, 0x15, 0xDE, 0xE8, 0x48, 0x1C, 0x7, 0xBB, 0x2D, 0x37, 0xCB, 0x22, 0x99, 0x7D, 0x35, 0x7D, 0xED, 0xA7, 0xEB, 0x55, 0x71, 0x56, 0x4B, 0x37, 0xC0, 0x48, 0xED, 0xD0, 0x42, 0xBB, 0x14, 0x37, 0x3A, 0x74, 0xC3, 0x86, 0xED, 0x51, 0xF3, 0xF3, 0x64, 0xE1, 0x8, 0xB1, 0x41, 0xB9, 0x23, 0xA5, 0x1A, 0x7E, 0xCA, 0x2F, 0xFB, 0x9F, 0x86, 0x63, 0x47, 0x55, 0x4C, 0x35, 0x83, 0x62, 0xE1, 0xB1, 0xFD, 0xBA, 0xBE, 0x6A, 0x97, 0xAE, 0x46, 0x4, 0x6E, 0xD8, 0xC7, 0x82, 0xC1, 0x8E, 0x56, 0xD9, 0xF7, 0xDC, 0x7, 0xD9, 0xCC, 0x38, 0x15, 0xA7, 0xBD, 0x54, 0x1C, 0xD3, 0x94, 0xB0, 0xD8, 0x35, 0xD1, 0x7A, 0x30, 0x22, 0xA9, 0x42, 0xBB, 0x1D, 0x4D, 0x31, 0x54, 0xFC, 0x85, 0x54, 0x4, 0xF, 0x6E, 0xBE, 0xC4, 0xD7, 0xBC, 0xFF, 0x24, 0xC4, 0xCD, 0x60, 0x60, 0x91, 0xE0, 0x5B, 0x89, 0x30, 0xF2, 0xA, 0xD4, 0xAE, 0xBC, 0xAF, 0xBE, 0xE7, 0xC2, 0xE2, 0x76, 0xB9, 0x8A, 0x4E, 0xAF, 0x8, 0x1A, 0x64, 0x43, 0x63, 0x6, 0xDD, 0x2A, 0x6A, 0xFE, 0xD0, 0xCD, 0x19, 0xB0, 0x63, 0x30, 0xDD, 0x3F, 0xFC, 0x55, 0x65, 0x57, 0x44, 0x4C, 0xC7, 0x1A, 0x59, 0x1D, 0x40, 0x79, 0xFE, 0x92, 0xF6, 0x39, 0xAD, 0x80, 0x2D, 0xB, 0x57, 0x22, 0x32, 0x8C, 0x96, 0x3E, 0x6F, 0xB4, 0xD8, 0xF2, 0x3F, 0x1, 0xBA, 0x34, 0x85, 0x97, 0x9B, 0x8C, 0x67, 0x3B, 0x91, 0xB9, 0x39, 0x6E, 0x88, 0x5, 0xED, 0xE7, 0x92, 0x2C, 0x7F, 0x90, 0xB4, 0xAC, 0x32, 0x14, 0xB, 0xA6, 0xE, 0x6A, 0x9, 0xAC, 0x70, 0xFC, 0x59, 0x2B, 0x2C, 0x68, 0x25, 0xF8, 0x2C, 0x9F, 0x2F, 0x1D, 0xF4, 0x5A, 0x79, 0x73, 0x8D, 0x7F, 0xCB, 0x73, 0xF3, 0x68, 0x3F, 0x7B, 0x6B, 0xC1, 0x84, 0x9C, 0xB3, 0xB1, 0x82, 0x57, 0x4, 0x6F, 0xCA, 0x9D, 0x2, 0xB6, 0xBA, 0xFC, 0xCA, 0xB8, 0x46, 0x36, 0x72, 0x94, 0x86, 0xBA, 0x75, 0xF4, 0xC, 0x0, 0x24, 0x65, 0xF6, 0x91, 0x73, 0x23, 0xF, 0x92, 0x54, 0x5, 0x34, 0x92, 0xE1, 0xF4, 0xE5, 0xB7, 0xB7, 0x31, 0x26, 0x1, 0xF6, 0xB2, 0x2D, 0xA4, 0x7E, 0x56, 0x1E, 0x36, 0x88, 0xE7, 0xC1, 0x4A, 0xF1, 0x70, 0xE5, 0x70, 0x75, 0x12, 0xDC, 0xC9, 0x9B, 0xD8, 0x1F, 0x76, 0xF5, 0x36, 0xCD, 0x70, 0x88, 0x96, 0xCF, 0x4B, 0xD6, 0x39, 0x4F, 0x75, 0x8E, 0x5F, 0x7, 0x59, 0xD5, 0x36, 0x6D, 0xD8, 0xDA, 0x2D, 0xB, 0x65, 0x23, 0x31, 0xA1, 0xF8, 0xD8, 0xE7, 0xC2, 0xF, 0x72, 0x5B, 0x8D, 0x53, 0xD4, 0x61, 0x5B, 0xE5, 0xF5, 0x9C, 0x36, 0xC7, 0xF, 0xBE, 0xF6, 0x36, 0xBB, 0xCE, 0xB6, 0xCB, 0xF7, 0x67, 0xB4, 0x8E, 0x31, 0x88, 0x90, 0x8D, 0xCA, 0xA4, 0x72, 0xD, 0x3A, 0x78, 0x26, 0x7E, 0xBF, 0xB0, 0xDF, 0xC7, 0xD9, 0x25, 0xC4, 0xF6, 0x70, 0x9C, 0xD9, 0x9, 0x98, 0x34, 0x5C, 0x12, 0x96, 0x69, 0xED, 0x80, 0xEC, 0x46, 0x0, 0x54, 0x67, 0xB6, 0xE7, 0xC, 0x96, 0x5E, 0x15, 0x32, 0x5D, 0x44, 0x73, 0x9E, 0xED, 0x85, 0x4D, 0x70, 0x51, 0x25, 0x9E, 0xCF, 0x2B, 0xD2, 0xC2, 0xD7, 0x7B, 0x6C, 0x45, 0x1D, 0xFF, 0x7D, 0x59, 0x5E, 0x3F, 0x27, 0x15, 0xD7, 0xE1, 0x3, 0xA0, 0xD9, 0x30, 0xF1, 0x89, 0x8D, 0xE4, 0x39, 0xDA, 0xDF, 0xE6, 0x80, 0xBD, 0x7B, 0x56, 0xD1, 0x4C, 0x1A, 0xC7, 0x6, 0xC9, 0xE9, 0x99, 0x22, 0xD3, 0x87, 0xB3, 0x75, 0xB5, 0xC4, 0x4E, 0x8B, 0x2, 0x7C, 0x1D, 0x25, 0x8C, 0xAE, 0xEE, 0x51, 0x9F, 0x1E, 0xAD, 0x70, 0x9A, 0x3, 0x8B, 0xB9, 0x4, 0xAC, 0xC3, 0x1A, 0x5A, 0xBA, 0x3C, 0xCE, 0xBF, 0x4C, 0xA0, 0xD2, 0x54, 0x6B, 0x2D, 0x21, 0xBF, 0x6C, 0x4A, 0x79, 0xDD, 0x53, 0xF0, 0xAE, 0x91, 0x5B, 0x4B, 0xA2, 0x5C, 0xCE, 0xED, 0x31, 0x83, 0x14, 0x89, 0x82, 0xA4, 0xFC, 0x17, 0xE8, 0xF5, 0x60, 0x2F, 0x91, 0x24, 0x95, 0xD5, 0xB6, 0x7, 0x6B, 0x53, 0x21, 0x4B, 0x39, 0x48, 0xEA, 0xC7, 0x51, 0x8F, 0xCD, 0x23, 0x77, 0x1F, 0xC1, 0xFE, 0x46, 0xDF, 0x25, 0xA0, 0xF2, 0x8B, 0xFA, 0x4C, 0xBF, 0x7B, 0x93, 0xEA, 0xA3, 0xB, 0xA8, 0x20, 0x70, 0x6D, 0xA5, 0x5, 0x83, 0x7F, 0x64, 0xBA, 0xD5, 0x9, 0xB5, 0x47, 0x4C, 0x92, 0xB5, 0xD5, 0x11, 0x52, 0x3C, 0xC3, 0x2D, 0x5C, 0x7F, 0x93, 0xF0, 0xA8, 0x30, 0xF7, 0xE, 0x1A, 0xDD, 0xCE, 0xE, 0x4F, 0x55, 0xE7, 0x97, 0x70, 0xC9, 0xEA, 0xCF, 0x6A, 0xE2, 0xEF, 0x92, 0x77, 0x6B, 0x71, 0xC6, 0xF2, 0xDF, 0x40, 0x55, 0x3F, 0x46, 0x28, 0x16, 0xC8, 0x91, 0xC5, 0xDF, 0xB0, 0x5C, 0xF4, 0x9A, 0x12, 0x16, 0x33, 0x20, 0x45, 0x59, 0x8D, 0xED, 0xE6, 0x2C, 0xFB, 0x20, 0xF4, 0xF4, 0xA1, 0x59, 0x30, 0x45, 0xE6, 0x33, 0xA6, 0xE1, 0x77, 0xC0, 0x49, 0xCB, 0xB, 0x4C, 0xC0, 0x6, 0xBC, 0x8, 0x2F, 0x54, 0xD5, 0x80, 0x7B, 0xA6, 0x2C, 0xA2, 0xEF, 0xAA, 0xC3, 0xBE, 0x48, 0x42, 0xDD, 0xCB, 0x4B, 0xE6, 0xFF, 0x80, 0x66, 0x30, 0x2F, 0x92, 0x75, 0x8F, 0x73, 0xF, 0x36, 0xB2, 0x21, 0xD1, 0xE8, 0x96, 0xE6, 0xFC, 0x9F, 0x53, 0xA5, 0x62, 0x30, 0x55, 0x76, 0xAD, 0xF6, 0x50, 0x84, 0x42, 0x13, 0xD9, 0x38, 0x82, 0xB4, 0x1D, 0xB2, 0xC7, 0xFB, 0x2B, 0xB4, 0xAD, 0xD5, 0x8, 0xA1, 0xA6, 0x11, 0x96, 0x4D, 0x14, 0x54, 0xC7, 0x26, 0x3B, 0x7, 0x68, 0x15, 0xE8, 0xE2, 0x28, 0x4B, 0xA0, 0x19, 0xB6, 0x84, 0x32, 0xB7, 0x34, 0x9B, 0x87, 0x4C, 0x90, 0x9B, 0x37, 0xED, 0xA3, 0x32, 0x8C, 0x60, 0xF2, 0x41, 0x53, 0x8, 0xE, 0x40, 0x43, 0xEA, 0xAD, 0x7B, 0x55, 0xCD, 0x8C, 0x4D, 0x29, 0xD8, 0x33, 0x1A, 0x69, 0x96, 0x5D, 0x5A, 0xE0, 0x1, 0x87, 0x92, 0x1C, 0xC9, 0x98, 0xB0, 0x8, 0xE2, 0xF0, 0xD1, 0x67, 0x28, 0xEE, 0xEC, 0x11, 0xFA, 0xDB, 0xA4, 0x24, 0xC0, 0x52, 0x42, 0x7D, 0x20, 0xC1, 0x64, 0x8C, 0x9E, 0x98, 0x64, 0xBF, 0x3E, 0xC8, 0xD4, 0xB5, 0x7, 0x9D, 0x5D, 0x9C, 0x89, 0xD8, 0xF7, 0x36, 0x38, 0x9E, 0xB2, 0x5D, 0xD6, 0x37, 0x2B, 0x7, 0x1D, 0x1A, 0xF, 0xE4, 0x16, 0x92, 0xF5, 0x6D, 0x1B, 0xAD, 0x9C, 0x57, 0x10, 0x99, 0xE6, 0xF5, 0xA3, 0x65, 0x66, 0xE4, 0xED, 0x47, 0xCD, 0x6E, 0xBE, 0x39, 0x7C, 0x35, 0xDF, 0x7D, 0x34, 0x80, 0xF, 0xDC, 0xDC, 0x43, 0xE, 0xC, 0x1C, 0x21, 0x48, 0x2B, 0x16, 0x8, 0x8B, 0xDA, 0x56, 0xF, 0x35, 0xF6, 0x74, 0xDE, 0x8A, 0xC4, 0x27, 0xC6, 0x64, 0x5C, 0xE3, 0x42, 0xD3, 0x0, 0x46, 0x95, 0x4A, 0x26, 0x8F, 0x2C, 0x16, 0x14, 0xF6, 0xFF, 0xE7, 0x8, 0x7, 0xC7, 0xB8, 0x1B, 0xD9, 0x27, 0x2B, 0xCE, 0x48, 0x3E, 0x12, 0xC5, 0xF2, 0xE3, 0xCB, 0x1D, 0xB1, 0x77, 0xD5, 0xB8, 0xDF, 0x11, 0xBE, 0x67, 0x28, 0xEB, 0x4C, 0x6D, 0xD3, 0x52, 0x93, 0xE1, 0x85, 0x49, 0xC2, 0x27, 0xC, 0x8C, 0xEC, 0xA2, 0xBB, 0x1, 0x98, 0xBE, 0x19, 0xEF, 0x92, 0x27, 0x16, 0xD4, 0x28, 0xA1, 0x6D, 0x3D, 0x2B, 0x5B, 0x53, 0xC4, 0x2E, 0xE6, 0x7F, 0x2D, 0x5C, 0x10, 0xAC, 0xA2, 0xCF, 0xD, 0x90, 0x58, 0x5A, 0xAB, 0xCF, 0xE, 0x99, 0x1A, 0xC2, 0xA4, 0xA, 0xCE, 0xF2, 0xA2, 0xC0, 0xFF, 0x96, 0x35, 0x8E, 0xAB, 0x4F, 0x80, 0x6B, 0x5D, 0x3D, 0x1B, 0x13, 0xFD, 0xD0, 0x99, 0x6E, 0x3E, 0x96, 0x9B, 0x5F, 0x94, 0xCC, 0x46, 0xF1, 0x6E, 0x92, 0x1B, 0xA9, 0x68, 0xDB, 0x18, 0xAB, 0x29, 0x28, 0x2D, 0xD6, 0x66, 0x4D, 0x31, 0x53, 0x36, 0xE, 0x1D, 0x6A, 0x90, 0xB6, 0xC, 0x32, 0xF1, 0x1E, 0xBD, 0x2C, 0xBF, 0x27, 0xF2, 0x5, 0x53, 0x4B, 0xD3, 0x4D, 0xF7, 0xE5, 0xEF, 0xDE, 0xDD, 0xE5, 0x56, 0x9B, 0x1D, 0x57, 0x5E, 0x3, 0xEA, 0x6D, 0xF4, 0x44, 0x65, 0x74, 0x8A, 0xC2, 0x89, 0xCB, 0xA0, 0x90, 0x80, 0x7D, 0xA3, 0x46, 0xE8, 0x76, 0x6B, 0x4A, 0x7D, 0x65, 0x50, 0x90, 0x1A, 0xEB, 0x83, 0xE1, 0xF1, 0xC2, 0x96, 0x98, 0x89, 0x45, 0x9B, 0xBB, 0xF9, 0xA8, 0x18, 0xC9, 0xB0, 0xEF, 0xFE, 0xA4, 0x24, 0xD2, 0xA8, 0x83, 0xE3, 0x7F, 0xF7, 0xAA, 0x7A, 0x72, 0xBD, 0x90, 0xC1, 0x19, 0x1A, 0xDD, 0x23, 0xA7, 0xD4, 0x8D, 0xA9, 0xAE, 0xC7, 0x4D, 0xF4, 0x62, 0x2D, 0x19, 0x26, 0x30, 0xDE, 0xBF, 0xB2, 0x84, 0x6D, 0x96, 0x8, 0x95, 0x19, 0x87, 0xD8, 0x48, 0xEF, 0xAB, 0x93, 0x25, 0xA7, 0x3C, 0xA6, 0xF, 0x58, 0x87, 0x68, 0x35, 0xC3, 0xCA, 0xFC, 0xE9, 0x36, 0x4B, 0x0, 0xF6, 0x90, 0xD1, 0x77, 0x7B, 0xDD, 0x27, 0x16, 0x95, 0x5A, 0x15, 0x50, 0x4, 0xF2, 0xBE, 0xB3, 0x12, 0xB5, 0x67, 0x6C, 0xEF, 0xD5, 0x30, 0x74, 0x49, 0x82, 0x6D, 0x50, 0xE3, 0xB0, 0x95, 0x1B, 0xF9, 0xF6, 0x85, 0x49, 0x28, 0x9A, 0x34, 0x50, 0xEC, 0x12, 0x5E, 0x70, 0x27, 0xE0, 0xC, 0xAC, 0x6B, 0x95, 0xB6, 0x7F, 0x7E, 0x85, 0xB2, 0x15, 0xB0, 0x2F, 0x94, 0x98, 0xD7, 0xFA, 0x3F, 0x72, 0x8, 0x48, 0xD8, 0xD9, 0xF1, 0xC, 0x99, 0x53, 0x23, 0xE6, 0x8B, 0x5D, 0x55, 0x51, 0x4F, 0x58, 0xE9, 0xA4, 0x94, 0x25, 0xD8, 0x23, 0xEC, 0x19, 0x43, 0xA6, 0xCB, 0xB3, 0xB9, 0x8F, 0x5B, 0x9A, 0x7E, 0x83, 0xB6, 0x9E, 0x87, 0x55, 0xF8, 0x3C, 0x7D, 0xEF, 0xFE, 0xC1, 0x15, 0xCC, 0xCA, 0x43, 0x2C, 0x88, 0xCC, 0xA4, 0x6E, 0xD5, 0x47, 0x60, 0x56, 0x89, 0x96, 0x66, 0xF9, 0x37, 0xA1, 0x65, 0xCD, 0x5B, 0xE6, 0x92, 0xEC, 0x29, 0x3, 0xF4, 0x3F, 0xEC, 0x26, 0xED, 0x2A, 0x1E, 0xBD, 0x7D, 0x6C, 0xCE, 0x40, 0x14, 0x89, 0xDB, 0x1E, 0xEC, 0x94, 0x66, 0xE1, 0x92, 0xC8, 0x55, 0x9F, 0xF1, 0x29, 0xC, 0xD3, 0x3C, 0x10, 0xFE, 0xC1, 0xC4, 0x30, 0x53, 0x10, 0x60, 0x7D, 0x90, 0x10, 0x7D, 0xA3, 0x19, 0x46, 0xFA, 0xB5, 0x1E, 0x48, 0x88, 0xF8, 0x20, 0xAD, 0x31, 0xA2, 0x4E, 0x48, 0x40, 0x6C, 0x69, 0x3, 0xF5, 0xEF, 0xD6, 0x92, 0x7A, 0x95, 0xB8, 0x5D, 0x3F, 0xCA, 0x6A, 0xAE, 0x68, 0x2A, 0x64, 0x0, 0x57, 0x50, 0x88, 0x4A, 0x4D, 0xE5, 0x0, 0xAE, 0x3F, 0xA1, 0xF6, 0xD1, 0x90, 0x58, 0x2, 0x6E, 0x5C, 0x9D, 0xCD, 0x35, 0xAF, 0xD9, 0x7F, 0x67, 0xCB, 0x3B, 0x77, 0xE5, 0xA9, 0x1C, 0xFD, 0x13, 0xED, 0xAF, 0xE8, 0xA9, 0x6B, 0x74, 0xE3, 0xE3, 0x1A, 0x79, 0xBB, 0xDB, 0xEB, 0xE7, 0xC6, 0xC2, 0xC3, 0x84, 0xA6, 0xFB, 0xE2, 0x64, 0xB4, 0x81, 0xF3, 0xF9, 0x7F, 0x7F, 0x2F, 0x5D, 0xA5, 0xEB, 0xAB, 0xCD, 0x8F, 0x5A, 0x3B, 0xAC, 0x24, 0xF0, 0x6D, 0x70, 0x12, 0xAE, 0x82, 0xA8, 0x9, 0x8A, 0xAA, 0x35, 0x42, 0xAA, 0x7A, 0xF8, 0xCC, 0xE, 0x6A, 0x47, 0x53, 0x5A, 0xF8, 0xB3, 0x31, 0x41, 0xF, 0xD9, 0x71, 0x5C, 0xE4, 0xDA, 0x9F, 0xBE, 0x84, 0xC5, 0x18, 0x5C, 0x90, 0x8E, 0x81, 0x45, 0xDD, 0xFE, 0x57, 0xAF, 0xC9, 0xA7, 0x2A, 0x4A, 0xDD, 0x4D, 0x78, 0xFB, 0x52, 0x4D, 0x8C, 0xD7, 0xFD, 0xCB, 0xB4, 0xFB, 0xD8, 0x78, 0x1C, 0xBC, 0xC0, 0xD9, 0x48, 0x61, 0x45, 0x46, 0xE, 0x4E, 0x70, 0xC5, 0xE1, 0xFC, 0x4A, 0x85, 0x34, 0x8E, 0x5A, 0x2, 0x87, 0xC, 0x9D, 0xE7, 0xA3, 0x95, 0xB5, 0xF1, 0x3, 0x40, 0x98, 0x58, 0x40, 0xF4, 0x20, 0x15, 0x1D, 0xE, 0xD4, 0xAE, 0xE8, 0x48, 0xD7, 0xAB, 0xEC, 0x13, 0x92, 0x4B, 0x5B, 0x11, 0x58, 0x7D, 0x82, 0x13, 0x59, 0x4C, 0xFA, 0x27, 0x9B, 0xA, 0x52, 0xBF, 0x9F, 0x11, 0x5F, 0x89, 0xD, 0xE8, 0x2, 0xED, 0xB7, 0x4, 0x81, 0x7E, 0xCD, 0x8E, 0xC9, 0x1, 0xF0, 0x53, 0x48, 0x79, 0x5D, 0x40, 0x19, 0xA4, 0x21, 0x1C, 0x5C, 0xBD, 0x7C, 0x2E, 0xB8, 0xF, 0xE6, 0x47, 0x27, 0xEB, 0xA, 0x56, 0xE9, 0xCE, 0x91, 0x41, 0xDC, 0x23, 0x76, 0xE4, 0xB1, 0x80, 0x3B, 0x17, 0x6D, 0xBC, 0x19, 0xAB, 0xEB, 0xFB, 0x42, 0xA5, 0xBC, 0x23, 0xDD, 0x2F, 0x7, 0x76, 0x6E, 0xF3, 0xD1, 0x79, 0xD0, 0x86, 0xA0, 0x81, 0xFC, 0xAE, 0x31, 0x5, 0xAC, 0xC1, 0x39, 0xEF, 0x22, 0xA4, 0x72, 0x65, 0xE7, 0x5, 0x30, 0x6A, 0xD, 0x8C, 0xFA, 0x9C, 0xA8, 0xD6, 0x68, 0x5, 0xE5, 0x38, 0xB4, 0x82, 0x82, 0x16, 0xA, 0xC3, 0x9C, 0xFA, 0x9C, 0xD0, 0x23, 0x5F, 0x25, 0xCC, 0xF8, 0x41, 0x4F, 0x84, 0x64, 0xA7, 0x7F, 0x5C, 0x77, 0xE8, 0xFB, 0xD2, 0x10, 0x4B, 0xAF, 0xBE, 0x7, 0xBA, 0x7E, 0x96, 0xF, 0xAF, 0xFD, 0xED, 0x52, 0xBD, 0x3C, 0x5B, 0x48, 0x7B, 0xB, 0x14, 0x5, 0x99, 0x55, 0xF6, 0x4B, 0x6, 0x64, 0x83, 0x2D, 0x85, 0xA6, 0x9D, 0xDA, 0x51, 0x6D, 0xE5, 0x77, 0xE2, 0xBD, 0xD8, 0x96, 0xD2, 0x23, 0x4C, 0xD7, 0x84, 0x78, 0xE3, 0x2C, 0x9A, 0xB1, 0x31, 0x61, 0x45, 0x34, 0xED, 0x15, 0x3F, 0xF, 0x6B, 0x98, 0xD0, 0x82, 0xA1, 0xC0, 0x58, 0xB1, 0x21, 0xF, 0xC5, 0x3B, 0x54, 0x8A, 0xCF, 0xD6, 0x9, 0xDF, 0x7A, 0x4, 0x64, 0x1B, 0x7D, 0xF2, 0xC2, 0xCB, 0x6D, 0xDA, 0xBD, 0x3C, 0x79, 0x22, 0xF2, 0xFF, 0x82, 0xE9, 0x35, 0x61, 0x9, 0x31, 0x21, 0x94, 0xA9, 0xEB, 0x57, 0xCF, 0x14, 0x53, 0x6D, 0x8B, 0x12, 0xDB, 0x92, 0xBA, 0x85, 0xEB, 0x77, 0x2E, 0x70, 0x25, 0x6E, 0xDE, 0x38, 0x6A, 0x72, 0xFE, 0xF9, 0x1C, 0x46, 0x74, 0xE5, 0x4D, 0x0, 0x74, 0x9F, 0xB2, 0xFF, 0x19, 0x96, 0xD0, 0x45, 0x4D, 0x1C, 0x12, 0x4E, 0x83, 0x7B, 0x8F, 0xA8, 0x32, 0x27, 0x33, 0x7, 0x2F, 0x5B, 0xE1, 0xFC, 0x10, 0xF7, 0xD4, 0xA, 0x4, 0x38, 0x3C, 0x9A, 0xD2, 0xC0, 0x8, 0xD3, 0xDB, 0x39, 0xC, 0x8D, 0x42, 0x5, 0xC2, 0x36, 0x99, 0xF6, 0x25, 0xE, 0xE1, 0x72, 0x8B, 0xBC, 0x8E, 0x6C, 0x16, 0xA3, 0x95, 0x17, 0xC6, 0x54, 0x73, 0xBC, 0x86, 0xED, 0x8C, 0xF, 0xB6, 0x4B, 0x5E, 0x12, 0x70, 0xE3, 0x96, 0x45, 0xFB, 0x90, 0x83, 0x9D, 0xEA, 0xF6, 0xD0, 0xFC, 0x7E, 0xCA, 0xA1, 0x39, 0xAC, 0x84, 0x2A, 0x51, 0x94, 0x5D, 0xCD, 0x9A, 0x91, 0x3, 0xC2, 0xED, 0xC3, 0xA0, 0x11, 0xFD, 0xC2, 0xCF, 0x1A, 0x13, 0xA, 0x91, 0xD9, 0x7B, 0x2F, 0xD, 0xCA, 0xA5, 0xA4, 0x54, 0xC7, 0xB1, 0x27, 0xDD, 0x50, 0xAE, 0x43, 0x59, 0xB8, 0x99, 0xB3, 0xDB, 0x2F, 0xC1, 0xF1, 0xC1, 0xA9, 0x6E, 0x25, 0x22, 0x8B, 0x6A, 0xFD, 0xC3, 0x7F, 0xA9, 0x26, 0x31, 0x3F, 0xE5, 0x36, 0xA1, 0x78, 0xB0, 0x39, 0xF6, 0xE, 0x97, 0x9B, 0x55, 0x31, 0x97, 0x4B, 0xF2, 0x92, 0xAE, 0x8C, 0x9E, 0x8B, 0xDE, 0xED, 0xD7, 0x2B, 0x1B, 0x0, 0xD5, 0x83, 0xC, 0xB9, 0x56, 0xFD, 0x94, 0xEF, 0x1C, 0x7C, 0xA, 0x14, 0xAB, 0x69, 0x65, 0xCA, 0xB, 0x99, 0x71, 0xF1, 0x54, 0xAE, 0xAB, 0x79, 0xBC, 0x47, 0x9B, 0x35, 0x24, 0xC8, 0x2B, 0xAF, 0x7B, 0xD2, 0x8, 0x6C, 0xE2, 0x28, 0x13, 0x37, 0x86, 0x70, 0xBC, 0x50, 0x5C, 0x52, 0x8, 0x65, 0x2C, 0xCD, 0x20, 0x22, 0xEE, 0xF2, 0xBC, 0x88, 0xA7, 0x4E, 0xFE, 0xB2, 0xC8, 0xC2, 0xD8, 0x5C, 0x32, 0x11, 0x2C, 0xCF, 0x42, 0xE9, 0xCE, 0x1B, 0xAF, 0xBF, 0xCF, 0xE1, 0xFA, 0x8E, 0x9F, 0x41, 0xC4, 0xA0, 0x84, 0x3A, 0xAD, 0x86, 0xE3, 0xA2, 0x3E, 0xDC, 0x76, 0xC6, 0x4F, 0xE, 0x5D, 0x66, 0xA9, 0x41, 0x2A, 0x5F, 0xF5, 0xC7, 0xFB, 0xAB, 0x4, 0x6F, 0xB5, 0x28, 0x7B, 0x94, 0x13, 0xA8, 0xBE, 0x4E, 0x64, 0xFB, 0xA6, 0xEF, 0x52, 0x71, 0x95, 0x10, 0x56, 0xA2, 0x88, 0x87, 0x41, 0x48, 0x85, 0xEC, 0xCC, 0x70, 0xAD, 0x4E, 0xEA, 0x40, 0xA0, 0xC5, 0x88, 0x2D, 0xE7, 0x35, 0x51, 0xC6, 0xE5, 0xD9, 0xC6, 0x89, 0xC8, 0x43, 0x70, 0xF0, 0x73, 0x96, 0x87, 0x5F, 0x97, 0xE5, 0x8D, 0x67, 0xD0, 0x3E, 0x92, 0xE4, 0xC0, 0xF1, 0x69, 0x8E, 0x8B, 0x20, 0xB8, 0xAD, 0x7D, 0xF, 0x1F, 0x20, 0x23, 0x1D, 0xB3, 0x86, 0xCC, 0x24, 0x55, 0x88, 0x50, 0xAB, 0x1C, 0x84, 0xC2, 0xE8, 0x79, 0x5E, 0x34, 0xDE, 0x5A, 0xB8, 0x48, 0xC1, 0xBB, 0xB, 0xB6, 0xA4, 0xF9, 0xE8, 0x8A, 0x75, 0x37, 0x10, 0x15, 0x18, 0x26, 0x79, 0xDE, 0xD9, 0x28, 0x1C, 0xB0, 0xB0, 0x3D, 0x5B, 0x29, 0x8D, 0xDD, 0x37, 0x6, 0xA, 0xDC, 0xA6, 0xCF, 0x2A, 0x46, 0xD4, 0x3C, 0x84, 0x90, 0x67, 0x73, 0xF, 0xE2, 0x95, 0x48, 0xAA, 0x66, 0x40, 0xCD, 0x5F, 0x77, 0xFF, 0x18, 0xF5, 0x15, 0xB3, 0x30, 0x12, 0xA9, 0x9B, 0x32, 0x3F, 0xAB, 0xA0, 0x39, 0x1E, 0xD3, 0x9E, 0x97, 0x94, 0x7, 0x5B, 0x71, 0x5E, 0xA0, 0x15, 0xA7, 0x7E, 0xAA, 0xC8, 0x16, 0x2A, 0x72, 0x35, 0xAD, 0x90, 0xE8, 0xD2, 0xDC, 0x36, 0x33, 0x62, 0x2C, 0x6B, 0x84, 0x95, 0x2C, 0x76, 0x82, 0xB1, 0xD, 0x40, 0x42, 0x3D, 0xE9, 0x93, 0xB7, 0x41, 0xAE, 0x4A, 0xBB, 0x87, 0xF0, 0x4B, 0x5E, 0xF5, 0xCC, 0xA4, 0xCD, 0x93, 0x37, 0xEF, 0xD8, 0x60, 0xA0, 0xB8, 0x53, 0x96, 0x68, 0xEA, 0xB7, 0x91, 0x37, 0xD2, 0xE3, 0xDB, 0x2F, 0x60, 0x48, 0x8E, 0x51, 0xE4, 0xEB, 0x18, 0x9F, 0x46, 0x2E, 0xC3, 0x84, 0xF7, 0xFE, 0xD7, 0xD8, 0xBE, 0x7E, 0x5F, 0x70, 0x1B, 0xE2, 0x5F, 0x83, 0x75, 0x7A, 0xE0, 0x8C, 0x82, 0x3C, 0x63, 0xB0, 0xEA, 0x31, 0xEA, 0x23, 0xB6, 0xE1, 0x4, 0xC, 0x14, 0x5D, 0x82, 0xB5, 0xAC, 0xDB, 0x7A, 0xC4, 0x54, 0xE1, 0x7, 0x1D, 0xB8, 0x17, 0xD0, 0xC3, 0x4D, 0x64, 0xC5, 0xFE, 0xC, 0x45, 0xB7, 0xB5, 0x8D, 0x29, 0x9C, 0x4D, 0x62, 0xD7, 0xC, 0x4C, 0xBD, 0x28, 0x76, 0xE6, 0x51, 0x46, 0x7, 0xFC, 0xC0, 0xB9, 0xA, 0x73, 0xFF, 0xF1, 0xDD, 0xF4, 0x3E, 0xB1, 0xB9, 0x0, 0x7D, 0x65, 0xE0, 0xE4, 0x6B, 0xB7, 0x5D, 0xFF, 0x61, 0x9A, 0xAB, 0xBE, 0xB0, 0x4D, 0x11, 0x21, 0x8C, 0xFF, 0xCD, 0x5D, 0xDE, 0x8B };
    }

    public static Texture2D mTex;
}
