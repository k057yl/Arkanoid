using UnityEngine;
public class EnemyCreator : MonoBehaviour
{
    int enemy1 = 0;
    public GameObject[] enemyPrefab, enemyPrefab1, enemyPrefab2;
    private void Start()
    {
        if (enemy1 < 1)
        {
            for (int i = 0; i < enemyPrefab.Length; i++)
            {
                Instantiate(enemyPrefab[0], new Vector2(-6 + i, 4), Quaternion.identity);
                Instantiate(enemyPrefab1[0], new Vector2(-6 + i, 3), Quaternion.identity);
                Instantiate(enemyPrefab2[0], new Vector2(-6 + i, 2), Quaternion.identity);
                enemy1++;    
            }
        }
    }
}
