using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Credit()
    {
        SceneManager.LoadScene(0);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }
}