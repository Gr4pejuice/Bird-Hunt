using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.gameIsOver)
        {
            Cursor.visible = false;
            followMouse();
        }
        else
        {
            Cursor.visible = true;
        }
        
    }
    private void followMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y -= 1;
        mousePos.z = 0;
        transform.position = mousePos;
    }
}
