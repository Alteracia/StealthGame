using UnityEngine;

public class Pressing : MonoBehaviour
{
    [SerializeField]
    private LayerMask mask;
    
    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.E)) return;
        
        
        //int layerMask = 1 << 9;
        
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, transform.forward, out hit, 1f, mask)) return;
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        Debug.Log("Did Hit");

        hit.transform.GetComponent<IPressable>().Pressed();

    }
    
    
}
