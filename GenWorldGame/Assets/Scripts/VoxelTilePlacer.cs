using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class VoxelTilePlacer : MonoBehaviour
{
    //  Time interval between attempts to add new voxels
    public float waitingTime = 0.1f;

    //  Array for tile prefabs (Links to tiles already placed on the scene)
    public List<VoxelTile> TilePrefabs;

    //  Variable for the size of our map
    public Vector2Int MapSize = new Vector2Int(x: 10, y: 10);

    //  Two-dimensional array of tiles (We sav