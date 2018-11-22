using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class PressE : MonoBehaviour {

    public GameObject leboutton;
    public GameObject Ame;
    public Transform spawnAme;
    private GameObject buttonE;
    private Vector3 offset = new Vector3(0.65f, 0.70f, 0f);

    public Sprite bouttonPresse;
    private SpriteRenderer EsRenderer;

    public ParticleSystem Glow;
    public Transform glowPoint;

    private bool canActivate = false;
    private bool alive = true;

    private void Start()
    {
        EsRenderer = leboutton.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (canActivate&&alive) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EsRenderer.sprite = bouttonPresse;
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                GetComponent<Animator>().SetTrigger("Open");
                //SpawnAme();
                Destroy(leboutton);
                alive = false;
            }
        }
    }
    void SpawnAme() {
        /*FindObjectOfType<AmeManager>().ListAmes.Add(Instantiate(Ame, spawnAme.position, Quaternion.identity));
        Debug.Log(spawnAme.position);*/
        StartCoroutine(SpawnAmee());
    }

    IEnumerator SpawnAmee() {
        GameObject ame = Instantiate(Ame, spawnAme.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        FindObjectOfType<AmeManager>().ListAmes.Add(ame);
    }

    void SpawnGlow() {
        ParticleSystem glow = Instantiate(Glow, glowPoint.position, Quaternion.identity);
        glow.Stop();
        Glow.Emit(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&alive) {
            Debug.Log("boup");
            //buttonE = Instantiate(leboutton, transform.position+offset, Quaternion.identity);
            leboutton.SetActive(true);
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&alive)
        {
            leboutton.SetActive(false);
            canActivate = false;
        }
    }
}
