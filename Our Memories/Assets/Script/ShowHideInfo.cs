using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideInfo : MonoBehaviour
{
    public GameObject InfoObject;
    
    private bool show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  ShowInfo() {
       // InfoObject.SetActive(true);
        if (!show) {
            show = true;
            InfoObject.SetActive(true);
        } else {
            show = false;
            InfoObject.SetActive(false);
        }
    }

    public void  HideInfo() {
       // InfoObject.SetActive(false);
        if (!show) {
            show = true;
            InfoObject.SetActive(true);
        } else {
            show = false;
            InfoObject.SetActive(false);
        }
    }
}
