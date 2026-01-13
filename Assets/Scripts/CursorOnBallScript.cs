using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorOnBallScript : MonoBehaviour
{
    public bool CursorIsOnThing = false;
    public double disttotal;
    public Vector2 mousepos;
    public float distx;
    public float disty;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //pythagore:
        float distX = Math.Abs(mousePos.x) - Math.Abs(transform.position.x);
        float distY = Math.Abs(mousePos.y) - Math.Abs(transform.position.y);
        disttotal = Math.Sqrt(distY * distY + distX * distX);

        //print(disttotal);

        if (disttotal > 1)
        {
            CursorIsOnThing = false;
        }
        else
        {
            CursorIsOnThing = true;
        }

    }
}
