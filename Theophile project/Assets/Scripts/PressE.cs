using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class PressE : MonoBehaviour {

    public GameObject leboutton;
    public Vector3 buttonPos;
    private GameObject buttonE;
    private Vector3 offset = new Vector3(0.65f, 0.70f, 0f);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("boup");
            buttonE = Instantiate(leboutton, transform.position+offset, Quaternion.identity);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(buttonE);
    }
}
