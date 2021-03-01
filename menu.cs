using UnityEngine;
using ProtoBuf;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using Microsoft.Win32;
using System.Linq;
using UnityEngine.Rendering;
using Facepunch;
using UnityEngine.Events;
using UnityEngine.UI;
using ConVar;

using Steamworks;
using Rust;
using System.Net;
using static UnityEngine.GUI;
using Facepunch.Extend;

public class menu : MonoBehaviour
{
    private void Start()
    {
        ChangeMaxValue();
        base.StartCoroutine(this.spaaam());
        base.StartCoroutine(this.g11());
        base.StartCoroutine(this._Update()); 
        Drawing.Initialize(); 

    }
    public static bool sleep;
  
    private IEnumerator g11()
    {
        while (true)
        {
            try
            {

                bool flag = menu.hhhfg && LocalPlayer.Entity != null && UnityEngine.Input.GetKey((KeyCode.C));
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
    void Awake()
    {
        string_0 = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "pic.png");
    }
    void Awake1()
    {
        ftf = "Wood";
    }
    void Awake11()
    {
        ftff = "Center";
    }
    void Awake111()
    {
        arrra = "Center";
    }
    void fff()
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
        if (menu.movement != null && CFG.Misc.HGHGH)
        {
            menu.movement.gravityMultiplier = 1.35f;
        }
        if (menu.movement != null && !CFG.Misc.HGHGH)
        {
            menu.movement.gravityMultiplier = 2.5f;
        }
    } 
    public GUISkin KLear()
    {
        

        return skin;
    }

    public Texture2D textureColor(Color color)
    {
        Texture2D texture2D = new Texture2D(1, 1);
        texture2D.SetPixel(0, 0, color);
        texture2D.Apply();
        return texture2D;
    }
    private void OnGUI()
    {

        if (gggf)
        {
            Players.PlayerColor = Players.randomColor;
        }

        SuperJump();
        
        if (LocalPlayer.Entity != null && CFG.Misc.ggdfggg)

        {
            buil();
        }
        if (CFG.Misc.ylylyy && UnityEngine.Input.GetKeyDown(KeyCode.Keypad4))
        {
            foreach (BuildingBlock codeLock in companent.shit)
            {
                int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.eyes.transform.position, codeLock.transform.position);
                if (codeLock != null && (float)lock_distance <= sp1ed && codeLock.grade != (int)BuildingGrade.Enum.Twigs)

                {
                    codeLock.ServerRPC("DoUpgradeToGrade", (int)menu.fdgdfgdfg, null, null, null, null);
                }
            }

        }
       
        if (menu.test2 && UnityEngine.Input.GetKeyDown(KeyCode.N))
        {
            foreach (CodeLock codelock in companent.door)
            {

                if (codelock != null)
                {
                   
                    int lock_distance = (int)Vector3.Distance(LocalPlayer.Entity.eyes.transform.position, codelock.transform.position);
                    if (codelock != null && codelock.IsLocked() && lock_distance <= 3f )
                    {
                        codelock.ServerRPC("UnlockWithCode", string_1, false);
                        codelock.ServerRPC("TryLock", null, null, null, null, null);
                    }
                }
            }
        }


        
        if (CFG.Misc.png)
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.P))
            {
                if (File.Exists(string_0))
                {
                    Texture2D texture2D = new Texture2D(1, 1);
                    byte[] array = File.ReadAllBytes(string_0);
                    if (!ImageConversion.LoadImage(texture2D, array))
                    {
                        return;
                    }
                    MeshPaintable[] array2 = UnityEngine.Object.FindObjectsOfType<MeshPaintable>();
                    foreach (MeshPaintable meshPaintable in array2)
                    {
                        meshPaintable.DrawTexture(Vector2.one * 0.5f, (float)meshPaintable.textureWidth, (float)meshPaintable.textureHeight, texture2D, Color.white);
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
     
        yffffff();
        yfffff();
        yffff();
       
        if (CFG.Aimbot.FOV)
        {
            GUI.color = Color.white;
            Drawing.DrawCircle(new Vector2(Screen.width / 2, Screen.height / 2), menu.fov, new Color32(255, 0, 0, 255), 1f, true, 30); GUI.color = Color.white;
        }
    
        if (CFG.Aimbot.FOV11)
        {
            GUI.color = Color.white;
            Drawing.DrawCircle(new Vector2(Screen.width / 2, Screen.height / 2), menu.fov1, Color.blue, 1f, true, 30); GUI.color = Color.white;
        }
        if (CFG.Aimbot.FOV1)
        {
            Drawing.DrawCircle(new Vector2(Screen.width / 2, Screen.height / 2), menu.fov, randomColor, 1f, true, 30);
            GUI.color = Color.white; GUI.color = Color.white;
        }
       
        
            if (menu.gui)
            {
            rr();
            }
            if (menu.gui1)
            {
                if (menu.gui)
            this.Render1();
            }
            if (menu.gui11)
            {
                if (menu.gui)
            this.Render11();
            }
        
        if (CFG.ESP.players || CFG.ESP.fdf || CFG.ESP.vbvc)
        {
            Players.DrawPlayerESP();
        }

        if (CFG.Aimbot.aimm && UnityEngine.Input.GetKey(KeyCode.X) && LocalPlayer.Entity != null)

        {
            aimbots.Aim();
        }
        if (menu.asdas && UnityEngine.Input.GetKey(KeyCode.X) && LocalPlayer.Entity != null)

        {
            aimbot.Aim();
        }
        if (menu.bvbgfg && UnityEngine.Input.GetKey(KeyCode.X))

        {

            aimheli.aimhel();
        }
        bool flag111 = menu.localplayer1 == null;
        if (flag111)
        {
            foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
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
            foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
            {
                bool flag2 = basePlayer.IsLocalPlayer();
                if (flag2)
                {
                    menu.localplayer = basePlayer;
                }
            }
        }


        if (CFG.Misc.cccvvbbbffdd && UnityEngine.Input.GetKey(KeyCode.Z))
        {
            foreach (BasePlayer player in BasePlayer.visiblePlayerList)
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

        if (menu.spam)

        {
            this.spaaam();
        }
        randomColor = new Color(
     Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
     Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
     Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);



        if (menu.grr)
        {
            GUI.DrawTexture(new Rect((float)Screen.width / 2 - 16, (float)Screen.height / 2 - 16, 32f, 32f), HukTexture.mTex3);
        }
        if (CFG.Aimbot.crrr)
        {
            GUI.DrawTexture(new Rect((float)Screen.width / 2 - 16, (float)Screen.height / 2 - 16, 32f, 32f), HukTexture.mTex2);
        }

    }
    private IEnumerator spaaam()
    {

        while (true)
        {
            try
            {
                if (menu.spam)

                {
                    ConsoleSystem.Run.Client.Quiet("chat.say", new object[]
                {
                        menu.string_11
                }) ;

                }
            }
            catch
            {
            }
            yield return new WaitForSeconds(menu.spamm);
        }
    }


    public static Vector3 rrr = new Vector3(0f, 0f, 10f);
    public static GameObject gfghghgh = null;
    public static void teleport()
    {
        RaycastHit raycastHit = default(RaycastHit);
        bool flag = UnityEngine.Physics.Raycast(LocalPlayer.Entity.eyes.HeadRay(), out raycastHit);
        bool flag2 = flag;
        if (flag2)
        {
            menu.rrr = raycastHit.point;
            menu.gfghghgh = raycastHit.transform.gameObject;
        }
    }
    public static float spamm;
    public static bool spam = false;
    private static float float_0; public static BasePlayer localplayer;
    private float distance; public static BasePlayer localplayer1;
    public static int govno;
    private void Update()
    {
        if (gov)
        {
            if (menu.localplayer != null)
            {
                menu.localplayer.playerFlags =   BasePlayer.PlayerFlags.IsAdmin  ;


            }
        }
        if (menu.gf)
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
            
            foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
            {
                if (govno == 1 && basePlayer != null && (int)Vector3.Distance(LocalPlayer.Entity.transform.position, basePlayer.transform.position) <= 2.8 && !basePlayer.IsLocalPlayer() && !basePlayer.IsSleeping() && !basePlayer.IsDead() && !basePlayer.IsWounded())
                {
                    Vector3 position = basePlayer.eyes.transform.position;
                    Vector3 vector = basePlayer.eyes.BodyForward();
                    Vector3 position2 = new Vector3(position.x + -vector.x + b, position.y + 0.35f, position.z + -vector.z + 0.4f);
                    LocalPlayer.Entity.movement.transform.position = position2;
                    
                }
            }

        }
        randomColor = new Color(
          Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
          Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
          Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);
        bool flag = LocalPlayer.Entity != null;
        if (flag)
        {
            bool tpp = CFG.Misc.df && UnityEngine.Input.GetKey(KeyCode.Z);
            if (tpp)
            {
                LocalPlayer.Entity.eyes.source.position = rrr;
            }
        }

        if (CFG.Misc.adadadaa)
        {
            LocalPlayer.Entity.selectedViewMode++;
            if (LocalPlayer.Entity.selectedViewMode > BasePlayer.CameraMode.FirstPerson)
            {
                LocalPlayer.Entity.selectedViewMode = BasePlayer.CameraMode.ThirdPerson;
            }
        }
        if (CFG.Misc.df)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
            {
                if (basePlayer2.IsLocalPlayer())
                {
                    typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                    typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                }
            }
        }

        if (CFG.Misc.bbbbvvv)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
            {
                if (basePlayer2.IsLocalPlayer())
                {
                    typeof(PlayerWalkMovement).GetField("groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                    typeof(PlayerWalkMovement).GetField("grounded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, true);
                    typeof(PlayerWalkMovement).GetField("groundAngle", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(basePlayer2.movement, 0f);
                }
            }
        }

        if (CFG.Misc.hghtrhf && UnityEngine.Input.GetKeyDown(KeyCode.Delete))
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
        bool flag8 = CFG.Misc.bbbvvvccc;
        if (flag8)
        {
            menu.eka();
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.N))
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
                if (menu.mili)
                {
                    mil.attackRadius = 360;

                    mil.maxDistance = 4.5f;
                    
                }
            }
           
        }

    }



    public static bool rrrrr;
    public static void ProjectileHacks()
    {
        foreach (BaseProjectile baseProjectile in companent.rojectile)
        {
            if (!(baseProjectile == null))
            {
                if (CFG.Aimbot.vvvv)
                {
                    baseProjectile.automatic = true;
                }
              
               
                    if (CFG.Aimbot.dgvcbb)
                    {
                        baseProjectile.recoil = null;
                    }
                
                if (CFG.Aimbot.yyttff)
                {
                    baseProjectile.aimSway = 0f;
                    baseProjectile.aimSwaySpeed = 0f;
                    baseProjectile.aimCone = 0f;
                    baseProjectile.hipAimCone = 0f;
                }
              
              
            }
            
        }
    }

    private static FieldInfo ni = typeof(BaseProjectile).GetField("Reload", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
    private IEnumerator _Update()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(0f);
            try
            {
                if (!(LocalPlayer.Entity == null))
                {

                    if (CFG.Aimbot.yyttff || CFG.Aimbot.dgvcbb || CFG.Aimbot.vvvv)
                    {
                        menu.ProjectileHacks();
                    }
                    if (menu.mili)
                    {
                        menu.millll();
                    }
                    if (movement == null && CFG.Misc.HGHGH)
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
        menu.fov = 160f;
        menu.fov1 = 180;
        menu.spamm = 3;
        menu.bb = 0.4f;
        menu.fgghhhh = 1;
        menu.hhh = 100f;
        menu.sped = 10;
        menu.sp1ed = 2;
    }

    private static UnityEngine.Color youabitch = new UnityEngine.Color(0.4f, 0.4f, 0.4f, 0.4f);
    public TOD_Sky SkyObj;



    private static Color randomColor;
    float speedR, speedG, speedB, speedMultiple = 1f;


    void ChangeMaxValue()
    {
        speedR = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedG = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedB = UnityEngine.Random.Range(20, 50) * speedMultiple;
    }

   
    

    private float deltaTime;
    private static void rr()

    {
        menu.main = GUI.Window(1, menu.main, new GUI.WindowFunction(Main1), "");

    }
    private void Render1()

    {

        menu.main1 = GUI.Window(2, menu.main1, new GUI.WindowFunction(this.Main11), menu.enru ? "" : "");
    }
    private void Render11()

    {

        menu.main11 = GUI.Window(3, menu.main11, new GUI.WindowFunction(this.Main111), menu.enru ? "" : "");
    }
    public static PlayerWalkMovement movement;
    public static void eka()
    {
        bool flag = CFG.Misc.bbbvvvccc;
        if (flag)
        {
            foreach (FlintStrikeWeapon flintStrikeWeapon in companent.strike)
            {
                LocalPlayer.Entity.belt.GetActiveItem();
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


  
    public static Color col = new Color(0f, 0f, 0f, 0.5f);

    public static bool zalypa1;

    public static bool zalypa;
    private static void Main1(int id)
    {
    GUI.color = randomColor;
        GUI.backgroundColor = randomColor;
        GUI.Box(new Rect(2f, 2f, 496, 301), "Deft Solutions[Koder] + Soplejuikin + Deko[Paster]");
        GUI.Box(new Rect(2f, 2f, 496, 301), "Deft Solutions[Koder] + Soplejuikin + Deko[Paster]");
        GUI.Box(new Rect(2f, 2f, 496, 301), "Deft Solutions[Koder] + Soplejuikin + Deko[Paster]");
        GUI.Box(new Rect(2f, 2f, 496, 301), "Deft Solutions[Koder] + Soplejuikin + Deko[Paster]");
        GUI.Box(new Rect(2f, 2f, 496, 301), "Deft Solutions[Koder] + Soplejuikin + Deko[Paster]");
        GUI.backgroundColor = Color.white;
        GUI.color = Color.white;
        if (GUI.Button(new Rect(3, 20f, 100, 25f), menu.enru ? "Players" : "Игроки"))
        {

            ff = menu.tab.f1;

        }
        if (GUI.Button(new Rect(3, 45, 100, 25f), menu.enru ? "Silent Aim" : "Silent Aim"))
        {
            ff = menu.tab.f2;
        }
        if (GUI.Button(new Rect(3, 70, 100, 25f), menu.enru ? "Weapon MOD" : "Оружие МОД"))
        {
           ff = menu.tab.f3;
        }
        if (GUI.Button(new Rect(3, 95, 100, 25f), menu.enru ? "Aim Bot" : "Аим Бот"))
        {
            ff = menu.tab.f4;
        }

        if (GUI.Button(new Rect(3, 120, 100, 25f), menu.enru ? "Player MOD" : "Игрок МОД"))
        {
            ff = menu.tab.f5;
        }
        if (GUI.Button(new Rect(3, 145, 100, 25f), menu.enru ? "Automation" : "Автоматика"))
        {
            ff = menu.tab.f7;
        }
        if (GUI.Button(new Rect(3, 170, 100, 25f), menu.enru ? "ESP" : "ESP"))
        {
            ff = menu.tab.f9;
        }
        if (GUI.Button(new Rect(3, 195, 100, 25f), menu.enru ? "Resources" : "Ресурсы"))
        {
            ff = menu.tab.f10;
        }
        if (GUI.Button(new Rect(3, 220, 100, 25f), menu.enru ? "Radar/Add" : "Радар/Доп"))
        {
            ff = menu.tab.f12;
        }
        if (GUI.Button(new Rect(3, 245, 100, 25f), menu.enru ? "Additional" : "Дополнение"))
        {
            ff = menu.tab.f13;
        }
        if (GUI.Button(new Rect(3, 270, 100, 25f), menu.enru ? "<color=#FF0000>!UNLOAD!</color>" : "<color=#FF0000>!ВЫГРУЗКА!</color>"))
        {
            ESP.свет = false;
            CFG.Misc.eeeeeeeee = false;
            CFG.Aimbot.sdfewewdff = false;
            GG();
        }
        if (GUI.Button(new Rect(445, 4, 50, 25f), "EN/RU"))
        {
            menu.enru = !menu.enru;
        }
        Enum @enum =  ff;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {
                case menu.tab.f1:
                    hp = GUI.Toggle(new Rect(190, 25f, 120f, 20f), hp, (menu.enru ? "  Bar HP" : "  Бар HP"));
                    xp = GUI.Toggle(new Rect(190, 50f, 120f, 20f), xp, (menu.enru ? "  XP and LVL" : "  XP и LVL"));
                    steam = GUI.Toggle(new Rect(190, 75, 40, 20f), steam, (menu.enru ? "  ID" : " ID"));
                    CFG.ESP.players = GUI.Toggle(new Rect(111, 25f, 80f, 20f), CFG.ESP.players, (menu.enru ? "  Players" : "  Игроки"));
                    CFG.ESP.fdf = GUI.Toggle(new Rect(111, 50f, 80f, 20f), CFG.ESP.fdf, (menu.enru ? "  Sleeping" : "  Спящие"));
                    CFG.ESP.dgdg = GUI.Toggle(new Rect(111, 75, 90f, 20f), CFG.ESP.dgdg, (menu.enru ? "  Box" : "  Боксы"));
                    CFG.ESP.gggf = GUI.Toggle(new Rect(111, 100, 130f, 20f), CFG.ESP.gggf, (menu.enru ? "  Holds in hands" : "  Держит в руках"));
                    CFG.ESP.bb = GUI.Toggle(new Rect(111, 125, 120f, 20f), CFG.ESP.bb, (menu.enru ? "  Inventory" : "  Инвентарь"));
                    menu.Cloth = GUI.Toggle(new Rect(111, 150, 120f, 20f), menu.Cloth, (menu.enru ? "  Clothing" : "  Одежда"));
                    menu.hot = GUI.Toggle(new Rect(111, 175, 120f, 20f), menu.hot, (menu.enru ? "  Hotbar" : "  Ремень"));
                    CFG.ESP.dgdgd = GUI.Toggle(new Rect(111, 200, 120f, 20f), CFG.ESP.dgdgd, (menu.enru ? "  Corpse" : "  Труп"));
                    CFG.Aimbot.gggg = GUI.Toggle(new Rect(111, 225, 120f, 20f), CFG.Aimbot.gggg, (menu.enru ? "  Target Label" : "  Метка Цели"));
                    CFG.ESP.greg = GUI.Toggle(new Rect(111, 250, 120f, 20f), CFG.ESP.greg, (menu.enru ? "  Line To Target" : "  Линия До Цели"));
                    CFG.ESP.vbvc = GUI.Toggle(new Rect(111, 275, 100f, 20f), CFG.ESP.vbvc, (menu.enru ? "  NPC" : "  NPC"));

                    GUI.Label(new Rect(255, 50, 180f, 30f), string.Format((menu.enru ? "        Players Distance" : "        Игроки Дистанция"), CFG.ESP.sdd));
                    CFG.ESP.sdd = (int)GUI.HorizontalSlider(new Rect(255, 75, 160f, 25f), CFG.ESP.sdd, 0f, 3000f);

                    GUI.Label(new Rect(255, 68, 180f, 30f), string.Format("              {0}", CFG.ESP.sdd));


                    if (GUI.Button(new Rect(280, 220, 25, 25f), "<size=20><color=#3cb371>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(128, 255, 128, 255);
                    }
                    if (GUI.Button(new Rect(320, 220, 25, 25f), "<size=20><color=#008000>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(0, 255, 0, 255);
                    }
                    if (GUI.Button(new Rect(360, 220, 25, 25f), "<size=20><color=#FFA500>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(255, 255, 75, 255);
                    }
                    if (GUI.Button(new Rect(400, 220, 25, 25f), "<size=20><color=#cd5c5c>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(255, 0, 0, 125);
                    }
                    if (GUI.Button(new Rect(440, 220, 25, 25f), "<size=20><color=#FF0000>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(255, 0, 0, 255);
                    }
                    if (GUI.Button(new Rect(280, 245, 25, 25f), "<size=20><color=#800080>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(50, 10, 75, 255);
                    }
                    if (GUI.Button(new Rect(320, 245, 25, 25f), "<size=20><color=#00FFFF>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(50, 220, 255, 255);
                    }
                    if (GUI.Button(new Rect(360, 245, 25, 25f), "<size=20><color=#FF6347>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(254, 158, 151, 148);
                    }
                    if (GUI.Button(new Rect(400, 245, 25, 25f), "<size=20><color=#F5F5F5>██                                                                      </color></size>" + menu.gui1.ToString().ToLower(), ""))
                    {
                        Players.PlayerColor = new Color32(255, 255, 255, 255);
                    }
                    if (gggf = GUI.Toggle(new Rect(443, 248, 25, 25f), gggf, ""))
                    {
                        ggggf = !ggggf;
                    }
                    Rendering.DrawString(new Vector2(439.5f, 242f), string.Format("<size=20>██                                                                      </size>", (int)(1f / float_0)), Players.randomColor, false, 5, FontStyle.Bold);


                    break;
                case menu.tab.f2:
                    CFG.Aimbot.ssddd = GUI.Toggle(new Rect(111, 25f, 120f, 20f), CFG.Aimbot.ssddd, (menu.enru ? "  Silent Players    <color=#FF0000>=</color>" : "  Сало Игроки    <color=#FF0000>=</color>"));
                    CFG.Aimbot.cbvcbcd = GUI.Toggle(new Rect(250, 25, 170f, 20f), CFG.Aimbot.cbvcbcd, (menu.enru ? "  Silent Body" : "  Сало Тело"));
                    CFG.Aimbot.uytgff = GUI.Toggle(new Rect(111, 50, 120, 20f), CFG.Aimbot.uytgff, (menu.enru ? "  Silent Wall    <color=#FF0000>=</color>" : "  Сало Стены    <color=#FF0000>=</color>"));
                    CFG.Aimbot.fdsfdsfew = GUI.Toggle(new Rect(250, 50, 170f, 20f), CFG.Aimbot.fdsfdsfew, (menu.enru ? "  Silent Body" : "  Сало Тело"));
                    CFG.Misc.cahh = GUI.Toggle(new Rect(111, 75, 160f, 20f), CFG.Misc.cahh, (menu.enru ? "  Silent Player [Clamp-X]  <color=#FF0000>=</color>" : "  Silent Игрок [Зажать-X]  <color=#FF0000>=</color>"));
                    CFG.Aimbot.bbccvvdd = GUI.Toggle(new Rect(300, 75, 170f, 20f), CFG.Aimbot.bbccvvdd, (menu.enru ? "  Silent Body" : "  Silent Тело"));
                    CFG.Aimbot.BulletDropPrediction = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Aimbot.BulletDropPrediction, (menu.enru ? "  Silent Heli [Clamp-X]" : "  Верт Сало [Зажать-X]"));
                    CFG.Aimbot.qewqefdsf = GUI.Toggle(new Rect(111, 275, 177f, 20f), CFG.Aimbot.qewqefdsf, (menu.enru ? "  Animal Silent [Clamp-X]" : "  Животные Сало [Зажать-X]"));
                    heli = GUI.Toggle(new Rect(111, 250, 177f, 20f), heli, (menu.enru ? "  Heli Silent" : " Верталёт Сало"));
                    CFG.Aimbot.dffs = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Aimbot.dffs, (menu.enru ? "  Silent Players[F]" : "  Сало Игроки[F]"));
                   ф = GUI.Toggle(new Rect(111, 125, 170f, 20f), ф, (menu.enru ? "  Silent Body " : "  Сало Тело "));
                    CFG.Misc.rrrar = GUI.Toggle(new Rect(111, 150, 120f, 20f), CFG.Misc.rrrar, (menu.enru ? "  Silemt Melee    <color=#FF0000>=</color>" : "  Сало Близь    <color=#FF0000>=</color>"));
                    CFG.Misc.tt = GUI.Toggle(new Rect(250, 150, 170f, 20f), CFG.Misc.tt, (menu.enru ? "  Silent Melee Body" : "  Сало Близь Тело"));
                    CFG.Misc.milll = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Misc.milll, (menu.enru ? "  Silent Melee Wall" : "  Сало Близь Через Стены"));
                    menu.mili = GUI.Toggle(new Rect(111, 200, 170f, 20f), menu.mili, (menu.enru ? "  Beat at the Distance" : "  Бить на Дистанции"));
                    CFG.Aimbot.FOV11 = GUI.Toggle(new Rect(305, 275, 150f, 20f), CFG.Aimbot.FOV11, (menu.enru ? "  FOV" : "  FOV"));
                    GUI.Label(new Rect(289, 225, 180f, 30f), string.Format((menu.enru ? "              FOV Silent" : "              FOV Сайлент"), menu.fov1));

                    menu.fov1 = (int)GUI.HorizontalSlider(new Rect(295, 250, 165f, 25f), menu.fov1, 0f, 480);
                    GUI.Label(new Rect(289, 243, 180f, 30f), string.Format("                    {0}", menu.fov1));



                    break;
                case menu.tab.f3:

                      
                        CFG.Aimbot.dgvcbb = GUI.Toggle(new Rect(111, 25, 170f, 20f), CFG.Aimbot.dgvcbb, menu.enru ? "  OFF Recoil" : "  Отключение Отдачи");
                    

                    gov = GUI.Toggle(new Rect(280, 100, 180f, 20f), gov, menu.enru ? "  IsAdmin[Noclip-BAN]" : "  Админ Hack[Noclip-BAN]");
                    garss1 = GUI.Toggle(new Rect(280, 125, 180f, 20f), garss1, menu.enru ? "  Silent шкаф[50m]" : "  Silent шкаф[50m]");
                    grass = GUI.Toggle(new Rect(280, 150, 180f, 20f), grass, menu.enru ? "  Shoot Through Terrain" : "  Стрелять Cквозь Землю");
                    CFG.Aimbot.yyttff = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Aimbot.yyttff, menu.enru ? "  No Sway" : "  Нет Тряски");
                    CFG.Aimbot.vvvv = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Aimbot.vvvv, menu.enru ? "  Automatic" : "  Автоматика");
                    CFG.Aimbot.cdddeee = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Aimbot.cdddeee, menu.enru ? "  No Spread" : "  Нет Разброса");
                    gfgfg = GUI.Toggle(new Rect(111, 125, 170f, 20f), gfgfg, menu.enru ? "  Auto Reload" : "  Авто Перезарядка");
                    CFG.Misc.bbbvvvccc = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Misc.bbbvvvccc, menu.enru ? "  Eoka with 1 shot" : "  Ёка с 1 Выстрела");
                    CFG.Misc.hyk = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Misc.hyk, menu.enru ? "  Fast Bow" : "  Быстрый Лук");
                    CFG.Aimbot.dfdswe = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.Aimbot.dfdswe, menu.enru ? "  Shoot As You Like" : "  Стрелять Как Угодно");
                    CFG.Aimbot.sdfewewdff = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Aimbot.sdfewewdff, menu.enru ? "  Thick Bullets" : "  Толстые Пули");
                    CFG.Aimbot.vcgrrrr = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.Aimbot.vcgrrrr, menu.enru ? "  No Bullet Gravity" : "  Нет Гравитации Пуль");
                    CFG.Aimbot.uuyyttrrr = GUI.Toggle(new Rect(280, 225, 170f, 20f), CFG.Aimbot.uuyyttrrr, menu.enru ? "  Thick Tools" : "  Толстые Инструменты");
                    CFG.Aimbot.hhhh = GUI.Toggle(new Rect(280, 250, 170f, 20f), CFG.Aimbot.hhhh, menu.enru ? "  No Gravity Tools" : "  Нет Гравитации Инструменты");


                    break;
                case menu.tab.f4:
                    CFG.Aimbot.FOV = GUI.Toggle(new Rect(111, 150, 150f, 20f), CFG.Aimbot.FOV, menu.enru ? "  FOV" : "  FOV");
                    CFG.Aimbot.FOV1 = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Aimbot.FOV1, menu.enru ? "  Raduga FOV" : "  Радужный - FOV");

                    asdas = GUI.Toggle(new Rect(111, 25, 140f, 20f), asdas, menu.enru ? "  Aim Bot [X]" : "  Аим Бот [Х]");
                    aimbot.head = GUI.Toggle(new Rect(111, 50, 140f, 20f), aimbot.head, menu.enru ? "  Aim Bot (Head)" : "  Аим Бот (Голова)");

                    bvbgfg = GUI.Toggle(new Rect(111, 75, 140f, 20f), bvbgfg, menu.enru ? "  Aim Bot Heli [X]" : "  Аим Бот-Верт [Х]");
                    CFG.Aimbot.aimm = GUI.Toggle(new Rect(111, 275, 140f, 20f), CFG.Aimbot.aimm, menu.enru ? "  Aim Bot (Test)" : "  Аим Бот (Тест)");
                    CFG.Aimbot.crrr = GUI.Toggle(new Rect(111, 100, 140f, 20f), CFG.Aimbot.crrr, menu.enru ? "  Crosshair" : "  Прицел");
                    grr = GUI.Toggle(new Rect(111, 125, 140f, 20f), grr, menu.enru ? "  Crosshair" : "  Прицел");
                    GUI.Label(new Rect(255, 50, 180f, 30f), string.Format(menu.enru ? "          FOV (Aim Bot)" : "          FOV (Aim Bot)", menu.fov));

                    menu.fov = (int)GUI.HorizontalSlider(new Rect(255, 75, 160f, 25f), menu.fov, 0f, 360f);
                    GUI.Label(new Rect(255, 68, 180f, 30f), string.Format("                {0}", menu.fov));
                    break;
                case menu.tab.f5:

                    CFG.Misc.adsfdgrege = GUI.Toggle(new Rect(111, 25, 160f, 20f), CFG.Misc.adsfdgrege, menu.enru ? "  Spidermen" : "  Паук");
                    CFG.Misc.walkon = GUI.Toggle(new Rect(111, 50, 160f, 20f), CFG.Misc.walkon, menu.enru ? "  Walk On Water [C]" : "  Ходить По Воде [C]");

                    CFG.Misc.AASDD = GUI.Toggle(new Rect(111, 100, 175f, 20f), CFG.Misc.AASDD, menu.enru ? "  Fast Throwing Grenades [F]" : "  Фаст Бросание Гранат [F]");
                    menu.test3 = GUI.Toggle(new Rect(111, 125, 170f, 20f), menu.test3, menu.enru ? "  Fast Glue A Grenade [F]" : "  Фаст Клеить Гранату [F]");
                    ESP.свет = GUI.Toggle(new Rect(111, 150, 170f, 20f), ESP.свет, menu.enru ? "  Remove The Darkness" : "  Убрать Тьму");
                    menu.traf = GUI.Toggle(new Rect(111, 175, 170f, 20f), menu.traf, menu.enru ? "  Remove The Grass" : "  Убрать Траву");
                    CFG.Misc.hghtrhf = GUI.Toggle(new Rect(111, 200, 160f, 20f), CFG.Misc.hghtrhf, menu.enru ? "  DebagCamera [Delete]" : "  ДебагКамера [Delete]");
                    CFG.Misc.HGHGH = GUI.Toggle(new Rect(111, 225, 160f, 20f), CFG.Misc.HGHGH, menu.enru ? "  Low Gravity" : "  Малая Гравитация");
                    CFG.Misc.ASDADAD = GUI.Toggle(new Rect(111, 250, 160f, 20f), CFG.Misc.ASDADAD, menu.enru ? "  Not Sink" : "  Не Тонуть");
                    CFG.Misc.NAXYI = GUI.Toggle(new Rect(111, 275, 160f, 20f), CFG.Misc.NAXYI, menu.enru ? "  Auto Heal" : "  Авто Хилл");
                    CFG.Misc.ZAEB = GUI.Toggle(new Rect(295, 25, 160f, 20f), CFG.Misc.ZAEB, menu.enru ? "  Heal Friend [F]" : "  Хилл Друга [F]");


                    CFG.Misc.cccvvbbbffdd = GUI.Toggle(new Rect(295, 50, 160f, 20f), CFG.Misc.cccvvbbbffdd, menu.enru ? "  Raise [Z]" : "  Поднять [Z]");
                    CFG.Misc.ZALYPA = GUI.Toggle(new Rect(295, 75, 160f, 20f), CFG.Misc.ZALYPA, menu.enru ? "  Drop Inventory [L]" : "  Скинуть Инвентарь [L]");
                    CFG.Misc.blats = GUI.Toggle(new Rect(295, 100, 160f, 20f), CFG.Misc.blats, menu.enru ? "  SpeedHack" : "  SpeedHack");
                    CFG.Misc.asawersffd = GUI.Toggle(new Rect(295, 125, 160f, 20f), CFG.Misc.asawersffd, menu.enru ? "  Jamp Hack" : "  Прыг Скок");
                    CFG.Misc.adadadaa = GUI.Toggle(new Rect(295, 150, 160f, 20f), CFG.Misc.adadadaa, menu.enru ? "  3 Face" : "  3 Лицо");
                    CFG.Misc.eeeeeeeee = GUI.Toggle(new Rect(295, 175, 160f, 20f), CFG.Misc.eeeeeeeee, menu.enru ? "  Run While Aiming" : "  Бегать Во Время Прицела");
                    nnn = GUI.Toggle(new Rect(295, 200, 96, 20f), nnn, menu.enru ? "  Wanker xD" : "  Дрочун xD");
                    test41 = GUI.Toggle(new Rect(390, 200, 160f, 20f), test41, menu.enru ? "  Spam Reload" : "  Спам Reload");
                    test411 = GUI.Toggle(new Rect(295, 225, 160f, 20f), test411, menu.enru ? "  Suicide [KeyPad5]" : "  Самоубийство [KeyPad5]");
                    nnnn = GUI.Toggle(new Rect(295, 250, 170f, 20f), nnnn, menu.enru ? "  Auto Speed Up Running" : "  Авто Ускороение Бега");

                    if (GUI.Button(new Rect(295, 273, 180, 25f), menu.enru ? "  Teleports + Settings" : "Телепорты + Настройка"))
                    {

                        menu.gui1 = !menu.gui1;


                    }
                    break;
                case menu.tab.f7:

                    CFG.Misc.iopiop = GUI.Toggle(new Rect(111, 25, 170f, 20f), CFG.Misc.iopiop, menu.enru ? "  Pickup Sulfur" : "  Поднятие Серы");
                    CFG.Misc.nbnhg = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Misc.nbnhg, menu.enru ? "  Pickup Metal" : "  Поднятие Метала");
                    CFG.Misc.vcgdcv = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Misc.vcgdcv, menu.enru ? "  Pickup Stone" : "  Поднятие Камня");
                    CFG.Misc.asarwad = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Misc.asarwad, menu.enru ? "  Pickup Hemp" : "  Поднятие Ткани");
                    CFG.Misc.mnbvc = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.Misc.mnbvc, menu.enru ? "  Pickup Pumpkins" : "  Поднятие Тыквы");
                    CFG.Misc.ooppoo = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.Misc.ooppoo, menu.enru ? "  Pickup Corn" : "  Поднятие Кукурузы");
                    CFG.Misc.adfsaa = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.Misc.adfsaa, menu.enru ? "  Pickup Mushroom" : "  Поднятие Грибов");
                    CFG.Misc.adsfbc = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.Misc.adsfbc, menu.enru ? "  Pickup Dropped Item" : "  Поднятие Предметов");
                    CFG.Misc.yyttrrfff = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.Misc.yyttrrfff, menu.enru ? "  Auto Drink" : "  Авто Бухло");
                    CFG.Misc.bvbvn = GUI.Toggle(new Rect(280, 25, 170f, 20f), CFG.Misc.bvbvn, menu.enru ? "  AutoFarm Stones" : "  Авто Фарм Камни");
                    menu.farm = GUI.Toggle(new Rect(280, 50, 170f, 20f), menu.farm, menu.enru ? "  AutoFarm Tree" : "  Авто Фарм Дерево");
                    CFG.Misc.hgf = GUI.Toggle(new Rect(280, 75, 170f, 20f), CFG.Misc.hgf, menu.enru ? "  AutoFarm Barrels" : "  Авто Фарм Бочки");
                   xyi = GUI.Toggle(new Rect(280, 100, 170f, 20f), xyi, menu.enru ? "  Auto On Torch" : "  Авто Вкл Факел");
                    CFG.Misc.adsafsddvcvc = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.Misc.adsafsddvcvc, menu.enru ? "  Auto Authorization In The Turret" : "  Авто Авторизация В Турели");

                    CFG.Misc.vbfgcvvcv = GUI.Toggle(new Rect(111, 275, 180f, 20f), CFG.Misc.vbfgcvvcv, menu.enru ? "  Auto Lifting Mine/Trap" : "  Авто Поднятие Мины/Капканы");
                    break;
                case menu.tab.f9:

                    CFG.ESP.dsfsf = GUI.Toggle(new Rect(111, 25, 90, 20f), CFG.ESP.dsfsf, menu.enru ? "  Heli" : "  Верт");
                    CFG.ESP.q = GUI.Toggle(new Rect(210, 25, 50, 20f), CFG.ESP.q, menu.enru ? "  Tank" : "  Танк");
                    bag = GUI.Toggle(new Rect(111, 50, 160, 20f), bag, menu.enru ? "  Sleeping Bag" : "  Спальники");
                    CFG.ESP.w = GUI.Toggle(new Rect(111, 75, 60f, 20f), CFG.ESP.w, menu.enru ? "  Cupboard" : "  Шкаф");
                   h = GUI.Toggle(new Rect(170, 75,40, 20f),h, menu.enru ? "  HP" : "  HP");
                    CFG.ESP.e = GUI.Toggle(new Rect(111, 100, 80, 20f), CFG.ESP.e, menu.enru ? "  Stash" : "  Стеши");
                    bbf = GUI.Toggle(new Rect(190, 100, 100, 20f), bbf, menu.enru ? "АвтоРазкоп" : "АвтоРазкоп");
                    CFG.ESP.r = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.ESP.r, menu.enru ? "  Supply Drop" : "  Аир Дроп");
                    CFG.ESP.t = GUI.Toggle(new Rect(111, 150, 100f, 20f), CFG.ESP.t, menu.enru ? "  Dropped Item" : "  Предметы");
                    menu.test4 = GUI.Toggle(new Rect(111, 175, 100f, 20f), menu.test4, menu.enru ? "  Recycler" : "  Переработчик");
                    CFG.ESP.corpse = GUI.Toggle(new Rect(210, 150, 50, 20f), CFG.ESP.corpse, menu.enru ? "  Icon" : "  Icon");
                    CFG.ESP.y = GUI.Toggle(new Rect(111, 200, 170f, 20f), CFG.ESP.y, menu.enru ? "  Food Box" : "  Ящик С Едой");
                    CFG.ESP.u = GUI.Toggle(new Rect(111, 225, 170f, 20f), CFG.ESP.u, menu.enru ? "  Crate" : "  Коробка");
                    CFG.ESP.i = GUI.Toggle(new Rect(111, 250, 170f, 20f), CFG.ESP.i, menu.enru ? "  Green Crate" : "  Зелёный Ящик");
                    CFG.ESP.o = GUI.Toggle(new Rect(111, 275, 170f, 20f), CFG.ESP.o, menu.enru ? "  Elite Crate" : "  Элитный Ящик");
                    CFG.ESP.p = GUI.Toggle(new Rect(280, 25, 110f, 20f), CFG.ESP.p, menu.enru ? "  Auto Turret" : "  Авто Турель");
                    turr = GUI.Toggle(new Rect(400, 25, 100f, 20f), turr, menu.enru ? "  AUTH" : "  Авториз.");
                    CFG.ESP.a = GUI.Toggle(new Rect(280, 50, 170f, 20f), CFG.ESP.a, menu.enru ? "  Gun Trap/Flame Turret" : "  Ган Трап/Огненная Турель");
                    CFG.ESP.s = GUI.Toggle(new Rect(280, 75, 170f, 20f), CFG.ESP.s, menu.enru ? "  Barrels" : "  Бочки");
                    CFG.ESP.d = GUI.Toggle(new Rect(280, 100, 170f, 20f), CFG.ESP.d, menu.enru ? "  Crate Heli/Tank" : "  Ящики Верт/Танк");
                    CFG.ESP.f = GUI.Toggle(new Rect(280, 125, 170f, 20f), CFG.ESP.f, menu.enru ? "  Explosion C4/Rocket/Satchel" : "  Взрыв С4/Ракета/Сочель");
                    CFG.ESP.g = GUI.Toggle(new Rect(280, 150, 170f, 20f), CFG.ESP.g, menu.enru ? "  Animals" : "  Животные");
                    CFG.ESP.bvbcfd = GUI.Toggle(new Rect(280, 175, 170f, 20f), CFG.ESP.bvbcfd, menu.enru ? "  Boxes" : "  Ящики");
                    CFG.ESP.fgfddd = GUI.Toggle(new Rect(280, 200, 170f, 20f), CFG.ESP.fgfddd, menu.enru ? "  Doors" : "  Двери");
                    vvvv = GUI.Toggle(new Rect(280, 225, 170f, 20f), vvvv, menu.enru ? "  Mine/Trap" : "  Мины/Капканы");
                    GUI.Label(new Rect(280, 250, 180f, 30f), string.Format(menu.enru ? "           Distance " : "           Дистанция ", (float)ESP.WorldEspDistance));
                    ESP.WorldEspDistance = (int)GUI.HorizontalSlider(new Rect(280, 275, 150f, 25f), (float)ESP.WorldEspDistance, 0f, 600f);
                    GUI.Label(new Rect(280, 269, 180f, 30f), string.Format("              {0}", (float)ESP.WorldEspDistance));
                    break;
                case menu.tab.f10:
                    CFG.ESP.ytcbcv = GUI.Toggle(new Rect(111, 25, 170f, 20f), CFG.ESP.ytcbcv, menu.enru ? "  Sulfur" : "  Сера");
                    CFG.ESP.cvdfg = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.ESP.cvdfg, menu.enru ? "  Metal" : "  Метал");
                    CFG.ESP.rtfgd = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.ESP.rtfgd, menu.enru ? "  Stone" : "  Камень");
                    CFG.ESP.fdgvcbd = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.ESP.fdgvcbd, menu.enru ? "  Hemp" : "  Ткань");
                    CFG.ESP.rererrr = GUI.Toggle(new Rect(111, 125, 170f, 20f), CFG.ESP.rererrr, menu.enru ? "  Pumpkin" : "  Тыква");
                    CFG.ESP.gfgrttt = GUI.Toggle(new Rect(111, 150, 170f, 20f), CFG.ESP.gfgrttt, menu.enru ? "  Corn" : "  Кукуруза");
                    CFG.ESP.bvcbfdge = GUI.Toggle(new Rect(111, 175, 170f, 20f), CFG.ESP.bvcbfdge, menu.enru ? "  Mushrooms" : "  Грибы");

                    CFG.ESP.iiii = GUI.Toggle(new Rect(280, 25, 170f, 20f), CFG.ESP.iiii, menu.enru ? "  Collectibles Sulfur" : "  Подбираемая Сера");
                    CFG.ESP.vbcbc = GUI.Toggle(new Rect(280, 50, 170f, 20f), CFG.ESP.vbcbc, menu.enru ? "  Collectibles Meatl" : "  Подбираемый Метал");
                    CFG.ESP.ytytf = GUI.Toggle(new Rect(280, 75, 170f, 20f), CFG.ESP.ytytf, menu.enru ? "  Collectibles Stone" : "  Подбираемый Камень");
                    CFG.ESP.fdgdg = GUI.Toggle(new Rect(280, 100, 170f, 20f), CFG.ESP.fdgdg, menu.enru ? "  Collectibles Wood" : "  Подбираемое Дерево");

                    GUI.Label(new Rect(111, 200, 180f, 30f), string.Format(menu.enru ? "             Distance " : "             Дистанция ", (float)ESP.range));
                    ESP.range = (int)GUI.HorizontalSlider(new Rect(111, 225, 150f, 25f), (float)ESP.range, 0f, 500f);
                    GUI.Label(new Rect(111, 219, 180f, 30f), string.Format("                 {0}", (float)ESP.range));



                    break;
                case menu.tab.f12:

                    CFG.Radar.radarrrrr = GUI.Toggle(new Rect(111, 25, 170f, 20f), CFG.Radar.radarrrrr, menu.enru ? "  Radar ON/OFF" : "  Радар Вкл/Выкл");
                    CFG.Radar.radar = GUI.Toggle(new Rect(111, 50, 170f, 20f), CFG.Radar.radar, menu.enru ? "  Players" : "  Игроки");
                    sleep = GUI.Toggle(new Rect(111, 75, 170f, 20f), sleep, menu.enru ? "  Sleepers" : "  Спящие");
                    CFG.Radar.radarnpc = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Radar.radarnpc, menu.enru ? "  NPC" : "  Боты");
                    fgghhhh = (int)GUI.HorizontalSlider(new Rect(111, 155, 150f, 25f), fgghhhh, 0, 2);
                    GUI.Label(new Rect(111, 149, 180f, 30f), string.Format(ftff, menu.fgghhhh));



                    gf = GUI.Toggle(new Rect(111, 125, 170f, 20f), gf, menu.enru ? "  Magnet to the Player [E]" : "  Магнит К Игроку [E]");


                    menu.spin = GUI.Toggle(new Rect(280, 25, 88, 20f), menu.spin, menu.enru ? "  Anti-Aim" : "  Анти-Аим");
                    fdfd = (int)GUI.HorizontalSlider(new Rect(280, 55, 150f, 25f), (float)fdfd, 0f, 3f);
                    GUI.Label(new Rect(280, 49, 180f, 30f), string.Format(arrra, (float)menu.fdfd));
                    GUI.Label(new Rect(280, 75, 180f, 30f), string.Format("         Speed Anti-Aim ", sped));
                    sped = (int)GUI.HorizontalSlider(new Rect(280, 100, 150f, 25f), sped, 5f, 55f);
                    GUI.Label(new Rect(280, 94, 180f, 30f), string.Format("               [{0}]", sped));

                    if (GUI.Button(new Rect(280, 125, 150f, 25f), "SPOOF COPY NAME"))
                    {
                        NameFromClipboard();
                    }
                    if (GUI.Button(new Rect(280, 150, 150f, 25f), "SPOOF COPY ID"))
                    {
                       SpoofToClipboard();
                    }

                 

                    break;
                case menu.tab.f13:
                    adf1 = GUI.Toggle(new Rect(111, 25, 185f, 20f), adf1, menu.enru ? "  Притягивание Объектов [+]" : "  Притягивание Объектов [+]");
                    adf = GUI.Toggle(new Rect(111, 50, 180f, 20f), adf, menu.enru ? "  Притягивание Шкафа [+]" : "  Притягивание Шкафа [+]");
                    CFG.Misc.ylylyy = GUI.Toggle(new Rect(111, 75, 170f, 20f), CFG.Misc.ylylyy, menu.enru ? "  Auto Upgrade [KeyPad4]" : "  Авто Улучш [KeyPad4]");
                    CFG.Misc.mmnb = GUI.Toggle(new Rect(111, 100, 170f, 20f), CFG.Misc.mmnb, menu.enru ? "  Knock Door [B]" : "  Стучать в Дверь [В]");
                    CFG.Misc.wertyu = GUI.Toggle(new Rect(111, 125, 160f, 20f), CFG.Misc.wertyu, menu.enru ? "  Remove [KeyPad1-2]" : "  Ремув [KeyPad1-2]");
                    CFG.Misc.png = GUI.Toggle(new Rect(111, 150, 160f, 20f), CFG.Misc.png, menu.enru ? "  PNG [P] (Settings)" : "  PNG [P] (Настройки)");
                    CFG.Misc.ggdfggg = GUI.Toggle(new Rect(111, 175, 175f, 20f), CFG.Misc.ggdfggg, menu.enru ? "  Twirl Build (Arrows)" : "  Вертеть Билду (Стрелочками)");
                    menu.spam = GUI.Toggle(new Rect(111, 200, 170f, 20f), menu.spam, menu.enru ? "  Spam Chat (Settings)" : "  Спам Чат (Настройки)");
                    CFG.Misc.oiuytgbmnb = GUI.Toggle(new Rect(111, 225, 185f, 20f), CFG.Misc.oiuytgbmnb, menu.enru ? "  Clear and Auth in the Cupboard[U]" : "  Очистка и Авторизация в Шкафу [U]");
                   test2= GUI.Toggle(new Rect(111, 275, 240, 20f), test2, menu.enru ? "  Lock Authorization [N] (Settings)" : "  Авторизация В Замках [N](Настройки)");
                    mbnbnm = GUI.Toggle(new Rect(280, 75, 170f, 20f), mbnbnm, "  WaterLevel");
                    mmmm = GUI.Toggle(new Rect(280, 150, 170f, 20f), mmmm, menu.enru ? "  Walk Under Water" : "  Ходить Под Водой");
                    hhhfg = GUI.Toggle(new Rect(111, 250, 170f, 20f), hhhfg, menu.enru ? "  Remove Walls and etc [C]" : "  Ремув Стены и тд [C]");

                    CFG.Misc.authh = GUI.Toggle(new Rect(280, 200, 170f, 20f), CFG.Misc.authh, menu.enru ? "  Loot a Corpse-5m [B]" : "  Лутать Труп-5м [B]");
                    GUI.Label(new Rect(280, 100, 180f, 30f), string.Format("       SpeedHack ", HACK.speedhackspeed));
                    HACK.speedhackspeed = (int)GUI.HorizontalSlider(new Rect(280, 125, 180f, 25f), HACK.speedhackspeed, 0f, 50);
                    GUI.Label(new Rect(280, 119, 180f, 30f), string.Format("           {0}", HACK.speedhackspeed));
                    menu.frre = GUI.Toggle(new Rect(285, 25, 170f, 20f), menu.frre, menu.enru ? "  Add To Friends [Button-9]" : "  Добавить В Друзья [9]");
                    if (GUI.Button(new Rect(310, 50, 170, 25f), menu.enru ? "  Delete Your Friends List" : "Удалить Список Друзей"))
                    {
                        if (friend.friendsList != null && friend.friendsList.Count > 0)
                        {
                            friend.friendsList.Clear();
                        }
                    }
                    if (GUI.Button(new Rect(310,240, 150, 25f), menu.enru ? "Settings" : "Настройки"))
                    {
                        menu.gui11 = !menu.gui11;
                    }
                    break;
            }
        }
        GUI.DragWindow();
    }
    public static bool steam;
    public static void SpoofToClipboard()
    {
        ulong spoofID;
        ulong.TryParse(GUIUtility.systemCopyBuffer, out spoofID);
        Client.spoofID = spoofID;
        SteamUser.spoofID = spoofID;
    }
    public static void NameFromClipboard()
    {
        Client.spoofName = GUIUtility.systemCopyBuffer;
    }
    public string WH = "OFF";
    public static bool ф;
    public static bool bbf;
    private void Main11(int id)
    {
        GUI.color = randomColor;
        GUI.backgroundColor = randomColor;
        GUI.Box(new Rect(2f, 2f, 196, 266), menu.enru ? "Teleportations" : "Телепортации");
        GUI.Box(new Rect(2f, 2f, 196, 266), menu.enru ? "Teleportations" : "Телепортации");
        GUI.Box(new Rect(2f, 2f, 196, 266), menu.enru ? "Teleportations" : "Телепортации");
        GUI.Box(new Rect(2f, 2f, 196, 266), menu.enru ? "Teleportations" : "Телепортации");
        GUI.Box(new Rect(2f, 2f, 196, 266), menu.enru ? "Teleportations" : "Телепортации");
        GUI.backgroundColor = Color.white;
        GUI.color = Color.white;
        Enum @enum = this.tab2;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {

                case menu.tab.f10:


                    CFG.Misc.ahahahha = GUI.Toggle(new Rect(10, 25, 170f, 20f), CFG.Misc.ahahahha, menu.enru ? "  TP-Players [X]" : "  ТП-Игроки [Х]");
                    CFG.Misc.dfdf = GUI.Toggle(new Rect(10, 50, 170f, 20f), CFG.Misc.dfdf, menu.enru ? "  TP-SupplyDrop [X]" : "  ТП-АирДроп [Х]");
                    CFG.Misc.df = GUI.Toggle(new Rect(10, 75, 170f, 20f), CFG.Misc.df, menu.enru ? "  TP-Into The Air [Z]" : "  ТП-В Воздух [Z]");
                    GUI.Label(new Rect(10, 100, 180f, 30f), string.Format(menu.enru ? "       Distance " : "       Дистанция ", (float)HACK.player1));
                    HACK.player1 = (int)GUI.HorizontalSlider(new Rect(10, 125, 170f, 25f), (float)HACK.player1, 0f, 350f);
                    GUI.Label(new Rect(10, 119, 180f, 30f), string.Format("           {0}", (float)HACK.player1));
                    GUI.Label(new Rect(10, 150, 180f, 30f), string.Format(menu.enru ? "       TP Height " : "       TP Высота ", (float)HACK.teleportheight));
                    HACK.teleportheight = (int)GUI.HorizontalSlider(new Rect(10, 175, 170f, 25f), (float)HACK.teleportheight, 0f, 150f);
                    GUI.Label(new Rect(10, 169, 180f, 30f), string.Format("           {0}", (float)HACK.teleportheight));

                    break;
            }
        }
        GUI.DragWindow();
    }
    public static bool garss1;
    public static bool h;
    public static bool adf = false;
    public static bool adf1=false;
    private void Main111(int id)
    {
        GUI.color = randomColor;
        GUI.backgroundColor = randomColor;



        GUI.Box(new Rect(2f, 2f, 196, 306), menu.enru ? "Settings" : "Настройки");
        GUI.Box(new Rect(2f, 2f, 196, 306), menu.enru ? "Settings" : "Настройки");
        GUI.Box(new Rect(2f, 2f, 196, 306), menu.enru ? "Settings" : "Настройки");
        GUI.Box(new Rect(2f, 2f, 196, 306), menu.enru ? "Settings" : "Настройки");
        GUI.Box(new Rect(2f, 2f, 196, 306), menu.enru ? "Settings" : "Настройки");
        GUI.backgroundColor = Color.white;
        GUI.color = Color.white;
        Enum @enum = this.currentTab11;
        Enum enum2;
        if (@enum != null && (enum2 = @enum) is menu.tab)
        {
            switch ((menu.tab)enum2)
            {

                case menu.tab.f8:
                    GUI.Label(new Rect(10, 25, 180, 30), string.Format(menu.enru ? "Code AutoLock - Auth Code" : "Код АвтоЛок - Авторизация", Color.red));


                    string_1 = GUI.TextArea(new Rect(10, 45, 50, 30), string_1, 4, "box");
                    GUI.Label(new Rect(10, 50, 150, 30), string.Format("  _______", Color.red));

                    GUI.Label(new Rect(10, 75, 180f, 30f), string.Format(menu.enru ? "       Auto upgrade " : "       Авто Улучшение ", fgghhh));
                    fgghhh = (int)GUI.HorizontalSlider(new Rect(10, 100, 170f, 25f), fgghhh, 0f, 4f);
                    GUI.Label(new Rect(10, 93, 180f, 30f), string.Format(ftf, fgghhh));
                    GUI.Label(new Rect(10, 105, 175, 30), string.Format("________________________________", Color.red));
                    GUI.Label(new Rect(10, 125, 175, 30), string.Format("РАСТОЯНИЕ УЛУЧШЕНИЯ", Color.red));
                    sp1ed = (int)GUI.HorizontalSlider(new Rect(10, 150, 170f, 25f), sp1ed, 1, 15);
                    GUI.Label(new Rect(10, 144, 180f, 30f), string.Format("               [{0}]", sp1ed));
                    GUI.Label(new Rect(10, 155, 175, 30), string.Format("________________________________", Color.red));
                    string_11 = GUI.TextArea(new Rect(10f, 175, 170f, 30), string_11, "box");
                    GUI.Label(new Rect(10, 180, 175, 30), string.Format("________________________________", Color.red));
                    GUI.Label(new Rect(10f, 200, 170f, 25f), string.Format(menu.enru ? "       Speed (Seconds)" : "       Скорость (Секунды)", (int)menu.spamm));
                    menu.spamm = GUI.HorizontalSlider(new Rect(10f, 225, 170, 25f), (int)menu.spamm, 0f, 6f);
                    GUI.Label(new Rect(10, 218, 180f, 30f), string.Format("                    {0}", (int)menu.spamm));
                    GUI.Label(new Rect(10, 250, 180, 30), string.Format(menu.enru ? "PNG Photo location" : "PNG Расположение фото", Color.red));
                    string_0 = GUI.TextArea(new Rect(10, 275, 180, 30), string_0, "box");
                    break;
            }
        }
        GUI.DragWindow();
    }
    public static string ftff;
    public static string ftf;
    public static void yffff()
    {
        int ggc = menu.fgghhh;
        switch (ggc)
        {
            case 0:
                fdgdfgdfg = BuildingGrade.Enum.Wood;
                menu.ftf = menu.enru ? "              Wood" : "              Дерево";
                break;
            case 1:
                fdgdfgdfg = BuildingGrade.Enum.Stone;
                menu.ftf = menu.enru ? "              Stone" : "              Камень";
                break;
            case 2:
                fdgdfgdfg = BuildingGrade.Enum.Metal;
                menu.ftf = menu.enru ? "              Metal" : "              Метал";
                break;
            case 3:
                fdgdfgdfg = BuildingGrade.Enum.TopTier;
                menu.ftf = menu.enru ? "              Armored" : "              МВК";
                break;
            case 4:
                fdgdfgdfg = BuildingGrade.Enum.Twigs;
                menu.ftf = menu.enru ? "              Салома" : "              Салома";
                break;





        }
    }
    public static void yfffff()
    {
        int ggc = menu.fgghhhh;
        switch (ggc)
        {
            case 0:
                b = -1f;
                menu.ftff = menu.enru ? "              Left" : "              Лево";
                break;
            case 1:
                b = 0f;
                menu.ftff = menu.enru ? "              Center" : "              Центер";
                break;
            case 2:
                b = 1f;
                menu.ftff = menu.enru ? "              Right" : "              Право";
                break;
        }
    }
    public static string arrra;
    public static int fdfd;
    public static void yffffff()
    {
        System.Random rand1 = new System.Random();
        int ggc = menu.fdfd;
        switch (ggc)
        {
            case 0:
                hhh = 100f;
                menu.arrra = menu.enru ? "              Down" : "              Вниз";
                break;
            case 1:
                hhh = 0f;
                menu.arrra = menu.enru ? "              None" : "              В Перёд";
                break;
            case 2:
                hhh = -100f;
                menu.arrra = menu.enru ? "              Up" : "              Верх";
                break;
            case 3:

                hhh = rand1.Next(-100, 100);
                menu.arrra = menu.enru ? "              Random" : "              Рандом";
                break;
        }
    }

    public static bool heli;
    public static bool xp;
    public static bool bg;
    public static bool grass;
    public static bool turr;
    public static bool gov;
    public static bool bild;
    public static bool fps = true;
    public static bool ggggf;
    public static bool gggf;
    private static void GG()
    {
      
        GameObject[] array = (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject));
        for (int i = 0; i < array.Length; i++)
        {
            bool flag = array[i].name == "New Game Object";
            if (flag)
            {
                UnityEngine.Object.Destroy(array[i].gameObject);
            }
        }
       

    }
    private Enum currentTab11 = menu.tab.f8;
    private Enum tab2 = menu.tab.f10;
    private static Enum ff = menu.tab.f1; private enum tab
    {
        f1,
        f2,
        f3,
        f4, f7, f9, f8, f10, f11, f12, f13,
        f5,
        f6

    }
    public static float hhh;
    public static int sp1ed;
    public static int sped;
    public static float hh;
    public static int fgghhhh;
    public static float bbb;
    public static float b;
    public static float bb;

    public static bool xyi;
    public static bool gf;



    public static bool farm = false;
    public static bool hp = false;
    public static bool gfgfg = false;
    public static bool gggg = false;
    public static bool ggggg = false;
    public static bool gggggg = false;
    public static bool ggg = false;
    public static bool enru = false;
    public static bool frre = false;
    private static Rect main11 = new Rect(530, 50, 200, 310);
    private static Rect main1 = new Rect(735, 50, 200,270);
    private static Rect main = new Rect(20f, 50f,500f, 305f);
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
    public static float reco1 = 0.5f; 
    public static float reco = 1f;
    public static bool grr = false;
    public static bool hot = false;
    public static bool bag = false;
    public static bool spin = false;
}
