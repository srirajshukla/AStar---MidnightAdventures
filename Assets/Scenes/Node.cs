    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;

    public int gCost;   // gCost is the cost from starting location.
    public int hCost;   // hCost is the cost from final location.

    public Node parent;


    public Node(bool walkable_param, Vector3 worldPosition_param, int gridX_param, int gridY_param)
    {
        walkable = walkable_param;
        worldPosition = worldPosition_param;
        gridX = gridX_param;
        gridY = gridY_param;
    }

    /// <summary>
    /// fCost is the sum of gCost and hCost.
    /// </summary>
    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }
}
