using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public Transform _spawnPoint;
    int score = 0;
    

    public TextMeshProUGUI _scoreText;
    public GameObject _playButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnOnstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, _spawnPoint.position, Quaternion.identity);

            
        }
    }

    void ScoreUp()
    {
        score++;
        _scoreText.text = score.ToString();
    }

    public void GameStart()
    {
        player.SetActive(true);
        _playButton.SetActive(false);

        StartCoroutine("SpawnOnstacles");
        InvokeRepeating("ScoreUp",2f,1f);
    }
}
