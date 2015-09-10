using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour
{

    public GameObject TileCubePrefab;

    public int boardHeight = 10;
    public int boardWidth = 10;

	// Use this for initialization
	void Start ()
    {
        SpawnPlayerBoard();
        SpawnEnemyBoard();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void SpawnPlayerBoard()
    {
        //public GameObject boardHolder2

        for (int i = 0; i < boardHeight; i++)
        {
            Instantiate(TileCubePrefab, new Vector2(i, 0f), Quaternion.identity);
            Debug.Log("First for-loop executed. (BoardHeight.)");

            for (int j = 0; j < boardWidth; j++)
            {
                Instantiate(TileCubePrefab, new Vector2(i, j),Quaternion.identity);
                Debug.Log("Second for-loop executed. (BoardWidth.)");
            }
        }
    }

    public void SpawnEnemyBoard()
    {
       
        for (int i = 0; i < boardHeight; i++)
        {
            Instantiate(TileCubePrefab, new Vector2(i + 15, 0f), Quaternion.identity);
            Debug.Log("First for-loop in enemyBoard executed. (BoardHeight.)");

            for (int j = 0; j < boardWidth; j++)
            {
                Instantiate(TileCubePrefab, new Vector2(i + 15, j), Quaternion.identity);
                Debug.Log("Second for-loop in enemyBoard executed. (BoardWidth.)");
            }
        }
    }
}
