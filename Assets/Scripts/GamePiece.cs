using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    public int score;
    private int x;
    private int y;
    private Grid.PieceType type;
    private Grid grid;
    private MovablePiece movableComponent;
    private ColorPiece colorComponent;
    private ClerablePiece clerableComponent;
    
    public int X
    {
        get => x;
        set
        {
            if(IsMovable())
                x = value;
        }
    }
    public int Y
    {
        get => y;
        set
        {
            if(IsMovable())
                y = value;
        }
    }
    public Grid.PieceType Type { get => type; }
    public Grid GridRef{ get => grid; }
    public MovablePiece MovableComponent
    {
        get => movableComponent;
    }
    public ColorPiece ColorComponent
    {
        get => colorComponent;
    }

    public ClerablePiece ClerableComponent
    {
        get => clerableComponent;
    }

    private void Awake()
    {
        movableComponent = GetComponent<MovablePiece>();
        colorComponent = GetComponent<ColorPiece>();
        clerableComponent = GetComponent<ClerablePiece>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(int x, int y, Grid grid, Grid.PieceType type)
    {
        this.x = x;
        this.y = y;
        this.grid = grid;
        this.type = type;
    }

    void OnMouseEnter()
    {
        grid.EnterPiece(this);
    }

    void OnMouseDown()
    {
        grid.PressPiece(this);
    }

    void OnMouseUp()
    {
        grid.ReleasePiece();
    }
    public bool IsMovable()
    {
        return movableComponent != null;
    }

    public bool IsColored()
    {
        return colorComponent != null;
    }

    public bool IsClearable()
    {
        return colorComponent != null;
    }
}
