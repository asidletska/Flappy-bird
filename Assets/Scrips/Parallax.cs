using UnityEngine;

public class Parallax : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float animationSpeed = 1f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
