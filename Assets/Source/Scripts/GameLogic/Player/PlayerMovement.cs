using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent (typeof(PlayerFlip))]
public class PlayerMovement : MonoBehaviour, IMoveble
{
    public const string Horizontal = nameof(Horizontal);
    public const string Run = nameof(Run);

    [SerializeField] private float _speed;

    private float _horizontal;
    private Animator _animator;
    private PlayerFlip _playerFlip;

    public float InputHorizontal => _horizontal;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerFlip = GetComponent<PlayerFlip>();
    }

    private void Update() => Move();

    public void Move()
    {
        _playerFlip.Flip();

        _horizontal = Input.GetAxis(Horizontal);
        float direction = _horizontal * _speed * Time.deltaTime;
        transform.Translate(Vector2.right * direction);

        if (_horizontal > 0 || _horizontal < 0)
            _animator.SetBool(Run, true);
        else
            _animator.SetBool(Run, false);
    }
}