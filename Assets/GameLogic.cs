using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static float dropTime = 0.9f;
    public static float quickDropTime = 0.05f;

    public static int width = 10, height = 20;
    public GameObject[] blocks;
    public Transform[,] grid = new Transform[width, height];
    // Start is called before the first frame update
    void Start()
    {
        SpawnBlock();
    }
    public void SpawnBlock()
    {
        float guess = Random.Range(0, 1f);
        guess *= blocks.Length; // recieve blocks index

        Instantiate(blocks[Mathf.FloorToInt(guess)]);
    }
}
