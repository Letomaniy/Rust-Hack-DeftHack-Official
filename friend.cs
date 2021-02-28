using System.Collections.Generic;

using UnityEngine;


public class friend : MonoBehaviour
{
    private void Start()
    {
        CFG.Setting.friendsList = new HashSet<ulong>();
    }



    public static void AddFriend()
    {
        BasePlayer basePlayer = null;
        float num = 999f;
        if (BasePlayer.VisiblePlayerList != null)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {

                {
                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer2.transform.position + new Vector3(0f, 1.7f, 0f));
                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(vector.x, Screen.height - vector.y)));
                    if (num2 <= 400 && num2 < num)
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
            if (screenPos.z > 0f)
            {
                if (LocalPlayer.Entity != null)
                {

                    if (!CFG.Setting.friendsList.Contains(basePlayer.userID))
                    {
                        CFG.Setting.friendsList.Add(basePlayer.userID);
                        return;
                    }
                    CFG.Setting.friendsList.Remove(basePlayer.userID);

                }
            }
        }
    }
    public static bool IsFriend(BasePlayer player)
    {
        return player != null && CFG.Setting.friendsList.Contains(player.userID);
    }
    public static HashSet<ulong> friendsList;
}

