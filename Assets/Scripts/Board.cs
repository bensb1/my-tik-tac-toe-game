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

    public bool CheckForWinner()
    {
        int i = 0;
        // horizontal 
        for(i = 0; i <=6; i += 3)
        {
            if (!CheckVaules(i, i + 1))
                continue;
            if (!CheckVaules(i, i + 2))
                continue;

            return true;

        }

        //vertical
        for (i = 0; i <= 2; i++)
        {
            if (!CheckVaules(i, i + 3))
                continue;
            if (!CheckVaules(i, i + 6))
                continue;

            return true;
        }
        //diaganol

            return false;
    }
  private bool CheckVaules(int firstIndex, int secondIndex)
    {
        string firstValue = mcells[firstIndex].mLabel.text;
        string secondVaule = mcells[secondIndex].mLabel.text;
        if(firstValue =="" || secondVaule == "")
        
            return false;

            if (firstValue == secondVaule)
                return true;
        else
        return false;
    }

  
}
