using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void loadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void quit()
    {
        Application.Quit();
    }
}
