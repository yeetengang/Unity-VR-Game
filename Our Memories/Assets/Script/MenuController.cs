using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;

    void Update() {
        if (gazedAt) {
            timer += Time.deltaTime;
            if (timer >= gazeTime) {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }

    public void PointerClick() {
        Debug.Log("Pointer Enter");
        SceneManager.LoadScene("SampleScene");
    }

    public void PointerExit() {
        gazedAt = false;
        Debug.Log("Exit");
    }

    public void PointerDown() {
        Debug.Log("Pointer Down");
    }
}
