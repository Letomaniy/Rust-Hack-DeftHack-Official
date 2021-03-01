using System;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public static Vector3 GetScreenPos(Vector3 position)
    {
        return MainCamera.mainCamera.WorldToScreenPoint(position);
    }

    public static Vector3 GetPositionBone(Model model, string name)
    {
        Vector3 result = Vector3.zero;
        if (model != null)
        {
            result = ((!(name == "headCenter")) ? model.FindBone(name).position : new Vector3(model.headBone.position.x, model.eyeBone.position.y, model.headBone.position.z));
        }
        return result;
    }

    public static BasePlayer GetTargetPlayer()
    {
        BasePlayer result = null;
        float num = float.MaxValue;
        foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
        {
            bool flag = basePlayer != null && basePlayer.IsValid();
            if (flag)
            {
                Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position);
                if (vector2.z > 0f)
                {

                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position + new Vector3(0f, 1.7f, 0f));
                    Vector2 vector3 = new Vector2(vector2.x, (float)Screen.height - vector2.y);
                    float num2 = Mathf.Abs(Vector2.Distance(vector, vector3));
                    bool flag2 = num2 <= num && num2 <= 400f;
                    if (flag2)
                    {
                        num = num2;
                        result = basePlayer;
                    }
                }
            }
        }
        return result;
    }

    public static void DrawPlayerESP()
    {
        if (LocalPlayer.Entity != null)
        {
            try
            {
                if (BasePlayer.visiblePlayerList != null)
                {
                    foreach (BasePlayer player in BasePlayer.visiblePlayerList)
                    {
                        if ((player != null) && (player.health > 0f) && !player.IsLocalPlayer())
                        {
                            Vector3 position = player.transform.position;
                            Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(position);
                            int distance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, position);
                            Vector3 vector28 = MainCamera.mainCamera.WorldToScreenPoint(position + new Vector3(0f, 1.7f, 0f));
                            Vector3 vector288 = MainCamera.mainCamera.WorldToScreenPoint(position + new Vector3(0f, 1.2f, 0f));
                            Vector3 vector21 = MainCamera.mainCamera.WorldToScreenPoint(position);
                            Vector3 positionBone = player.FindBone("head").transform.position;
                            Vector3 screenPos = Players.GetScreenPos(positionBone + new Vector3(0f, 0.3f, 0f));
                            float num4 = Mathf.Abs(vector3.y - screenPos.y);
                            float width = num4 / 2f;
                            float num145 = Mathf.Abs(vector21.y - vector28.y);
                            float num1455 = Mathf.Abs(vector21.y - vector288.y);
                            if (CFG.ESP.adm)
                            {
                                if (player.IsAlive())
                                {
                                    //  VDraw.DrawLine(new Vector2(Screen.width / 2f, 0f), new Vector2(Position2DUP.x, Screen.height - Position2DUP.y), Color.red);
                                    Rendering.DrawString1(new Vector2(Screen.width / 2, 30f), string.Format("{0} {1}", "Админ ТУТ!!!", player.displayName), new Color32(255, 0, 0, 255), true, 13);
                                }
                            }
                            if (vector3.z > 0.5f)
                            {
                                int cameradistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, position);
                                if (!player.IsSleeping() && player.health > 0f)
                                {
                                    if (cameradistance <= CFG.ESP.sdd)
                                    {
                                        if (CFG.ESP.players  )
                                        {
                                            GUI.color = Color.white;
                                            if (!menu.hp && !friend.friendsList.Contains(player.userID))
                                                Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num4, player.health);
                                            GUI.color = Color.white;
                                            if (!menu.hp && friend.friendsList.Contains(player.userID))
                                                Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num4, player.health);
                                            GUI.color = Color.white;
                                            if (menu.hp && !friend.friendsList.Contains(player.userID))
                                                Rendering.Health11(screenPos.x, (float)Screen.height - screenPos.y, player.health, 100, 45, 6, 1f);
                                            GUI.color = Color.white;
                                            if (menu.hp && friend.friendsList.Contains(player.userID))
                                                Rendering.Health11(screenPos.x, (float)Screen.height - screenPos.y, player.health, 100, 45, 6, 1f);
                                            GUI.color = Color.white;
                                            if (!friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", player.displayName, distance), PlayerColor, true, 8);

                                            GUI.color = Color.white;
                                            if (menu.hp && friend.friendsList.Contains(player.userID))
                                                Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num4, player.health);
                                            GUI.color = Color.white;
                                            if (friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format((menu.enru ? "Friend [{1}]" : "Друг [{1}]"), player.displayName, distance), Color.green, true, 8);



                                        }
                                       
                                        if (menu.xp  )
                                        {
                                            GUI.color = Color.white;
                                            if (!friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(screenPos.x, (float)Screen.height - screenPos.y + -30f), string.Format("[{0}]XP", player.UnspentXp, distance), PlayerColor, true, 8);
                                            GUI.color = Color.white;
                                            if (!friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(screenPos.x, (float)Screen.height - screenPos.y + -40f), string.Format("[{0}]LVL", player.ExperienceLevel, distance), PlayerColor, true, 8);
                                            if(menu.steam)
                                            Rendering.DrawString1(new Vector2(screenPos.x, (float)Screen.height - screenPos.y + -50f), string.Format("[{0}]", player.userID, distance), PlayerColor, true, 8);
                                        }
                                        if (CFG.ESP.dgdg  )
                                        {
                                            GUI.color = Color.white;
                                            if (!player.IsWounded() && !player.IsDucked() && !friend.friendsList.Contains(player.userID))
                                                Rendering.CornerBox(new Vector2(vector28.x, (float)Screen.height - vector28.y), num145 / 2.5f, num145, 3f, PlayerColor, false);
                                            GUI.color = Color.white;
                                            if (!player.IsWounded() && player.IsDucked() && !friend.friendsList.Contains(player.userID))
                                                Rendering.CornerBox(new Vector2(vector288.x, (float)Screen.height - vector288.y), num1455 / 2.5f, num1455, 3f, PlayerColor, false);
                                            GUI.color = Color.white;
                                            if (player.IsWounded() && !friend.friendsList.Contains(player.userID))
                                                Rendering.CornerBox(new Vector2(vector288.x, (float)Screen.height - vector288.y), num1455 / 2.5f, num1455, 3f, PlayerColor, false);

                                            //      if (player.userID.ToString() == "76561198810444875" || player.userID.ToString() == "76561198974039542")
                                            //   Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", "Hostile"), new Color32(255, 0, 0, 255), true, 8);
                                        }

                                        if (CFG.ESP.gggf  )
                                        {
                                            GUI.color = Color.white;
                                            if (!player.IsWounded() && !friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), (player.GetHeldEntity() != null) ? (menu.enru ? player.GetHeldEntity().GetItem().info.displayName.english : traah.Translate(player.GetHeldEntity().GetItem().info.displayName.english)) : "", PlayerColor, true, 8);
                                            GUI.color = Color.white;
                                            if (player.IsWounded() && !friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "Wounded" : "ЛЕЖИТ")), new Color32(255, 0, 0, 255), true, 8);
                                            Color32 newColourRange = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 255);
                                            GUI.color = Color.white;
                                            if (player.IsWounded() && friend.friendsList.Contains(player.userID))
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "WOUNDED FUCKER" : "ПРИЛЁГ ДАЛБАЁБ")), randomColor, true, 8);
                                        }
                                       

                                    }


                                }
                                else
                                {
                                    if ( CFG.ESP.fdf)
                                    {
                                        if (cameradistance <= CFG.ESP.sdd && player.IsSleeping())
                                        {
                                            GUI.color = Color.white;
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", player.displayName, distance), new Color32(0, 62, 179, 255), true, 8);
                                            if (menu.steam)
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y + -10f), string.Format("[{0}]", player.userID, distance), PlayerColor, true, 8);
                                        }
                                }
                            }

                                if (CFG.ESP.vbvc)
                                {
                                    if (cameradistance <= CFG.ESP.sdd  )
                                    {
                                        GUI.color = Color.white;
                                        Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num4, player.health);
                                        GUI.color = Color.white;
                                        Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", "NPC", distance), Color.blue, true, 8);
                                        if (!player.IsWounded() && !friend.friendsList.Contains(player.userID))
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), (player.GetHeldEntity() != null) ? (menu.enru ? player.GetHeldEntity().GetItem().info.displayName.english : traah.Translate(player.GetHeldEntity().GetItem().info.displayName.english)) : "", PlayerColor, true, 8);
                                        GUI.color = Color.white;
                                        if (player.IsWounded() && !friend.friendsList.Contains(player.userID))
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "Wounded" : "ЛЕЖИТ")), new Color32(255, 0, 0, 255), true, 8);
                                    }
                                }
                            }
                        }
                    }

                    if (CFG.Aimbot.gggg)
                    {
                        BasePlayer bb = null;
                        float gggg = 999f;
                        if (BasePlayer.visiblePlayerList != null)
                        {
                            foreach (BasePlayer ffff in BasePlayer.visiblePlayerList)
                            {

                                {
                                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
                                    if (num2 <= menu.fov && num2 < gggg)
                                    {
                                        gggg = num2;
                                        bb = ffff;
                                    }
                                }
                            }
                        }
                        if (bb != null && !bb.IsDead() && !bb.IsSleeping() && !bb.IsLocalPlayer() && !friend.friendsList.Contains(bb.userID))
                        {
                            int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, bb.transform.position);
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(bb.transform.position);
                            Vector3 screenPos = Players.GetScreenPos(bb.transform.position);
                            if (screenPos.z > 0f && dist <= CFG.ESP.sdd)
                            {
                                GUI.color = Color.white;
                                Rendering.DrawString1(new Vector2(screenPos.x, Screen.height - screenPos.y - +15f), string.Format("{0}", (menu.enru ? "TARGET" : "ЦЕЛЬ")), Color.green, true, 8);
                            }
                        }
                    }

                    BasePlayer gg = null;
                    float rr = 999f;
                    if (BasePlayer.visiblePlayerList != null)
                    {
                        foreach (BasePlayer ffff in BasePlayer.visiblePlayerList)
                        {

                            {
                                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
                                if (num2 <= menu.fov && num2 < rr)
                                {
                                    rr = num2;
                                    gg = ffff;
                                }
                            }
                        }
                    }
                    if (gg != null && !gg.IsDead() && !gg.IsSleeping() && !gg.IsLocalPlayer() && !friend.friendsList.Contains(gg.userID))
                    {
                        Vector3 positionBone = Players.GetPositionBone(gg.GetModel(), "headCenter");
                        bool flag6 = !(positionBone == Vector3.zero) || !CFG.ESP.greg;
                        if (flag6)
                        {
                            Vector3 screenPos = Players.GetScreenPos(positionBone + new Vector3(0f, 0f, 0f));
                            bool flag7 = screenPos.z > 3f && CFG.ESP.greg;
                            if (flag7)
                            {
                                GUI.color = Color.white;

                                draw.DrawLine(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f), new Vector2(screenPos.x + 0f, (float)Screen.height - screenPos.y + 0f), Color.green, 1f);
                            }
                        }
                    }


                    BasePlayer basePlayer = null;
                    float num = 999f;
                    if (BasePlayer.visiblePlayerList != null)
                    {
                        foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
                        {

                            {
                                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer2.transform.position + new Vector3(0f, 1.7f, 0f));
                                float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
                                if (num2 <= menu.fov && num2 < num)
                                {
                                    num = num2;
                                    basePlayer = basePlayer2;
                                }
                            }
                        }
                    }
                    if (basePlayer != null && !basePlayer.IsDead() && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer())
                    {
                        Vector3 screenPos = Players.GetScreenPos(basePlayer.transform.position);
                        if (screenPos.z > 0f && menu.Cloth)
                        {
                            Rendering.DrawString1(new Vector2((float)Screen.width - 335, 70f), (menu.enru ? "[Clothing]" : "[Одежда]"), new Color32(12, 155, 171, 255), true, 10, FontStyle.Bold, 1);
                            List<Item> list = new List<Item>();
                            list = basePlayer.inventory.containerWear.itemList;

                            for (int i = 0; i < list.Count; i++)
                            {
                                GUI.color = Color.white;
                                Rendering.DrawString1(new Vector2((float)Screen.width - 335, 70f + (float)((i + 1) * 13)), (menu.enru ? list[i].info.displayName.english : traah.Translate(list[i].info.displayName.english)), Color.green, true, 10, FontStyle.Bold, 1);
                            }
                        }

                        if (screenPos.z > 0f && menu.tt)
                        {
                            List<Item> list = new List<Item>();
                            list = basePlayer.inventory.containerMain.itemList;
                            for (int i = 0; i < list.Count; i++)
                            {
                                GUI.color = Color.white;
                                Rendering.DrawString1(new Vector2((float)Screen.width - 150f, 60f), "Инвентарь", new Color32(12, 155, 171, 255), false, 10, FontStyle.Bold, 1);
                                Rendering.DrawString1(new Vector2((float)Screen.width - 150, 70f + (float)((i + 1) * 16)), traah.Translate(list[i].info.displayName.english), Color.green, true, 10, FontStyle.Bold, 1);
                            }
                        }
                        if (screenPos.z > 0f && CFG.ESP.bb)
                        {
                            GUI.color = Color.white;
                            Item[] array = basePlayer.inventory.AllItems();
                            Rect rect = new Rect((float)Screen.width - 250f, 60f, 200f, 35f + (float)(array.Length * 16));
                            GUI.DrawTexture(new Rect((float)Screen.width - 268f, 60f, 200f, 35f + (float)(array.Length * 16)),HukTexture.mTex1);
                            Rendering.DrawString1(new Vector2((float)Screen.width - 140f, 70f), "[" + (int)basePlayer.ExperienceLevel + "LVL] ", new Color32(212, 138, 0, 255), false, 10, FontStyle.Bold, 1);
                            Rendering.DrawString1(new Vector2((float)Screen.width - 190f, 70f), "[" + (int)basePlayer.UnspentXp + "XP] ", new Color32(212, 138, 0, 255), false, 10, FontStyle.Bold, 1);
                            Rendering.DrawString1(new Vector2((float)Screen.width - 240f, 70f), "[" + (int)basePlayer.health + "HP] ", new Color32(45, 186, 2, 255), false, 10, FontStyle.Bold, 1);
                            Rendering.DrawString1(new Vector2((float)Screen.width - 240f, 60f), basePlayer.displayName, new Color32(12, 155, 171, 255), false, 10, FontStyle.Bold, 1);
                            for (int i = 0; i < array.Length; i++)
                            {
                                Texture2D texture = array[i].info.iconSprite.texture;
                                if (array[i] != null)
                                {
                                    GUI.color = Color.white;
                                    Rendering.DrawString1(new Vector2((float)Screen.width - 240f, 70f + (float)((i + 1) * 16)), "[" + array[i].amount.ToString() + "x] " + (menu.enru ? array[i].info.displayName.english : traah.Translate(array[i].info.displayName.english)), new Color32(255, 255, 255, 255), false, 10, FontStyle.Bold, 1);
                                }
                                GUI.color = Color.white;
                                GUI.DrawTexture(new Rect((float)Screen.width - 260f, 70f + (float)(i + 1) * 16f, 16f, 16f), texture);
                            }
                        }

                    }
                    if (menu.hot)
                    {
                        BasePlayer ff = null;
                        float fff = 999f;
                        if (BasePlayer.visiblePlayerList != null)
                        {
                            foreach (BasePlayer ffff in BasePlayer.visiblePlayerList)
                            {

                                {
                                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
                                    if (num2 <= menu.fov && num2 < fff)
                                    {
                                        fff = num2;
                                        ff = ffff;
                                    }
                                }
                            }
                        }
                        if (ff != null && !ff.IsDead() && !ff.IsSleeping() && !ff.IsLocalPlayer())
                        {
                            Vector3 f = Players.GetScreenPos(ff.transform.position);

                            int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, ff.transform.position);
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ff.transform.position);
                            Vector3 screenPos = Players.GetScreenPos(ff.transform.position);
                            if (screenPos.z > 0f && dist <= CFG.ESP.sdd && !ff.IsWounded())
                            {


                                List<Item> list = new List<Item>();
                                list = ff.inventory.containerBelt.itemList;
                                for (int i = 0; i < list.Count; i++)
                                {
                                    GUI.color = Color.white;
                                    Rendering.DrawString1(new Vector2(screenPos.x, Screen.height - screenPos.y - -20f), (menu.enru ? "[Hotbar]" : "[Ремень]"), new Color32(12, 155, 171, 255), true, 9, FontStyle.Bold, 1);
                                    Rendering.DrawString1(new Vector2(screenPos.x, Screen.height - screenPos.y - -20f + (float)((i + 1) * 10)), "[" + list[i].amount.ToString() + "x] " + (menu.enru ? list[i].info.displayName.english : traah.Translate(list[i].info.displayName.english)), Color.green, true, 8, FontStyle.Bold, 1);
                                }
                            }
                        }



                    }
                }


            }

            catch (NullReferenceException)
            {
            }
        }
    }
    

    





    void Update()
    {

        randomColor = new Color(
    Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
    Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
    Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);
    }
    void Start()
    {
        ChangeMaxValue();
    }
    public static Color randomColor;
    float speedR, speedG, speedB, speedMultiple = 1f;



    void ChangeMaxValue()
    {
        speedR = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedG = UnityEngine.Random.Range(20, 50) * speedMultiple;
        speedB = UnityEngine.Random.Range(20, 50) * speedMultiple;
    }

    void OnGUI()
    {
        randomColor = new Color(
         Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
         Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
         Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);

    }
    public static bool skelet = false;
    public static Color32 TargetColor = new Color32(255, 255, 255, 255);
    public static Color32 ScientistColor = new Color32(255, 255, 255, 255);
    public static Color32 CollectablEspColor = new Color32(255, 255, 255, 255);
    public static Color32 PlayerColor = new Color32(255, 255, 255, 255);
    public static Color32 WorldEspColor = new Color32(255, 255, 255, 255);

}

