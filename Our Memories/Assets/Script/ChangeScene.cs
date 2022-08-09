using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool next;
    public string nextSceneName;
    //public string nextScene;
    void Start() {
        next = false;
    }

    /*public void clicked() {
        next = true;
        SceneManager.LoadScene(nextSceneName);
    }*/

    public void StartBtn() {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoBed()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void GoBath()
    {
        SceneManager.LoadScene("Bathroom");
    }

    public void BackMain()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void Dream()
    {
        SceneManager.LoadScene("Dream");
    }

    public void House()
    {
        SceneManager.LoadScene("EndingHouse");
    }


    public void End()
    {
        SceneManager.LoadScene("Ending");
    }


}
