using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class Users : MonoBehaviour
{
    public int arrPos = -1;
    private string location;
    private string user;
    public string[] users = { "", "", "", "", ""};
    public string[] locations = { "", "", "", "", "" };
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject newUserButton;
    [SerializeField] public TextMeshProUGUI usernameInput;
    [SerializeField] public TextMeshProUGUI userlocationInput;
    [SerializeField] public TextMeshProUGUI username;

    public string Location
    {
        get
        {
            return location;
        }
        set
        {
            location = value;
        }
    }
    public string Name
    {
        get
        {
            return user;
        }
        set
        {
            user = value;
        }
    }
    public void OpenPanel()
    {
        panel.SetActive(true);
        newUserButton.SetActive(false);
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
        newUserButton.SetActive(true);
    }
    public virtual void NewUser()
    {
        if (arrPos < 4)
        {
            arrPos += 1;
            int userNum = arrPos + 1;
            //User u = new User();
            Name = "New User";
            Location = "Player Center";
            users[arrPos] = Name;
            locations[arrPos] = Location;
            username.SetText(userNum + " Users,\n Viewing " + users[arrPos] + " at " + locations[arrPos]);

            Debug.Log(userNum + " Users, Viewing " + users[arrPos] + " at " + locations[arrPos]);
        }
        else if (arrPos == 4)
        {
            username.SetText("Max users : 5");
        }
        ClosePanel();
    }
}
