using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class User : Users
{
    public override void NewUser()
    {
        if (arrPos < 4)
        {
            arrPos += 1;
            int userNum = arrPos + 1;
            //User u = new User();
            Name = usernameInput.text;
            Location = userlocationInput.text;
            users[arrPos] = Name;
            locations[arrPos] = Location;
            username.SetText(userNum + " Users,\n Viewing " + users[arrPos] + " at " + locations[arrPos]);

            Debug.Log(userNum + " Users, Viewing " + users[arrPos]+" at "+locations[arrPos]);
        }
        else if (arrPos == 4)
        {
            username.SetText("Max users : 5");
        }
        ClosePanel();
    }

}

