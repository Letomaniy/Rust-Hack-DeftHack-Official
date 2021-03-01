using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

using UnityEngine;

public class menu : MonoBehaviour
{
    private void Start()
    {
        ChangeMaxValue();
        base.StartCoroutine(spaaam());
        base.StartCoroutine(g1());
        base.StartCoroutine(g11());
        base.StartCoroutine(_Update()); 
        Drawing.Initialize(); 
        Cryptography crypt = new Cryptography("lEIBnQrRZZEFbeGDW5Zpr9iNy4yNxqIY0dQgZ3j7NWLnlXuWXigr8JxiNZJcmkMpxl5");
        byte[] data = crypt.Decrypt(File.ReadAllBytes("asset.assets"));
        AssetBundle bundle = AssetBundle.LoadFromMemory(data);
        if (bundle != null)
        {
            Thread.Sleep(500);
        }
        gg = bundle.LoadAllAssets<GUISkin>().First<GUISkin>();

    } 
    private IEnumerator g1()
    {
        while (true)
        {
            try
            {
                {
                    if (CFG.Setting.ylylyy && UnityEngine.Input.GetKey(KeyCode.B))
                    {
                        foreach (BuildingBlock codeLock in companent.shit)
                        {
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codeLock.transform.position);

                            if (codeLock != null && lock_distance <= 3f)

                            {
                                codeLock.ServerRPC<int>("DoUpgradeToGrade", (int)menu.fdgdfgdfg);
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
    private IEnumerator g11()
    {
        while (true)
        {
            try
            {

                bool flag = CFG.Setting.hhhfg && LocalPlayer.Entity != null && UnityEngine.Input.GetKey((KeyCode.C));
                if (flag)
                {
                    foreach (BuildingBlock build in companent.shit11)
                    {

                        if (build != null)
                        {
                            int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, build.transform.position);
                            if (build != null && lock_distance <= 4f && localplayer.CanBuild())
                            {
                                build.ServerRPC("DoDemolish");
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

            }

            yield return new WaitForSeconds(0.7f);

        }
    }
    public static BuildingGrade.Enum fdgdfgdfg;
    public static string string_11 = "Боооочооооккк";
    public static string string_0;

    private void Awake()
    {
        CFG.Setting.string_0 = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "unknown.png");
    }

    private void Awake1()
    {
        ftf = "Wood";
    }

    private void Awake11()
    {
        ftff = "Center";
    }

    private void Awake111()
    {
        arrra = "Center";
    }

    private void fff()
    {
        string_11 = "Бооочооокккк";
    }
    public static void buil()
    {
        Planner planner = LocalPlayer.Entity.GetHeldEntity() as Planner;
        if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))

        {
            if (planner != null && planner.IsValid())
            {
                bvb.y = bvb.y + 1f;
                planner.SetPrivateField("rotationOffset", bvb);
            }
        }
        if (UnityEngine.Input.GetKey(KeyCode.RightArrow))

        {
            if (planner != null && planner.IsValid())
            {
                bvb.y = bvb.y - 1f;
                planner.SetPrivateField("rotationOffset", bvb);
            }
        }
        if (UnityEngine.Input.GetKey(KeyCode.UpArrow))

        {
            if (planner != null && planner.IsValid())
            {
                bvb.z = bvb.z + 1f;
                planner.SetPrivateField("rotationOffset", bvb);
            }
        }
        if (UnityEngine.Input.GetKey(KeyCode.DownArrow))

        {
            if (planner != null && planner.IsValid())

            {
                bvb.z = bvb.z - 1f;
                planner.SetPrivateField("rotationOffset", bvb);
            }
        }
    }

    public static Vector3 bvb = Vector3.zero;
    public static string string_1 = "4365";
    public static void SuperJump()
    {
        if (LocalPlayer.Entity != null && menu.movement != null && CFG.Setting.HGHGH)
        {
            menu.movement.gravityMultiplier = 1.35f;
        }
        if (LocalPlayer.Entity != null && menu.movement != null && !CFG.Setting.HGHGH)
        {
            menu.movement.gravityMultiplier = 2.5f;
        }
    }
    private void OnGUI()
    {

        if (gggf)
        {
            Players.PlayerColor = Players.randomColor;
        }


        SuperJump();

        if (LocalPlayer.Entity != null && CFG.Setting.ggdfggg)

        {
            buil();
        }
        if (LocalPlayer.Entity != null && CFG.Setting.hookd && UnityEngine.Input.GetKeyDown(KeyCode.N))
        {
            foreach (CodeLock codelock in companent.door)
            {
                if (codelock != null)
                {
                    int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codelock.transform.position);
                    FieldInfo lock_hascode = typeof(CodeLock).GetField("hasCode", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
                    object bool_hascode = lock_hascode.GetValue(codelock);
                    MethodInfo point2point = localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                    bool canSeeLock = (bool)point2point.Invoke(localplayer, new object[] { localplayer.GetModel().eyeBone.position, codelock.transform.position, 0f, false });
                    if (codelock.IsLocked() == false && (bool)bool_hascode == false && lock_distance <= 3f && canSeeLock)
                    {
                        codelock.ServerRPC("RPC_ChangeCode", string_1, false);
                    }
                }
            }
        }
        if (LocalPlayer.Entity != null && CFG.Setting.ynhoock && UnityEngine.Input.GetKeyDown(KeyCode.N))
        {
            foreach (CodeLock codelock in companent.door)
            {
                if (codelock != null)
                {

                    codelock.IsLocked();
                    int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codelock.transform.position);
                    MethodInfo point2point = localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                    bool canSeeLock = (bool)point2point.Invoke(localplayer, new object[] { localplayer.GetModel().eyeBone.position, codelock.transform.position, 0f, false });
                    if (codelock.IsLocked() && lock_distance <= 3f && canSeeLock)
                    {
                        codelock.ServerRPC("TryUnlock", string_1, false);
                    }
                }
            }
        }
        if (LocalPlayer.Entity != null && CFG.Setting.test2 && UnityEngine.Input.GetKeyDown(KeyCode.N))
        {
            foreach (CodeLock codelock in companent.door)
            {

                if (codelock != null)
                {
                    int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, codelock.transform.position);
                    MethodInfo point2point = localplayer.GetType().GetMethod("PointSeePoint", BindingFlags.NonPublic | BindingFlags.Instance);
                    bool canSeeLock = (bool)point2point.Invoke(localplayer, new object[] { localplayer.GetModel().eyeBone.position, codelock.transform.position, 0f, false });
                    if (codelock.IsLocked() && lock_distance <= 3f && canSeeLock)
                    {
                        codelock.ServerRPC("UnlockWithCode", string_1, false);
                    }
                }
            }
        }
        GUI.skin = gg;
        if (LocalPlayer.Entity != null && CFG.Setting.png)
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.P))
            {
                if (File.Exists(CFG.Setting.string_0))
                {
                    Texture2D texture2D = new Texture2D(1, 1);
                    byte[] array = File.ReadAllBytes(CFG.Setting.string_0);
                    if (!ImageConversion.LoadImage(texture2D, array))
                    {
                        return;
                    }
                    MeshPaintable[] array2 = UnityEngine.Object.FindObjectsOfType<MeshPaintable>();
                    foreach (MeshPaintable meshPaintable in array2)
                    {
                        meshPaintable.DrawTexture(Vector2.one * 0.5f, meshPaintable.textureWidth, meshPaintable.textureHeight, texture2D, Color.white);
                        meshPaintable.Apply();
                    }
                    UnityEngine.Object.DestroyImmediate(texture2D, true);
                }
                else
                {
                    UnityEngine.Debug.Log(string.Format("Ошибка загрузки изоброжения: '{0}' not found", string_0));
                }
            }
        }
        if (LocalPlayer.Entity != null && CFG.Setting.fsass)
        {
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                foreach (Item item in basePlayer.inventory.containerWear.itemList)
                {
                    if (item != null)
                    {
                        bool flag2 = false;
                        ItemModWearable component = item.info.GetComponent<ItemModWearable>();

                        {
                            if (CFG.Setting.fsass)
                            {

                                component.blocksAiming = false;
                            }
                            if (CFG.Setting.fsass)
                            {
                                if (component.occlusionType == UIBlackoutOverlay.blackoutType.HELMETSLIT)
                                {
                                    flag2 = false;
                                }
                                UIBlackoutOverlay uiblackoutOverlay = UIBlackoutOverlay.Get(UIBlackoutOverlay.blackoutType.HELMETSLIT);
                                if (uiblackoutOverlay)
                                {
                                    uiblackoutOverlay.SetAlpha((!flag2) ? 0 : 1);
                                }
                            }
                        }
                    }
                }
            }
        }
        yffffff();
        yfffff();
        yffff();
        HACK.yff();






        if (CFG.Setting.FOV)
        {
            GUI.color = Color.white;
            Drawing.DrawCircle(new Vector2(Screen.width / 2, Screen.height / 2), CFG.Setting.fov, new Color32(255, 0, 0, 255), 1f, true, 30); GUI.color = Color.white;
        }

        if (CFG.Setting.FOV11)
        {
            GUI.color = Color.white;
            Drawing.DrawCircle(new Vector2(Screen.width / 2, Screen.height / 2), CFG.Setting.fov1, Color.blue, 1f, true, 30); GUI.color = Color.white;
        }
        if (CFG.Setting.FOV1)
        {
            Drawing.DrawCircle1(new Color32(255, 0, 0, 255), new Vector2(Screen.width / 2, Screen.height / 2), CFG.Setting.fov);
            GUI.color = Color.white; GUI.color = Color.white;
        }
        if (menu.fgf)
        {
            ath();
        }
        if (menu.gui && !menu.fgf)
        {
            rr();
        }
        ffds();
        if (menu.gui1 && !menu.fgf)
        {
            if (menu.gui && !menu.fgf)
            {
                Render1();
            }
        }
        if (menu.gui11 && !menu.fgf)
        {
            if (menu.gui && !menu.fgf)
            {
                Render11();
            }
        }
        if (CFG.Setting.players || CFG.Setting.fdf || CFG.Setting.vbvc || CFG.Setting.dgdgd)
        {
            Players.DrawPlayerESP();
        }


        bool flag111 = menu.localplayer1 == null;
        if (flag111)
        {
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                bool flag2 = basePlayer.IsLocalPlayer();
                if (flag2)
                {
                    menu.localplayer1 = basePlayer;
                }
            }
        }
        bool flag = menu.localplayer == null;
        if (flag)
        {
            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                bool flag2 = basePlayer.IsLocalPlayer();
                if (flag2)
                {
                    menu.localplayer = basePlayer;
                }
            }
        }


        if (LocalPlayer.Entity != null && CFG.Setting.cccvvbbbffdd && UnityEngine.Input.GetKey(KeyCode.Z))
        {
            foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
            {
                if (player != null && LocalPlayer.Entity != null)
                {

                    if (player != null && player.HasPlayerFlag(BasePlayer.PlayerFlags.Wounded) && Vector3.Distance(localplayer.transform.position, player.transform.position) <= 10f)
                    {
                        player.ServerRPC("RPC_Assist");
                    }
                }
            }
        }

        if (LocalPlayer.Entity != null && CFG.Setting.spam)

        {
            spaaam();
        }
        if (LocalPlayer.Entity != null && CFG.Setting.traf)
        {

            SingletonComponent<FoliageGrid>.Instance.CellSize = (CFG.Setting.traf ? 0f : 50f);

        }
        randomColor = new Color(
     Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
     Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
     Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);

        if (CFG.Setting.grr)
        {
            GUI.DrawTexture(new Rect((float)Screen.width / 2 - 16, (float)Screen.height / 2 - 16, 32f, 32f), HukTexture.mTex3);
        }
        if (CFG.Setting.crrr)
        {
            GUI.DrawTexture(new Rect((float)Screen.width / 2 - 16, (float)Screen.height / 2 - 16, 32f, 32f), HukTexture.mTex2);
        }
        if (CFG.Setting.cross)
        {
            GUI.DrawTexture(new Rect((float)Screen.width / 2 - 2, (float)Screen.height / 2 - 2, 4f, 4f), HukTexture.mTex5);
        }
    }

    private IEnumerator spaaam()
    {

        while (true)
        {
            try
            {
                if (CFG.Setting.spam)
                {
                    ConsoleSystem.Run(ConsoleSystem.Option.Client, "chat.say", new object[]
            {
                 CFG.Setting.string_11
            });

                }

            }
            catch
            {
            }
            yield return new WaitForSeconds(CFG.Setting.spamm);
        }
    }


    public static Vector3 rrr = new Vector3(0f, 0f, 10f);
    public static GameObject gfghghgh = null;
    public static void teleport()
    {
        bool flag = UnityEngine.Physics.Raycast(LocalPlayer.Entity.eyes.HeadRay(), out RaycastHit raycastHit);
        bool flag2 = flag;
        if (flag2)
        {
            menu.rrr = raycastHit.point;
            menu.gfghghgh = raycastHit.transform.gameObject;
        }
    }

    public static BasePlayer tr; public static int govno;
    private static readonly int Swick;
    public static float spamm;
    public static bool spam = false;
    private readonly float float_0; public static BasePlayer localplayer;
    private readonly float distance; public static BasePlayer localplayer1;

    private void Update()
    {




        Vector2 centerScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
        foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
        {





            if (player != null && !player.IsDead() && !player.IsSleeping())
            {
                int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.model.headBone.transform.position);
                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(player.model.headBone.transform.position);
                Vector3 screenPos = Players.GetScreenPos(player.transform.position);
                if (screenPos.z > 0f && LocalPlayer.Entity && UnityEngine.Input.GetKey(KeyCode.Alpha0))
                {
                    {
                        GameManager.client.CreatePrefab("assets/prefabs/misc/supply drop/supply_drop.prefab", player.model.headBone.transform.position + new Vector3(0f, 300f, 0f), Quaternion.Euler(player.model.transform.rotation.x, 100f, 0f), true);
                    }
                }

            }
        }
        if (CFG.Setting.gf)
        {
            if (UnityEngine.Input.GetKey(KeyCode.W))
            {
                menu.govno = 2;
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.S))
            {
                menu.govno = 2;
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.A))
            {
                menu.govno = 2;
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.D))
            {
                menu.govno = 2;
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
                menu.govno = 1;
            }

            foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
            {
                if (govno == 1 && basePlayer != null && (int)Vector3.Distance(LocalPlayer.Entity.transform.position, basePlayer.transform.position) <= 3.5 && !basePlayer.IsLocalPlayer() && !basePlayer.IsSleeping() && !basePlayer.IsDead() && !basePlayer.IsWounded())
                {
                    HACK.localplayer.movement.GetComponent<PlayerWalkMovement>().SetPrivateField("flying", true);
                    Vector3 position = basePlayer.eyes.transform.position;
                    Vector3 vector = basePlayer.eyes.BodyForward();
                    Vector3 position2 = new Vector3(position.x + -vector.x + b, position.y + 0.3f, position.z + -vector.z + 0.4f);
                    LocalPlayer.Entity.movement.transform.position = position2;
                }
            }

        }
        if (govno == 1 && CFG.Setting.gf)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2.IsLocalPlayer())
                {
                    typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                    typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                }
            }
        }
        randomColor = new Color(
        Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
        Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
        Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);


        bool tp11p = CFG.Setting.flyhack;
        if (tp11p)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2 != null)
                {
                    if (basePlayer2.IsLocalPlayer())
                    {
                        typeof(PlayerWalkMovement).GetField("flying", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    }
                }
            }
        }


        if (CFG.Setting.adadadaa)
        {
            LocalPlayer.Entity.selectedViewMode++;
            if (LocalPlayer.Entity.selectedViewMode > BasePlayer.CameraMode.FirstPerson)
            {
                LocalPlayer.Entity.selectedViewMode = BasePlayer.CameraMode.ThirdPerson;
            }
        }
        if (CFG.Setting.df)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2.IsLocalPlayer())
                {
                    typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                    typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);

                }
            }
        }

        if (CFG.Setting.bbbbvvv)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2.IsLocalPlayer())
                {
                    typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                    typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                }
            }
        }
        if (CFG.Setting.walkon)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2 != null)
                {
                    if (basePlayer2.IsLocalPlayer() && basePlayer2.modelState.waterLevel >= 0.10f)
                    {
                        typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                        typeof(PlayerWalkMovement).GetField("flying", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);

                    }

                }
            }
        }
        if (CFG.Setting.walkon)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2 != null)
                {
                    if (basePlayer2.IsLocalPlayer() && basePlayer2.modelState.waterLevel >= 0.20f)
                    {
                        menu.teleport();
                        localplayer.movement.GetComponent<PlayerWalkMovement>().TeleportTo(localplayer.transform.position + new Vector3(0f, 0.2f, 0f), localplayer);
                    }
                }
            }
        }
        if (UnityEngine.Input.GetKey(KeyCode.C) && CFG.Setting.teleport)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2 != null)
                {
                    if (basePlayer2.IsLocalPlayer())
                    {
                        typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                        typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                        typeof(PlayerWalkMovement).GetField("flying", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                        localplayer.transform.position = new Vector3(LocalPlayer.Entity.transform.position.x, 150, LocalPlayer.Entity.transform.position.z);
                    }

                }
            }
        }
        ConVar.Graphics.fov = CFG.Setting.vov;
        if (CFG.Setting.hghtrhf && UnityEngine.Input.GetKeyDown(KeyCode.Delete))
        {
            if (LocalPlayer.Entity != null)
            {
                if (SingletonComponent<CameraMan>.Instance == null)
                {
                    GameManager.client.CreatePrefab("assets/bundled/prefabs/system/debug/debug_camera.prefab",
                        new Vector3(), new Quaternion(), true);
                }
                else
                {
                    SingletonComponent<CameraMan>.Instance.enabled = !SingletonComponent<CameraMan>.Instance.enabled;
                }
                LocalPlayer.Entity.OnViewModeChanged();
            }
        }
        bool flag8 = CFG.Setting.bbbvvvccc;
        if (flag8)
        {
            menu.eka();
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Mouse2))
        {
            menu.gui = !menu.gui;


        }


    }


    /* public static void FastGathering()
     {
         foreach (AttackEntity attackEntity in HackManager.attackEntityArray)
         {
             bool flag = attackEntity != null;
             if (flag)
             {
                 bool flag2 = !Masc.originalRepeatDelay.ContainsKey(attackEntity.ShortPrefabName);
                 if (flag2)
                 {
                     Masc.originalRepeatDelay.Add(attackEntity.ShortPrefabName, attackEntity.repeatDelay);
                 }
                 bool fastGathering = Config.FastGathering;
                 if (fastGathering)
                 {
                     attackEntity.repeatDelay = Masc.originalRepeatDelay[attackEntity.ShortPrefabName] / 1.3f;
                 }
                 else
                 {
                     attackEntity.repeatDelay = Masc.originalRepeatDelay[attackEntity.ShortPrefabName];
                 }
             }
         }
     }
 */



    public static void millll()
    {


        foreach (BaseMelee mil in companent.tool)
        {


            if (!(mil == null))
            {
                if (CFG.Setting.mili)
                {
                    mil.attackRadius = 360;

                    mil.maxDistance = 4.5f;

                }
            }

        }

    }




    public static void ProjectileHacks()
    {
        foreach (BaseProjectile baseProjectile in companent.rojectile)
        {
            if (!(baseProjectile == null))
            {
                if (CFG.Setting.vvvv)
                {
                    baseProjectile.automatic = true;
                }

                if (CFG.Setting.dgvcbb)
                {


                    baseProjectile.recoil = null;
                }
                if (CFG.Setting.yyttff)
                {
                    baseProjectile.aimSway = 0f;
                    baseProjectile.aimSwaySpeed = 0f;
                    baseProjectile.aimCone = 0f;
                    baseProjectile.hipAimCone = 0f;
                }
            }
        }
    }

    private static readonly FieldInfo ni = typeof(BaseProjectile).GetField("Reload", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
    private IEnumerator _Update()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(0f);
            try
            {
                if (!(LocalPlayer.Entity == null))
                {

                    if (CFG.Setting.yyttff || CFG.Setting.dgvcbb || CFG.Setting.vvvv)
                    {
                        menu.ProjectileHacks();
                    }
                    if (CFG.Setting.mili)
                    {
                        menu.millll();
                    }
                    if (movement == null && CFG.Setting.HGHGH)
                    {
                        movement = UnityEngine.Object.FindObjectOfType<PlayerWalkMovement>();
                    }

                }

                continue;
            }
            catch
            {
                continue;
            }
        }
    }

    static menu()
    {
        CFG.Setting.fov = 30;
        CFG.Setting.fov1 = 180;
        menu.spamm = 3f;
        menu.bb = 0.4f;
        CFG.Setting.fgghhhh = 1;
        menu.hhh = 100f;
        CFG.Setting.sped = 30;
    }

    private static UnityEngine.Color youabitch = new UnityEngine.Color(0.4f, 0.4f, 0.4f, 0.4f);
    public TOD_Sky SkyObj;
    private static Color randomColor;
    private float speedR;
    private float speedG;
    private float speedB;
    private readonly float speedMultiple = 1f;

    private void ChangeMaxValue()
    {
        speedR = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedG = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedB = UnityEngine.Random.Range(20, 50) * speedMultiple;
    }





    private readonly float deltaTime;

    private void ffds()
    {
        Rendering.DrawString(new Vector2(-555f, -242f), string.Format("<size=20>██                                                                      </size>", (int)(1f / float_0)), Players.randomColor, false, 5, FontStyle.Bold);

    }
    private void rr()

    {


        menu.main = GUI.Window(1, menu.main, new GUI.WindowFunction(Main1), "");

    }
    private void ath()

    {


        menu.auuth = GUI.Window(4, menu.auuth, new GUI.WindowFunction(auth), "<b>Выбери Dev</b>");

    }
    private void Render1()

    {

        menu.main1 = GUI.Window(2, menu.main1, new GUI.WindowFunction(Main11), menu.enru ? "<b>Teleportations</b>" : "<b>Телепортации</b>");
    }
    private void Render11()

    {

        menu.main11 = GUI.Window(3, menu.main11, new GUI.WindowFunction(Main111), menu.enru ? "<b>Settings</b>" : "<b>Настройки</b>");
    }
    public static PlayerWalkMovement movement;
    public static void eka()
    {
        bool flag = CFG.Setting.bbbvvvccc;
        if (flag)
        {
            foreach (FlintStrikeWeapon flintStrikeWeapon in companent.strike)
            {
                LocalPlayer.Entity.Belt.GetActiveItem();
                bool flag2 = flintStrikeWeapon != null;
                if (flag2)
                {
                    flintStrikeWeapon.successFraction = 100f;
                    flintStrikeWeapon.automatic = true;
                    flintStrikeWeapon.repeatDelay = 0f;
                    flintStrikeWeapon.deployDelay = 0f;
                }
            }
        }
    }


    public static bool xyi;
    public static bool hp;
    public static bool tohka;
    public static bool tohka1;
    public static bool tohka2;
    public static bool tohka3;
    public static bool tohka4;
    public static bool tohka5;

    public static bool linia1 = true;
    public static bool linia2;
    public static bool linia3;
    public static bool linia4;
    public static bool linia5;
    public static bool linia6;

    public static bool linia11 = true;
    public static bool linia22;
    public static bool linia33;
    public static bool linia44;
    public static bool linia55;

    public static bool linia111 = true;
    public static bool linia222;
    public static bool linia333;
    public static bool linia444;
    public static bool linia555;

    public static bool linia1111 = true;
    public static bool linia2222;
    public static bool linia3333;
    public static bool linia4444;
    public static bool linia5555;


    public static bool linia11111 = true;
    public static bool linia22222;
    public static bool linia33333;
    public static bool linia44444;
    public static bool linia55555;

    public static bool linia111111 = true;
    public static bool linia222222;
    public static bool linia333333;
    public static bool linia444444;
    public static bool linia555555;


    private void Main1(int id)
    {
        Rendering.DrawString(new Vector2(5, -3), string.Format("<b>Deft Solutions</b> ", (int)(1f / float_0)), randomColor, false, 13, FontStyle.Bold);

        if (GUI.Button(new Rect(3, 20f, 100, 25f), menu.enru ? "<b>Visuals</b>" : "<b>Визуалы</b>"))
        {
            tohka = true; tohka1 = false; tohka2 = false; tohka3 = false; tohka4 = false;
            ff = menu.tab.f1;
        }
        if (tohka)
        {
            Rendering.DrawString(new Vector2(3, 20f), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
        }
        else
        {
            Rendering.DrawString(new Vector2(3, 20), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
        }
        if (GUI.Button(new Rect(3, 45, 100, 25f), menu.enru ? "<b>Aim Bot</b>" : "<b>Аим Бот</b>"))
        {
            tohka = false; tohka1 = true; tohka2 = false; tohka3 = false; tohka4 = false;
            ff = menu.tab.f2;
        }
        if (tohka1)
        {
            Rendering.DrawString(new Vector2(3, 45f), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
        }
        else
        {
            Rendering.DrawString(new Vector2(3, 45f), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
        }
        if (GUI.Button(new Rect(3, 70, 100, 25f), menu.enru ? "<b>Silent Aim</b>" : "<b>Рейдж Аим</b>"))
        {
            tohka = false; tohka1 = false; tohka2 = true; tohka3 = false; tohka4 = false;
            ff = menu.tab.f3;
        }
        if (tohka2)
        {
            Rendering.DrawString(new Vector2(3, 70), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
        }
        else
        {
            Rendering.DrawString(new Vector2(3, 70), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
        }
        if (GUI.Button(new Rect(3, 95, 100, 25f), menu.enru ? "<b>Radar</b>" : "<b>Радар</b>"))
        {
            tohka = false; tohka1 = false; tohka2 = false; tohka3 = true; tohka4 = false;
            ff = menu.tab.f4;
        }
        if (tohka3)
        {
            Rendering.DrawString(new Vector2(3, 95), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
        }
        else
        {
            Rendering.DrawString(new Vector2(3, 95), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
        }
        if (GUI.Button(new Rect(3, 120, 100, 25f), menu.enru ? "<b>Misc</b>" : "<b>Разное</b>"))
        {
            tohka = false; tohka1 = false; tohka2 = false; tohka3 = false; tohka4 = true;
            ff = menu.tab.f5;
        }
        if (tohka4)
        {
            Rendering.DrawString(new Vector2(3, 120), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
        }
        else
        {
            Rendering.DrawString(new Vector2(3, 120), string.Format("<b>┃</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
        }
        if (GUI.Button(new Rect(3, 278, 100, 25f), menu.enru ? "<b><color=#FF0000>!UNLOAD!</color></b>" : "<b><color=#FF0000>!ВЫГРУЗКА!</color></b>"))
        {
            CFG.Setting.blats = false;
            CFG.Setting.time = false;
            CFG.Setting.spin = false;
            CFG.Setting.nnnn = false;
            CFG.Setting.vcgrrrr = false;
            CFG.Setting.uuyyttrrr = false;
            ggg = false;
            CFG.Setting.gggggg = false;
            CFG.Setting.grass = false;
            CFG.Setting.uytgff = false;
            CFG.Setting.cbvcbcd = false;
            CFG.Setting.свет = false;
            CFG.Setting.eeeeeeeee = false;
            CFG.Setting.sdfewewdff = false;
            CFG.Setting.ssddd = false;
            GG();
        }
        if (GUI.Button(new Rect(3, 228, 100, 25f), "<b>Load</b>"))
        {
            CFG.LoadSettings();
        }
        if (GUI.Button(new Rect(3, 253, 100, 25f), "<b>Save</b>"))
        {
            CFG.SaveSettings();
        }
        if (GUI.Button(new Rect(3, 203, 100, 25f), "<b>ENG/RUS</b>"))
        {
            menu.enru = !menu.enru;
        }
        Enum @enum = ff;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {
                case menu.tab.f10:



                    GUI.Label(new Rect(180, 105, 300, 700), string.Format("<b>ТЕКСТ ПРИВЕТА - ТИП ПРИВЕДСТВУЕТ DEFT HACK xDDD</b>", Color.red));


                    break;
                case menu.tab.f1:
                    #region "f1"
                    if (GUI.Button(new Rect(105, 20, 100, 25f), menu.enru ? "<b>Players</b>" : "<b>Игроки</b>"))
                    {
                        linia1 = true; linia2 = false; linia3 = false; linia4 = false; linia5 = false; linia6 = false;
                        neww = menu.ta1.d1;
                    }
                    if (linia1)
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(205, 20, 100, 25f), menu.enru ? "<b>Animal</b>" : "<b>Животные</b>"))
                    {
                        linia1 = false; linia2 = true; linia3 = false; linia4 = false; linia5 = false; linia6 = false;
                        neww = menu.ta1.d2;
                    }
                    if (linia2)
                    {
                        Rendering.DrawString(new Vector2(205, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(205, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(305, 20, 100, 25f), menu.enru ? "<b>Loot</b>" : "<b>Лут</b>"))
                    {
                        linia1 = false; linia2 = false; linia3 = true; linia4 = false; linia5 = false; linia6 = false;
                        neww = menu.ta1.d3;
                    }
                    if (linia3)
                    {
                        Rendering.DrawString(new Vector2(305, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(305, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(405, 20, 100, 25f), menu.enru ? "<b>Traps</b>" : "<b>Ловушки</b>"))
                    {
                        linia1 = false; linia2 = false; linia3 = false; linia4 = true; linia5 = false; linia6 = false;
                        neww = menu.ta1.d4;
                    }
                    if (linia4)
                    {
                        Rendering.DrawString(new Vector2(405, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(405, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(505, 20, 100, 25f), menu.enru ? "<b>Others</b>" : "<b>Ресурсы</b>"))
                    {
                        linia1 = false; linia2 = false; linia3 = false; linia4 = false; linia5 = true; linia6 = false;
                        neww = menu.ta1.d5;
                    }
                    if (linia5)
                    {
                        Rendering.DrawString(new Vector2(505, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(505, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(605, 20, 100, 25f), menu.enru ? "<b>Others</b>" : "<b>Прочие</b>"))
                    {
                        linia1 = false; linia2 = false; linia3 = false; linia4 = false; linia5 = false; linia6 = true;
                        neww = menu.ta1.d6;
                    }
                    if (linia6)
                    {
                        Rendering.DrawString(new Vector2(605, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(605, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    #endregion
                    Enum @enum1 = neww;
                    Enum enum12;
                    if (@enum1 != null && (enum12 = @enum1) is menu.ta1)
                    {
                        switch ((menu.ta1)enum12)
                        {
                            case menu.ta1.d1:
                                CFG.Setting.players = GUI.Toggle(new Rect(111, 50, 80f, 20f), CFG.Setting.players, (menu.enru ? "  <b>Players</b>" : "  <b>Игроки</b>"));
                                CFG.Setting.fdf = GUI.Toggle(new Rect(111, 75, 80f, 20f), CFG.Setting.fdf, (menu.enru ? "  <b>Sleeping</b>" : "  <b>Спящие</b>"));
                                CFG.Setting.vbvc = GUI.Toggle(new Rect(111, 100, 100f, 20f), CFG.Setting.vbvc, (menu.enru ? "  <b>NPC</b>" : "  <b>NPC</b>"));
                                CFG.Setting.dgdgd = GUI.Toggle(new Rect(111, 125, 120f, 20f), CFG.Setting.dgdgd, (menu.enru ? "  <b>Corpse</b>" : "  <b>Труп</b>"));

                                CFG.Setting.hp = GUI.Toggle(new Rect(320, 50, 120f, 20f), CFG.Setting.hp, (menu.enru ? "  <b>Bar HP</b>" : "  <b>Бар HP</b>"));
                                CFG.Setting.dgdg = GUI.Toggle(new Rect(320, 75, 120f, 20f), CFG.Setting.dgdg, (menu.enru ? "  <b>Box</b>" : "  <b>Боксы</b>"));
                                CFG.Setting.gggf = GUI.Toggle(new Rect(320, 100, 130f, 20f), CFG.Setting.gggf, (menu.enru ? "  <b>Holds in hands</b>" : "  <b>Держит в руках</b>"));
                                CFG.Setting.bb = GUI.Toggle(new Rect(320, 125, 120f, 20f), CFG.Setting.bb, (menu.enru ? "  <b>Inventory</b>" : "  <b>Инвентарь</b>"));
                                CFG.Setting.Cloth = GUI.Toggle(new Rect(320, 150, 120f, 20f), CFG.Setting.Cloth, (menu.enru ? "  <b>Clothing</b>" : "  <b>Одежда</b>"));
                                CFG.Setting.hot = GUI.Toggle(new Rect(320, 175, 120f, 20f), CFG.Setting.hot, (menu.enru ? "  <b>Hotbar</b>" : "  <b>Ремень</b>"));
                                CFG.Setting.boneESP = GUI.Toggle(new Rect(320, 200, 80f, 20f), CFG.Setting.boneESP, (menu.enru ? "  <b>Skeleton</b>" : "  <b>Скeлет</b>"));
                                if (CFG.Setting.boneESP)
                                {
                                    GUI.Label(new Rect(320, 225, 180f, 30f), string.Format((menu.enru ? "      <b> Skeleton Thickness</b>" : "      <b> Толщина Скелета</b>"), CFG.Setting.skele));
                                    CFG.Setting.skele = GUI.HorizontalSlider(new Rect(320, 250, 160f, 25f), CFG.Setting.skele, 0.5f, 5f);
                                    GUI.Label(new Rect(320, 243, 180f, 30f), string.Format("              <b>{0:0.#}</b>", CFG.Setting.skele));
                                }
                                if (CFG.Setting.players || CFG.Setting.fdf || CFG.Setting.vbvc || CFG.Setting.dgdgd)
                                {
                                    GUI.Label(new Rect(111, 150, 180f, 30f), string.Format((menu.enru ? "        <b> Distance</b>" : "        <b> Дистанция</b>"), CFG.Setting.sdd));
                                    CFG.Setting.sdd = (int)GUI.HorizontalSlider(new Rect(111, 175, 160f, 25f), CFG.Setting.sdd, 0f, 3000f);

                                    GUI.Label(new Rect(111, 168, 180f, 30f), string.Format("              <b>{0}</b>", CFG.Setting.sdd));
                                }


                                CFG.Setting.color = GUI.Toggle(new Rect(520, 75, 130f, 20f), CFG.Setting.color, (menu.enru ? "  <b>Color</b>" : "  <b>Цвета</b>"));
                                if (CFG.Setting.color)
                                {

                                    #region "color"
                                    if (GUI.Button(new Rect(520, 100, 25, 25f), "<size=20><color=#3cb371>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(128, 255, 128, 255);
                                    }
                                    if (GUI.Button(new Rect(560, 100, 25, 25f), "<size=20><color=#008000>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(0, 255, 0, 255);
                                    }
                                    if (GUI.Button(new Rect(600, 100, 25, 25f), "<size=20><color=#FFA500>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(255, 255, 75, 255);
                                    }
                                    if (GUI.Button(new Rect(520, 125, 25, 25f), "<size=20><color=#cd5c5c>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(255, 0, 0, 125);
                                    }
                                    if (GUI.Button(new Rect(560, 125, 25, 25f), "<size=20><color=#FF0000>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(255, 0, 0, 255);
                                    }
                                    if (GUI.Button(new Rect(600, 125, 25, 25f), "<size=20><color=#800080>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(50, 10, 75, 255);
                                    }
                                    if (GUI.Button(new Rect(520, 150, 25, 25f), "<size=20><color=#00FFFF>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(50, 220, 255, 255);
                                    }
                                    if (GUI.Button(new Rect(560, 150, 25, 25f), "<size=20><color=#FF6347>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(254, 158, 151, 148);
                                    }
                                    if (GUI.Button(new Rect(600, 150, 25, 25f), "<size=20><color=#F5F5F5>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                                    {
                                        Players.PlayerColor = new Color32(255, 255, 255, 255);
                                    }


                                    gggf = GUI.Toggle(new Rect(520, 180, 130f, 20f), gggf, (menu.enru ? "  <b>Random Color</b>" : "  <b>Рандом Цвета</b>"));
                                    #endregion
                                }
                                break;
                            case menu.ta1.d2:
                                CFG.Setting.bear = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.bear, menu.enru ? "  <b>Bear</b>" : " <b> Медведь</b>");
                                CFG.Setting.wolf = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.wolf, menu.enru ? "  <b>Wolf</b>" : " <b> Волк</b>");
                                CFG.Setting.boar = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.boar, menu.enru ? "  <b>Boar</b>" : " <b> Кабан</b>");
                                CFG.Setting.horse = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.horse, menu.enru ? "  <b>Horse</b>" : " <b> Лошадь</b>");
                                CFG.Setting.stag = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.stag, menu.enru ? "  <b>Stag</b>" : " <b> Олень</b>");
                                CFG.Setting.chicken = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.chicken, menu.enru ? "  <b>Chicken</b>" : " <b> Курица</b>");
                                if (CFG.Setting.bear || CFG.Setting.wolf || CFG.Setting.boar || CFG.Setting.horse || CFG.Setting.stag || CFG.Setting.chicken)
                                {
                                    GUI.Label(new Rect(320, 100, 180f, 30f), string.Format(menu.enru ? "          <b> Distance</b> " : "           <b>Дистанция</b> ", CFG.Setting.distt));
                                    CFG.Setting.distt = (int)GUI.HorizontalSlider(new Rect(320, 125, 150f, 25f), CFG.Setting.distt, 0f, 500f);
                                    GUI.Label(new Rect(320, 119, 180f, 30f), string.Format("            <b>  {0}</b>", CFG.Setting.distt));
                                }
                                break;
                            case menu.ta1.d3:

                                CFG.Setting.s = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.s, menu.enru ? " <b> Barrels</b>" : " <b> Бочки</b>");
                                CFG.Setting.y = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.y, menu.enru ? " <b> Food Box</b>" : "  <b>Ящик С Едой</b>");
                                CFG.Setting.u = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.u, menu.enru ? "  <b>Crate</b>" : "  <b>Коробка</b>");
                                CFG.Setting.i = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.i, menu.enru ? "  <b>Green Crate</b>" : "  <b>Зелёный Ящик</b>");
                                CFG.Setting.o = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.o, menu.enru ? "  <b>Elite Crate</b>" : " <b> Элитный Ящик</b>");
                                CFG.Setting.d = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.d, menu.enru ? "  <b>Crate Heli/Tank</b>" : " <b> Ящики Верт/Танк</b>");
                                CFG.Setting.test4 = GUI.Toggle(new Rect(111, 200, 100f, 20f), CFG.Setting.test4, menu.enru ? " <b> Recycler</b>" : " <b> Переработчик</b>");
                                CFG.Setting.r = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Setting.r, menu.enru ? " <b> Supply Drop</b>" : "  <b>Аир Дроп</b>");
                                CFG.Setting.bvbcfd = GUI.Toggle(new Rect(320, 50, 170f, 20f), CFG.Setting.bvbcfd, menu.enru ? "  <b>Boxes</b>" : " <b> Ящики</b>");
                                CFG.Setting.t = GUI.Toggle(new Rect(320, 125, 100f, 20f), CFG.Setting.t, menu.enru ? " <b> Dropped Item</b>" : " <b> Предметы</b>");
                                if (CFG.Setting.t)
                                {
                                    CFG.Setting.corpse = GUI.Toggle(new Rect(420, 125, 50, 20f), CFG.Setting.corpse, menu.enru ? " <b> Icon</b>" : " <b> Ава</b>");
                                }
                                CFG.Setting.e = GUI.Toggle(new Rect(320, 100, 60, 20f), CFG.Setting.e, menu.enru ? " <b> Stash</b>" : "  <b>Стеши</b>");
                                if (CFG.Setting.e)
                                {
                                    CFG.Setting.bbf = GUI.Toggle(new Rect(390, 100, 80, 20f), CFG.Setting.bbf, menu.enru ? " <b> AutoExcavation</b>" : " <b> АвтоРазкоп</b>");
                                }
                                CFG.Setting.w = GUI.Toggle(new Rect(320, 75, 60f, 20f), CFG.Setting.w, menu.enru ? " <b> Cupboard</b>" : "<b>  Шкаф</b>");
                                if (CFG.Setting.w)
                                {
                                    CFG.Setting.h = GUI.Toggle(new Rect(390, 75, 40, 20f), CFG.Setting.h, menu.enru ? " <b> HP</b>" : " <b> HP</b>");
                                }
                                if (CFG.Setting.s || CFG.Setting.y || CFG.Setting.u || CFG.Setting.i || CFG.Setting.o || CFG.Setting.d || CFG.Setting.test4 || CFG.Setting.r ||
                                    CFG.Setting.bvbcfd ||
                                    CFG.Setting.t ||
                                    CFG.Setting.e || CFG.Setting.w)
                                {
                                    GUI.Label(new Rect(530, 75, 180f, 30f), string.Format(menu.enru ? "          <b> Distance</b> " : "           <b>Дистанция</b> ", CFG.Setting.WorldEspDistance));
                                    CFG.Setting.WorldEspDistance = (int)GUI.HorizontalSlider(new Rect(530, 100, 150f, 25f), CFG.Setting.WorldEspDistance, 0f, 600f);
                                    GUI.Label(new Rect(530, 94, 180f, 30f), string.Format("            <b>  {0}</b>", CFG.Setting.WorldEspDistance));
                                }
                                break;
                            case menu.ta1.d4:

                                CFG.Setting.guntrap = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.guntrap, menu.enru ? "  <b>Gun Trap</b>" : " <b> Ган Трап</b>");
                                CFG.Setting.Flame = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.Flame, menu.enru ? "  <b>Flame Turret</b>" : " <b> Огненная Турель</b>");

                                CFG.Setting.traa = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.traa, menu.enru ? "  <b>Mine</b>" : "  <b>Мины</b>");
                                CFG.Setting.breed = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.breed, menu.enru ? "  <b>Bear Trap</b>" : "  <b>Капканы</b>");


                                CFG.Setting.p = GUI.Toggle(new Rect(111, 100, 110f, 20f), CFG.Setting.p, menu.enru ? "  <b>Auto Turret</b>" : " <b> Авто Турель</b>");
                                if (CFG.Setting.p)
                                {
                                    CFG.Setting.turr = GUI.Toggle(new Rect(231, 100, 100f, 20f), CFG.Setting.turr, menu.enru ? "  <b>AUTH</b>" : "  <b>Авториз.</b>");
                                }
                                if (CFG.Setting.guntrap || CFG.Setting.Flame || CFG.Setting.traa || CFG.Setting.breed || CFG.Setting.p)
                                {
                                    GUI.Label(new Rect(360, 75, 180f, 30f), string.Format(menu.enru ? "          <b> Distance</b> " : "           <b>Дистанция</b> ", CFG.Setting.traps));
                                    CFG.Setting.traps = (int)GUI.HorizontalSlider(new Rect(360, 100, 150f, 25f), CFG.Setting.traps, 0f, 600f);
                                    GUI.Label(new Rect(360, 94, 180f, 30f), string.Format("            <b>  {0}</b>", CFG.Setting.traps));
                                }
                                break;
                            case menu.ta1.d5:
                                CFG.Setting.ytcbcv = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.ytcbcv, menu.enru ? "  <b>Sulfur</b>" : " <b> Сера</b>");
                                CFG.Setting.cvdfg = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.cvdfg, menu.enru ? " <b> Metal</b>" : " <b> Метал</b>");
                                CFG.Setting.rtfgd = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.rtfgd, menu.enru ? " <b> Stone</b>" : " <b> Камень</b>");
                                CFG.Setting.fdgvcbd = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.fdgvcbd, menu.enru ? " <b> Hemp</b>" : "  <b>Ткань</b>");
                                CFG.Setting.rererrr = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.rererrr, menu.enru ? "<b>  Pumpkin</b>" : "  <b>Тыква</b>");
                                CFG.Setting.gfgrttt = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.gfgrttt, menu.enru ? " <b> Corn</b>" : "<b>  Кукуруза</b>");
                                CFG.Setting.bvcbfdge = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.Setting.bvcbfdge, menu.enru ? "<b>  Mushrooms</b>" : " <b> Грибы</b>");

                                CFG.Setting.iiii = GUI.Toggle(new Rect(320, 50, 170f, 20f), CFG.Setting.iiii, menu.enru ? " <b> Collectibles Sulfur</b>" : " <b> Подбираемая Сера</b>");
                                CFG.Setting.vbcbc = GUI.Toggle(new Rect(320, 75, 170f, 20f), CFG.Setting.vbcbc, menu.enru ? "  <b>Collectibles Meatl</b>" : " <b> Подбираемый Метал</b>");
                                CFG.Setting.ytytf = GUI.Toggle(new Rect(320, 100, 170f, 20f), CFG.Setting.ytytf, menu.enru ? "  <b>Collectibles Stone</b>" : " <b> Подбираемый Камень</b>");
                                CFG.Setting.fdgdg = GUI.Toggle(new Rect(320, 125, 170f, 20f), CFG.Setting.fdgdg, menu.enru ? " <b> Collectibles Wood</b>" : " <b> Подбираемое Дерево</b>");

                                if (CFG.Setting.ytcbcv || CFG.Setting.cvdfg || CFG.Setting.rtfgd || CFG.Setting.fdgvcbd || CFG.Setting.rererrr || CFG.Setting.gfgrttt ||
                                    CFG.Setting.bvcbfdge || CFG.Setting.iiii || CFG.Setting.vbcbc || CFG.Setting.ytytf || CFG.Setting.fdgdg)
                                {
                                    GUI.Label(new Rect(320, 200, 180f, 30f), string.Format(menu.enru ? "          <b>   Distance</b> " : "           <b>  Дистанция </b>", CFG.Setting.range));
                                    CFG.Setting.range = (int)GUI.HorizontalSlider(new Rect(320, 225, 150f, 25f), CFG.Setting.range, 0f, 500f);
                                    GUI.Label(new Rect(320, 219, 180f, 30f), string.Format("             <b>    {0}</b>", CFG.Setting.range));
                                }
                                break;
                            case menu.ta1.d6:


                                CFG.Setting.dsfsf = GUI.Toggle(new Rect(111, 50, 150, 20f), CFG.Setting.dsfsf, menu.enru ? "  <b>Helicopter [∞ Meters]</b>" : " <b> Вертолёт [∞ Метров]</b>");
                                CFG.Setting.q = GUI.Toggle(new Rect(111, 75, 150, 20f), CFG.Setting.q, menu.enru ? " <b> Tank [400 Meters]</b>" : "  <b>Танк [400 Метров]</b>");
                                CFG.Setting.bag = GUI.Toggle(new Rect(111, 100, 160, 20f), CFG.Setting.bag, menu.enru ? " <b> Sleeping Bag</b>" : " <b> Спальники</b>");

                                CFG.Setting.f = GUI.Toggle(new Rect(111, 125, 190f, 20f), CFG.Setting.f, menu.enru ? " <b> Explosion C4/Rocket/Satchel/F1 etc.</b>" : "<b>  Взрыв С4/Ракета/Сочель/F1 и ТД.</b>");

                                CFG.Setting.fgfddd = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.fgfddd, menu.enru ? "  <b>Doors</b>" : " <b> Двери</b>");

                                break;
                        }
                    }





                    break;
                case menu.tab.f2:
                    #region "f2"
                    if (GUI.Button(new Rect(105, 20, 120, 25f), menu.enru ? "<b>Aim Bot</b>" : "<b>Аим Бот</b>"))
                    {
                        linia11 = true; linia22 = false; linia33 = false; linia44 = false; linia55 = false;
                        neww1 = menu.ta2.d1;
                    }
                    if (linia11)
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(225, 20, 120, 25f), menu.enru ? "<b>Crosshair</b>" : "<b>Прицелы</b>"))
                    {
                        linia11 = false; linia22 = true; linia33 = false; linia44 = false; linia55 = false;
                        neww1 = menu.ta2.d2;
                    }
                    if (linia22)
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    #endregion
                    Enum @enum121 = neww1;
                    Enum enum1212;
                    if (@enum121 != null && (enum1212 = @enum121) is menu.ta2)
                    {
                        switch ((menu.ta2)enum1212)
                        {
                            case menu.ta2.d1:


                                CFG.Setting.asdas = GUI.Toggle(new Rect(111, 50, 140f, 20f), CFG.Setting.asdas, menu.enru ? "  <b>Aim Bot [X]</b>" : "  <b>Аим Бот [Х]</b>");

                                CFG.Setting.head = GUI.Toggle(new Rect(111, 75, 140f, 20f), CFG.Setting.head, menu.enru ? "  <b>Aim Bot [Body]</b>" : "  <b>Аим Бот [Тело]</b>");
                                CFG.Setting.bvbgfg = GUI.Toggle(new Rect(111, 100, 140f, 20f), CFG.Setting.bvbgfg, menu.enru ? "  <b>Aim Bot Heli [X]</b>" : "  <b>Аим Бот-Верт [Х]</b>");

                                CFG.Setting.FOV = GUI.Toggle(new Rect(320, 50, 150f, 20f), CFG.Setting.FOV, menu.enru ? "  <b>FOV</b>" : "  <b>FOV</b>");
                                CFG.Setting.FOV1 = GUI.Toggle(new Rect(320, 75, 150f, 20f), CFG.Setting.FOV1, menu.enru ? "  <b>FOV [Test]</b>" : "  <b>FOV [Тест]</b>");
                                if (CFG.Setting.asdas || CFG.Setting.head || CFG.Setting.bvbgfg || CFG.Setting.FOV || CFG.Setting.FOV1)
                                {
                                    GUI.Label(new Rect(530, 75, 180f, 30f), string.Format(menu.enru ? "          <b>FOV [Aim Bot]</b>" : "          <b>FOV [Аим Бот]</b>", CFG.Setting.fov));
                                    CFG.Setting.fov = (int)GUI.HorizontalSlider(new Rect(530, 100, 160f, 25f), CFG.Setting.fov, 0f, 180f);
                                    GUI.Label(new Rect(530, 94, 180f, 30f), string.Format("                <b>{0}</b>", CFG.Setting.fov));
                                }

                                break;
                            case menu.ta2.d2:

                                CFG.Setting.cross = GUI.Toggle(new Rect(111, 110, 140f, 20f), CFG.Setting.cross, menu.enru ? "  <b>Crosshair</b>" : "  <b>Прицел</b>");
                                CFG.Setting.crrr = GUI.Toggle(new Rect(111, 80, 140f, 20f), CFG.Setting.crrr, menu.enru ? "  <b>Crosshair</b>" : "  <b>Прицел</b>");
                                CFG.Setting.grr = GUI.Toggle(new Rect(111, 50, 140f, 20f), CFG.Setting.grr, menu.enru ? "  <b>Crosshair</b>" : "  <b>Прицел</b>");

                                GUI.DrawTexture(new Rect(211, 50, 25f, 25f), HukTexture.mTex3);

                                GUI.DrawTexture(new Rect(211, 80, 25f, 25f), HukTexture.mTex2);

                                GUI.DrawTexture(new Rect(211, 110, 25f, 25f), HukTexture.mTex5);

                                break;
                        }
                    }



                    break;
                case menu.tab.f3:
                    #region "f3"
                    if (GUI.Button(new Rect(105, 20, 120, 25f), menu.enru ? "<b>Players</b>" : "<b>Игроки</b>"))
                    {
                        linia111 = true; linia222 = false; linia333 = false; linia444 = false; linia555 = false;
                        neww2 = menu.ta3.d1;
                    }
                    if (linia111)
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(225, 20, 120, 25f), menu.enru ? "<b>Helicopter</b>" : "<b>Вертолёт</b>"))
                    {
                        linia111 = false; linia222 = true; linia333 = false; linia444 = false; linia555 = false;
                        neww2 = menu.ta3.d2;
                    }
                    if (linia222)
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(345, 20, 120, 25f), menu.enru ? "<b>Animals</b>" : "<b>Животные</b>"))
                    {
                        linia111 = false; linia222 = false; linia333 = true; linia444 = false; linia555 = false;
                        neww2 = menu.ta3.d3;
                    }
                    if (linia333)
                    {
                        Rendering.DrawString(new Vector2(345, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(345, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }

                    #endregion
                    Enum @enum131 = neww2;
                    Enum enum1312;
                    if (@enum131 != null && (enum1312 = @enum131) is menu.ta3)
                    {
                        switch ((menu.ta3)enum1312)
                        {
                            case menu.ta3.d1:
                                CFG.Setting.gggg = GUI.Toggle(new Rect(500, 225, 120f, 20f), CFG.Setting.gggg, (menu.enru ? "  <b>Target Label</b>" : "  <b>Метка Цели</b>"));
                                CFG.Setting.greg = GUI.Toggle(new Rect(500, 250, 120f, 20f), CFG.Setting.greg, (menu.enru ? "  <b>Line To Target</b>" : "  <b>Линия До Цели</b>"));
                                CFG.Setting.ssddd = GUI.Toggle(new Rect(111, 50, 120f, 20f), CFG.Setting.ssddd, (menu.enru ? "  <b>Silent Players</b>" : "  <b>Сало Игроки</b>"));
                                if (CFG.Setting.ssddd)
                                {
                                    CFG.Setting.cbvcbcd = GUI.Toggle(new Rect(320, 50, 170f, 20f), CFG.Setting.cbvcbcd, (menu.enru ? "  <b>Silent Body</b>" : "  <b>Сало Тело</b>"));
                                }
                                CFG.Setting.uytgff = GUI.Toggle(new Rect(111, 75, 120, 20f), CFG.Setting.uytgff, (menu.enru ? "  <b>Silent Wall</b>" : "  <b>Сало Стены</b>"));
                                if (CFG.Setting.uytgff)
                                {
                                    CFG.Setting.fdsfdsfew = GUI.Toggle(new Rect(320, 75, 170f, 20f), CFG.Setting.fdsfdsfew, (menu.enru ? "  <b>Silent Body</b>" : "  <b>Сало Тело</b>"));
                                }
                                CFG.Setting.cahh = GUI.Toggle(new Rect(111, 100, 100f, 20f), CFG.Setting.cahh, (menu.enru ? "  <b>Silent Player [Clamp-X]</b>" : "  <b>Silent Игрок [Зажать-X]</b>"));
                                if (CFG.Setting.cahh)
                                {
                                    CFG.Setting.bbccvvdd = GUI.Toggle(new Rect(320, 100, 170f, 20f), CFG.Setting.bbccvvdd, (menu.enru ? "  <b>Silent Body</b>" : "  <b>Silent Тело</b>"));
                                }


                                CFG.Setting.dffs = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.dffs, (menu.enru ? "  <b>Silent Players[150M-AK]</b>" : "  <b>Сало Игроки[150M-АК]</b>"));
                                CFG.Setting.cvvcv = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.cvvcv, (menu.enru ? "  <b>Silent Body[150M-AK]</b>" : "  <b>Сало Тело[150М-АК]</b>"));

                                CFG.Setting.rrrar = GUI.Toggle(new Rect(500, 75, 120f, 20f), CFG.Setting.rrrar, (menu.enru ? "  <b>Silemt Melee</b>" : "  <b>Сало Близь</b>"));

                                CFG.Setting.tt = GUI.Toggle(new Rect(500, 100, 170f, 20f), CFG.Setting.tt, (menu.enru ? "  <b>Silent Melee Body</b>" : "  <b>Сало Близь Тело</b>"));

                                CFG.Setting.milll = GUI.Toggle(new Rect(500, 125, 170f, 20f), CFG.Setting.milll, (menu.enru ? "  <b>Silent Melee Wall</b>" : "  <b>Сало Близь Через Стены</b>"));
                                CFG.Setting.mili = GUI.Toggle(new Rect(500, 50, 100f, 20f), CFG.Setting.mili, (menu.enru ? "  <b>Beat at the Distance</b>" : "  <b>Бить на Дистанции</b>"));
                                CFG.Setting.FOV11 = GUI.Toggle(new Rect(111, 200, 150f, 20f), CFG.Setting.FOV11, (menu.enru ? "  <b>FOV</b>" : "  <b>FOV</b>"));

                                GUI.Label(new Rect(111, 225, 180f, 30f), string.Format((menu.enru ? "            <b>FOV [Silent]</b>" : "            <b>FOV [Сайлент]</b>"), CFG.Setting.fov1));
                                CFG.Setting.fov1 = (int)GUI.HorizontalSlider(new Rect(111, 250, 180f, 25f), CFG.Setting.fov1, 0f, 720);
                                GUI.Label(new Rect(111, 243, 180f, 30f), string.Format("                  <b>{0}</b>", CFG.Setting.fov1));


                                break;
                            case menu.ta3.d2:

                                CFG.Setting.BulletDropPrediction = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.BulletDropPrediction, (menu.enru ? "  <b>Silent Heli [Clamp-X]</b>" : "  <b>Верт Сало [Зажать-X]</b>"));



                                CFG.Setting.dfertwdf = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.dfertwdf, (menu.enru ? "  <b>Tank Silent [Clamp-X]</b>" : "  <b>Танк Сало [Зажать-X]</b>"));


                                CFG.Setting.heli = GUI.Toggle(new Rect(111, 75, 100f, 20f), CFG.Setting.heli, (menu.enru ? "  <b>Silent Helicopter</b>" : "  <b>Сало Верталёт</b>"));

                                break;
                            case menu.ta3.d3:
                                CFG.Setting.qewqefdsf = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.qewqefdsf, (menu.enru ? "  <b>Animals Silent [Clamp-X]</b>" : "  <b>Живтоные Сало [Зажать-X]</b>"));







                                break;
                        }
                    }

                    break;
                case menu.tab.f4:
                    #region "f4"
                    if (GUI.Button(new Rect(105, 20, 120, 25f), menu.enru ? "<b>Radar 2D</b>" : "<b>Радар 2D</b>"))
                    {
                        linia1111 = true; linia2222 = false; linia3333 = false; linia4444 = false; linia5555 = false;
                        neww3 = menu.ta4.d1;
                    }
                    if (linia1111)
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(225, 20, 120, 25f), menu.enru ? "<b>Skin 2D</b>" : "<b>Скин 2D</b>"))
                    {
                        linia1111 = false; linia2222 = true;
                        neww3 = menu.ta4.d2;
                    }
                    if (linia2222)
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    #endregion
                    Enum @enum141 = neww3;
                    Enum enum1132;
                    if (@enum141 != null && (enum1132 = @enum141) is menu.ta4)
                    {
                        switch ((menu.ta4)enum1132)
                        {
                            case menu.ta4.d1:

                                CFG.Setting.radarrrrr = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.radarrrrr, menu.enru ? " <b> Radar ON/OFF</b>" : " <b> Радар Вкл/Выкл</b>");
                                GUI.Label(new Rect(111, 75, 180f, 30f), string.Format((menu.enru ? "            <b>Left/Right</b>" : "            <b>Лево/Право</b>"), CFG.Setting.left));
                                CFG.Setting.left = (int)GUI.HorizontalSlider(new Rect(111, 100, 180f, 25f), CFG.Setting.left, 5f, Screen.width);
                                GUI.Label(new Rect(111, 94, 180f, 30f), string.Format("                  <b>{0}</b>", CFG.Setting.left));

                                GUI.Label(new Rect(111, 125, 180f, 30f), string.Format((menu.enru ? "            <b>Up/Down</b>" : "            <b>Верх/Низ</b>"), CFG.Setting.up));
                                CFG.Setting.up = (int)GUI.HorizontalSlider(new Rect(111, 150, 180f, 25f), CFG.Setting.up, 5f, Screen.height);
                                GUI.Label(new Rect(111, 144, 180f, 30f), string.Format("                  <b>{0}</b>", CFG.Setting.up));

                                GUI.Label(new Rect(111, 175, 180f, 30f), string.Format((menu.enru ? "            <b>Size</b>" : "            <b>Размер</b>"), CFG.Setting.size));
                                CFG.Setting.size = (int)GUI.HorizontalSlider(new Rect(111, 200, 180f, 25f), CFG.Setting.size, 100f, 250);
                                GUI.Label(new Rect(111, 194, 180f, 30f), string.Format("                  <b>{0}</b>", CFG.Setting.size));

                                GUI.Label(new Rect(111, 225, 180f, 30f), string.Format((menu.enru ? "            <b>Distance</b>" : "            <b>Дистанция</b>"), CFG.Setting.dist));
                                CFG.Setting.dist = (int)GUI.HorizontalSlider(new Rect(111, 250, 180f, 25f), CFG.Setting.dist, 50f, 400);
                                GUI.Label(new Rect(111, 243, 180f, 30f), string.Format("                  <b>{0}</b>", CFG.Setting.dist));

                                CFG.Setting.radar = GUI.Toggle(new Rect(320, 50, 170f, 20f), CFG.Setting.radar, menu.enru ? " <b> Players</b>" : " <b> Игроки</b>");
                                CFG.Setting.sleep = GUI.Toggle(new Rect(320, 75, 170f, 20f), CFG.Setting.sleep, menu.enru ? " <b> Sleepers</b>" : " <b> Спящие</b>");
                                CFG.Setting.radarnpc = GUI.Toggle(new Rect(320, 100, 170f, 20f), CFG.Setting.radarnpc, menu.enru ? "  <b>NPC</b>" : " <b> Боты</b>");




                                break;
                            case menu.ta4.d2:


                                if (GUI.Button(new Rect(283, 50, 170, 170), menu.enru ? "" : ""))
                                {
                                    CFG.Setting.skin = false;
                                }
                                if (GUI.Button(new Rect(111, 50, 170, 170), menu.enru ? "" : ""))
                                {
                                    CFG.Setting.skin = true;
                                }

                                GUI.DrawTexture(new Rect(111, 50, 170, 170), HukTexture.mTex);
                                GUI.DrawTexture(new Rect(135, 111, 3, 3), HukTexture.merr);
                                GUI.DrawTexture(new Rect(156, 76, 3, 3), HukTexture.merr);
                                GUI.DrawTexture(new Rect(180, 130, 3, 3), HukTexture.merr);
                                GUI.DrawTexture(new Rect(283, 50, 170, 170), HukTexture.mTex6);
                                Rendering.BoxRect(new Rect(340, 76, 3, 3), Color.red);
                                Rendering.BoxRect(new Rect(378, 130, 3, 3), Color.red);
                                Rendering.BoxRect(new Rect(400, 170, 3, 3), Color.red);

                                break;
                        }
                    }

                    break;
                case menu.tab.f5:
                    #region "f5"
                    if (GUI.Button(new Rect(105, 20, 120, 25f), menu.enru ? "<b>Weapons</b>" : "<b>Оружие</b>"))
                    {
                        linia11111 = true; linia22222 = false; linia33333 = false; linia44444 = false; linia55555 = false;
                        neww4 = menu.ta5.d1;
                    }
                    if (linia11111)
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(105, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(225, 20, 120, 25f), menu.enru ? "<b>Movement</b>" : "<b>Движение</b>"))
                    {
                        linia11111 = false; linia22222 = true; linia33333 = false; linia44444 = false; linia55555 = false;
                        neww4 = menu.ta5.d2;
                    }
                    if (linia22222)
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(225, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(345, 20, 120, 25f), menu.enru ? "<b>Misc</b>" : "<b>Разное</b>"))
                    {
                        linia11111 = false; linia22222 = false; linia33333 = true; linia44444 = false; linia55555 = false;
                        neww4 = menu.ta5.d3;
                    }
                    if (linia33333)
                    {
                        Rendering.DrawString(new Vector2(345, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(345, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(465, 20, 120, 25f), menu.enru ? "<b>Automation</b>" : "<b>Автоматика</b>"))
                    {
                        linia11111 = false; linia22222 = false; linia33333 = false; linia44444 = true; linia55555 = false;
                        neww4 = menu.ta5.d4;
                    }
                    if (linia44444)
                    {
                        Rendering.DrawString(new Vector2(465, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(465, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    if (GUI.Button(new Rect(585, 20, 120, 25f), menu.enru ? "<b>None</b>" : "<b>Пусто</b>"))
                    {
                        linia11111 = false; linia22222 = false; linia33333 = false; linia44444 = false; linia55555 = true;
                        neww4 = menu.ta5.d5;
                    }
                    if (linia55555)
                    {
                        Rendering.DrawString(new Vector2(585, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.green, false, 13, FontStyle.Bold);
                    }
                    else
                    {
                        Rendering.DrawString(new Vector2(585, 24), string.Format("<b>▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁</b> ", (int)(1f / float_0)), Color.grey, false, 13, FontStyle.Bold);
                    }
                    #endregion
                    Enum @enuma11 = neww4;
                    Enum enuma112;
                    if (@enuma11 != null && (enuma112 = @enuma11) is menu.ta5)
                    {
                        switch ((menu.ta5)enuma112)
                        {
                            case menu.ta5.d1:
                                CFG.Setting.dgvcbb = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.dgvcbb, menu.enru ? "  <b>No Recoil</b>" : "  <b>Нет Отдачи</b>");
                                CFG.Setting.yyttff = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.yyttff, menu.enru ? "  <b>No Sway</b>" : "  <b>Нет Тряски</b>");
                                CFG.Setting.vvvv = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.vvvv, menu.enru ? "  <b>Automatic</b>" : "  <b>Автоматика</b>");
                                CFG.Setting.cdddeee = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.cdddeee, menu.enru ? "  <b>No Spread</b>" : "  <b>Нет Разброса</b>");
                                CFG.Setting.sfwewwww = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.sfwewwww, menu.enru ? "  <b>No Spread Shotgun</b>" : "  <b>Нет Спрея Дробовик</b>");
                                CFG.Setting.bbbvvvccc = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.bbbvvvccc, menu.enru ? "  <b>Eoka with 1 shot</b>" : "  <b>Ёка с 1 Выстрела</b>");
                                CFG.Setting.hyk = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.Setting.hyk, menu.enru ? "  <b>Fast Bow</b>" : " <b> Быстрый Лук</b>");
                                CFG.Setting.dfdswe = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Setting.dfdswe, menu.enru ? "  <b>Shoot As You Like</b>" : "  <b>Стрелять Как Угодно</b>");
                                CFG.Setting.sdfewewdff = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.Setting.sdfewewdff, menu.enru ? "  <b>Thick Bullets</b>" : "  <b>Толстые Пули</b>");
                                CFG.Setting.vcgrrrr = GUI.Toggle(new Rect(111, 275, 170f, 20f), CFG.Setting.vcgrrrr, menu.enru ? "  <b>No Bullet Gravity</b>" : "  <b>Нет Гравитации Пуль</b>");
                                CFG.Setting.uuyyttrrr = GUI.Toggle(new Rect(320, 250, 170f, 20f), CFG.Setting.uuyyttrrr, menu.enru ? "  <b>Thick Tools</b>" : "  <b>Толстые Инструменты</b>");
                                CFG.Setting.hhhh = GUI.Toggle(new Rect(320, 275, 170f, 20f), CFG.Setting.hhhh, menu.enru ? "  <b>No Gravity Tools</b>" : "  <b>Нет Гравитации Инструменты</b>");

                                GUI.Label(new Rect(320, 50, 170f, 27f), string.Format(menu.enru ? "<b>Random Assassination Distance</b>" : "<b>Рандом Дистанция Убийства</b>", Color.red));


                                CFG.Setting.gggggg = GUI.Toggle(new Rect(320, 75, 170f, 20f), CFG.Setting.gggggg, menu.enru ? "  <b>77 - 999999999M</b>" : "  <b>77 - 999999999M</b>");

                                CFG.Setting.grass = GUI.Toggle(new Rect(500, 50, 170f, 20f), CFG.Setting.grass, menu.enru ? "  <b>Shoot Through Terrain</b>" : "  <b>Стрелять Через Землю</b>");

                                if (CFG.Setting.grass)
                                {
                                    CFG.Setting.grass12 = GUI.Toggle(new Rect(500, 75, 170f, 20f), CFG.Setting.grass12, menu.enru ? "  <b>Shoot Through Trees</b>" : "  <b>Стрелять Через Деревья</b>");
                                }



                                break;
                            case menu.ta5.d2:
                                CFG.Setting.adsfdgrege = GUI.Toggle(new Rect(111, 50, 70, 20f), CFG.Setting.adsfdgrege, menu.enru ? "  <b>Spidermen</b>" : "  <b>Паук</b>");
                                CFG.Setting.walkon = GUI.Toggle(new Rect(111, 75, 160f, 20f), CFG.Setting.walkon, menu.enru ? " <b> Walk On Water</b>" : " <b> Ходить По Воде</b>");
                                CFG.Setting.eeeeeeeee = GUI.Toggle(new Rect(111, 100, 160f, 20f), CFG.Setting.eeeeeeeee, menu.enru ? " <b> Run While Aiming</b>" : " <b> Бегать Во Время Прицела</b>");
                                CFG.Setting.blats = GUI.Toggle(new Rect(111, 125, 160f, 20f), CFG.Setting.blats, menu.enru ? " <b> SpeedHack</b>" : " <b> SpeedHack</b>");
                                CFG.Setting.asawersffd = GUI.Toggle(new Rect(111, 175, 160f, 20f), CFG.Setting.asawersffd, menu.enru ? "  <b>Jamp Hack</b>" : " <b> Прыг Скок</b>");
                                CFG.Setting.speedhackspeed = (int)GUI.HorizontalSlider(new Rect(111, 155, 180f, 25f), CFG.Setting.speedhackspeed, 4f, 50);
                                GUI.Label(new Rect(111, 149, 180f, 30f), string.Format("          <b>SpeedHack [{0}]</b>", CFG.Setting.speedhackspeed));
                                CFG.Setting.HGHGH = GUI.Toggle(new Rect(111, 200, 160f, 20f), CFG.Setting.HGHGH, menu.enru ? "  <b>Low Gravity</b>" : " <b> Малая Гравитация</b>");
                                CFG.Setting.ASDADAD = GUI.Toggle(new Rect(111, 225, 160f, 20f), CFG.Setting.ASDADAD, menu.enru ? " <b> Not Sink</b>" : "  <b>Не Тонуть</b>");
                                CFG.Setting.fsass = GUI.Toggle(new Rect(111, 250, 160f, 20f), CFG.Setting.fsass, menu.enru ? "<b>  MOD Heavy Armor</b>" : " <b> МОД Тяж Брони</b>");
                                CFG.Setting.test411 = GUI.Toggle(new Rect(111, 275, 160f, 20f), CFG.Setting.test411, menu.enru ? "<b>  Suicide [KeyPad5]</b>" : "<b>  Самоубийство [KeyPad5]</b>");
                                CFG.Setting.AASDD = GUI.Toggle(new Rect(310, 50, 160f, 20f), CFG.Setting.AASDD, menu.enru ? "<b>  Fast Throwing Grenades[F]</b>" : " <b> Фаст Бросание Гранат [F]</b>");
                                CFG.Setting.test3 = GUI.Toggle(new Rect(310, 75, 170f, 20f), CFG.Setting.test3, menu.enru ? " <b> Fast Glue A Grenade [F]</b>" : " <b> Фаст Клеить Гранату [F]</b>");

                                CFG.Setting.teleport = GUI.Toggle(new Rect(310, 100, 160f, 20f), CFG.Setting.teleport, menu.enru ? " <b> Teleport [C]</b>" : " <b> Телепорт [C]</b>");
                                CFG.Setting.NAXYI = GUI.Toggle(new Rect(310, 250, 160f, 20f), CFG.Setting.NAXYI, menu.enru ? " <b> Auto Heal</b>" : " <b> Авто Хилл</b>");
                                CFG.Setting.ZAEB = GUI.Toggle(new Rect(310, 225, 160f, 20f), CFG.Setting.ZAEB, menu.enru ? " <b> Heal Friend [F]</b>" : " <b> Хилл Друга [F]</b>");
                                CFG.Setting.cccvvbbbffdd = GUI.Toggle(new Rect(310, 275, 160f, 20f), CFG.Setting.cccvvbbbffdd, menu.enru ? "  <b>Raise [Z]</b>" : " <b> Поднять [Z]</b>");
                                CFG.Setting.ZALYPA = GUI.Toggle(new Rect(310, 125, 160f, 20f), CFG.Setting.ZALYPA, menu.enru ? " <b> Drop Inventory [L]</b>" : " <b> Скинуть Инвентарь [L]</b>");
                                CFG.Setting.adadadaa = GUI.Toggle(new Rect(310, 150, 160f, 20f), CFG.Setting.adadadaa, menu.enru ? " <b> 3 Face</b>" : " <b> 3 Лицо</b>");
                                CFG.Setting.nnn = GUI.Toggle(new Rect(310, 175, 96, 20f), CFG.Setting.nnn, menu.enru ? " <b> Wanker xD</b>" : "<b>  Дрочун xD</b>");
                                CFG.Setting.test41 = GUI.Toggle(new Rect(310, 200, 160f, 20f), CFG.Setting.test41, menu.enru ? " <b> Spam Reload</b>" : " <b> Спам Reload</b>");


                                CFG.Setting.traf = GUI.Toggle(new Rect(500, 125, 170f, 20f), CFG.Setting.traf, menu.enru ? " <b> Remove The Grass</b>" : "  <b>Убрать Траву</b>");
                                CFG.Setting.свет = GUI.Toggle(new Rect(500, 50, 170f, 20f), CFG.Setting.свет, menu.enru ? " <b> Remove The Darkness</b>" : " <b> Убрать Тьму</b>");

                                CFG.Setting.time = GUI.Toggle(new Rect(500, 75, 170f, 20f), CFG.Setting.time, menu.enru ? "  <b>Time</b>" : "  <b>Время</b>");
                                CFG.Setting.dfd = GUI.HorizontalSlider(new Rect(500, 105, 160f, 25f), CFG.Setting.dfd, 0f, 24f);
                                GUI.Label(new Rect(500, 99, 180f, 30f), string.Format(menu.enru ? "           <b>[{0:0.#} Hr/Min]</b>" : "           <b>[{0:0.#} Час/Мин]</b>", CFG.Setting.dfd));

                                CFG.Setting.mbnbnm = GUI.Toggle(new Rect(500, 150, 170f, 20f), CFG.Setting.mbnbnm, "  <b>WaterLevel</b>");
                                CFG.Setting.mmmm = GUI.Toggle(new Rect(500, 175, 170f, 20f), CFG.Setting.mmmm, menu.enru ? " <b> Walk Under Water</b>" : " <b> Ходить Под Водой</b>");

                                GUI.Label(new Rect(460, 227, 80, 30), string.Format(menu.enru ? "  <b>Nick:</b>" : "  <b>Ник:</b>", Color.red));
                                CFG.Setting.spoof = GUI.Toggle(new Rect(500, 200, 170f, 20f), CFG.Setting.spoof, menu.enru ? "  <b>Spoof nickname</b>" : "  <b>Спуф ника </b>");
                                CFG.Setting.faked = GUI.TextArea(new Rect(500, 225, 170f, 30), CFG.Setting.faked, "box");
                                GUI.Label(new Rect(500, 230, 170f, 30), string.Format("<b>____________________________________________________________________________</b>", Color.red));
                                GUI.Label(new Rect(500, 210, 170f, 30), string.Format("<b>____________________________________________________________________________</b>", Color.red));
                                CFG.Setting.nnnn = GUI.Toggle(new Rect(500, 250, 170f, 20f), CFG.Setting.nnnn, menu.enru ? " <b> Auto Speed Up Running</b>" : "<b>  Авто Ускороение Бега</b>");

                                break;
                            case menu.ta5.d3:

                                CFG.Setting.gf = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.gf, menu.enru ? " <b> Magnet to the Player [E]</b>" : " <b> Магнит К Игроку [E]</b>");

                                CFG.Setting.govno2 = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.govno2, menu.enru ? " <b> Hack Automatic [E]</b>" : " <b> Взлом Автоматика</b>");

                                CFG.Setting.spin = GUI.Toggle(new Rect(111, 75, 88, 20f), CFG.Setting.spin, menu.enru ? "  <b>Anti-Aim</b>" : " <b> Анти-Аим</b>");
                                CFG.Setting.fdfd = (int)GUI.HorizontalSlider(new Rect(111, 105, 150f, 25f), CFG.Setting.fdfd, 0f, 3f);
                                GUI.Label(new Rect(111, 99, 180f, 30f), string.Format(arrra, (float)CFG.Setting.fdfd));
                                GUI.Label(new Rect(111, 125, 180f, 30f), string.Format(menu.enru ? "      <b>Speed Anti-Aim </b>" : "     <b> Скорость Анти-Аим </b>", CFG.Setting.sped));
                                CFG.Setting.sped = (int)GUI.HorizontalSlider(new Rect(111, 150, 150f, 25f), CFG.Setting.sped, 5f, 50f);
                                GUI.Label(new Rect(111, 144, 180f, 30f), string.Format("              <b> [{0}]</b>", CFG.Setting.sped));
                                CFG.Setting.wertyu = GUI.Toggle(new Rect(111, 200, 160f, 20f), CFG.Setting.wertyu, menu.enru ? "  <b>Remove Objects[KeyPad1-2]</b>" : "  <b>Ремув Объектов[KeyPad1-2]</b>");
                                CFG.Setting.ggdfggg = GUI.Toggle(new Rect(111, 225, 160f, 20f), CFG.Setting.ggdfggg, menu.enru ? "  <b>Twirl Build [Arrows]</b>" : " <b> Вертеть Билду [Стрелочками]</b>");

                                CFG.Setting.df = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.Setting.df, menu.enru ? " <b> Fly-Into The Air [Z]</b>" : "  <b>Полёт-В Воздух [Z]</b>");
                                CFG.Setting.flyhack = GUI.Toggle(new Rect(111, 275, 170f, 20f), CFG.Setting.flyhack, menu.enru ? " <b> Fly Hack </b>" : "  <b>Полёт Хук </b>");

                                CFG.Setting.hookd = GUI.Toggle(new Rect(320, 50, 155f, 20f), CFG.Setting.hookd, menu.enru ? " <b> Lock Doors [N]</b>" : "  <b>Лок Замка [N]</b>");
                                CFG.Setting.test2 = GUI.Toggle(new Rect(320, 75, 170f, 20f), CFG.Setting.test2, menu.enru ? "  <b>Auth Doors [N]</b>" : "  <b>Авториз В Замке [N]</b>");
                                GUI.Label(new Rect(320, 100, 180, 30), string.Format(menu.enru ? "<b>Code AutoLock - Auth Code</b>" : "<b>Код Лок - Авторизация</b>", Color.red));
                                CFG.Setting.mmnb = GUI.Toggle(new Rect(500, 180, 170f, 20f), CFG.Setting.mmnb, menu.enru ? "  <b>Knock Door [B]</b>" : "  <b>Стучать в Дверь [В]</b>");

                                GUI.Label(new Rect(500, 200, 180, 30), string.Format(menu.enru ? "<b>FIELD OF VIEW - FOV</b>" : "<b>FIELD OF VIEW - FOV</b>", Color.red));

                                CFG.Setting.vov = GUI.HorizontalSlider(new Rect(500, 225, 160f, 25f), CFG.Setting.vov, 10f, 150f);
                                GUI.Label(new Rect(500, 219, 180f, 30f), string.Format(menu.enru ? "           <b>[{0:0.#}]</b>" : "           <b>[{0:0.#}]</b>", CFG.Setting.vov));

                                CFG.Setting.hghtrhf = GUI.Toggle(new Rect(500, 245, 160f, 20f), CFG.Setting.hghtrhf, menu.enru ? " <b> DebagCamera [Delete]</b>" : " <b> ДебагКамера [Delete]</b>");

                                CFG.Setting.debugg = GUI.HorizontalSlider(new Rect(500, 275, 160f, 25f), CFG.Setting.debugg, 0.5f, 5f);
                                GUI.Label(new Rect(500, 269, 180f, 30f), string.Format(menu.enru ? "      <b>SpeedDebug[{0:0.#}]</b>" : "      <b>СкоростьДебуг[{0:0.#}]</b>", CFG.Setting.debugg));
                                CFG.Setting.string_1 = GUI.TextArea(new Rect(320, 125, 50, 30), CFG.Setting.string_1, 4, "box");
                                GUI.Label(new Rect(320, 130, 150, 30), string.Format(" <b> _______</b>", Color.red));
                                CFG.Setting.ylylyy = GUI.Toggle(new Rect(320, 150, 170f, 20f), CFG.Setting.ylylyy, menu.enru ? " <b> Auto Upgrade [B]</b>" : " <b> Авто Улучшение [B]</b>");

                                CFG.Setting.fgghhh1 = (int)GUI.HorizontalSlider(new Rect(320, 180, 170f, 25f), CFG.Setting.fgghhh1, 0f, 3f);
                                GUI.Label(new Rect(320, 174, 180f, 30f), string.Format(ftf, CFG.Setting.fgghhh1));
                                CFG.Setting.spam = GUI.Toggle(new Rect(320, 200, 170f, 20f), CFG.Setting.spam, menu.enru ? " <b> Spam Chat</b>" : " <b> Спам Чат</b>");
                                CFG.Setting.string_11 = GUI.TextArea(new Rect(320, 225, 170f, 30), CFG.Setting.string_11, "box");
                                GUI.Label(new Rect(320, 230, 175, 30), string.Format("<b>________________________________</b>", Color.red));
                                GUI.Label(new Rect(320, 250, 170f, 25f), string.Format(menu.enru ? "      <b> Speed [Seconds]</b>" : "      <b> Скорость [Секунды]</b>", CFG.Setting.spamm));
                                CFG.Setting.spamm = GUI.HorizontalSlider(new Rect(320, 275, 170, 25f), CFG.Setting.spamm, 0f, 6f);
                                GUI.Label(new Rect(320, 269, 180f, 30f), string.Format("                   <b> {0:0.#}</b>", CFG.Setting.spamm));
                                CFG.Setting.frre = GUI.Toggle(new Rect(500, 50, 170, 20f), CFG.Setting.frre, menu.enru ? " <b> Add To Friends [Button-9]</b>" : "  <b>Add В Друзья [Кнопка-9]</b>");
                                if (GUI.Button(new Rect(500, 75, 178, 25f), menu.enru ? "<b>Delete Your Friends List</b>" : "<b>Удалить Список Друзей</b>"))
                                {
                                    if (CFG.Setting.friendsList != null && CFG.Setting.friendsList.Count > 0)
                                    {
                                        CFG.Setting.friendsList.Clear();
                                    }
                                }
                                CFG.Setting.png = GUI.Toggle(new Rect(500, 100, 160f, 20f), CFG.Setting.png, menu.enru ? "  <b>Uploading Рhotos [P]</b>" : "  <b>Загрузка Фото [P]</b>");

                                GUI.Label(new Rect(500, 125, 180, 30), string.Format(menu.enru ? "<b>Photo location</b>" : "<b>Расположение фото</b>", Color.red));
                                CFG.Setting.string_0 = GUI.TextArea(new Rect(500, 150, 180, 30), CFG.Setting.string_0, "box");
                                GUI.Label(new Rect(500, 155, 180, 30), string.Format("<b>________________________________</b>", Color.red));

                                break;
                            case menu.ta5.d4:


                                CFG.Setting.iopiop = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Setting.iopiop, menu.enru ? "<b>  Pickup Sulfur</b>" : " <b> Поднятие Серы</b>");
                                CFG.Setting.nbnhg = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Setting.nbnhg, menu.enru ? " <b> Pickup Metal</b>" : " <b> Поднятие Метала</b>");
                                CFG.Setting.vcgdcv = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Setting.vcgdcv, menu.enru ? " <b> Pickup Stone</b>" : " <b> Поднятие Камня</b>");
                                CFG.Setting.ff = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Setting.ff, menu.enru ? " <b> Pickup Wood</b>" : " <b> Поднятие Дерева</b>");
                                CFG.Setting.asarwad = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Setting.asarwad, menu.enru ? "<b>  Pickup Hemp</b>" : " <b> Поднятие Ткани</b>");
                                CFG.Setting.mnbvc = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Setting.mnbvc, menu.enru ? " <b> Pickup Pumpkins</b>" : " <b> Поднятие Тыквы</b>");
                                CFG.Setting.ooppoo = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.Setting.ooppoo, menu.enru ? " <b> Pickup Corn</b>" : "  <b>Поднятие Кукурузы</b>");
                                CFG.Setting.adfsaa = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Setting.adfsaa, menu.enru ? " <b> Pickup Mushroom</b>" : "  <b>Поднятие Грибов</b>");
                                CFG.Setting.adsfbc = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.Setting.adsfbc, menu.enru ? " <b> Pickup Dropped Item</b>" : " <b> Поднятие Предметов</b>");
                                CFG.Setting.yyttrrfff = GUI.Toggle(new Rect(290, 50, 170f, 20f), CFG.Setting.yyttrrfff, menu.enru ? " <b> Auto Drink</b>" : " <b> Авто Бухло</b>");
                                CFG.Setting.bvbvn = GUI.Toggle(new Rect(520, 50, 170f, 20f), CFG.Setting.bvbvn, menu.enru ? "  <b>AutoFarm Stones</b>" : " <b> Авто Фарм Камни</b>");
                                CFG.Setting.hgf = GUI.Toggle(new Rect(520, 75, 170f, 20f), CFG.Setting.hgf, menu.enru ? " <b> AutoFarm Barrels</b>" : " <b> Авто Фарм Бочки</b>");
                                CFG.Setting.tree = GUI.Toggle(new Rect(520, 100, 170f, 20f), CFG.Setting.tree, menu.enru ? "  <b>AutoFarm Tree</b>" : " <b> Авто Фарм Дерево</b>");
                                CFG.Setting.animal = GUI.Toggle(new Rect(520, 125, 170f, 20f), CFG.Setting.animal, menu.enru ? "  <b>AutoAttack Animal</b>" : " <b> Авто Атака Животных</b>");
                                CFG.Setting.xyi = GUI.Toggle(new Rect(520, 150, 170f, 20f), CFG.Setting.xyi, menu.enru ? "  <b>Auto On Torch</b>" : " <b> Авто Вкл Факел</b>");
                                CFG.Setting.adsafsddvcvc = GUI.Toggle(new Rect(290, 75, 170f, 20f), CFG.Setting.adsafsddvcvc, menu.enru ? " <b> Auto Auth In The Turret</b>" : "  <b>Авто Авториз В Турели</b>");

                                CFG.Setting.vbfgcvvcv = GUI.Toggle(new Rect(290, 100, 170f, 20f), CFG.Setting.vbfgcvvcv, menu.enru ? " <b> Auto Lifting Mine/Trap</b>" : " <b> Авто Поднятие Мины/Капканы</b>");

                                CFG.Setting.oiuytgbmnb = GUI.Toggle(new Rect(290, 125, 185f, 20f), CFG.Setting.oiuytgbmnb, menu.enru ? "  <b>Clear and Auth in the Cupboard[U]</b>" : "  <b>Очистка и Авториз в Шкафу [U]</b>");

                                CFG.Setting.hhhfg = GUI.Toggle(new Rect(290, 150, 170f, 20f), CFG.Setting.hhhfg, menu.enru ? " <b> Remove Walls and etc [C]</b>" : " <b> Ремув Стены и тд [C]</b>");
                                CFG.Setting.authh = GUI.Toggle(new Rect(290, 175, 170f, 20f), CFG.Setting.authh, menu.enru ? "  <b>Loot a Corpse-5m [B]</b>" : "  <b>Лутать Труп-5м [B]</b>");




                                break;
                            case menu.ta5.d5:




                                break;
                        }
                    }

                    break;

            }
        }
        GUI.DragWindow();
    }
    public static bool govno2;
    public string WH = "OFF";
    public static bool grass1;
    public static bool grass;
    public static bool spoof;
    public static bool animal;
    public static bool trag;
    public static bool turr;
    public static bool h;
    public static bool sleep;
    public static bool bbf;
    public static bool heli;

    private void Main11(int id)
    {


        Enum @enum = tab2;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {

                case menu.tab.f10:




                    break;
            }
        }
        GUI.DragWindow();
    }
    private void auth(int id)
    {
        if (GUI.Button(new Rect(1, 15, 99, 25f), "<b>198 Dev</b>"))
        {
            menu.df = 0;
            menu.fgf = false;
            menu.gui = true;
        }
        if (GUI.Button(new Rect(1, 40, 99, 25f), "<b>196 Dev</b>"))
        {
            menu.df = 1;
            menu.fgf = false;
            menu.gui = true;
        }

        GUI.DragWindow();
    }
    public static bool asd;
    public static bool tree;
    public static bool time;
    private void Main111(int id)
    {


        Enum @enum = currentTab11;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {

                case menu.tab.f8:

                    break;
            }
        }
        GUI.DragWindow();
    }
    public static int df;
    public static string ftff;
    public static string ftf;
    public static void yffff()
    {
        int ggc = CFG.Setting.fgghhh1;
        switch (ggc)
        {
            case 0:
                fdgdfgdfg = BuildingGrade.Enum.Wood;
                menu.ftf = menu.enru ? "              <b>Wood</b>" : "           <b>   Дерево</b>";
                break;
            case 1:
                fdgdfgdfg = BuildingGrade.Enum.Stone;
                menu.ftf = menu.enru ? "             <b> Stone</b>" : "        <b>      Камень</b>";
                break;
            case 2:
                fdgdfgdfg = BuildingGrade.Enum.Metal;
                menu.ftf = menu.enru ? "             <b> Metal</b>" : "            <b>  Метал</b>";
                break;
            case 3:
                fdgdfgdfg = BuildingGrade.Enum.TopTier;
                menu.ftf = menu.enru ? "             <b> Armored</b>" : "          <b>    МВК</b>";
                break;





        }
    }
    public static void yfffff()
    {
        int ggc = CFG.Setting.fgghhhh;
        switch (ggc)
        {
            case 0:
                b = -1f;
                menu.ftff = menu.enru ? "         <b>     Left</b>" : "        <b>      Лево</b>";
                break;
            case 1:
                b = 0f;
                menu.ftff = menu.enru ? "           <b>   Center</b>" : "        <b>      Центер</b>";
                break;
            case 2:
                b = 1f;
                menu.ftff = menu.enru ? "            <b>  Right</b>" : "       <b>       Право</b>";
                break;
        }
    }
    public static string arrra;
    public static int fdfd;
    public static void yffffff()
    {
        System.Random rand1 = new System.Random();
        int ggc = CFG.Setting.fdfd;
        switch (ggc)
        {
            case 0:
                hhh = 100f;
                menu.arrra = menu.enru ? "          <b>    Down</b>" : "         <b>     Вниз</b>";
                break;
            case 1:
                hhh = 0f;
                menu.arrra = menu.enru ? "           <b>   None</b>" : "         <b>     В Перёд</b>";
                break;
            case 2:
                hhh = -100f;
                menu.arrra = menu.enru ? "           <b>   Up</b>" : "           <b>   Верх</b>";
                break;
            case 3:

                hhh = rand1.Next(-100, 100);
                menu.arrra = menu.enru ? "            <b>  Random</b>" : "         <b>     Рандом</b>";
                break;
        }
    }


    private void GG()
    {
        UnityEngine.Object.Destroy(nWTAsSXPzaMv.wbcOKNDbFMC6.gameObject);

    }
    private readonly Enum currentTab11 = menu.tab.f8;
    private readonly Enum tab2 = menu.tab.f10;


    private Enum ff = menu.tab.f10;
    private enum tab
    {
        f1,
        f2,
        f3,
        f4, f7, f9, f8, f10, f11, f12, f13,
        f5,
        f6

    }

    private Enum neww = menu.ta1.d1;
    private enum ta1
    {
        d1,
        d2,
        d3,
        d4, f7, f9, f8, f10, f11, f12, f13,
        d5,
        d6

    }
    private Enum neww1 = menu.ta2.d1;
    private enum ta2
    {
        d1,
        d2,
        d3,
        d4, f7, f9, f8, f10, f11, f12, f13,
        d5,
        f6

    }
    private Enum neww2 = menu.ta3.d1;
    private enum ta3
    {
        d1,
        d2,
        d3,
        d4, f7, f9, f8, f10, f11, f12, f13,
        d5,
        f6

    }
    private Enum neww3 = menu.ta4.d1;
    private enum ta4
    {
        d1,
        d2,
        d3,
        d4, f7, f9, f8, f10, f11, f12, f13,
        d5,
        f6

    }
    private Enum neww4 = menu.ta5.d1;
    private enum ta5
    {
        d1,
        d2,
        d3,
        d4, f7, f9, f8, f10, f11, f12, f13,
        d5,
        f6

    }


    public static float hhh;
    public static int sped;
    public static float hh;
    public static int fgghhhh;
    public static float bbb;
    public static float b;
    public static float bb;

    public static bool fgf = true;
    public static bool gf;

    public static bool skin = true;
    public static bool ggggf;
    public static bool gggf;


    public static bool gggg = false;
    public static bool ggggg = false;
    public static bool gggggg = false;
    public static bool ggg = false;
    public static bool enru = false;
    public static bool frre = false;
    private static Rect auuth = new Rect(20, 50, 101, 66);
    private static Rect main11 = new Rect(530, 50, 200, 270);
    private static Rect main1 = new Rect(735, 50, 200, 270);
    private static Rect main = new Rect(20f, 50f, 706f, 305f);
    public static BaseHelicopter targetPlayer1 = null;
    public static bool gui = false; public static bool gui1; public static bool mili;
    public static float fov; public static int fgghhh;
    public static bool asdas = false; public static bool traf = false;
    public static bool bvbgfg = false; private GUISkin gg;
    public static float fov1; public static bool gui11; public static bool nnn = false; public static bool nnnn = false;
    public static bool hghg = false; public static bool sd = false;
    public static bool hhhfg = false; public static bool bbbb = false;
    public static bool mbnbnm = false; public static bool vvvv = false;
    public static bool mmmm = false; public static bool rrrr = false;
    public static bool test = false;
    public static bool test1 = false;
    public static bool test2 = false;
    public static bool test3 = false;
    public static bool test4 = false;
    public static bool test41 = false;

    public static bool test411 = false;
    public static bool Cloth = false;
    public static bool tt = false;

    public static bool grr = false;
    public static bool fast = false;
    public static bool hot = false;
    public static bool bag = false;
    public static bool spin = false;
}
