using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
   // [SerializeField] private Animator Door;

    private string Answer = "NEXT";

    public void Words(string word)
    {
        // Ans.text += word.ToString();
        Ans.text += word;
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "Correct";
            SceneManager.LoadScene("Room4");
            //  Door.SetBool("Open", true);
            // StartCoroutine("StopDoor");
        }
        else
        {
            Ans.text = "Invalid";
        }
    }

    public void Clear()
    {
            Ans.text = "";
    }

    // IEnumerator StopDoor()
    // {
    //    yield return new WaitForSeconds(0.5f);
    //    Door.SetBool("Open", false);
    //    Door.enabled = false;
    // }
}
