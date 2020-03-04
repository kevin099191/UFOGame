using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Screan : MonoBehaviour
{
    public Text T;
    private ScoreManager SM;
    public GameObject Startgame;
    public bool bl;

    private void Start()
    {
        SM = FindObjectOfType<ScoreManager>();
       
    }




    public void StartGame()
    {
        Startgame.SetActive(false);
       
    }





    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void ScoreFinal()
    {

        T.text = "Score : " + SM.Score;

    }

    private void Update()
    {
        ScoreFinal();
    }



}
