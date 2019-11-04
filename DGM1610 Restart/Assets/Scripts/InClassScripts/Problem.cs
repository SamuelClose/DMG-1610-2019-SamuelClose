using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Problem : MonoBehaviour
{
    public List<GameArtData> collectionList;

    private void Start()
    {
        AddData(GameArtData);
        Debug.Log("sweet new item");
    }

    public GameArtData GameArtData { get; set; }


    private void AddData(GameArtData obj)
    {
        for (int i = 0; i < collectionList.Count; i++)
        {
            if (collectionList.Contains(obj))
            {
                collectionList.Remove(obj);
            }
        }
    }
}




//CHECK OBJECT ITSELF

// == is equals