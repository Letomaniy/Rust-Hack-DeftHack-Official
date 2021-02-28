using UnityEngine;

// Token: 0x02000170 RID: 368
public class gavno : SingletonComponent<CameraMan>
{
    private void Start()
    {
        byte[] nop1er = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        boredaaaasf1 = new DumbHook(typeof(CameraMan), "DoControls", typeof(gavno), "DoControls", typeof(gavno), "DoControlsTrampoline", nop1er);
        boredaaaasf1.Hook();
    }
    private void DoControlsTrampoline()
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

    private void DoControls()
    {

        if (LocalPlayer.Entity == null || LocalPlayer.Entity.Frozen)
        {
            if (Buttons.Attack2.IsDown && (!gameObject.GetComponent<CameraMan>().NeedBothMouseButtonsToZoom || Buttons.Attack.IsDown))
            {
                gameObject.GetComponent<CameraMan>().zoom = Mathf.Clamp(gameObject.GetComponent<CameraMan>().zoom + UnityEngine.Input.GetAxisRaw("Mouse Y") * -0.033f, 0.01f, 1f);
            }
            else if (Buttons.Duck.IsDown)
            {
                gameObject.GetComponent<CameraMan>().view.z = gameObject.GetComponent<CameraMan>().view.z + UnityEngine.Input.GetAxisRaw("Mouse X") * 1.5f;
            }
            else
            {
                gameObject.GetComponent<CameraMan>().view.y = gameObject.GetComponent<CameraMan>().view.y + UnityEngine.Input.GetAxisRaw("Mouse X") * 3f * gameObject.GetComponent<CameraMan>().zoom * gameObject.GetComponent<CameraMan>().LookSensitivity;
                gameObject.GetComponent<CameraMan>().view.x = gameObject.GetComponent<CameraMan>().view.x - UnityEngine.Input.GetAxisRaw("Mouse Y") * 3f * gameObject.GetComponent<CameraMan>().zoom * gameObject.GetComponent<CameraMan>().LookSensitivity;
            }
            base.transform.rotation = Quaternion.Euler(gameObject.GetComponent<CameraMan>().view);
            Vector3 vector = Vector3.zero;
            if (Buttons.Forward.IsDown)
            {
                vector += Vector3.forward;
            }
            if (Buttons.Backward.IsDown)
            {
                vector += Vector3.back;
            }
            if (Buttons.Left.IsDown)
            {
                vector += Vector3.left;
            }
            if (Buttons.Right.IsDown)
            {
                vector += Vector3.right;
            }
            vector.Normalize();
            if (Buttons.Sprint.IsDown)
            {
                vector *= 5f;
            }
            if (Buttons.Jump.IsDown)
            {
                vector *= 0.2f;
            }
            gameObject.GetComponent<CameraMan>().velocity += base.transform.rotation * vector * 0.05f * gameObject.GetComponent<CameraMan>().MoveSpeed * CFG.Setting.debugg;
            gameObject.GetComponent<CameraMan>().velocity = Vector3.Lerp(gameObject.GetComponent<CameraMan>().velocity, Vector3.zero, 0.2f);
            base.transform.position += gameObject.GetComponent<CameraMan>().velocity;
        }
        else
        {
            Vector3 forward = LocalPlayer.Entity.transform.position - base.transform.position + Vector3.up;
            base.transform.rotation = Quaternion.LookRotation(forward);
        }
        MainCamera.mainCamera.transform.position = Vector3.Lerp(MainCamera.mainCamera.transform.position, base.transform.position, ConVar.Client.camlerp);
        MainCamera.mainCamera.transform.rotation = Quaternion.Slerp(MainCamera.mainCamera.transform.rotation, base.transform.rotation, ConVar.Client.camlerp);
        MainCamera.mainCamera.fieldOfView = Mathf.Lerp(1f, 120f, gameObject.GetComponent<CameraMan>().zoom);
    }

    private DumbHook boredaaaasf1;

}