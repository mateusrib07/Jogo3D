using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(3);
    }
    public void Configurações()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Você saiu");
    }
}
