using System.Collections;
using UnityEngine;

public class PlanStal : MonoBehaviour
{
    public Transform[] Pos ;
    public GameObject[] OBJ;
    public GameObject bor;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is create
 /*   void Start()
    {
        InvokeRepeating("St",4.655f,4.655f);        
    }
    void St()
    {
        for (int i = 0; i < Pos.Length; i++) {
            Instantiate(OBJ[Random.Range(0, OBJ.Length)], Pos[i].position, Quaternion.identity);
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bor"))
        {
            Instantiate(bor, Pos[2].position, Quaternion.identity);
            for (int i = 0; i < Pos.Length; i++)
            {
                Instantiate(OBJ[Random.Range(0, OBJ.Length)], Pos[i].position, Quaternion.identity);
            }
        }
    }


}
