using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManaget : MonoBehaviour
{
    public static ScreenManaget SM { get; private set; }



    private void Awake()
    {

        if (SM != null)
        {
            Destroy(gameObject);
            return;
        }

        SM = this;
        DontDestroyOnLoad(gameObject);

    }
    public void StartGame(int screenId) => SceneManager.LoadScene(screenId);


    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }



}
