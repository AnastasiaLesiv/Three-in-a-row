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
        base.Clear();
        piece.GridRef.ClearAround(piece.X, piece.Y);
    }
}
