using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrigger : MonoBehaviour {

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
            Destroy(collision.gameObject);
            GameControl.instance.UpdateScore(-5);
            if (block.last)
            {
                GameControl.instance.GameOver();
            }
        }
    }

}
