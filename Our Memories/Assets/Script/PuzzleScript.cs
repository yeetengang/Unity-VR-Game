using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public bool isCorrect = false;
    public PlayerGrabPuzzle puzzleManager;

    public void Grab() {
        if (isCorrect) {
            Debug.Log("Correct Answer");
            puzzleManager.correct();
        } else {
            Debug.Log("Wrong Answer");
            puzzleManager.wrong();
        }
    }
}
