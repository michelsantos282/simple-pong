using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] private TextMeshProUGUI labelP1;
    [SerializeField] private TextMeshProUGUI labelIa;
    private int playerScore = 0;
    private int iaScore = 0;


    public void PlayerPoint()
    {
        playerScore++;
        labelP1.text = playerScore.ToString();
    }

    public void IaScore()
    {
        iaScore++;
        labelIa.text = iaScore.ToString();
    }
}
