using JetBrains.Annotations;
using UnityEngine;

public class GlobMoveScript : MonoBehaviour
{
    //public Vector2 startPos; //start and end for position
    //public Vector2 endPos;

    public Vector3 startRot;//start and end for rotation
    public Vector3 endRot;

    public Vector2 startScale;//start and end for scale
    public Vector2 endScale;

     Vector2 PosRangeStart;
     Vector2 PosRangeEnd;

    public float t;
    void Start()
    {
        //PosRangeStart = (Vector2)transform.position + startPos;
        //PosRangeEnd = (Vector2)transform.position + endPos;

    }

    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        //transform.position = Vector2.Lerp(PosRangeStart, PosRangeEnd, t);
        transform.eulerAngles = Vector3.Lerp(startRot, endRot, t);
        transform.localScale = Vector2.Lerp(endScale, startScale, t);
    }
}
