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
        foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
        {
            bool flag = basePlayer != null && basePlayer.IsValid();
            if (flag)
            {
                Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position);
                if (vector2.z > 0f)
                {

                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position + new Vector3(0f, 1.7f, 0f));
                    Vector2 vector3 = new Vector2(vector2.x, Screen.height - vector2.y);
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
                if (BasePlayer.VisiblePlayerList != null)
                {
                    foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
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
                            if (CFG.Setting.adm)
                            {
                                if (player.IsAlive())
                                {
                                    //  VDraw.DrawLine(new Vector2(Screen.width / 2f, 0f), new Vector2(Position2DUP.x, Screen.height - Position2DUP.y), Color.red);
                                    Rendering.DrawString1(new Vector2(Screen.width / 2, 30f), string.Format("{0} {1}", "Админ ТУТ!!!", player.displayName), new Color32(255, 0, 0, 255), true, 13);
                                }
                            }
                            if (vector3.z > 1f)
                            {
                                int cameradistance = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, position);
                                if (!player.IsSleeping() && player.health > 0f)
                                {
                                    if (cameradistance <= CFG.Setting.sdd)
                                    {
                                        if (CFG.Setting.players && player.userID > 1000000000UL)
                                        {
                                            if (!CFG.Setting.hp && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawVerticalHealth(new Vector2(screenPos.x, Screen.height - screenPos.y), width, num4, player.health);
                                            }

                                            if (CFG.Setting.hp && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.Health11(screenPos.x, Screen.height - screenPos.y, player.health, 100, 45, 6, 1f);
                                            }

                                            if (CFG.Setting.hp && CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.Health11(screenPos.x, Screen.height - screenPos.y, player.health, 100, 45, 6, 1f);
                                            }

                                            if (!CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", player.displayName, distance), PlayerColor, true, 8);
                                            }

                                            if (CFG.Setting.friendsList.Contains(player.userID) && CFG.Setting.hp)
                                            {
                                                Rendering.Health11(screenPos.x, Screen.height - screenPos.y, player.health, 100, 45, 6, 1f);
                                            }

                                            if (CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format((menu.enru ? "Friend [{1}]" : "Друг [{1}]"), player.displayName, distance), Color.green, true, 8);
                                            }
                                        }

                                        if (CFG.Setting.dgdg && player.userID > 1000000000UL)
                                        {
                                            if (!player.IsWounded() && !player.IsDucked() && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.CornerBox(new Vector2(vector28.x, Screen.height - vector28.y), num145 / 2.5f, num145, 3f, PlayerColor, false);
                                            }

                                            if (!player.IsWounded() && player.IsDucked() && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.CornerBox(new Vector2(vector288.x, Screen.height - vector288.y), num1455 / 2.5f, num1455, 3f, PlayerColor, false);
                                            }

                                            if (player.IsWounded() && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.CornerBox(new Vector2(vector288.x, Screen.height - vector288.y), num1455 / 2.5f, num1455, 3f, PlayerColor, false);
                                            }

                                            //      if (player.userID.ToString() == "76561198810444875" || player.userID.ToString() == "76561198974039542")
                                            //   Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", "Hostile"), new Color32(255, 0, 0, 255), true, 8);
                                        }

                                        if (vector3.z > 2f && CFG.Setting.boneESP && player.IsAlive() && !CFG.Setting.friendsList.Contains(player.userID) && player.userID > 1000000000UL)
                                        {
                                            Vector3[] bonePositions = player.GetBonePositions();
                                            Vector2[] array = new Vector2[16];
                                            for (int i = 0; i < bonePositions.Length; i++)
                                            {
                                                Vector2 vector4 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions[i]);
                                                array[i] = new Vector2(vector4.x, Screen.height - vector4.y);
                                            }
                                            Rendering.DrawLine(array[0], array[1], CFG.Setting.skele);
                                            Rendering.DrawLine(array[1], array[2], CFG.Setting.skele);
                                            Rendering.DrawLine(array[2], array[3], CFG.Setting.skele);
                                            Rendering.DrawLine(array[1], array[4], CFG.Setting.skele);
                                            Rendering.DrawLine(array[1], array[7], CFG.Setting.skele);
                                            Rendering.DrawLine(array[4], array[5], CFG.Setting.skele);
                                            Rendering.DrawLine(array[7], array[8], CFG.Setting.skele);
                                            Rendering.DrawLine(array[5], array[6], CFG.Setting.skele);
                                            Rendering.DrawLine(array[8], array[9], CFG.Setting.skele);
                                            Rendering.DrawLine(array[3], array[10], CFG.Setting.skele);
                                            Rendering.DrawLine(array[3], array[13], CFG.Setting.skele);
                                            Rendering.DrawLine(array[10], array[11], CFG.Setting.skele);
                                            Rendering.DrawLine(array[13], array[14], CFG.Setting.skele);
                                            Rendering.DrawLine(array[11], array[12], CFG.Setting.skele);
                                            Rendering.DrawLine(array[14], array[15], CFG.Setting.skele);
                                        }
                                        if (vector3.z > 2f && CFG.Setting.boneESP && player.IsAlive() && CFG.Setting.friendsList.Contains(player.userID) && player.userID > 1000000000UL)
                                        {
                                            Vector3[] bonePositions = player.GetBonePositions();
                                            Vector2[] array = new Vector2[16];
                                            for (int i = 0; i < bonePositions.Length; i++)
                                            {
                                                Vector2 vector4 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions[i]);
                                                array[i] = new Vector2(vector4.x, Screen.height - vector4.y);
                                            }
                                            Rendering.DrawLine11(array[0], array[1], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[2], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[2], array[3], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[4], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[7], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[4], array[5], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[7], array[8], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[5], array[6], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[8], array[9], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[3], array[10], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[3], array[13], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[10], array[11], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[13], array[14], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[11], array[12], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[14], array[15], CFG.Setting.skele);
                                        }
                                        if (vector3.z > 2f && CFG.Setting.boneESP && player.IsAlive() && player.userID < 1000000000UL && !CFG.Setting.friendsList.Contains(player.userID))
                                        {
                                            Vector3[] bonePositions = player.GetBonePositions();
                                            Vector2[] array = new Vector2[16];
                                            for (int i = 0; i < bonePositions.Length; i++)
                                            {
                                                Vector2 vector4 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions[i]);
                                                array[i] = new Vector2(vector4.x, Screen.height - vector4.y);
                                            }
                                            Rendering.DrawLine1(array[0], array[1], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[1], array[2], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[2], array[3], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[1], array[4], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[1], array[7], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[4], array[5], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[7], array[8], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[5], array[6], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[8], array[9], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[3], array[10], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[3], array[13], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[10], array[11], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[13], array[14], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[11], array[12], CFG.Setting.skele);
                                            Rendering.DrawLine1(array[14], array[15], CFG.Setting.skele);
                                        }
                                        if (vector3.z > 2f && CFG.Setting.boneESP && player.IsAlive() && player.userID < 1000000000UL && CFG.Setting.friendsList.Contains(player.userID))
                                        {
                                            Vector3[] bonePositions = player.GetBonePositions();
                                            Vector2[] array = new Vector2[16];
                                            for (int i = 0; i < bonePositions.Length; i++)
                                            {
                                                Vector2 vector4 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions[i]);
                                                array[i] = new Vector2(vector4.x, Screen.height - vector4.y);
                                            }
                                            Rendering.DrawLine11(array[0], array[1], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[2], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[2], array[3], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[4], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[1], array[7], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[4], array[5], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[7], array[8], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[5], array[6], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[8], array[9], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[3], array[10], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[3], array[13], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[10], array[11], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[13], array[14], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[11], array[12], CFG.Setting.skele);
                                            Rendering.DrawLine11(array[14], array[15], CFG.Setting.skele);
                                        }
                                        if (CFG.Setting.gggf && player.userID > 1000000000UL)
                                        {
                                            if (!player.IsWounded() && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), (player.GetHeldEntity() != null) ? (menu.enru ? player.GetHeldEntity().GetItem().info.displayName.english : traah.Translate(player.GetHeldEntity().GetItem().info.displayName.english)) : "", PlayerColor, true, 8);
                                            }

                                            if (player.IsWounded() && !CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "Wounded" : "ЛЕЖИТ")), new Color32(255, 0, 0, 255), true, 8);
                                            }

                                            Color32 newColourRange = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 255);

                                            if (player.IsWounded() && CFG.Setting.friendsList.Contains(player.userID))
                                            {
                                                Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "WOUNDED FUCKER" : "ПРИЛЁГ ДАЛБАЁБ")), randomColor, true, 8);
                                            }
                                        }

                                    }


                                }
                                else
                                {
                                    if (cameradistance <= CFG.Setting.sdd)
                                    {
                                        if (player.IsSleeping() && CFG.Setting.fdf)
                                        {
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", player.displayName, distance), new Color32(0, 62, 179, 255), true, 8);
                                        }
                                    }
                                }

                                if (CFG.Setting.vbvc)
                                {
                                    if (cameradistance <= CFG.Setting.sdd && player.userID < 1000000000UL)
                                    {

                                        Rendering.DrawVerticalHealth(new Vector2(screenPos.x, Screen.height - screenPos.y), width, num4, player.health);

                                        Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y), string.Format("{0} [{1}]", "NPC", distance), Color.blue, true, 8);
                                        if (!player.IsWounded() && !CFG.Setting.friendsList.Contains(player.userID))
                                        {
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), (player.GetHeldEntity() != null) ? (menu.enru ? player.GetHeldEntity().GetItem().info.displayName.english : traah.Translate(player.GetHeldEntity().GetItem().info.displayName.english)) : "", PlayerColor, true, 8);
                                        }

                                        if (player.IsWounded() && !CFG.Setting.friendsList.Contains(player.userID))
                                        {
                                            Rendering.DrawString1(new Vector2(vector3.x, Screen.height - vector3.y - -10f), string.Format("{0}", (menu.enru ? "Wounded" : "ЛЕЖИТ")), new Color32(255, 0, 0, 255), true, 8);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (CFG.Setting.gggg)
                    {
                        BasePlayer bb = null;
                        float gggg = 999f;
                        if (BasePlayer.VisiblePlayerList != null)
                        {
                            foreach (BasePlayer ffff in BasePlayer.VisiblePlayerList)
                            {

                                {
                                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                                    if (num2 <= CFG.Setting.fov1 && num2 < gggg)
                                    {
                                        gggg = num2;
                                        bb = ffff;
                                    }
                                }
                            }
                        }
                        if (bb != null && !bb.IsDead() && !bb.IsSleeping() && !bb.IsLocalPlayer() && !CFG.Setting.friendsList.Contains(bb.userID))
                        {
                            int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, bb.transform.position);
                            Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(bb.transform.position);
                            Vector3 screenPos = Players.GetScreenPos(bb.transform.position);
                            if (screenPos.z > 0f && dist <= CFG.Setting.sdd)
                            {
                                Rendering.DrawString1(new Vector2(screenPos.x, Screen.height - screenPos.y - +15f), string.Format("{0}", (menu.enru ? "TARGET" : "ЦЕЛЬ")), Color.green, true, 8);
                            }
                        }
                    }

                    BasePlayer gg = null;
                    float rr = 999f;
                    if (BasePlayer.VisiblePlayerList != null)
                    {
                        foreach (BasePlayer ffff in BasePlayer.VisiblePlayerList)
                        {

                            {
                                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                                if (num2 <= CFG.Setting.fov1 && num2 < rr)
                                {
                                    nameTargetKILL = ffff.displayName;
                                    rr = num2;
                                    gg = ffff;
                                }
                            }
                        }
                    }
                    if (gg != null && !gg.IsDead() && !gg.IsSleeping() && !gg.IsLocalPlayer() && !CFG.Setting.friendsList.Contains(gg.userID))
                    {
                        Vector3 positionBone = Players.GetPositionBone(gg.GetModel(), "head");
                        bool flag6 = !(positionBone == Vector3.zero) || !CFG.Setting.greg;
                        if (flag6)
                        {
                            Vector3 screenPos = Players.GetScreenPos(positionBone + new Vector3(0f, 0f, 0f));
                            bool flag7 = screenPos.z > 3f && CFG.Setting.greg;
                            if (flag7)
                            {
                                GUI.color = Color.white;
                                draw.DrawString1(new Vector2(Screen.width / 2f, Screen.height / 1.89f), string.Format("<b>[{0}]</b>", nameTargetKILL), Color.green, false, 12, FontStyle.Bold);
                                draw.DrawLine(new Vector2(Screen.width / 2f, Screen.height / 2f), new Vector2(screenPos.x + 0f, Screen.height - screenPos.y + 0f), 1f);
                            }
                        }
                    }


                    BasePlayer basePlayer = null;
                    float num = 999f;
                    if (BasePlayer.VisiblePlayerList != null)
                    {
                        foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
                        {

                            {
                                Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer2.transform.position + new Vector3(0f, 1.7f, 0f));
                                float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                                if (num2 <= CFG.Setting.fov && num2 < num)
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
                        if (screenPos.z > 0f && CFG.Setting.Cloth)
                        {
                            List<Item> list = new List<Item>();
                            list = basePlayer.inventory.containerWear.itemList;

                            GUI.DrawTexture(new Rect((float)Screen.width - 470, 60f, 200f, 35f + list.Count * 13), HukTexture.mTe2x1);
                            Rendering.DrawString1(new Vector2((float)Screen.width - 370, 70f), (menu.enru ? "[Clothing]" : "[Одежда]"), new Color32(12, 155, 171, 255), true, 10, FontStyle.Bold, 1);
                            for (int i = 0; i < list.Count; i++)
                            {

                                Rendering.DrawString1(new Vector2((float)Screen.width - 370, 70f + (i + 1) * 13), (menu.enru ? list[i].info.displayName.english : traah.Translate(list[i].info.displayName.english)), new Color32(255, 145, 0, 255), true, 10, FontStyle.Bold, 1);

                            }

                        }

                        if (screenPos.z > 0f && menu.tt)
                        {
                            List<Item> list = new List<Item>();
                            list = basePlayer.inventory.containerMain.itemList;
                            for (int i = 0; i < list.Count; i++)
                            {
                                Rendering.DrawString1(new Vector2(Screen.width - 150f, 60f), "Инвентарь", new Color32(12, 155, 171, 255), false, 10, FontStyle.Bold, 1);
                                Rendering.DrawString1(new Vector2((float)Screen.width - 150, 70f + (i + 1) * 16), traah.Translate(list[i].info.displayName.english), Color.green, true, 10, FontStyle.Bold, 1);
                            }
                        }
                        if (screenPos.z > 0f && CFG.Setting.bb)
                        {

                            Item[] array = basePlayer.inventory.AllItems();
                            Rect rect = new Rect(Screen.width - 250f, 60f, 200f, 35f + array.Length * 16);
                            GUI.DrawTexture(new Rect(Screen.width - 268f, 60f, 200f, 35f + array.Length * 16), HukTexture.mTex1);
                            if (basePlayer.IsWounded())
                            {
                                Rendering.DrawString1(new Vector2((float)Screen.width - 175, 70f), string.Format("{0}", (menu.enru ? "[Wounded]" : "[ЛЕЖИТ]")), new Color32(255, 0, 0, 255), true, 10, FontStyle.Bold, 1);
                            }
                            Rendering.DrawString1(new Vector2(Screen.width - 240f, 70f), "[" + (int)basePlayer.health + "HP] ", new Color32(45, 186, 2, 255), false, 10, FontStyle.Bold, 1);
                            Rendering.DrawString1(new Vector2(Screen.width - 240f, 60f), basePlayer.displayName, new Color32(12, 155, 171, 255), false, 10, FontStyle.Bold, 1);
                            for (int i = 0; i < array.Length; i++)
                            {
                                Texture2D texture = array[i].info.iconSprite.texture;
                                if (array[i] != null)
                                {
                                    Rendering.DrawString1(new Vector2(Screen.width - 240f, 70f + (i + 1) * 16), "[" + array[i].amount.ToString() + "x] " + (menu.enru ? array[i].info.displayName.english : traah.Translate(array[i].info.displayName.english)), new Color32(255, 255, 255, 255), false, 10, FontStyle.Bold, 1);
                                }
                                GUI.DrawTexture(new Rect(Screen.width - 260f, 70f + (i + 1) * 16f, 16f, 16f), texture);
                            }
                        }

                    }
                    if (CFG.Setting.hot)
                    {
                        BasePlayer ff = null;
                        float fff = 999f;
                        if (BasePlayer.VisiblePlayerList != null)
                        {
                            foreach (BasePlayer ffff in BasePlayer.VisiblePlayerList)
                            {

                                {
                                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(ffff.transform.position + new Vector3(0f, 1.7f, 0f));
                                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                                    if (num2 <= CFG.Setting.fov && num2 < fff)
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
                            if (screenPos.z > 0f && dist <= CFG.Setting.sdd && !ff.IsWounded())
                            {


                                List<Item> list = new List<Item>();
                                list = ff.inventory.containerBelt.itemList;
                                GUI.DrawTexture(new Rect(screenPos.x, Screen.height - screenPos.y - -22f, - -60f, +(list.Count * 11)), HukTexture.mTex1);
                                GUI.DrawTexture(new Rect(screenPos.x, Screen.height - screenPos.y - -22f, -60f, +(list.Count * 11)), HukTexture.mTex1);
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Rendering.DrawString1(new Vector3(screenPos.x, Screen.height - screenPos.y - -10f + (i + 1) * 10), (menu.enru ? list[i].info.displayName.english : traah.Translate(list[i].info.displayName.english)), new Color32(255, 145, 0, 255), true, 8, FontStyle.Bold, 1);


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
    public static bool boneESP;

    private void Update()
    {

        randomColor = new Color(
    Mathf.PingPong(UnityEngine.Time.time * speedR, 100) / 100,
    Mathf.PingPong(UnityEngine.Time.time * speedG, 100) / 100,
    Mathf.PingPong(UnityEngine.Time.time * speedB, 100) / 100);
    }

    private void Start()
    {
        ChangeMaxValue();
    }
    public static Color randomColor;
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

    private void OnGUI()
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
    public static string nameTargetKILL;
}

