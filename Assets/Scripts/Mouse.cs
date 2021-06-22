using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject pause;
    public GameObject dialog;
    public GameObject win;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (win.activeSelf || lose.activeSelf || pause.activeSelf || dialog != null) Cursor.visible = true;
        else Cursor.visible = false;
    }
}
