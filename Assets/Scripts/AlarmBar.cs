using UnityEngine;
using UnityEngine.UI;

public class AlarmBar : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        var image = GetComponent<Image>();
        var rect = GetComponent<RectTransform>();
        AlarmGauge.OnLevelChanged += f =>
        {
            rect.sizeDelta = new Vector2(f * 222f, rect.sizeDelta.y);
            image.color = Color.Lerp(Color.white, Color.red, f);
        };
    }
}
