using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void openMyWebsite()
    {
        Application.OpenURL("https://koyakokubu.com/");
    }

    public void openLinkedIn()
    {
        Application.OpenURL("https://linkedin.com/in/KoyaKokubu");
    }
    public void openGitHub()
    {
        Debug.Log("onClickÇ™çÏìÆÇµÇΩ(linkManager)");
        Application.OpenURL("https://github.com/KoyaKokubu");
    }
    public void openInstagram()
    {
        Application.OpenURL("https://instagram.com/koya_b3?igshid=YWVjMmZiZjg=");
    }
    public void openDiscord()
    {
        Application.OpenURL("https://discord.gg/nsHvxjAdyB");
    }
}
