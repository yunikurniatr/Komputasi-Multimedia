using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour
{
    // Start is called before the first frame update
    public void MENU_ACTION_GoToPage(string MainMenu)
    {
        Application.LoadLevel(MainMenu);
    }

   
}
