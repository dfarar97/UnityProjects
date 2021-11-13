using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;
    public TextMeshProUGUI gameOverText;
    private float spawnRate = 1.0f;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public bool isGameActive;
    public Button restartButton;
    

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        UpdateScore(0);
        StartCoroutine(SpawnTarget());

        
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

            //UpdateScore(5);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
