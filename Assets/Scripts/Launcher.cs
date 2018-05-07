using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public float reloadTime;
    
    private bool isActive;
    private float timePassed;

	// Update is called once per frame
	void Update ()
    {
	    if (isActive && timePassed > reloadTime)
        {
            timePassed = 0;
            Instantiate(bulletPrefab, spawnPoint);
        }
        timePassed += Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isActive = false;
        }
    }
}
