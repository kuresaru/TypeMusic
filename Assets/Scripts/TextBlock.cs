using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlock : MonoBehaviour {

    public KeyCode key;
    public bool last = false;

	// Use this for initialization
	void Start () {
        if (GameControl.instance.singleMode.isOn)
        {
            key = KeyCode.A;
        }
        else
        {
            int rand = Random.Range('a', 'z' + 1);
            key = (KeyCode)rand;
        }
        TextMesh text = GetComponentInChildren<TextMesh>();
        text.text = (char)(key - 0x20) + "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
