using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * me8odoi gia tin ploigisi stin selida tou levelmenu kai oi leitourgies ton koumpion 
 */
public class LevelScreenMenu : MonoBehaviour
{
    public void StartLevelScreenMenu()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void EneterToHelpScreen()
    {
        SceneManager.LoadScene("HelpScreen");
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void StartLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void StartLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void StartLevel5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void StartLevel6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void StartLevel7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void StartLevel8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void StartLevel9()
    {
        SceneManager.LoadScene("Level9");
    }
    public void StartLevel10()
    {
        SceneManager.LoadScene("Level10");
    }

    public void Quit()
    {
        Debug.Log("Pressed Quit!");
        Application.Quit();
    }
}
