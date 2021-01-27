using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * oi leitourgies apo ta koumpia tis arxikis o8onis
 */
public class StartScreenMenu : MonoBehaviour
{
    public void StartGane()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void Quit()
    {
        Debug.Log("Pressed Quit!");
        Application.Quit();
    }
    
}
