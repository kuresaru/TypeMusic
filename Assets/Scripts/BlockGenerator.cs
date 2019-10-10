using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    private const float genX = 10.1F;
    private const float genY = 3.0F;

    public GameObject blockPrefab;
    public float generateOffset;

    private List<GameObject> objects = new List<GameObject>();
    private int currentBlockIndex;

    // Use this for initialization
    void Start()
    {
        currentBlockIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ClearAll()
    {
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
        objects.Clear();
        Start();
    }

    public void StartGen()
    {
        Invoke("Timer", BlockTable.start[currentBlockIndex] - generateOffset);
    }

    void Timer()
    {
        if (!GameControl.instance.gameOver)
        {
            Gen();
            currentBlockIndex++;
            if (currentBlockIndex < BlockTable.start.Length)
            {
                Invoke("Timer", BlockTable.start[currentBlockIndex]);
            }
        }
    }

    private void Gen()
    {
        GameObject gameObject = Instantiate(blockPrefab, new Vector2(genX, genY), Quaternion.identity);
        TextBlock textBlock = gameObject.GetComponent<TextBlock>();
        if (textBlock != null)
        {
            textBlock.last = currentBlockIndex + 1 == BlockTable.start.Length;
            objects.Add(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
