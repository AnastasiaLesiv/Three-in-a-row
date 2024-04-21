using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAroundPiece : ClerablePiece
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Clear()
    {
        Debug.Log("Do method Clear in class ClearAroundPiece");
        base.Clear();
        Debug.Log("Do method ClearAround in class ClearAroundPiece");
        piece.GridRef.ClearAround(piece.X, piece.Y);
    }
}
