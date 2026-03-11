using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    private bool isPaused;
    public GameObject PauseMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        isPaused = false;
    }
}
