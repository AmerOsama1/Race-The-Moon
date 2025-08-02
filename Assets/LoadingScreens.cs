using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScreens : MonoBehaviour
{
    public GameObject two;
    public GameObject one;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ss", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ss()
    {
        one.SetActive(false);
        two.SetActive(true);
        Invoke("sss", 3);
    }
    void sss()
    {
        SceneManager.LoadScene("Main");
    }
}
