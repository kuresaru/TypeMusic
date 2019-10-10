using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlockBlock : MonoBehaviour {

    private const float blockSize = 1.0F;
    private const float borderSize = 0.1F;

	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = new Vector3[]
        {
            new Vector3(-blockSize, blockSize, 0.0F),
            new Vector3(-blockSize + borderSize, blockSize, 0.0F),
            new Vector3(blockSize - borderSize, blockSize, 0.0F),
            new Vector3(blockSize, blockSize, 0.0F),

            new Vector3(-blockSize, blockSize - borderSize, 0.0F),
            new Vector3(-blockSize + borderSize, blockSize - borderSize, 0.0F),
            new Vector3(blockSize - borderSize, blockSize - borderSize, 0.0F),
            new Vector3(blockSize, blockSize - borderSize, 0.0F),

            new Vector3(-blockSize, -blockSize + borderSize, 0.0F),
            new Vector3(-blockSize + borderSize, -blockSize + borderSize, 0.0F),
            new Vector3(blockSize - borderSize, -blockSize + borderSize, 0.0F),
            new Vector3(blockSize, -blockSize + borderSize, 0.0F),

            new Vector3(-blockSize, -blockSize, 0.0F),
            new Vector3(-blockSize + borderSize, -blockSize, 0.0F),
            new Vector3(blockSize - borderSize, -blockSize, 0.0F),
            new Vector3(blockSize, -blockSize, 0.0F)
        };
        mesh.triangles = new int[]
        {
            12, 0, 1,
            12, 1, 13,
            5, 1, 2,
            5, 2, 6,
            14, 2, 3,
            14, 3, 15,
            13, 9, 10,
            13, 10, 14
        };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
