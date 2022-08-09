using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public GameObject door;
    public GameObject doorInteract;
    public GameObject showCorrectOrWrongBtn;
    public TMPro.TextMeshProUGUI showCorrectOrWrongText;
    public string currentScene;
    public int currentQuestion;

    public TMPro.TextMeshProUGUI QuestionTxt;

    Animator _doorAnim;

    private void Start() {
        _doorAnim = door.GetComponent<Animator>();
        _doorAnim.SetBool("isOpening", false);
        generateQuestion();
        showCorrectOrWrongBtn.GetComponent<Renderer>().material.color = Color.blue;
        showCorrectOrWrongText.GetComponent<TMPro.TextMeshProUGUI>().text = "Select Object";
    }

    public void correct() {
        //QnA.RemoveAt(currentQuestion);
        showCorrectOrWrongBtn.GetComponent<Renderer>().material.color = Color.green;
        showCorrectOrWrongText.GetComponent<TMPro.TextMeshProUGUI>().text = "Yes, Correct! Door to escape is opened now";
        if (currentScene == "Room1") {
            _doorAnim.SetBool("isOpening", true);
            Debug.Log("testing");
            doorInteract.SetActive(false);
            //SceneManager.LoadScene("Room2");
        } else if (currentScene == "Room2") {
            SceneManager.LoadScene("Room3");
        } else if (currentScene == "Room 3") {
            SceneManager.LoadScene("Room4");
        } else if (currentScene == "Room4") {
            SceneManager.LoadScene("Room5");
        } else {
            Debug.Log("No scene anymore, some error");
        }
        //generateQuestion(); // Proceed to next screne instead of next question
    }

    public void wrong() {
        //QnA.RemoveAt(currentQuestion);
        showCorrectOrWrongBtn.GetComponent<Renderer>().material.color = Color.blue;
        showCorrectOrWrongText.GetComponent<TMPro.TextMeshProUGUI>().text = "Nope, Try Again :(";
    }

    public void retry() {
        // Should put in Ending Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void setAnswers() {
        for (int i = 0; i < options.Length; i++) {
            options[i].GetComponent<AnswerScipt>().isCorrect = false;
            //options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answer[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1) {
                options[i].GetComponent<AnswerScipt>().isCorrect = true;
            }
        }
    }

    void changeSomething() {

    }

    void generateQuestion() {
        if(QnA.Count > 0) {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            setAnswers();
        } else {
            // Later proceed to Ending Scene
            Debug.Log("Out of Question");
        }
        
    }
}
