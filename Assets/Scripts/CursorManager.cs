using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;  // Show the cursor
        Cursor.lockState = CursorLockMode.None;  // Unlock the cursor
    }
}

