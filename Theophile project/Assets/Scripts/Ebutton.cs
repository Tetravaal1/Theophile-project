using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebutton : MonoBehaviour {

    private SpriteRenderer sRenderer;
    private GameManager gameManager;
    public Sprite bouttonPresse;

	void Start () {
        sRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sRenderer.sprite = bouttonPresse;
        }
        if(Input.GetKeyUp(KeyCode.E)) {
            gameManager.Changement();
            Destroy(gameObject);
        }
	}
}
