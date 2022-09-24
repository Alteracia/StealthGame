using UnityEngine;

public class AlarmTriger : MonoBehaviour
{
    private bool trigerd;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource alarm = GetComponent<AudioSource>();
        AlarmGauge.OnLevelChanged += f =>
        {
            if (f < 1f || trigerd) return;
            alarm.Play();
            trigerd = true;
        };
    }

}
