using UnityEngine;
public class Trap2 : MonoBehaviour
{
    public GameObject spike1;

    public GameObject spike2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spike1.SetActive(true);
            spike2.SetActive(true);
        }
    }
}