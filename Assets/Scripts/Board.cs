using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject mCellPrefab;
    private Cell[] mcells = new Cell[9];
    
    // Start is called before the first frame update

    public void Build(Main main)
    {
        for (int i = 0; i <= 8; i++)
        {
            GameObject newCell = Instantiate(mCellPrefab, transform);
            mcells[i] = newCell.GetComponent<Cell>();
            mcells[i].mMain = main;
        }
    }

  
}
