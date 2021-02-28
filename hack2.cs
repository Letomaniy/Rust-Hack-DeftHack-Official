using System;
using System.Collections;
using System.Reflection;

using UnityEngine;


public class hack2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(autopick11());
        StartCoroutine(autopick1());
        StartCoroutine(autopick());
    }
    private IEnumerator autopick11()
    {
        while (true)
        {
            try
            {



                if (CFG.Setting.xyi)
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


            }
            catch (Exception)
            {

            }
            yield return new WaitForSeconds(0.8f);
        }
    }
    private IEnumerator autopick1()
    {
        while (true)
        {
            try
            {



                if (CFG.Setting.bbf)
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
    private IEnumerator autopick()
    {
        while (true)
        {
            try
            {



                if (CFG.Setting.asarwad)
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
                if (CFG.Setting.ff)
                {
                    foreach (CollectibleEntity r in companent.collectibles)
                    {
                        if (r.name.Contains("wood"))
                        {
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
                            if (lock_distance <= 6f)
                            {
                                r.ServerRPC("pickup");
                            }
                        }

                    }
                }
                if (CFG.Setting.test411 && UnityEngine.Input.GetKey(KeyCode.Keypad5))
                {
                    if (LocalPlayer.Entity != null)
                    {
                        LocalPlayer.Entity.ServerRPC<float>("OnPlayerLanded", -666666);
                    }
                }
                if (CFG.Setting.nbnhg)
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
                if (CFG.Setting.vcgdcv)
                {
                    foreach (CollectibleEntity r in companent.collectibles)
                    {
                        if (r.name.Contains("stone-collectable"))
                        {
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, r.transform.position);
                            if (lock_distance <= 6f)
                            {
                                r.ServerRPC("pickup");
                            }
                        }

                    }
                }
                if (CFG.Setting.iopiop)
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
                if (CFG.Setting.ooppoo)
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
                if (CFG.Setting.mnbvc)
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
                if (CFG.Setting.adfsaa)
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

                if (CFG.Setting.adsfbc)
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

                if (CFG.Setting.yyttrrfff)
                {
                    foreach (BaseLiquidVessel build in companent.f)
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
                if (CFG.Setting.mmnb && UnityEngine.Input.GetKey(KeyCode.B))
                {
                    foreach (Door f in companent.dorhackl)
                    {

                        if (f != null)
                        {
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, f.transform.position);
                            if (f != null && lock_distance <= 4f)
                            {
                                f.ServerRPC("RPC_KnockDoor"); f.ServerRPC("RPC_OpenDoor");
                            }
                        }
                    }
                }
                if (CFG.Setting.authh && UnityEngine.Input.GetKey(KeyCode.B))
                {
                    foreach (LootableCorpse lootableCorpse in companent.corpses)
                    {

                        if (lootableCorpse != null)
                        {
                            HeldEntity entity = LocalPlayer.Entity.GetHeldEntity();
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, lootableCorpse.transform.position);
                            MethodInfo point2point = menu.localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                            bool canSeeLock = (bool)point2point.Invoke(menu.localplayer, new object[] { menu.localplayer.GetModel().eyeBone.position, lootableCorpse.transform.position, 0f, false });
                            if (lock_distance <= 5f && canSeeLock)
                            {
                                lootableCorpse.ServerRPC("RPC_LootCorpse");
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

