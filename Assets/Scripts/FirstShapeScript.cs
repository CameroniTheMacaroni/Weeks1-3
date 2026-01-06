using UnityEngine;

public class FirstShapeScript : MonoBehaviour
{
    public GameObject shape;
    public float speed = 0.05f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 newpos = transform.position;
        newpos.x += speed;
        transform.position = newpos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }

        //shape.transform.position += new Vector3(Time.deltaTime, 0, 0);
        shape.transform.localScale += new Vector3(0, Time.deltaTime, 0);
    }
}
