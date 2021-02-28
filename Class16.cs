using UnityEngine;

// Token: 0x0200026E RID: 622
public class ccc : EntityComponent<BasePlayer>
{
    private void Start()
    {
        byte[] nop1er = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        boredaaaasf1 = new DumbHook(typeof(PlayerEyes), "UpdateCamera", typeof(ccc), "UpdateCamera", typeof(ccc), "UpdateCameraTrampoline", nop1er);
        boredaaaasf1.Hook();
    }
    private void UpdateCameraTrampoline(Camera cam)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

    private void UpdateCamera(Camera cam)
    {
        if (cam == null)
        {
            return;
        }
        cam.fieldOfView = CFG.Setting.vov;
        switch (base.baseEntity.currentViewMode)
        {
            case BasePlayer.CameraMode.FirstPerson:
                gameObject.GetComponent<PlayerEyes>().DoFirstPersonCamera(cam);
                break;
            case BasePlayer.CameraMode.ThirdPerson:
                gameObject.GetComponent<PlayerEyes>().DoThirdPersonCamera(cam);
                break;
            case BasePlayer.CameraMode.Eyes:
                gameObject.GetComponent<PlayerEyes>().DoInEyeCamera(cam);
                break;
        }

    }

    private DumbHook boredaaaasf1;

}