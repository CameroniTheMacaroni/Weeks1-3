using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    void Start()
    {
        
    }

    void Update()
    {

        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    PickARandomColor();
        //}

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape?
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            //y: set the color to col variable
            spriteRenderer.color = col;
        }
        else
        {
            //n: set colour to white
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColor()
    {
        //spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.color = col;
    }
}
