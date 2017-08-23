using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSelect : MonoBehaviour
{
    public Vector2 mousePos;
    public string direction;
    public bool showSelectMenu;
    public float scrH, scrW; //Screen width and height
    public Inventory inventory;//location of the items list
    public Item selectedItem;
    public Item equiptedItem;


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            scrH = Screen.height / 9;
            scrW = Screen.width / 16;
            showSelectMenu = !showSelectMenu;
        }
        if (showSelectMenu)
        {
            mousePos = Input.mousePosition;
            #region MouseInput
            #region Direction North-West
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 0 &&
                -mousePos.y + Screen.height <= scrH * 4)
            {
                if (mousePos.x >= scrW * 0f && mousePos.x <= scrW * 7.4f)
                {
                    direction = "North-West";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction North
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 0 &&
                -mousePos.y + Screen.height <= scrH * 4)
            {
                if (mousePos.x >= scrW * 7.5f && mousePos.x <= scrW * 8.5f)
                {
                    direction = "North";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction North-East
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 0 &&
                -mousePos.y + Screen.height <= scrH * 4)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    direction = "North-East";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction East
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 4 &&
                -mousePos.y + Screen.height <= scrH * 5)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    direction = "East";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction South-East
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 5.1f &&
                -mousePos.y + Screen.height <= scrH * 9)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    direction = "South-East";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction West
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 4 &&
                -mousePos.y + Screen.height <= scrH * 5)
            {
                if (mousePos.x >= scrW * 0f && mousePos.x <= scrW * 7.5f)
                {
                    direction = "West";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Direction South
            //Moves the mouse start pos to the default screen 00
            if (-mousePos.y + Screen.height >= scrH * 5 &&
                -mousePos.y + Screen.height <= scrH * 9)
            {
                if (mousePos.x >= scrW * 7.5f && mousePos.x <= scrW * 8.5f)
                {
                    direction = "South";
                    Debug.Log(direction);
                }
            }
            #endregion
            #region Selected
            if (Input.GetMouseButtonDown(0))
            {
                if (direction != "")
                {
                    if (direction == "North_West")
                    {
                        selectedItem = inventory.inv[0];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "North")
                    {
                        selectedItem = inventory.inv[1];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "North_East")
                    {
                        selectedItem = inventory.inv[2];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "West")
                    {
                        selectedItem = inventory.inv[3];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "Center")
                    {
                        selectedItem = null;
                    }
                    if (direction == "East")
                    {
                        selectedItem = inventory.inv[5];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "South_East")
                    {
                        selectedItem = inventory.inv[6];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "South")
                    {
                        selectedItem = inventory.inv[7];
                        Debug.Log(selectedItem.Name);
                    }
                    if (direction == "South_West")
                    {
                        selectedItem = inventory.inv[8];
                        Debug.Log(selectedItem.Name);
                    }
                }
                
            }

            #endregion
            #endregion
        }
    }

    private void OnGUI()
    {
        if (showSelectMenu)
        {
            if (selectedItem != null)
            {
                //Sets the texture 
                GUI.DrawTexture(new Rect(scrW * 7.5f, scrH * 4f, scrW, scrH), selectedItem.IconName);
            }
            //North West
            GUI.Box(new Rect(scrW * 0, scrH * 0, scrW * 7.5f , scrH * 4), "");
            //North
            GUI.Box(new Rect(scrW * 7.5f, scrH * 0, scrW * 1, scrH * 4), "");
            //North East
            GUI.Box(new Rect(scrW * 8.5f, scrH * 0, scrW * 8f, scrH * 4), "");
            //West
            GUI.Box(new Rect(scrW * 0, scrH * 4, scrW * 7.5f, scrH * 1), "");
            //Center Box
            GUI.Box(new Rect(scrW * 7.5f, scrH * 4f, scrW * 1, scrH * 1), "");
            //East
            GUI.Box(new Rect(scrW * 8.5f, scrH * 4, scrW * 8, scrH * 1), "");
            //South West
            GUI.Box(new Rect(scrW * 0, scrH * 5, scrW * 7.5f, scrH * 4), "");
            //South
            GUI.Box(new Rect(scrW * 7.5f, scrH * 5, scrW * 1, scrH * 4), "");
            //South East
            GUI.Box(new Rect(scrW *8.5f, scrH * 5, scrW * 8f, scrH * 4), "");
        }
    }

}
