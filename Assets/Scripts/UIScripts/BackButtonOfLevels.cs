using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * To BACK button pou uparxei se ola ta levels gia an epistrepsei noritera stin o8oni me ta levels
 */
public class BackButtonOfLevels : MonoBehaviour
{
    public void StartLevelScreenMenu()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
