using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCursorScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousePos;
    }
}
