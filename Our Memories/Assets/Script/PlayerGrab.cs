using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject item; 
    public GameObject hand;
    bool inHands = false;
    public float handPower;
    Collider itemCol;
    Rigidbody itemRb;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        itemCol = item.GetComponent<SphereCollider>();
        itemRb = item.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("test");
            if (!inHands) {
                itemCol.isTrigger = true;
                inHands = true;
                item.transform.SetParent(hand.transform);
                item.transform.localPosition = new Vector3(-0.04f, -0.35f, 0.31f);
                itemRb.velocity = Vector3.zero;
                itemRb.useGravity = false;
            } else {
                itemCol.isTrigger = false;
                itemRb.useGravity = true;
                this.GetComponent<PlayerGrab>().enabled = false;
                itemRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
                inHands = false;
                item.transform.SetParent(null);
            }
            
        }
    }
}
