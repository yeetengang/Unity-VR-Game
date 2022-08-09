using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SelectSubmitAnswer : MonoBehaviour
{
    public bool correctAnswer;
    bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor() {
        if (selected) {
            // Selected to become not selected
            selected = false;
            GetComponent<Renderer>().material.color = new Color(12, 7, 130);
        } else {
            // Not Selected to become selected
            selected = true;
            GetComponent<Renderer>().material.color = new Color(23, 156, 95);
        }
    }

    
}
