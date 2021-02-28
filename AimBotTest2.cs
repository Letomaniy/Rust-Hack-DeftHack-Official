using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace gg
{
    public class AimBotTest2
    {
        public class Aimbot : MonoBehaviour
        {
            public static bool bNoRecoil = false;
            public static bool bNoSway = false;
            public static bool bAimbotEnabled = false;
            public static bool bAimAtHead = false;
            public static bool bPredictVelocity = true;
            public static bool bPredictDrop = true;
            public static bool bForceAutomatic = false;

            public static bool IsAiming = false;

            public static KeyCode kAimKey = KeyCode.F;
            public static float fFOV = 200f;

            public static List<float> velocities = new List<float>();
            public static List<string> projectiles = new List<string>();

            public static BasePlayer aimPlayer;

            public static Vector3 playerVelocity = Vector3.zero;

            private void Start()
            {
                StartCoroutine(SetLockedObject());
            }

            public IEnumerator SetLockedObject()
            {
                while (true)
                {
                    //Debug.LogError("SetLockedObject");
                    if (!bAimbotEnabled)
                    {

                        //Debug.LogError("Aimbot Not Enabled");
                        yield return new WaitForSeconds(.1f);
                        continue;
                    }

                    //Debug.LogError("Aimbot Enabled");
                    BasePlayer player = null;
                    foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
                    {
                        //Debug.LogError($"1: {basePlayer.displayName}");
                        if (((basePlayer != null) && (basePlayer.health > 0f)) && (!basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer()))
                        {
                            // Debug.LogError($"2: {basePlayer.displayName}");
                            Vector3 enemyPosition;
                            if (bAimAtHead)
                            {
                                enemyPosition = GetBonePosition(basePlayer.GetModel(), "head");
                            }
                            else
                            {
                                enemyPosition = GetBonePosition(basePlayer.GetModel(), "penis");
                            }

                            //Debug.LogError(basePlayer.displayName);

                            Vector3 v2dist = MainCamera.mainCamera.WorldToScreenPoint(enemyPosition);

                            if (v2dist.z <= 0)
                            {
                                continue;
                            }

                            //Debug.LogError($"3: {basePlayer.displayName}");
                            Vector2 pos = new Vector2(v2dist.x, v2dist.y);
                            float vdist = Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), pos);

                            if (vdist < fFOV && player == null)
                            {
                                player = basePlayer;
                            }
                            else if (vdist < fFOV)
                            {
                                //Debug.LogError($"4: {basePlayer.displayName}");
                                Vector3 enemyPosition_;
                                if (bAimAtHead)
                                {
                                    enemyPosition_ = GetBonePosition(player.GetModel(), "head");
                                }
                                else
                                {
                                    enemyPosition_ = GetBonePosition(player.GetModel(), "penis");
                                }

                                Vector3 v2dist_ = MainCamera.mainCamera.WorldToScreenPoint(enemyPosition_);
                                Vector2 pos_ = new Vector2(v2dist_.x, v2dist_.y);
                                float vdist_ = Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2),
                                    pos_);

                                if (vdist_ > vdist)
                                {
                                    player = basePlayer;
                                }
                            }
                        }
                    }
                    if (!IsAiming)
                    {
                        aimPlayer = (player == null ? null : player);
                    }

                    yield return new WaitForEndOfFrame();
                }
            }



            public static void DoAimbot()
            {
                Vector3 vector = GetEnemyVector();
                if (vector != Vector3.zero)
                {
                    Quaternion rotation = Quaternion.LookRotation(vector, LocalPlayer.Entity.eyes.transform.up);
                    LocalPlayer.Entity.input.SetViewVars(BaseMountable.ConvertVector(rotation.eulerAngles));
                }
            }

            public static void DoSilentAimbot()
            {
                try
                {
                    if (aimPlayer)
                    {
                        //Debug.LogError(LocalPlayer.Entity.GetHeldEntity().GetType().ToString());
                        BaseProjectile baseProjectile = LocalPlayer.Entity.GetHeldEntity() as BaseProjectile;
                        if (baseProjectile)
                        {
                            foreach (Projectile projectile in baseProjectile.GetFieldValue("createdProjectiles") as List<Projectile>)
                            {
                                Debug.LogError(projectile.projectileID);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }

            public static Vector3 GetEnemyVector()
            {
                Vector3 result = Vector3.zero;
                if (aimPlayer != null)
                {
                    Vector3 enemyPosition;
                    if (bAimAtHead)
                    {
                        enemyPosition = GetBonePosition(aimPlayer.GetModel(), "head");
                    }
                    else
                    {
                        enemyPosition = GetBonePosition(aimPlayer.GetModel(), "penis");
                    }

                    if (bPredictVelocity)
                    {
                        return playerVelocity;
                    }

                    return enemyPosition;
                }
                return result;
            }


            public void FixedUpdate()
            {
                if (LocalPlayer.Entity == null || aimPlayer == null)
                {
                    return;
                }

                Vector3 enemyPosition;
                if (bAimAtHead)
                {
                    enemyPosition = GetBonePosition(aimPlayer.GetModel(), "head");
                }
                else
                {
                    enemyPosition = GetBonePosition(aimPlayer.GetModel(), "penis");
                }

                Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
                if (activeItem != null && (activeItem.info.shortname.Contains("bow") ||
                                           activeItem.info.shortname.Contains("smg.") ||
                                           activeItem.info.shortname.Contains("pistol.") ||
                                           activeItem.info.shortname.Contains("lmg.") ||
                                           activeItem.info.shortname.Contains("spear.") ||
                                           activeItem.info.shortname.Contains("rifle")))
                {
                    if (bPredictDrop || bPredictVelocity)
                    {
                        float bulletSpeed = 250f;
                        switch (activeItem.info.shortname)
                        {
                            case "rifle.bolt":
                                bulletSpeed = 656.25f;
                                break;
                            case "rifle.ak":
                                bulletSpeed = 375f;
                                break;
                            case "rifle.lr300":
                                bulletSpeed = 375f;
                                break;
                            case "rifle.semiauto":
                                bulletSpeed = 375f;
                                break;
                            case "smg.mp5":
                                bulletSpeed = 180f;
                                break;
                            case "smg.thompson":
                                bulletSpeed = 300f;
                                break;
                            case "smg.2":
                                bulletSpeed = 240f;
                                break;
                            case "pistol.m92":
                                bulletSpeed = 300f;
                                break;
                            case "pistol.semiauto":
                                bulletSpeed = 300f;
                                break;
                            case "pistol.python":
                                bulletSpeed = 300f;
                                break;
                            case "pistol.nailgun":
                                bulletSpeed = 50f;
                                break;
                            case "bow.hunting":
                                bulletSpeed = 50f;
                                break;
                            case "crossbow":
                                bulletSpeed = 75f;
                                break;
                            case "spear.wooden":
                                bulletSpeed = 25f;
                                break;
                            case "rock":
                                bulletSpeed = 50f;
                                break;
                        }

                        if (bPredictVelocity)
                        {

                            int numSolutions = 0;

                            Vector3 projPos = LocalPlayer.Entity.eyes.position;

                            Vector3 vel = (Vector3)aimPlayer.playerModel.GetFieldValue("velocity");
                            Vector3[] solutions = new Vector3[2];

                            if (vel.sqrMagnitude > 0)
                            {
                                numSolutions = aim.solve_ballistic_arc(projPos, bulletSpeed, enemyPosition, vel, 9.81f,
                                    out solutions[0], out solutions[1]);
                            }
                            else
                            {
                                numSolutions = aim.solve_ballistic_arc(projPos, bulletSpeed, enemyPosition, 9.81f,
                                    out solutions[0], out solutions[1]);
                            }

                            if (numSolutions > 0)
                            {
                                playerVelocity = solutions[0];
                            }
                        }
                    }
                }
            }


            public static bool IsVisible(Vector3 vector3_0)
            {
                Vector3 vector = MainCamera.mainCamera.transform.position - vector3_0;
                float magnitude = vector.magnitude;
                if (magnitude < Mathf.Epsilon)
                {
                    return true;
                }

                Vector3 direction = vector / magnitude;
                Vector3 vector3 = direction * Mathf.Min(magnitude, 0.01f);
                return LocalPlayer.Entity.IsVisible(new Ray(vector3_0 + vector3, direction), magnitude);
            }

            public static Vector3 GetBonePosition(Model playerModel, string boneName)
            {
                if (playerModel == null)
                {
                    return Vector3.zero;
                }

                return playerModel.FindBone(boneName).position;
            }

            private void OnGUI()
            {


                if (aimPlayer != null)
                {
                    if (bAimbotEnabled && LocalPlayer.Entity != null && Input.GetKey(KeyCode.X))
                    {
                        IsAiming = true;
                        DoAimbot();
                    }
                    else
                    {
                        IsAiming = false;
                    }
                }
                else
                {
                    IsAiming = false;
                }
            }

            private void Update()
            {





            }
        }
    }
}

