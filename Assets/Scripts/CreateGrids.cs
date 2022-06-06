using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
using Random = UnityEngine.Random;

public class CreateGrids : MonoBehaviour
{
    public GameObject prefab;
    public int numToCreate;

    void Start()
    {
        CreateLevelsUI();
    }
    
    void CreateLevelsUI()
    {
        GameObject newObj;

        for (int i = 0; i < numToCreate; i++)
        {
            newObj = (GameObject) Instantiate(prefab, transform);
            newObj.GetComponent<Image>().color = Random.ColorHSV();
        }
    }
}
