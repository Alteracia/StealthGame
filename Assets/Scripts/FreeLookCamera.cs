using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    [SerializeField]
    private float sensitivity;
    
    private float _y;

    private void Start()
    {
        _y = this.transform.localEulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        _y -= Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;
        _y = Mathf.Clamp(_y, -70, 88);
        Vector3 rot = this.transform.localEulerAngles;
        this.transform.localEulerAngles = new Vector3(_y, rot.y, rot.z);
    }
}
