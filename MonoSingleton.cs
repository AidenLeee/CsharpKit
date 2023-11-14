using UnityEngine;

/// <summary>
/// MonoBehaviour singleton, use case:
///     public class GameManager : MonoSingleton<GameManager> {}
/// </summary>
/// <typeparam name="T"></typeparam>
public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance => _instance;

    protected void Awake()
    {
        if (_instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }

        _instance = gameObject.GetComponent<T>();
        InitOnAwake();
    }

    protected void OnDestroy()
    {
        if (_instance == this)
        {
            ReleaseOnDestroy();
            _instance = null;
        }
    }
    
    protected virtual void InitOnAwake() {}
    protected virtual void ReleaseOnDestroy() {}
}
