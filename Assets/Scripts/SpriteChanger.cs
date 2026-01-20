using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    void Start()
    {
        
    }

    void Update()
    {

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            //PickARandomColor();
            PickARandomSprite();

        }

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape?
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            //y: set the color to col variable
            //spriteRenderer.sprite = barrels[3];
            spriteRenderer.color = col;
        }
        else
        {
            //n: set colour to white
            spriteRenderer.color = Color.white;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame && barrels.Count > 0)
        {
            randomNumber = Random.Range(0, barrels.Count); //choose a random number
            barrels.RemoveAt(randomNumber);
        }
    }

    void PickARandomColor()
    {
        //spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.color = col;
    }
    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;
        randomNumber = Random.Range(0, barrels.Count); //choose a random number
        //use that number to choose a sprite
        //assign that sprite to the sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
