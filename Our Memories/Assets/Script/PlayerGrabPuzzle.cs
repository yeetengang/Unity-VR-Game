using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGrabPuzzle : MonoBehaviour
{
    public GameObject item; 
    public GameObject hand;
    public GameObject[] puzzleAns;
    //public GameObject ori;
    bool inHands = false;
    public int indexes;
    bool testting;
    GameObject test3;
    GameObject tablePiece;
    public GameObject door;
    public GameObject[] pieces;
    bool[] grab;
    Vector3 itemPos;
    Quaternion itemRot;
    Vector3 itemSca;
    Animator _doorAnim;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("start");
        _doorAnim = door.GetComponent<Animator>();
        _doorAnim.SetBool("isOpening", false);
    }

    // Update is called once per frame
    void Update()
    {
        int inttest = 0;
        if (inttest != -1) {
            for (int i=0; i<pieces.Length; i++) {
                if (pieces[i].GetComponent<Renderer>().material.color == Color.green) {
                    inttest = inttest + 1;
                }
            }

            if (inttest == 9) {
                _doorAnim.SetBool("isOpening", true);
                Debug.Log("Ending Scene");
                SceneManager.LoadScene("Dream");
            }
        }
        //Debug.Log(indexes);
        //for (int i = 0; i < item.Length; i++) {
            if (Input.GetButtonDown("Fire1")) {
                if (!inHands) {
                    inHands = true;
                    item.transform.SetParent(hand.transform);
                    item.transform.localPosition = new Vector3(-1.007f, 0.187f, 0.565f);
                    item.transform.localRotation = Quaternion.Euler(-134.6f, -1.525f, -60);
                    item.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    item.GetComponent<BoxCollider>().enabled = false;
                } else if (inHands){
                    inHands = false;
                    item.transform.SetParent(test3.transform);
                    item.GetComponent<BoxCollider>().enabled = true;
                    item.transform.localPosition = itemPos;
                    item.transform.localRotation = itemRot;
                    item.transform.localScale = itemSca;
                    indexes = 0;
                    //this.GetComponent<PlayerGrab>().enabled = false;
                }
                
            }

            if (indexes == 9) {
                //Change to Ending
                Debug.Log("Ending");
             }
        //}
    }

    public void setLocation() {
        //Debug.Log("test2");
        //itemPos = item.transform.position;
    }

    public void removeGrab() {
        if (!inHands) {
            //Debug.Log("test3");
            item = null;
        }
    }

    public void setGrab(GameObject test) {
        //Debug.Log("test1");
        item = test;
        test3 = test.transform.parent.gameObject;
        itemPos = test.transform.localPosition;
        itemRot = test.transform.localRotation;
        itemSca = test.transform.localScale;
        Debug.Log(itemPos);
        /*for (int i = 0; i < item.Length; i++) {
            item[i].GetComponent<PuzzleScript>().isCorrect = false;
            //grab[i] = false;
        }*/
        //grab[index] = true;
    }

    public void setAnswer(GameObject answerPiece) {
        if (answerPiece == item) {
            testting = true;
            //tablePiece.GetComponent<Renderer>().material.color = Color.green;
        } else {
            testting = false;
            //tablePiece.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public bool checkAnswer() {
        return true;
    }

    public void getAnsPiece(GameObject tablePiece1) {
        if (testting) {
            //tablePiece = tablePiece1;
            //Debug.Log("Haha");
            //indexes = indexes + 1;
            tablePiece1.GetComponent<Renderer>().material.color = Color.green;
        } else {
            tablePiece1.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    public void correct() {
        Debug.Log("grab");
    }

    public void wrong() {
        Debug.Log("no");
    }
}
