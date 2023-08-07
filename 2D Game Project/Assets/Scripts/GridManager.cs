using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        int tileNum = 1;
        for(int x = 0; x < 10; x++)
        {
            for(int y = 0; y < 10; y++)
            {
                GameObject tileClone = Instantiate(tile, new Vector2(x + 0.5f - 5f, y + 0.5f - 5f), Quaternion.identity);
                tileClone.name = "Tile " + tileNum;
                tileNum++;
                tileClone.transform.localScale = new Vector2(0.95f, 0.95f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
