using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public UnityEvent Fly;
    public UnityEvent Crash;
    public UnityEvent Scores;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * force, mode:ForceMode2D.Impulse);
            Fly.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            Crash.Invoke();
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (other.gameObject.tag == "Scoring")
        {
            Scores.Invoke();
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }


}
