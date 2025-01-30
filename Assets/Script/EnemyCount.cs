using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    public static List<Enemy> enemies = new List<Enemy>();
    public GameObject piratePrefab;
    public TextMeshProUGUI victoryText;

    void SpawnEnemies()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-7f, 7f), Random.Range(-4f, 4f));
            GameObject newEnemy = Instantiate(piratePrefab, randomPosition, Quaternion.identity);
        }
    }

    public static void RegisterEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public static void UnregisterEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        if (enemies.Count == 0)
        {
            FindObjectOfType<EnemyCount>().ShowVictoryText();
        }
    }

    void ShowVictoryText()
    {
        victoryText.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
        victoryText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
