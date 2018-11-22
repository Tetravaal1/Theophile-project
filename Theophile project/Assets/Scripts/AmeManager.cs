using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AmeManager : MonoBehaviour {

    public List<GameObject> ListAmes;
    private Transform player;
    public float distanceFromPlayer;

    private float speed;

    public float ratio = 0.25f;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(0);
        } 
	}

    private void FixedUpdate()
    {
        foreach (GameObject ame in ListAmes)
        {
            float dist = (player.position - ame.transform.position).magnitude;
            speed = dist * ratio*5;
            Debug.Log(dist);
            if (dist > distanceFromPlayer)
            {
                ame.transform.position = Vector3.MoveTowards(ame.transform.position, player.position, speed * Time.deltaTime);
            }
        }
    }
}
