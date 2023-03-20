using System.Runtime.InteropServices;   // DllImport���g�����߂ɕK�v
using UnityEngine;

/// <summary>
/// �V�����^�u��URL���J���e�X�g�X�N���v�g
/// </summary>
public class TestOpenNewTab : MonoBehaviour
{
    // �V�����^�u��URL���J��
#if !UNITY_EDITOR && UNITY_WEBGL
    // For WebGL build
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);
#else
    // Other than Unity and WebGL
    private static void OpenNewTab(string url) => Application.OpenURL(url);
#endif

    public void NewTab()
    {
        OpenNewTab("https://github.com/KoyaKokubu");
    }
}