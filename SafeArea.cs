using UnityEngine;

/// <summary>
/// 手游开发中，在 Safe Area 区域中显示 UI，避免被异形屏遮挡
/// 使用方法：
///     新建一个 Empty GameObject，然后将其 RectTransform 设置为全延展，最后将需要在 Safe Area 区域中显示的 UI 对象作为其子对象即可
/// </summary>
public class SafeArea : MonoBehaviour
{
    private RectTransform _rectTransform;
    private Rect _safeArea;
    private Vector2 _minAnchor;
    private Vector2 _maxAnchor;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _safeArea = Screen.safeArea;
        _minAnchor = _safeArea.position;
        _maxAnchor = _minAnchor + _safeArea.size;
        
        _minAnchor.x /= Screen.width;
        _minAnchor.y /= Screen.height;
        _maxAnchor.x /= Screen.width;
        _maxAnchor.y /= Screen.height;

        _rectTransform.anchorMin = _minAnchor;
        _rectTransform.anchorMax = _maxAnchor;
    }
}
