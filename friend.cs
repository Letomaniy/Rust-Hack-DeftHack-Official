using System;
using System.Collections.Generic;
using UnityEngine;


    public class friend : MonoBehaviour
    {
        private void Start()
        {
            friend.friendsList = new HashSet<ulong>();
        }

       

        public static void AddFriend()
        {
        BasePlayer basePlayer = null;
        float num = 999f;
        if (BasePlayer.visiblePlayerList != null)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
            {

                {
                    Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer2.transform.position + new Vector3(0f, 1.7f, 0f));
                    float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
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
                    
                        if (!friend.friendsList.Contains(basePlayer.userID))
                        {
                            friend.friendsList.Add(basePlayer.userID);
                            return;
                        }
                        friend.friendsList.Remove(basePlayer.userID);
                    
                }
            }
        }
            }
        public static bool IsFriend(BasePlayer player)
        {
            return player != null && friend.friendsList.Contains(player.userID);
        }
        public static HashSet<ulong> friendsList;
    }

