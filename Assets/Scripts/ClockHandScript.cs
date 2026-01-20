using UnityEngine;

public class ClockHandScript : MonoBehaviour
{
    public float rotationspeed = -30f;
    public Vector3 newRot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newRot = transform.eulerAngles;
        newRot.z += rotationspeed * Time.deltaTime;
        transform.eulerAngles = newRot;
    }
}
