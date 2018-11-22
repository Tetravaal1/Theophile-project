using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXLayer : MonoBehaviour {

    public SpriteRenderer objectRenderer;
	void Start () {
        
        

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<ParticleSystemRenderer>().sortingOrder = objectRenderer.sortingOrder+1;
    }
}
