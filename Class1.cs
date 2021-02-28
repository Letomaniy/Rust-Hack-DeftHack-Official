using UnityEngine;

public class Rendering
{
    private static Color color_0;
    private static GUIStyle guistyle_0 = new GUIStyle(GUI.skin.label);
    private static readonly Texture2D texture2D_0 = new Texture2D(1, 1);
    private static Texture2D figTex;
    private static Color lfgColor;
    private static Color textureColor;
    public static Font tahoma = Font.CreateDynamicFontFromOSFont("Tahoma", 12);
    private static readonly Texture2D aaLineTex = null;
    private static readonly Texture2D lineTex = null;
    private static readonly Material blitMaterial = null;
    private static readonly Material blendMaterial = null;
    private static Rect lineRect = new Rect(0, 0, 1, 1);
    private static readonly Material lineMaterial = null;
    private static Color outlineColor = new Color(0f, 0f, 0f, 1f);

    public static void DrawString(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold)
    {
        Rendering.outlineStyle.fontStyle = fontStyle;
        Rendering.style.fontStyle = fontStyle;
        guistyle_0.fontSize = size;
        guistyle_0.normal.textColor = color;
        GUIContent content = new GUIContent(text);
        if (center)
        {
            pos.x -= guistyle_0.CalcSize(content).x / 2f;
        }
        GUI.Label(new Rect(pos.x, pos.y, 300f, 40), content, guistyle_0);
        Rendering.outlineStyle.fontStyle = fontStyle;
        Rendering.style.fontStyle = fontStyle;
    }

    private static readonly Texture2D texture1 = new Texture2D(1, 1);
    private static readonly Texture2D texture2 = new Texture2D(1, 1);

    private static readonly Texture2D texture = new Texture2D(1, 1);

    private static readonly GUIStyle style = new GUIStyle(GUI.skin.label)
    {
        fontSize = 12
    };

    private static readonly GUIStyle outlineStyle = new GUIStyle(GUI.skin.label)
    {
        fontSize = 12
    };
    public static Color32 WallHackColor = new Color32(156, 39, 176, byte.MaxValue);

    public static Texture2D myTexture;

    public static Material[] ChamMats;

    public static Material wallhackMaterial;

    private static Rect linesize = new Rect(0f, 0f, 1f, 1f);
    public static void String(float x, float y, string text, Color color, bool outline = true, bool center = true)
    {
        GUIContent guicontent = new GUIContent(text);
        if (center)
        {
            x -= Rendering.style.CalcSize(guicontent).x / 2f;
        }
        if (outline)
        {
            Rendering.style.normal.textColor = Rendering.outlineColor;
            GUI.Label(new Rect(x - 1f, y, 300f, 25f), guicontent, Rendering.style);
            GUI.Label(new Rect(x + 1f, y, 300f, 25f), guicontent, Rendering.style);
            GUI.Label(new Rect(x, y + 1f, 300f, 25f), guicontent, Rendering.style);
            GUI.Label(new Rect(x, y - 1f, 300f, 25f), guicontent, Rendering.style);
        }
        Rendering.style.normal.textColor = color;
        GUI.Label(new Rect(x, y, 300f, 25f), guicontent, Rendering.style);
    }
    public static void DrawOutlinedString(Rect rect, string text, Color color)
    {
        GUIStyle guistyle = Rendering.guistyle_0;
        Rendering.guistyle_0.normal.textColor = Color.black;
        float num = rect.x;
        rect.x = num - 1f;
        GUI.Label(rect, text, Rendering.guistyle_0);
        rect.x += 2f;
        GUI.Label(rect, text, Rendering.guistyle_0);
        num = rect.x;
        rect.x = num - 1f;
        num = rect.y;
        rect.y = num - 1f;
        GUI.Label(rect, text, Rendering.guistyle_0);
        rect.y += 2f;
        GUI.Label(rect, text, Rendering.guistyle_0);
        num = rect.y;
        rect.y = num - 1f;
        Rendering.guistyle_0.normal.textColor = color;
        GUI.Label(rect, text, Rendering.guistyle_0);
        Rendering.guistyle_0 = guistyle;
    }
    public static void DrawString11(Vector2 pos, string text, Color color, bool center = true, int size = 12, bool outline = false, int lines = 1)
    {
        Rendering.guistyle_0.fontSize = size;
        Rendering.guistyle_0.normal.textColor = color;
        GUIContent guicontent = new GUIContent(text);
        if (center)
        {
            pos.x -= Rendering.guistyle_0.CalcSize(guicontent).x / 2f;
        }

        bool flag = !outline;
        if (flag)
        {
            GUI.Label(new Rect(pos.x, pos.y, 300f, lines * 25f), guicontent, Rendering.guistyle_0);
        }
        else
        {
            Rendering.DrawOutlinedString(new Rect(pos.x, pos.y, 300f, lines * 25f), text, color);
        }
    }
    public static void DrawLine009(Vector2 pointA, Vector2 pointB, Color color, float width, bool antiAlias)
    {
        float num = pointB.x - pointA.x;
        float num2 = pointB.y - pointA.y;
        float num3 = Mathf.Sqrt(num * num + num2 * num2);
        if (num3 >= 0.001f)
        {
            Texture2D texture = new Texture2D(1, 1);

            float num4 = width * num2 / num3;
            float num5 = width * num / num3;
            Matrix4x4 identity = Matrix4x4.identity;
            identity.m00 = num;
            identity.m01 = -num4;
            identity.m03 = pointA.x + 0.5f * num4;
            identity.m10 = num2;
            identity.m11 = num5;
            identity.m13 = pointA.y - 0.5f * num5;
            GL.PushMatrix();
            GL.MultMatrix(identity);
            GUI.color = color;
            GUI.DrawTexture(linesize, texture);
            GL.PopMatrix();
        }
    }
    public static Material[] CreateChamMaterial(Color color)
    {
        bool flag = wallhackMaterial == null;
        if (flag)
        {
            wallhackMaterial = new Material(Shader.Find("Hidden/Internal-Colored"));
            wallhackMaterial.CopyPropertiesFromMaterial(new Material("Custom/Chams-WallHack"));
            wallhackMaterial.hideFlags = HideFlags.HideAndDontSave;
            wallhackMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
            wallhackMaterial.SetInt("_SrcBlend", 5);
            wallhackMaterial.SetInt("_DstBlend", 10);
            wallhackMaterial.color = color;
        }
        bool flag2 = ChamMats == null;
        if (flag2)
        {
            ChamMats = new Material[]
            {
            wallhackMaterial,
            wallhackMaterial,
           wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial,
            wallhackMaterial
            };
        }
        return ChamMats;
    }

    public static void DrawCircle(Vector2 center, int radius, Color color, float width, int segmentsPerQuarter)
    {
        DrawCircle(center, radius, color, width, false, segmentsPerQuarter);
    }

    public static void DrawCircle(Vector2 center, int radius, Color color, float width, bool antiAlias, int segmentsPerQuarter)
    {
        float rh = (float)radius / 2;

        Vector2 p1 = new Vector2(center.x, center.y - radius);
        Vector2 p1_tan_a = new Vector2(center.x - rh, center.y - radius);
        Vector2 p1_tan_b = new Vector2(center.x + rh, center.y - radius);

        Vector2 p2 = new Vector2(center.x + radius, center.y);
        Vector2 p2_tan_a = new Vector2(center.x + radius, center.y - rh);
        Vector2 p2_tan_b = new Vector2(center.x + radius, center.y + rh);

        Vector2 p3 = new Vector2(center.x, center.y + radius);
        Vector2 p3_tan_a = new Vector2(center.x - rh, center.y + radius);
        Vector2 p3_tan_b = new Vector2(center.x + rh, center.y + radius);

        Vector2 p4 = new Vector2(center.x - radius, center.y);
        Vector2 p4_tan_a = new Vector2(center.x - radius, center.y - rh);
        Vector2 p4_tan_b = new Vector2(center.x - radius, center.y + rh);

        DrawBezierLine(p1, p1_tan_b, p2, p2_tan_a, color, width, antiAlias, segmentsPerQuarter);
        DrawBezierLine(p2, p2_tan_b, p3, p3_tan_b, color, width, antiAlias, segmentsPerQuarter);
        DrawBezierLine(p3, p3_tan_a, p4, p4_tan_b, color, width, antiAlias, segmentsPerQuarter);
        DrawBezierLine(p4, p4_tan_a, p1, p1_tan_a, color, width, antiAlias, segmentsPerQuarter);
    }

    public static void DrawLine3(Vector2 pointA, Vector2 pointB, Color color, float width, bool antiAlias)
    {


        // Note that theta = atan2(dy, dx) is the angle we want to rotate by, but instead
        // of calculating the angle we just use the sine (dy/len) and cosine (dx/len).
        float dx = pointB.x - pointA.x;
        float dy = pointB.y - pointA.y;
        float len = Mathf.Sqrt(dx * dx + dy * dy);

        // Early out on tiny lines to avoid divide by zero.
        // Plus what's the point of drawing a line 1/1000th of a pixel long??
        if (len < 0.001f)
        {
            return;
        }


        Texture2D tex;
        Material mat;
        if (antiAlias)
        {
            // Multiplying by three is fine for anti-aliasing width-1 lines, but make a wide "fringe"
            // for thicker lines, which may or may not be desirable.
            width = width * 3.0f;
            tex = aaLineTex;
            mat = blendMaterial;
        }
        else
        {
            tex = lineTex;
            mat = blitMaterial;
        }

        float wdx = width * dy / len;
        float wdy = width * dx / len;

        Matrix4x4 matrix = Matrix4x4.identity;
        matrix.m00 = dx;
        matrix.m01 = -wdx;
        matrix.m03 = pointA.x + 0.5f * wdx;
        matrix.m10 = dy;
        matrix.m11 = wdy;
        matrix.m13 = pointA.y - 0.5f * wdy;

        // Use GL matrix and Graphics.DrawTexture rather than GUI.matrix and GUI.DrawTexture,
        // for better performance. (Setting GUI.matrix is slow, and GUI.DrawTexture is just a
        // wrapper on Graphics.DrawTexture.)
        GL.PushMatrix();
        GL.MultMatrix(matrix);
        //Graphics.DrawTexture(lineRect, tex, lineRect, 0, 0, 0, 0, color, mat);
        //Replaced by:
        GUI.color = color;//this and...
        GUI.DrawTexture(lineRect, tex);//this

        GL.PopMatrix();
    }



    private static Vector2 CubeBezier(Vector2 s, Vector2 st, Vector2 e, Vector2 et, float t)
    {
        float rt = 1 - t;
        return rt * rt * rt * s + 3 * rt * rt * t * st + 3 * rt * t * t * et + t * t * t * e;
    }

    public static void DrawLine6(Vector2 pointA, Vector2 pointB, Color color)
    {
        lineMaterial.SetPass(0);
        GL.Begin(1);
        GL.Color(color);
        GL.Vertex3(pointA.x, pointA.y, 0f);
        GL.Vertex3(pointB.x, pointB.y, 0f);
        GL.End();
    }

    public static void BoxRect(Rect rect, Color color)
    {
        if (color != color_0)
        {
            texture2D_0.SetPixel(0, 0, color);
            texture2D_0.Apply();
            color_0 = color;
        }
        GUI.DrawTexture(rect, texture2D_0);
    }


    public static void DrawBezierLine(Vector2 start, Vector2 startTangent, Vector2 end, Vector2 endTangent, Color color, float width, bool antiAlias, int segments)
    {
        Vector2 lastV = CubeBezier(start, startTangent, end, endTangent, 0);
        for (int i = 1; i < segments + 1; ++i)
        {
            Vector2 v = CubeBezier(start, startTangent, end, endTangent, i / (float)segments);
            Rendering.DrawLine3(lastV, v, color, width, antiAlias);
            lastV = v;
        }
    }

    public static void DrawHealth(float x, float y, float health, float maxHealth = 100f, float width = 50f, float height = 5f, float thickness = 1f)
    {
        float num = (width - thickness * 2f) * health / maxHealth;
        if (num < 1f)
        {
            num = 1f;
        }
        Color color = Color.green;
        if (health < maxHealth * 0.6f)
        {
            color = Color.yellow;
        }
        if (health < maxHealth * 0.3f)
        {
            color = Color.red;
        }
        Rendering.RectFilled(x - width / 2f, y - height, width, height, Color.black);
        Rendering.RectFilled(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f, color);
    }


    public static void CornerBox(Vector2 Head, float Width, float Height, float thickness, Color color, bool outline)
    {
        int num = (int)(Width / 4f);
        int num2 = num;
        if (outline)
        {
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, num + 2, 3f, Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, num2 + 2, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - num - 1f, Head.y - 1f, num + 2, 3f, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, num2 + 2, Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, num + 2, 3f, Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - num2 - 4f, 3f, num2 + 2, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - num - 1f, Head.y + Height - 4f, num + 2, 3f, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - num2 - 4f, 3f, num2 + 3, Color.black);
        }
        Rendering.RectFilled(Head.x - Width / 2f, Head.y, num, 1f, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y, 1f, num2, color);
        Rendering.RectFilled(Head.x + Width / 2f - num, Head.y, num, 1f, color);
        Rendering.RectFilled(Head.x + Width / 2f, Head.y, 1f, num2, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, num, 1f, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - num2 - 3f, 1f, num2, color);
        Rendering.RectFilled(Head.x + Width / 2f - num, Head.y + Height - 3f, num, 1f, color);
        Rendering.RectFilled(Head.x + Width / 2f, Head.y + Height - num2 - 3f, 1f, num2 + 1, color);
    }
    public static void CornerBox1(Vector2 Head, float Width, float Height, float thickness, Color color, bool outline)
    {
        int num = (int)(Width / 4f);
        int num2 = num;
        if (outline)
        {
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, (num + 2), 3f, Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, (num2 + 2), Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - num - 1f, Head.y - 1f, (num + 2), 3f, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, (num2 + 2), Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, (num + 2), 3f, Color.black);
            Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - num2 - 4f, 3f, (num2 + 2), Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - num - 1f, Head.y + Height - 4f, (num + 2), 3f, Color.black);
            Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - num2 - 4f, 3f, (num2 + 3), Color.black);
        }
        Rendering.RectFilled(Head.x - Width / 2f, Head.y, num, 1f, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y, 1f, num2, color);
        Rendering.RectFilled(Head.x + Width / 2f - num, Head.y, num, 1f, color);
        Rendering.RectFilled(Head.x + Width / 2f, Head.y, 1f, num2, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - 9, num, 1f, color);
        Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - num2 - 9f, 1f, num2, color);
        Rendering.RectFilled(Head.x + Width / 2f - num, Head.y + Height - 9, num, 1f, color);
        Rendering.RectFilled(Head.x + Width / 2f, Head.y + Height - num2 - 9, 1f, (num2 + 1), color);
    }
    public static void DrawLine2(Vector2 startPos, Vector2 endPos, Color color, float thickness)
    {
        if (Rendering.texture != null)
        {
            Rendering.texture.SetPixel(0, 0, color);
            Rendering.texture.wrapMode = 0;
            Rendering.texture.Apply();
        }
        Rendering.DrawLineStretched(startPos, endPos, Rendering.texture, thickness);
    }
    public static void DrawLineStretched1(Vector2 lineStart, Vector2 lineEnd, Texture2D texture, float thickness)
    {
        Vector2 vector = lineEnd - lineStart;
        float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
        if (vector.x < 0f)
        {
            num += 180f;
        }
        if (thickness < 1f)
        {
            thickness = 1f;
        }
        int num2 = (int)Mathf.Ceil(thickness / 2f);
        GUIUtility.RotateAroundPivot(num, lineStart);
        GUI.DrawTexture(new Rect(lineStart.x, lineStart.y - num2, vector.magnitude, thickness), HukHealth.merr0);
        GUIUtility.RotateAroundPivot(-num, lineStart);
    }
    public static void DrawLine1(Vector2 startPos, Vector2 endPos, float thickness)
    {

        Rendering.DrawLineStretched1(startPos, endPos, Rendering.texture, thickness);
    }
    public static void DrawLineStretched11(Vector2 lineStart, Vector2 lineEnd, Texture2D texture, float thickness)
    {
        Vector2 vector = lineEnd - lineStart;
        float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
        if (vector.x < 0f)
        {
            num += 180f;
        }
        if (thickness < 1f)
        {
            thickness = 1f;
        }
        int num2 = (int)Mathf.Ceil(thickness / 2f);
        GUIUtility.RotateAroundPivot(num, lineStart);
        GUI.DrawTexture(new Rect(lineStart.x, lineStart.y - num2, vector.magnitude, thickness), HukHealth.merr);
        GUIUtility.RotateAroundPivot(-num, lineStart);
    }
    public static void DrawLine11(Vector2 startPos, Vector2 endPos, float thickness)
    {

        Rendering.DrawLineStretched11(startPos, endPos, Rendering.texture, thickness);
    }
    public static void DrawLineStretched(Vector2 lineStart, Vector2 lineEnd, Texture2D texture, float thickness)
    {
        Vector2 vector = lineEnd - lineStart;
        float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
        if (vector.x < 0f)
        {
            num += 180f;
        }
        if (thickness < 1f)
        {
            thickness = 1f;
        }
        int num2 = (int)Mathf.Ceil(thickness / 2f);
        GUIUtility.RotateAroundPivot(num, lineStart);
        GUI.DrawTexture(new Rect(lineStart.x, lineStart.y - num2, vector.magnitude, thickness), HukHealth.merr1);
        GUIUtility.RotateAroundPivot(-num, lineStart);
    }
    public static void DrawLine(Vector2 startPos, Vector2 endPos, float thickness)
    {

        Rendering.DrawLineStretched(startPos, endPos, Rendering.texture, thickness);
    }
    public static void DrawString(Vector2 pos, string text, Color color, bool center = true, int size = 12, bool stroke = true)
    {

        guistyle_0.fontSize = size;
        guistyle_0.fontStyle = FontStyle.Bold;

        GUIContent content = new GUIContent(text);
        if (center)
        {
            pos.x -= guistyle_0.CalcSize(content).x / 2f;
        }

        if (stroke)
        {
            GUI.color = UnityEngine.Color.black;
            GUI.Label(new Rect(pos.x - 1, pos.y, 300f, 25f), content, guistyle_0);
            GUI.Label(new Rect(pos.x + 1, pos.y, 300f, 25f), content, guistyle_0);
            GUI.Label(new Rect(pos.x, pos.y - 1, 300f, 25f), content, guistyle_0);
            GUI.Label(new Rect(pos.x, pos.y + 1, 300f, 25f), content, guistyle_0);
        }

        GUI.color = color;
        GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, guistyle_0);
    }

    public static void DrawString1(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold, int depth = 1)
    {

        Rendering.style.fontSize = size;
        Rendering.style.richText = true;
        Rendering.style.font = Rendering.tahoma;
        Rendering.style.normal.textColor = color;
        Rendering.style.fontStyle = fontStyle;
        Rendering.outlineStyle.fontSize = size;
        Rendering.outlineStyle.richText = true;
        Rendering.outlineStyle.font = Rendering.tahoma;
        Rendering.outlineStyle.normal.textColor = new Color(0f, 0f, 0f, 1f);
        Rendering.outlineStyle.fontStyle = fontStyle;
        GUIContent content = new GUIContent(text);
        GUIContent content2 = new GUIContent(text);
        if (center)
        {
            pos.x -= Rendering.style.CalcSize(content).x / 2f;
        }
        switch (depth)
        {
            case 0:
                GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
                return;
            case 1:
                GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
                return;
            case 2:
                GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
                return;
            case 3:
                GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
                GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
                return;
            default:
                return;
        }
    }

    public static void DrawHealth11(Vector2 pos, float health, bool center = false)
    {
        if (center)
        {
            pos -= new Vector2(26f, 0f);
        }

        pos += new Vector2(0f, 18f);
        BoxRect(new Rect(pos.x, pos.y, 52f, 5f), UnityEngine.Color.black);
        pos += new Vector2(1f, 1f);

        Color hpcolor = UnityEngine.Color.green;

        if (health <= 50f)
        {
            hpcolor = UnityEngine.Color.yellow;
        }

        if (health <= 25f)
        {
            hpcolor = UnityEngine.Color.red;
        }

        BoxRect(new Rect(pos.x, pos.y, 0.5f * health, 3f), hpcolor);
    }

    public static void DrawVerticalHealth(Vector2 Head, float Width, float Height, float health)
    {
        int num = (int)(Width / 4f);
        float num2 = health / Height / 100f;
        if (num2 >= 1f)
        {
            if (num2 < 0f)
            {
            }
        }
        if (health > 0f)
        {
            f = "♥♥♥";
            Color color = new Color32(0, 255, 0, 255);
            if (health < 75f)
            {
                f = "♥♥";
                color = new Color32(255, 255, 75, 255);
            }
            if (health < 35f)
            {
                f = "♥";
                color = new Color32(255, 0, 0, 255);
            }
            if (health <= 0f)
            {
                f = "";
                color = Color.clear;
            }
            Rendering.DrawString1(new Vector2(Head.x, Head.y - 20f), (int)health + f, color, true, 8);
        }
    }
    public static string f;
    public static void DrawVerticalHealth1(Vector2 Head, float Width, float Height, float health)
    {
        int num = (int)(Width / 4f);
        float num2 = health / Height / 100f;
        if (num2 >= 1f)
        {
            if (num2 < 0f)
            {
            }
        }
        if (health > 0f)
        {
            Color color = new Color32(0, 255, 0, 255);
            if (health < 7000f)
            {
                color = new Color32(255, 255, 75, 255);
            }
            if (health < 4000f)
            {
                color = new Color32(255, 0, 0, 255);
            }
            if (health <= 1000f)
            {
                color = Color.clear;
            }
            Rendering.DrawString1(new Vector2(Head.x, Head.y - 20f), "❤" + (int)health + "❤", color, true, 8);
        }
    }
    public static void DrawVerticalHealth11(Vector2 Head, float Width, float Height, float health)
    {
        int num = (int)(Width / 4f);
        float num2 = health / Height / 100f;
        if (num2 >= 1f)
        {
            if (num2 < 0f)
            {
            }
        }
        if (health > 0f)
        {
            Color32 color = new Color32(233, 0, 245, 255);

            if (health <= 10000f)
            {
                color = new Color32(233, 0, 245, 255);
            }
            Rendering.DrawString1(new Vector2(Head.x, Head.y), "" + (int)health + "", color, true, 6);
        }
    }
    public static void DrawVerticalHealth111(Vector2 Head, float Width, float Height, float health)
    {
        int num = (int)(Width / 4f);
        float num2 = health / Height / 100f;
        if (num2 >= 1f)
        {
            if (num2 < 0f)
            {
            }
        }
        if (health > 0f)
        {
            Color32 color = new Color32(233, 0, 245, 255);

            if (health <= 10000f)
            {
                color = new Color32(233, 0, 245, 255);
            }
            Rendering.DrawString1(new Vector2(Head.x, Head.y), "" + (int)health + "", color, true, 8);
        }
    }
    public static void Health(float x, float y, float health, float maxHealth = 10000f, float width = 28, float height = 10, float thickness = 1f)
    {
        float num = (width - thickness * 2f) * health / maxHealth;
        if (num < 1f)
        {
            num = 1f;
        }
        GUI.DrawTexture(new Rect(x - width / 2f, y - height, width, height), HukHealth.black);
        if (health < maxHealth * 1.1f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr10);
        }
        if (health < maxHealth * 0.9f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr9);
        }
        if (health < maxHealth * 0.8f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr8);
        }
        if (health < maxHealth * 0.7f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr7);
        }
        if (health < maxHealth * 0.6f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr6);
        }
        if (health < maxHealth * 0.5f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr5);
        }
        if (health < maxHealth * 0.4f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr4);
        }
        if (health < maxHealth * 0.3f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr3);
        }
        if (health < maxHealth * 0.2f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr2);
        }
        if (health <= maxHealth * 0.1f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr2);
        }


    }
    public static void Health1(float x, float y, float health, float maxHealth = 1000f, float width = 28, float height = 5f, float thickness = 1f)
    {
        float num = (width - thickness * 2f) * health / maxHealth;
        if (num < 1f)
        {
            num = 1f;
        }
        Color color = Color.green;
        if (health < maxHealth * 0.7f)
        {
            color = Color.yellow;
        }

        if (health < maxHealth * 0.2f)
        {
            color = Color.red;
        }
        Rendering.RectFilled(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f, color);
    }
    public static void DrawVerticalHealthf(Vector2 Head, float Width, float Height, float health, float thickness = 3f)
    {
        int num = (int)(Width - thickness * 3f);
        float num2 = health / Height / 100f;
        if (num2 < 1f)
        {
            num2 = 1f;
        }
        if (health > 0f)
        {
            Color color = Color.green;
            if (health < 70f)
            {
                color = Color.yellow;
            }
            if (health < 50f)
            {
                color = new Color(1f, 0.7f, 0.16f, 1f);
            }
            if (health < 25f)
            {
                color = Color.red;
            }
            if (health <= 0f)
            {
                color = Color.clear;
            }

            Rendering.RectFilled(Head.x - Width / 2f - thickness, Head.y, -2f + thickness, Height - 2f, color);
        }
    }
    public static void Health11(float x, float y, float health, float maxHealth = 100, float width = 28, float height = 5f, float thickness = 1f)
    {
        float num = (width - thickness * 2f) * health / maxHealth;
        if (num < 1f)
        {
            num = 1f;
        }
        GUI.DrawTexture(new Rect(x - width / 2f, y - height, width, height), HukHealth.black);
        if (health < 101f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr10);
        }
        if (health < 90f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr9);
        }
        if (health < 80f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr8);
        }
        if (health < 70f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr7);
        }
        if (health < 60f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr6);
        }
        if (health < 50f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr5);
        }
        if (health < 40f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr4);
        }
        if (health < 30f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr3);
        }
        if (health < 20f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr2);
        }
        if (health < 10f)
        {
            GUI.DrawTexture(new Rect(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f), HukHealth.merr2);
        }


    }

    public static void Box(float x, float y, float width, float height, Color color, float thickness = 1f)
    {
        Rendering.RectOutlined(x - width / 2f, y - height, width, height, color, thickness);
    }
    public static void RectOutlined(float x, float y, float width, float height, Color color, float thickness = 1f)
    {
        Rendering.RectFilled(x, y, thickness, height, color);
        Rendering.RectFilled(x + width - thickness, y, thickness, height, color);
        Rendering.RectFilled(x + thickness, y, width - thickness * 2f, thickness, color);
        Rendering.RectFilled(x + thickness, y + height - thickness, width - thickness * 2f, thickness, color);
    }
    public static void RectFilled(float x, float y, float width, float height, Color color)
    {
        if (color != Rendering.textureColor)
        {
            Rendering.textureColor = color;
            Rendering.texture.SetPixel(0, 0, color);
            Rendering.texture.Apply();
        }
        GUI.DrawTexture(new Rect(x, y, width, height), Rendering.texture);
    }


    public static void DrawBox1(Vector2 pos, Vector2 size, Color color)
    {
        if (!figTex)
        {
            figTex = new Texture2D(1, 1);
        }
        if (color != lfgColor)
        {
            figTex.SetPixel(0, 0, color);
            figTex.Apply();
            lfgColor = color;
        }
        GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, size.y), figTex);
    }

    public static void DrawWatermark(string text, Color color, int size = 12)
    {
        guistyle_0.fontSize = size;
        guistyle_0.normal.textColor = color;
        GUIContent content = new GUIContent(text);
        GUI.Label(new Rect(1, 1, 300f, 25f), content, guistyle_0);
    }
}