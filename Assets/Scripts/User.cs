using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User
{
    public string Location;
    public string Team;
    public string Time;
    public string Value;

    public User(){
        Location = "\"" + TextController.location1 + "\"";
        Team = "\"" + TextController.TeamName1 + "\"";
        Time = "\"" + TextController.Date_Month_Name1 + "\\/" + TextController.Date_Day_Name1 + "\\/" + TextController.Date_Year_Name1 + " " + TextController.Time_Name1 + "\"";
        Value = TextController.ValueName1;
    }
}
