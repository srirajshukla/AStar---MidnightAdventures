    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;

    public Vector3 worldPosition;

    public Node(bool walkable_param, Vector3 worldPosition_param)
    {
        walkable = walkable_param;
        worldPosition = worldPosition_param;
    }
}
