using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Sky : MonoBehaviour
{
    public Material[] skyMaterials;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderSettings.skybox = skyMaterials[UnityEngine.Random.Range(0, skyMaterials.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
