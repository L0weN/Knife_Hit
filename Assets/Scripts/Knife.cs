using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private Rigidbody rb;
    private bool onWood;

    private KnifeSpawner knifeSpawner;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        knifeSpawner = GameObject.Find("KnifeSpawner").GetComponent<KnifeSpawner>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !onWood)
        {
            rb.velocity = new Vector3(0f, speed, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wood")
        {
            gameObject.transform.SetParent(other.transform);
            rb.velocity = Vector3.zero;
            onWood= true;
            rb.detectCollisions = false;

            knifeSpawner.SpawnKnife();
            knifeSpawner.IncrementScore();
        }

        if(other.tag == "knife")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
