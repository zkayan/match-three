using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{

    public int xIndex;
    public int yIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetCoord(int x, int y)
    {
        xIndex = x;
        yIndex = y;
    }
}
