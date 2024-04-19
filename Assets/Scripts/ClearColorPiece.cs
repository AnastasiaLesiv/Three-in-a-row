using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearColorPiece : ClerablePiece
{
    private ColorPiece.ColorType color;

    public ColorPiece.ColorType Color
    {
        get => color;
        set => color = value;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void Clear()
    {
        base.Clear();
        piece.GridRef.ClearColor(color);
        
    }
}
