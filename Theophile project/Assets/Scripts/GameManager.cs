using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private Animator coffre;

	void Start () {
        //coffre = GameObject.FindGameObjectWithTag("Coffre").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Changement() {
        coffre.SetTrigger("Open");
    }
}
