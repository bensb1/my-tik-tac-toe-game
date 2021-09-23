using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject mCellPrefab;
    private Cell[] mcells = new Cell[9];
    
    // Start is called before the first frame update
    void Start()
    {
        Build();
    }
    public void Build()
    {
        for (int i = 0; i <= 8; i++)
        {
            GameObject newCell = Instantiate(mCellPrefab, transform);
            mcells[i] = newCell.GetComponent<Cell>();
        }
    }

  
}
