using System;

using UnityEngine.UI;

// Token: 0x02000638 RID: 1592
public class AboutYou1 : BaseMonoBehaviour
{
    // Token: 0x06002263 RID: 8803 RVA: 0x0001B29F File Offset: 0x0001949F
    private void OnEnable()
    {
        subtitle.text = string.Empty;
        username.text = string.Empty;
        base.InvokeRepeating(new Action(Init), 0f, 300f);
    }

    // Token: 0x06002264 RID: 8804 RVA: 0x000BC208 File Offset: 0x000BA408
    private void Init()
    {
        if (!MainMenuSystem.isOpen)
        {
            return;
        }
        if (Client.Steam == null)
        {
            return;
        }
        Client.Steam.Stats.UpdateGlobalStats(2);
        username.text = CFG.Setting.spoof ? CFG.Setting.faked : SteamClient.localName;
        avatar.texture = SingletonComponent<SteamClient>.Instance.GetAvatarTexture(SteamClient.localSteamID);
    }

    // Token: 0x04001EDC RID: 7900
    public Text username;

    // Token: 0x04001EDD RID: 7901
    public RawImage avatar;

    // Token: 0x04001EDE RID: 7902
    public Text subtitle;
}
