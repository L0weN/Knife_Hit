using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knifePrefab;

    [SerializeField]private Text scoreText;
    private int score;

    public void SpawnKnife()
    {
        GameObject go = Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        go.transform.parent = spawnPoint;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
