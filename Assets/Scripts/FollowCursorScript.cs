using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCursorScript : MonoBehaviour
{
   // public Vector2 mousePos;
    void Start()
    {
        
    }

    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousePos;
    }
}
