using System;
using UnityEngine;

public class AlarmGauge : MonoBehaviour
{
    private float _level = -1f;
    
    public static Action<float> OnLevelChanged;

    void FixedUpdate()
    {
        ChangeLevel(-0.02f);
    }

    private void OnTriggerStay(Collider other)
    {
        ChangeLevel(0.06f);
    }

    private void ChangeLevel(float diff)
    {
        float lvl = _level;
        _level += diff;
        _level = Mathf.Clamp01(_level);
        if (Mathf.Abs(lvl - _level) > float.Epsilon) OnLevelChanged?.Invoke(_level);
    }
}
