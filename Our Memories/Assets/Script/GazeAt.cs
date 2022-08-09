using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeAt : MonoBehaviour
{
    public GameObject InfoObject;
    public float gazeTime = 10f;
    private float timer;
    private bool gazedAt;
    private bool show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gazedAt) {
            timer += Time.deltaTime;
            if (timer >= gazeTime) {
                InfoObject.SetActive(false);
            }
        }
    }

    public void PointerEnter() {
        gazedAt = true;
    }

    public void PointerExit() {
        gazedAt = false;
    }
}
