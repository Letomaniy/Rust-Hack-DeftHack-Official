using System;
using UnityEngine;


	// Token: 0x0200006F RID: 111
	internal class aimbot
	{
		// Token: 0x0600029B RID: 667
		public static BasePlayer GetTarget()
		{
			BasePlayer result = null;
			new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
			float num = 1000f;
			foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
			{
				if (!(basePlayer == null) && !basePlayer.IsLocalPlayer() && basePlayer.health > 0f && !friend.friendsList.Contains(basePlayer.userID) && !basePlayer.IsDead())
				{
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.transform.position);
					new Vector2(vector.x, (float)Screen.height - vector.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
					if (num2 <= (float)menu.fov && num2 < num && basePlayer.IsAlive())
					{
						num = num2;
						result = basePlayer;
					}
				}
			}
			return result;
		}

		// Token: 0x0600029C RID: 668
		public static float BulletDrop(Vector3 v1, Vector3 v2, float BulletSpeed)
		{
			float num = Vector3.Distance(v1, v2);
			float result;
			if ((double)num >= 0.001)
			{
				float num2 = 9.81f;
				float num3 = num / BulletSpeed;
				result = (float)(0.5 * (double)num2 * (double)num3 * (double)num3);
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600029D RID: 669
		public static void Aim()
		{
			Vector3 posTargetPlayer = aimbot.GetPosTargetPlayer();
			if (!(posTargetPlayer == Vector3.zero))
			{
				Quaternion quaternion = Quaternion.LookRotation(posTargetPlayer - MainCamera.mainCamera.transform.position, Vector3.right);
				float num = quaternion.eulerAngles.x;
				num = ((MainCamera.mainCamera.transform.position.y < posTargetPlayer.y) ? (-360f + num) : num);
				num = Mathf.Clamp(num, -89f, 89f);
				LocalPlayer.Entity.input.SetViewVars(new Vector3(num, quaternion.eulerAngles.y, 0f));
			}
		}

		// Token: 0x0600029E RID: 670
		public static Vector3 GetBonePosition(Model playerModel, string boneName)
		{
			Vector3 zero = Vector3.zero;
			Vector3 result;
			if (playerModel == null)
			{
				result = zero;
			}
			else if (boneName == "headCenter")
			{
				result = new Vector3(playerModel.headBone.position.x, playerModel.eyeBone.position.y, playerModel.headBone.position.z);
			}
			else
			{
				result = playerModel.FindBone(boneName).position;
			}
			return result;
		}

		// Token: 0x0600029F RID: 671
		private static Vector3 GetPosTargetPlayer()
		{
			Vector3 result = Vector3.zero;
			Vector2 a = new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2));
			float num = 999f;
			foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
			{
				if (!friend.friendsList.Contains(basePlayer.userID) && !(basePlayer == null) && !basePlayer.IsLocalPlayer() && !basePlayer.IsSleeping() && basePlayer.health > 0f)
				{
					Vector3 bonePosition;
					if (aimbot.head)
					{
						bonePosition = aimbot.GetBonePosition(basePlayer.GetModel(), "headCenter") + new Vector3(0f, 0.05f, 0f);
				}
					else
					{
						bonePosition = aimbot.GetBonePosition(basePlayer.GetModel(), "bodyCenter") + new Vector3(0f,0.2f,0f);
					}
					if (!(bonePosition == Vector3.zero))
					{
						Vector3 screenPos = Players.GetScreenPos(bonePosition);
						if (screenPos.z > 0f)
						{
							Vector2 b = new Vector2(screenPos.x, (float)Screen.height - screenPos.y);
							float num2 = Mathf.Abs(Vector2.Distance(a, b));
							if (num2 <= (float)menu.fov && num2 <= num)
							{
								result = bonePosition;
								num = num2;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x04000381 RID: 897
		public static bool head;
	}
