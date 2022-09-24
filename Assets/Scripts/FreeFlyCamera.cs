using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FreeFlyCamera : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float sensitivity;
    
    private Rigidbody _body;
    private Vector3 _velocity;
        
    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    // Input
    private void Update()
    {
        Vector3 add = Vector3.zero;
        
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        this.transform.Rotate(Vector3.up, x);
        
        add.x = Input.GetAxis("Horizontal") * Time.deltaTime;
        add.z = Input.GetAxis("Vertical") * Time.deltaTime;

        _velocity += this.transform.rotation * (add * speed);
    }

    // Movements
    void FixedUpdate()
    {
        if (_body.velocity.y < -0.001f)
        {
            _velocity = Vector3.zero;
            return;
        }
        
        _body.velocity = _velocity;
        _velocity = Vector3.zero;
    }
}
