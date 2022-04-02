using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private Vector3 cursorPos;
    
    private void Update()
    {
        Cursor.visible = false;

        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(cursorPos.x, cursorPos.y, 0);
    }
}
