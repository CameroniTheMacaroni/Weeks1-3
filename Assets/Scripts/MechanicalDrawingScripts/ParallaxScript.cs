using UnityEngine;
using UnityEngine.InputSystem;


public class ParallaxScript : MonoBehaviour
{

    public Vector2 start1; //start and end for position
    public Vector2 end1;

    public Vector3 start2;//start and end for rotation
    public Vector3 end2;
    public float t;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());//find the mouse position

        t = (mousePos.x+10)/20;//convert the range from between -10 and 10 to between 0 and 1

        transform.position = Vector2.Lerp(start1, end1, t);//map the position to between the start and end positions
        transform.eulerAngles = Vector3.Lerp(start2, end2, t);
    }
}
