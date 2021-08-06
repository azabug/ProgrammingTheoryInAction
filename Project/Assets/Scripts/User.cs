using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class User : Users
{
    private string location;
    private string user;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject newUserButton;
    [SerializeField] public TextMeshProUGUI usernameInput;
    [SerializeField] private TextMeshProUGUI userlocationInput;

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
    public void NewUser()
    {
        panel.SetActive(true);
        newUserButton.SetActive(false);
    }
    public void Main()
    {
        if (arrPos < 4)
        {
            arrPos += 1;
            User u = new User();
            u.Name = usernameInput.text;
            u.Location = userlocationInput.text;
            users[arrPos] = u.Name;
            locations[arrPos] = u.Location;

            Debug.Log(arrPos + ", " + users.Length + ", " + users[arrPos]+" at "+locations[arrPos]);
        }
        else if (arrPos == 4)
        {
            Debug.Log("Max users : 5");
        }
        panel.SetActive(false);
        newUserButton.SetActive(true);
    }

}

