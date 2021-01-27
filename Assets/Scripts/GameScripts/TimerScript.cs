using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    // me to timer orizoume to xrono pou 8a exei se kaue epipedo gia na paiksei
    float timer = 90f;
    public Text timerText;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0");

        if (timer <= 0)
        {
            StopLevel();
        }
    }

    private void StopLevel()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
