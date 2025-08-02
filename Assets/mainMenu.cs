using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public GameObject es;
    bool Show = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Show)
            {
                es.SetActive(true);
                Show = true;
                Time.timeScale = 0;

            }
            else
            {
                es.SetActive(false);
                Show = false;
                Time.timeScale = 1;

            }

        }
    }
}
