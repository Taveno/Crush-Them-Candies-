using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    public GameObject OptionsBTN;
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void OpenOptions()
    {
        OptionsBTN.SetActive(true);
    }

    public void CloseOptions()
    {
        OptionsBTN.SetActive(false);
    }
}
