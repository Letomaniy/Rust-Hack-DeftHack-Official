using System.Collections.Generic;

using UnityEngine;

public static class Bones
{
    static Bones()
    {
        Bones.boneList[0] = "head";
        Bones.boneList[1] = "neck";
        Bones.boneList[2] = "spine1";
        Bones.boneList[3] = "pelvis";
        Bones.boneList[4] = "l_upperarm";
        Bones.boneList[5] = "l_forearm";
        Bones.boneList[6] = "l_hand";
        Bones.boneList[7] = "r_upperarm";
        Bones.boneList[8] = "r_forearm";
        Bones.boneList[9] = "r_hand";
        Bones.boneList[10] = "l_hip";
        Bones.boneList[11] = "l_knee";
        Bones.boneList[12] = "l_foot";
        Bones.boneList[13] = "r_hip";
        Bones.boneList[14] = "r_knee";
        Bones.boneList[15] = "r_foot";
    }
    public static Vector3[] GetBonePositions(this BasePlayer player)
    {
        Vector3[] array = new Vector3[Bones.boneList.Count];
        for (int i = 0; i < Bones.boneList.Count; i++)
        {
            array[i] = player.playerModel.FindBone(Bones.boneList[i]).position;
        }
        return array;
    }

    public static Dictionary<int, string> boneList = new Dictionary<int, string>();

}

