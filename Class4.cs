using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class draw
{
	// Token: 0x0600011D RID: 285 RVA: 0x0000F64C File Offset: 0x0000D84C
	public static void RectFilled(float x, float y, float width, float height, Color color)
	{
		bool flag = color != draw.textureColor;
		bool flag2 = flag;
		if (flag2)
		{
			draw.textureColor = color;
			draw.texture.SetPixel(0, 0, color);
			draw.texture.Apply();
		}
		GUI.DrawTexture(new Rect(x, y, width, height), draw.texture);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
	public static void RectOutlined(float x, float y, float width, float height, Color color, float thickness = 1f)
	{
		draw.RectFilled(x, y, thickness, height, color);
		draw.RectFilled(x + width - thickness, y, thickness, height, color);
		draw.RectFilled(x + thickness, y, width - thickness * 2f, thickness, color);
		draw.RectFilled(x + thickness, y + height - thickness, width - thickness * 2f, thickness, color);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002474 File Offset: 0x00000674
	internal static void DrawString(Vector2 vector2, string v1, Color yellow, bool v2, int v3, int v4)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000F708 File Offset: 0x0000D908


	// Token: 0x06000121 RID: 289 RVA: 0x0000FA98 File Offset: 0x0000DC98
	public static void DrawString1(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold, int depth = 1)
	{
		draw.style.fontSize = size;
		draw.style.richText = true;
		draw.style.font = draw.tahoma;
		draw.style.normal.textColor = color;
		draw.style.fontStyle = fontStyle;
		draw.outlineStyle.fontSize = size;
		draw.outlineStyle.richText = true;
		draw.outlineStyle.font = draw.tahoma;
		draw.outlineStyle.normal.textColor = new Color(0f, 0f, 0f, 1f);
		draw.outlineStyle.fontStyle = fontStyle;
		GUIContent content = new GUIContent(text);
		GUIContent content2 = new GUIContent(text);
		if (center)
		{
			pos.x -= draw.style.CalcSize(content).x / 2f;
		}
		switch (depth)
		{
			case 0:
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 1:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 2:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 3:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000FDAC File Offset: 0x0000DFAC
	public static void DrawString(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold, int depth = 1)
	{
		draw.style.fontSize = size;
		draw.style.normal.textColor = color;
		GUIContent content = new GUIContent(text);
		GUIContent content2 = new GUIContent(text);
		if (center)
		{
			pos.x -= draw.style.CalcSize(content).x / 2f;
		}
		switch (depth)
		{
			case 0:
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 1:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 2:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
			case 3:
				GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
				GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
				break;
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00010038 File Offset: 0x0000E238
	public static void Crosshair(float x, float y, float size, Color color, float thickness = 1f)
	{
		GUI.color = Color.red;
		draw.RectFilled(x - thickness / 2f, y - size / 2f, thickness, size, color);
		draw.RectFilled(x - size / 2f, y - thickness / 2f, size, thickness, color);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0001008C File Offset: 0x0000E28C
	public static void SimpleString(Vector2 pos, string text, Color color, bool center = true, int size = 12)
	{
		draw.style.fontSize = size;
		draw.style.richText = true;
		draw.style.font = draw.tahoma;
		draw.style.normal.textColor = color;
		draw.style.fontStyle = FontStyle.Bold;
		GUIContent content = new GUIContent(text);
		if (center)
		{
			pos.x -= draw.style.CalcSize(content).x / 2f;
		}
		GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00010138 File Offset: 0x0000E338
	public static void DrawShadowString(Vector2 pos, string text, string shadowText, Color color, bool center = true, int size = 12)
	{
		draw.style.fontSize = size;
		draw.style.richText = true;
		draw.style.font = draw.tahoma;
		draw.style.normal.textColor = color;
		draw.style.fontStyle = FontStyle.Bold;
		draw.outlineStyle.fontSize = size;
		draw.outlineStyle.richText = true;
		draw.outlineStyle.font = draw.tahoma;
		draw.outlineStyle.normal.textColor = new Color(0f, 0f, 0f, 1f);
		draw.outlineStyle.fontStyle = FontStyle.Bold;
		GUIContent content = new GUIContent(text);
		GUIContent content2 = new GUIContent(shadowText);
		if (center)
		{
			pos.x -= draw.style.CalcSize(content).x / 2f;
		}
		GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, draw.outlineStyle);
		GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, draw.style);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002268 File Offset: 0x00000468
	public static void Crosshair()
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0001027C File Offset: 0x0000E47C
	public static void DrawHealth(float x, float y, float health, float maxHealth = 100f, float width = 50f, float height = 5f, float thickness = 1f)
	{
		float num = (width - thickness * 2f) * health / maxHealth;
		bool flag = num < 1f;
		bool flag2 = flag;
		if (flag2)
		{
			num = 1f;
		}
		Color color = Color.green;
		bool flag3 = health < maxHealth * 0.6f;
		bool flag4 = flag3;
		if (flag4)
		{
			color = Color.yellow;
		}
		bool flag5 = health < maxHealth * 0.3f;
		bool flag6 = flag5;
		if (flag6)
		{
			color = Color.red;
		}
		draw.RectFilled(x - width / 2f, y - height, width, height, Color.black);
		draw.RectFilled(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f, color);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00010334 File Offset: 0x0000E534
	public static void FullBox(Vector2 Head, float Width, float Height, float thickness, int distance, Color color, bool outline = false)
	{
		float num = Width / 4f;
		if (outline)
		{
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			draw.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, Width, 3f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, Width, 3f, Color.black);
		}
		draw.RectFilled(Head.x - Width / 2f, Head.y, 1f, Height - 2f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y, 1f, Height - 2f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y, Width, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, Width, 1f, color);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00010334 File Offset: 0x0000E534
	public static void FullBox1(Vector2 Head, float Width, float Height, float thickness, int distance, Color color1, bool outline = false)
	{
		float num = Width / 4f;
		if (outline)
		{
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			draw.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, Width, 3f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, Width, 3f, Color.black);
		}
		draw.RectFilled(Head.x - Width / 2f, Head.y, 1f, Height - 2f, color1);
		draw.RectFilled(Head.x + Width / 2f, Head.y, 1f, Height - 2f, color1);
		draw.RectFilled(Head.x - Width / 2f, Head.y, Width, 1f, color1);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, Width, 1f, color1);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x000104B8 File Offset: 0x0000E6B8
	public static void BoxRect(Rect rect, Color color)
	{
		bool flag = color != draw.textureColor;
		bool flag2 = flag;
		if (flag2)
		{
			draw.texture.SetPixel(0, 0, color);
			draw.texture.Apply();
			draw.textureColor = color;
		}
		GUI.DrawTexture(rect, draw.texture);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00010504 File Offset: 0x0000E704
	public static void DrawLine(Vector2 startPos, Vector2 endPos, Color color, float thickness)
	{
		bool flag = draw.texture != null;
		bool flag2 = flag;
		if (flag2)
		{
			draw.texture.SetPixel(0, 0, color);
			draw.texture.wrapMode = TextureWrapMode.Repeat;
			draw.texture.Apply();
		}
		draw.DrawLineStretched(startPos, endPos, draw.texture, thickness);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00010504 File Offset: 0x0000E704
	public static void DrawLine1(Vector2 startPos, Vector2 endPos, Color color, float thickness)
	{
		bool flag = draw.texture != null;
		bool flag2 = flag;
		if (flag2)
		{
			draw.texture.SetPixel(0, 0, color);
			draw.texture.wrapMode = TextureWrapMode.Repeat;
			draw.texture.Apply();
		}
		draw.DrawLineStretched(startPos, endPos, draw.texture, thickness);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000910C File Offset: 0x0000730C
	public static void DrawLineStretched(Vector2 lineStart, Vector2 lineEnd, Texture2D texture, float thickness)
	{
		Vector2 vector = lineEnd - lineStart;
		float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
		bool flag = vector.x < 0f;
		bool flag2 = flag;
		if (flag2)
		{
			num += 180f;
		}
		bool flag3 = thickness < 1f;
		bool flag4 = flag3;
		if (flag4)
		{
			thickness = 1f;
		}
		int num2 = (int)Mathf.Ceil(thickness / 2f);
		GUIUtility.RotateAroundPivot(num, lineStart);
		GUI.DrawTexture(new Rect(lineStart.x, lineStart.y - (float)num2, vector.magnitude, thickness), texture);
		GUIUtility.RotateAroundPivot(0f - num, lineStart);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00010558 File Offset: 0x0000E758
	public static void DrawVerticalHealth(Vector2 Head, float Width, float Height, float health)
	{
		float num = Width / 4f;
		float num2 = health / Height / 100f;
		bool flag = health > 0f;
		bool flag2 = flag;
		if (flag2)
		{
			Color color = Color.green;
			bool flag3 = health < 60f;
			bool flag4 = flag3;
			if (flag4)
			{
				color = Color.yellow;
			}
			bool flag5 = health < 50f;
			bool flag6 = flag5;
			if (flag6)
			{
				color = Color.yellow;
			}
			bool flag7 = health < 25f;
			bool flag8 = flag7;
			if (flag8)
			{
				color = Color.red;
			}
			bool flag9 = health <= 0f;
			bool flag10 = flag9;
			if (flag10)
			{
				color = Color.red;
			}
			draw.RectFilled(Head.x - Width / 2f - 4f, Head.y - 1f, 3f, 1f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 4f, Head.y, 1f, Height - 2f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y, 1f, Height - 2f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 4f, Head.y + Height - 2f, 3f, 1f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y, -2f, Height - 2f, color);
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00010700 File Offset: 0x0000E900
	public static void DrawVerticalHealth11(Vector2 Head, float Width, float Height, float health)
	{
		int num = (int)(Width / 4f);
		float num2 = health / Height / 100f;
		bool flag = num2 >= 1f && num2 >= 0f;
		bool flag2 = flag;
		if (flag2)
		{
		}
		bool flag3 = health > 0f;
		bool flag4 = flag3;
		if (flag4)
		{
			Color color = Color.green;
			bool flag5 = health < 70f;
			bool flag6 = flag5;
			if (flag6)
			{
				color = Color.yellow;
			}
			bool flag7 = health < 50f;
			bool flag8 = flag7;
			if (flag8)
			{
				color = new Color(1f, 0.7f, 0.16f, 1f);
			}
			bool flag9 = health < 25f;
			bool flag10 = flag9;
			if (flag10)
			{
				color = Color.red;
			}
			bool flag11 = health <= 0f;
			bool flag12 = flag11;
			if (flag12)
			{
				color = Color.clear;
			}
			Rendering.DrawString1(new Vector2(Head.x, Head.y - -15f), " " + ((int)health).ToString(), color, true, 10, FontStyle.Bold, 3);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0001081C File Offset: 0x0000EA1C
	public static void DrawVerticalHealth1(Vector2 Head, float Width, float Height, float health)
	{
		int num = (int)(Width / 4f);
		float num2 = health / Height / 100f;
		bool flag = num2 >= 1f && num2 >= 0f;
		bool flag2 = flag;
		if (flag2)
		{
		}
		bool flag3 = health > 0f;
		bool flag4 = flag3;
		if (flag4)
		{
			Color color = Color.green;
			bool flag5 = health < 70f;
			bool flag6 = flag5;
			if (flag6)
			{
				color = Color.yellow;
			}
			bool flag7 = health < 50f;
			bool flag8 = flag7;
			if (flag8)
			{
				color = new Color(1f, 0.7f, 0.16f, 1f);
			}
			bool flag9 = health < 25f;
			bool flag10 = flag9;
			if (flag10)
			{
				color = Color.red;
			}
			bool flag11 = health <= 0f;
			bool flag12 = flag11;
			if (flag12)
			{
				color = Color.clear;
			}
			Rendering.DrawString1(new Vector2(Head.x, Head.y - 30f), "❤ " + ((int)health).ToString() + "❤", color, true, 10, FontStyle.Bold, 3);
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0001093C File Offset: 0x0000EB3C
	public static void CornerBox(Vector2 Head, float Width, float Height, float thickness, Color color, bool outline)
	{
		int num = (int)(Width / 4f);
		int num2 = num;
		if (outline)
		{
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
			draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
			draw.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
			draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 2), Color.black);
			draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
			draw.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 3), Color.black);
		}
		draw.RectFilled(Head.x - Width / 2f, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)(num2 + 1), color);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00010C5C File Offset: 0x0000EE5C
	public static void PlayerCornerBox1(Vector2 Head, float Width, float Height, float thickness, int distance, Color color)
	{
		int num = (int)(Width / 4f);
		int num2 = num;
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, (float)(num + 2), 3f, color);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), color);
		draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y - 1f, (float)(num + 2), 3f, color);
		draw.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), color);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, color);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 2), color);
		draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, color);
		draw.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 3), color);
		draw.RectFilled(Head.x - Width / 2f, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)(num2 + 1), color);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00010F58 File Offset: 0x0000F158
	public static void PlayerCornerBox(Vector2 Head, float Width, float Height, float thickness, int distance, Color color)
	{
		int num = (int)(Width / 4f);
		int num2 = num;
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
		draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
		draw.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
		draw.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 2), Color.black);
		draw.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
		draw.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 3), Color.black);
		draw.RectFilled(Head.x - Width / 2f, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y, 1f, (float)num2, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x - Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)num2, color);
		draw.RectFilled(Head.x + Width / 2f - (float)num, Head.y + Height - 3f, (float)num, 1f, color);
		draw.RectFilled(Head.x + Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)(num2 + 1), color);
	}

	// Token: 0x04000117 RID: 279
	private static Color textureColor;

	// Token: 0x04000118 RID: 280
	private static Color outlineColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x04000119 RID: 281
	private static Texture2D texture = new Texture2D(1, 1);

	// Token: 0x0400011A RID: 282
	private static GUIStyle style = new GUIStyle(GUI.skin.label)
	{
		fontSize = 12
	};

	// Token: 0x0400011B RID: 283
	private static GUIStyle outlineStyle = new GUIStyle(GUI.skin.label)
	{
		fontSize = 12
	};

	// Token: 0x0400011C RID: 284
	public static Font tahoma = Font.CreateDynamicFontFromOSFont("Consolas", 12);
}
