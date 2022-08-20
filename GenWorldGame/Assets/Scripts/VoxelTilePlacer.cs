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

    //  Two-dimensional array of tiles (We save here already spawned tiles)
    private VoxelTile[,] spawnedTiles;

    // Start is called before the first frame update
    private void Start()
    {
        //  Initialize the array to fit the map 
        spawnedTiles = new VoxelTile[MapSize.x, MapSize.y];

        foreach(VoxelTile tilePrefab in TilePrefabs)
        {
            tilePrefab.CalculateSidesColors();
        }

        int countBeforeAdding = TilePrefabs.Count;
        for (int i = 0; i < countBeforeAdding; i++)
        {
            VoxelTile clone;
            switch (TilePrefabs[i].Rotation)
            {
                case VoxelTile.RotationType.OnlyRotation:
                    break;

                case VoxelTile.RotationType.TwoRotations:
                    TilePrefabs[i].Weight /= 2;
                    if (TilePrefabs[i].Weight <= 0) TilePrefabs[i].Weight = 1;

                    clone = Instantiate(TilePrefabs[i], TilePrefabs[i].transform.position + Vector3.right, Quaternion.identity);
                    clone.Rotate90();
                    TilePrefabs.Add(clone);
                    break;

                case VoxelTile.RotationType.FourRotations:
                    TilePrefabs[i].Weight /= 4;
                    if (TilePrefabs[i].Weight <= 0) TilePrefabs[i].Weight = 1;

                    clone = Instantiate(TilePrefabs[i], TilePrefabs[i].transform.position + Vector3.right, Quaternion.identity);
                    clone.Rotate90();
                    TilePrefabs.Add(clone);

                    clone = Instantiate(TilePrefabs[i], TilePrefabs[i].transform.position + Vector3.right * 2, Quaternion.identity);
                    clone.Rotate90();
                    clone.Rotate90();
                    TilePrefabs.Add(clone);

                    clone = Instantiate(TilePrefabs[i], TilePrefabs[i].transform.position + Vector3.right * 3, Quaternion.identity);
                    clone.Rotate90();
                    clone.Rotate90();
                    clone.Rotate90();
                    TilePrefabs.Add(clone);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        //  Calling the map generation function 
        StartCoroutine(routine: Generate());
    }

    // Update is called once per frame
    private void Update()
    {
        //  Restarting our generation when pressing the d key
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();

            foreach(VoxelTile spawnedTile in spawnedTiles)