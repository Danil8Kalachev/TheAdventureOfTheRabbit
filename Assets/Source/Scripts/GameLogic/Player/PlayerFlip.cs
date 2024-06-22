using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent (typeof(PlayerMovement))]
public class PlayerFlip : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private SpriteRenderer _spriteRenderer;

    private void Awake() => _spriteRenderer = GetComponent<SpriteRenderer>();

    public void Flip()
    {
        if (_playerMovement.InputHorizontal < 0)
            _spriteRenderer.flipX = true;
        else
            _spriteRenderer.flipX = false;
    }
}