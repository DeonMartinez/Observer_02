using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    bool gameOver = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    //half way marker text
    public Text TextLeft;
    public Text TextRight;
    public int count = 1;

    //halo change 
    public GameObject player;



    private void OnEnable()
    {
        PlayerMovement.OnHalfWay += DisplayText;

    }

    private void OnDisable()
    {
        PlayerMovement.OnHalfWay -= DisplayText;

    }
    public void CompleteLevel()
    { 
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameOver == false) {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DisplayText()
    {
        switch (count)
        {
            case 1:
                TextLeft.text = "There's no earthly way of knowing";
                break;
            case 2:
                TextRight.text = "Which direction we are going";
                break;
            case 3:
                TextLeft.text = "There's no knowing where we're rowing";
                break;
            case 4:
                TextRight.text = "Or which way the river's flowing";
                break;
            default:
                TextRight.text = "Something is Very wrong";
                break;

        }

        count++;
    }


}
