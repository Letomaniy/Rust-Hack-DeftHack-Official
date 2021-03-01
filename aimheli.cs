using System;
using UnityEngine;

internal class aimheli : MonoBehaviour
{
	public static void aimhel()
	{
		Vector3 posTargetPlayer = aimheli.opg();
		if (posTargetPlayer != Vector3.zero)
		{
			Vector3 vector = posTargetPlayer;
			Quaternion quaternion = Quaternion.LookRotation(vector - MainCamera.mainCamera.transform.position, Vector3.right);
			float num = quaternion.eulerAngles.x;
			num = ((MainCamera.mainCamera.transform.position.y < vector.y) ? (-360f + num) : num);
			num = Mathf.Clamp(num, -89f, 89f);
			LocalPlayer.Entity.input.SetViewVars(new Vector3(num, quaternion.eulerAngles.y, 0f));
		}
	}
	public static float BulletDrop(Vector3 v1, Vector3 v2, float BulletSpeed)
	{
		float num = Vector3.Distance(v1, v2);
		float result;
		if ((double)num < 0.001)
		{
			result = 0f;
		}
		else
		{
			float num2 = 9.81f;
			float num3 = num / BulletSpeed;
			result = (float)(0.5 * (double)num2 * (double)num3 * (double)num3);
		}
		return result;
	}
	private static Vector3 opg()
	{
		Vector3 result = Vector3.zero;
		Vector2 a = new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2));
		float num = 999f;
		foreach (BaseHelicopter basePlayer in companent.heli1)
		{
			if (!(basePlayer == null)  && basePlayer.health > 0f)
			{
				Vector3 bonePosition;
				if (true)
				{
					bonePosition = basePlayer.mainRotor.transform.position;
				}
				
				if (!(bonePosition == Vector3.zero) && true)
				{
					Vector3 screenPos = Players.GetScreenPos(bonePosition);
					if (screenPos.z > 0f)
					{
						Vector2 b = new Vector2(screenPos.x, (float)Screen.height - screenPos.y);
						float num2 = Mathf.Abs(Vector2.Distance(a, b));
						if (num2 <= 360 && num2 <= num)
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
}
