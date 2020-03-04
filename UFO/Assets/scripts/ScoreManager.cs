using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Text Text;
    public int Score = 0;
    public int p;
    public void AddScore(int getScore)
    {
        Score += getScore;

        Text.text = "Score : " + Score;
     

    }










}
