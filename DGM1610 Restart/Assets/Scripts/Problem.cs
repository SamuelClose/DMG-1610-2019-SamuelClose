using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
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