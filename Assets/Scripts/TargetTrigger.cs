using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBlock block = collision.GetComponent<TextBlock>();
        if (block != null)
        {
            GameControl.instance.currentBlock = block;
            if (GameControl.instance.lbwnb)
            {
                Destroy(block.gameObject);
                GameControl.instance.UpdateScore(1);
                if (block.last)
                {
                    GameControl.instance.GameOver();
                }
            }
        }
    }

}
