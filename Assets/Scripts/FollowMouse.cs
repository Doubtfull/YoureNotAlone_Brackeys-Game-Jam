using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
       Vector2 curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(curPos.x, curPos.y);
    }
    void FixedUpdate()
    {
        
    }
}
