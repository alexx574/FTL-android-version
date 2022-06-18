using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100f;
    Vector2 lastClickedPos;
    Vector2 roomPosition1;
    Vector2 roomPosition2;
    
    Rect bounds = new Rect(246, 155, 115, 75);
    bool moving;
    private void Update() {
        //bottem right room cord x = 246, y = 155;
        //room x = 34, y = 34;
        
        
        if (Input.GetMouseButtonDown(0) && bounds.Contains(Input.mousePosition))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
            
        }
        
        if (lastClickedPos.x > -4.99 && lastClickedPos.x < -4.17 && lastClickedPos.y > -0.95 && lastClickedPos.y < -0.10)
        {
            float step = speed* Time.deltaTime;
            roomPosition1 = new Vector2(-4.3f,-0.31f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition1, step);
        } else {
            moving = false;
        }
        if (lastClickedPos.x > -4.99 && lastClickedPos.x < -4.17 && lastClickedPos.y > 0.05 && lastClickedPos.y < 0.92)
        {
            float step = speed* Time.deltaTime;
            roomPosition2 = new Vector2(-4.86f,0.76f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition2, step);
        } else {
            moving = false;
        }
        if (lastClickedPos.x > -4.00 && lastClickedPos.x < -3.11 && lastClickedPos.y > 0.05 && lastClickedPos.y < 0.92)
        {
            float step = speed* Time.deltaTime;
            roomPosition2 = new Vector2(-3.25f,0.74f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition2, step);
        } else {
            moving = false;
        }
        if (lastClickedPos.x > -4.00 && lastClickedPos.x < -3.09 && lastClickedPos.y > -0.95 && lastClickedPos.y < -0.12)
        {
            float step = speed* Time.deltaTime;
            roomPosition2 = new Vector2(-3.27f,-0.81f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition2, step);
        } else {
            moving = false;
        }
        if (lastClickedPos.x > -2.91 && lastClickedPos.x < -2.06 && lastClickedPos.y > -0.93 && lastClickedPos.y < -0.08)
        {
            float step = speed* Time.deltaTime;
            roomPosition2 = new Vector2(-2.22f,-0.31f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition2, step);
        } else {
            moving = false;
        }
        if (lastClickedPos.x > -2.91 && lastClickedPos.x < -2.06 && lastClickedPos.y > 0.05 && lastClickedPos.y < 0.92)
        {
            float step = speed* Time.deltaTime;
            roomPosition2 = new Vector2(-2.75f,0.74f);
            transform.position = Vector2.MoveTowards(transform.position, roomPosition2, step);
        } else {
            moving = false;
        }
    }
    
}
