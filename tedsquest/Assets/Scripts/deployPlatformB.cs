using System.Collections;
using UnityEngine;

public class deployPlatformB : Singleton<deployPlatformB>
{
    public GameObject platformBPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(PlatformBWave());
    }

    private void spawnPlatformB()
    {
        GameObject a = Instantiate(platformBPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -1, UnityEngine.Random.Range((float)0.7, (screenBounds.y / 2)));
    }

    IEnumerator PlatformBWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatformB();
        }
    }
}
