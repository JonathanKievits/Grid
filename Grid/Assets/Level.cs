using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    private Grid curGrid;

	void Start ()
    {
        curGrid = new Grid(20, 20);
        curGrid.GetNode(2, 2).IsWalkable = false;
        curGrid.GetNode(2, 3).IsWalkable = false;
        curGrid.GetNode(3, 3).IsWalkable = false;
        curGrid.GetNode(4, 3).IsWalkable = false;
        curGrid.GetNode(5, 3).IsWalkable = false;
    }
	

	void Update ()
    {
		
	}
}
