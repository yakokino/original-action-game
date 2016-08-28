using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class attack3 : MonoBehaviour
{

    string inputCommands = "";
    bool commandEnable = true;

    int recCommandLength = 100;

    // Use this for initialization
    void Start()
    {
        inputCommands = inputCommands.PadLeft(100);
        StartCoroutine("commandInputControl");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator commandInputControl()
    {

        while (true)
        {
            //Axis
            if (commandEnable)
            {
                getAxis();
                confirmCommand();
                yield return new WaitForSeconds(0.1f);

            }









        }//end While
    }

    void getAxis()
    {
        if (Input.GetKeyDown("q"))
        {

            inputCommands += "1";

        }

    }

   

    void confirmCommand()
    {
        string testA = "1";
        int comLength = 30;
        string checkframe = inputCommands.Remove(0, recCommandLength - comLength);
        if (Regex.IsMatch(checkframe, testA))
        {
            Debug.Log("攻撃完了");
            return;
        }

      
        //Debug.Log(checkframe);
    }
}