using UnityEngine;

public class Tube : MonoBehaviour
{
    public float Speed = 5f;
    private float leftRage;

    private void Start()
    {
        leftRage = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < leftRage)
        {
            Destroy(gameObject);
        }
    }


}
