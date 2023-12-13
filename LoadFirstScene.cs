#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

/// <summary>
/// Load the scene which index is 0 whenever we jump into play mode
/// How to use: just place this script into the directory "Assets/Editor"
/// </summary>
[InitializeOnLoad]
public class EditorInit
{
    static EditorInit()
    {
        var pathOfFirstScene = EditorBuildSettings.scenes[0].path;
        var sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(pathOfFirstScene);
        EditorSceneManager.playModeStartScene = sceneAsset;
        Debug.Log(pathOfFirstScene + " was set as default play mode scene");
    }
}
#endif
