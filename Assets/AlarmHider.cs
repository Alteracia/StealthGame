using UnityEngine;
using UnityEngine.Events;

public interface IPressable
{
    void Pressed();
}

public class AlarmHider : MonoBehaviour, IPressable
{
    public UnityEvent OnHided = new UnityEvent();
    private bool hidden;

    public void Pressed()
    {
        if (hidden) return; 
        hidden = true;
        OnHided.Invoke();
    }
}
