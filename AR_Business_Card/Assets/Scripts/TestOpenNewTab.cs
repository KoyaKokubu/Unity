using System.Runtime.InteropServices;   // DllImportを使うために必要
using UnityEngine;

/// <summary>
/// 新しいタブでURLを開くテストスクリプト
/// </summary>
public class TestOpenNewTab : MonoBehaviour
{
    // 新しいタブでURLを開く
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