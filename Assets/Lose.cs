using System;
using UnityEngine;

public class Lose : MonoBehaviour
{
     GameObject LoseScreen;
    public AudioClip clip;
    AudioSource sc;
    private void Start()
    {
        sc = GetComponent<AudioSource>();
        LoseScreen = GameObject.FindGameObjectWithTag("Lose");

    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            sc.clip = clip;
            sc.PlayOneShot(clip);

            foreach (Transform child in LoseScreen.transform)
            {
                child.gameObject.SetActive(true);
            }
            Time.timeScale = 0;
        }
    }
}
