using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public static GameManager Instance;

    public int score;


    public void GameOver()
    {
        Debug.Log("Game over");
    }

    public void IncreaseScore()
    {
        score++;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



}
