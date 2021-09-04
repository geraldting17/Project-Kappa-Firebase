using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Proyecto26;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI locationName;
    public static string location1;
    public TextMeshProUGUI TeamName;
    public static string TeamName1;
    public TextMeshProUGUI TimeDate_Name;
    public static string Date_Day_Name1;
    public static string Date_Month_Name1;
    public static string Date_Year_Name1;
    public static string Time_Name1;
    public TextMeshProUGUI ValueName;
    public static string ValueName1;

    public TMP_InputField location_inputfield;
    public TMP_InputField team_inputfield;
    public TMP_InputField date_Day_inputfield;
    public TMP_InputField date_Month_inputfield;
    public TMP_InputField date_Year_inputfield;

    public TMP_InputField time_inputfield; 
    public TMP_InputField value_inputfield;

    public void StoreData(){
        locationName.text = "Location is " + location_inputfield.text;
        location1 = location_inputfield.text;

        TeamName.text = "Team is " + team_inputfield.text;
        TeamName1 = team_inputfield.text;

        TimeDate_Name.text = "Time & Date is " + date_Day_inputfield.text + " " + date_Month_inputfield.text + " " + date_Year_inputfield.text + ", \n" + time_inputfield.text;
        Date_Day_Name1 = date_Day_inputfield.text;
        Date_Month_Name1 = date_Month_inputfield.text;
        Date_Year_Name1 = date_Year_inputfield.text;
        Time_Name1 = time_inputfield.text;

        ValueName.text = "Value is " + value_inputfield.text;
        ValueName1 = value_inputfield.text;

        PostToDatabase();
    }

    public void resetData(){
        locationName.text = "Location is -";
        location_inputfield.text = "";

        TeamName.text = "Team is -";
        team_inputfield.text = "";

        TimeDate_Name.text = "Time & Date is -";
        date_Day_inputfield.text = "";
        date_Month_inputfield.text = "";
        date_Year_inputfield.text = "";
        time_inputfield.text = "";
        
        ValueName.text = "Value is -";
        value_inputfield.text = "";
    }

    private void PostToDatabase(){
        User user = new User();
        //RestClient.Post(url: "https://projectkappa-firebase-default-rtdb.asia-southeast1.firebasedatabase.app/" + "Project Kappa-Firebase" + TeamName1 + ".json", user);
        RestClient.Put(url: "https://projectkappa-firebase-default-rtdb.asia-southeast1.firebasedatabase.app/" + TeamName1 + ".json", user);
    }
}
