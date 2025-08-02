using UnityEngine;

public class XTaken : MonoBehaviour
{
    public AudioClip clip;
   public AudioSource sc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource tempAudio = Instantiate(sc, transform.position, Quaternion.identity);
            Destroy(gameObject);
            tempAudio.clip = clip;
            tempAudio.Play();
            Destroy(tempAudio.gameObject, clip.length);

    

        }
    }
    
}
