using System;
using UnityEngine;

public class radar2D : MonoBehaviour
{
	private void radar()
	{
		if (CFG.Radar.radarrrrr)
		{

			if (radar2D.size % 2f != 0f)
			{
				radar2D.size -= 1f;
			}
			GUI.color = Color.white;
			if (menu.gui)

			{

				GUI.DrawTexture(new Rect((float)radar2D.left, (float)radar2D.up, (float)radar2D.size, (float)radar2D.size), HukTexture.mTex);
				GUI.DrawTexture(new Rect(20, 280, (float)radar2D.size, (float)radar2D.size), HukTexture.mTex4);
			}
			if (!menu.gui)
			{
				GUI.DrawTexture(new Rect((float)radar2D.left, (float)radar2D.up, (float)radar2D.size, (float)radar2D.size), HukTexture.mTex);
			}
			GUI.color = Color.white;
			foreach (BasePlayer basePlayer in BasePlayer.visiblePlayerList)
			{
				if (basePlayer.health > 0f && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer() && CFG.Radar.radar && CFG.Radar.radarrrrr && basePlayer.userID > 10000000000U)
				{
					Vector3 centerPos = menu.localplayer.transform.position;
					Vector3 extPos = basePlayer.transform.position;
					float dist = Vector3.Distance(centerPos, extPos);
					float dx = centerPos.x - extPos.x;
					float dz = centerPos.z - extPos.z;
					float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
					float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
					float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
					bX = bX * ((float)radar2D.size / (float)radar2D.dist) / 2f;
					bY = bY * ((float)radar2D.size / (float)radar2D.dist) / 2f;
					if (dist <= radar2D.dist)
					{
						GUI.color = Color.white;
						if (!friend.friendsList.Contains(basePlayer.userID))
							GUI.DrawTexture(new Rect((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f, 6, 6), HukTexture.merr);
						Rendering.DrawString1(new Vector2((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f), string.Format("  [{0}m]", (int)dist), Color.white, true, 7, FontStyle.Bold, 1);

						GUI.color = Color.white;
						if (friend.friendsList.Contains(basePlayer.userID))
							GUI.DrawTexture(new Rect((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f, 6, 6), HukTexture.merr1);
						Rendering.DrawString1(new Vector2((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f), string.Format("  [{0}m]", (int)dist), Color.white, true, 7, FontStyle.Bold, 1);
					}
				}
			}
			if (menu.sleep && CFG.Radar.radarrrrr)
			{
				foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
				{
					if (basePlayer2.health > 0f && basePlayer2.IsSleeping() && !basePlayer2.IsLocalPlayer())
					{
						Vector3 centerPos = menu.localplayer.transform.position;
						Vector3 extPos = basePlayer2.transform.position;
						float dist = Vector3.Distance(centerPos, extPos);
						float dx = centerPos.x - extPos.x;
						float dz = centerPos.z - extPos.z;
						float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
						float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
						float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
						bX = bX * ((float)radar2D.size / (float)radar2D.dist) / 2f;
						bY = bY * ((float)radar2D.size / (float)radar2D.dist) / 2f;
						if (dist <= radar2D.dist)
						{
							GUI.color = Color.white;
							GUI.DrawTexture(new Rect((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f, 6, 6), HukTexture.merr2);
							GUI.color = Color.white;
						}
					}
				}
			}
			if (CFG.Radar.radarnpc && CFG.Radar.radarrrrr)
			{
				foreach (BasePlayer basePlayer2 in BasePlayer.visiblePlayerList)
				{
					if (basePlayer2.health > 0f && !basePlayer2.IsSleeping() && !basePlayer2.IsLocalPlayer() && CFG.Radar.radarnpc && basePlayer2.userID < 10000000000U)
					{
						Vector3 centerPos = menu.localplayer.transform.position;
						Vector3 extPos = basePlayer2.transform.position;
						float dist = Vector3.Distance(centerPos, extPos);
						float dx = centerPos.x - extPos.x;
						float dz = centerPos.z - extPos.z;
						float deltay = Mathf.Atan2(dx, dz) * Mathf.Rad2Deg - 270 - menu.localplayer.transform.eulerAngles.y;
						float bX = dist * Mathf.Cos(deltay * Mathf.Deg2Rad);
						float bY = dist * Mathf.Sin(deltay * Mathf.Deg2Rad);
						bX = bX * ((float)radar2D.size / (float)radar2D.dist) / 2f;
						bY = bY * ((float)radar2D.size / (float)radar2D.dist) / 2f;
						if (dist <= radar2D.dist)
						{
							GUI.color = Color.white;
							GUI.DrawTexture(new Rect((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f, 6, 6), HukTexture.merr3);
							Rendering.DrawString1(new Vector2((float)(radar2D.left + radar2D.size / 2) + bX - 3f, (float)(radar2D.up + radar2D.size / 2) + bY - 3f), string.Format("  [{0}m]", (int)dist), Color.white, true, 7, FontStyle.Bold, 1);
							GUI.color = Color.white;
						}
					}
				}
			}

		}
	}



	private void OnGUI()
	{
		this.radar();

	}
	public static float left = 20f;
	public static float up = 40;
	public static float size = 240;

	public static float size1 = 230;
	public static float dist = 350f;
}
