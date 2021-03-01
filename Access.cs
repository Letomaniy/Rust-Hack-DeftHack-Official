using System;
using System.Reflection;

internal static class Access
{
    internal static T GetPrivateFieldq<T>(this object obj, string name)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        FieldInfo field = type.GetField(name, flags);
        return (T)field.GetValue(obj);
    }
    internal static void SetPrivateFieldq(this object obj, string name, object value)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        FieldInfo field = type.GetField(name, flags);
        field.SetValue(obj, value);
    }
    internal static void CallPrivateMethodq(this object obj, string name, params object[] param)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(name, flags);
        method.Invoke(obj, param);
    }
}