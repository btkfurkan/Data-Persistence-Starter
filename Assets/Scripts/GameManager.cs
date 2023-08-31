using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    private string playerName;
    private int bestScore;

    public InputField inputName;


    public void SetScore(int score) => bestScore = score;

    public int GetScore() { return bestScore; }

    public void SetName() => playerName = inputName.text;

    public string GetName() { return playerName; }

    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

    }

}
