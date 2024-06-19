using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    [SerializeField]
    private LayerMask _whatIsGround;
    [SerializeField]
    private LayerMask _whatIsSliGround;
    [SerializeField]
    private float _ray = 1f;
    [SerializeField]
    private float _speed = 5f;

    private Vector2 _moveDir;

    public float _jumpPower = 1f;
    public float _maxJumpPower = 14f;


    public bool isGround;
    public bool isSliGround;

    public bool _jumpReady;
    public bool _jump;
    public bool _superJump;

    private Rigidbody2D _rigid;
    private Animator _anim;
    private SpriteRenderer _spriteRenderer;
    private FrogInput _frogInput;
    private CollisionEagle _collisionEagle;

    private void Awake()
    {
        _frogInput = GetComponent<FrogInput>();
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collisionEagle = GetComponent<CollisionEagle>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        isGround = Physics2D.BoxCast(transform.position, new Vector2(0.9f,0.5f), 0, Vector2.down, _ray, _whatIsGround);

        Move();
        Flip();
        CheckLanding();
    }

    private void OnEnable()
    {
        _frogInput.OnJumpButtonPressed += JumpReady;
        _frogInput.OnJumpButtonReleased += Jump;
    }

    private void OnDisable()
    {
        _frogInput.OnJumpButtonPressed -= JumpReady;
        _frogInput.OnJumpButtonReleased -= Jump;
    }

    public void JumpReady()
    {
        if (isGround)
        {
            _jumpReady = true;
            _anim.SetBool("PlayerJumpReady", true);
            _jumpPower = Mathf.Clamp(_jumpPower, 0f, _maxJumpPower);
            _jumpPower += 17f * Time.deltaTime;
            _speed = 4f;
        }

        else if (!isGround)
        {
            _anim.SetBool("PlayerJumpReady", false);
            _jumpPower = 1f;
        }
    }

    private void Jump()
    {
        if (isGround)
        {
            _jump = true;
            _superJump = true;
            _anim.SetBool("PlayerJumpReady", false);
            _rigid.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
            _jumpPower = 1f;
            _speed = 5f;
        }
    }

    private void CheckLanding()
    {
        _anim.SetBool("PlayerJump", _superJump ? true : false);

        if (isGround && _superJump)
        {
            _superJump = false;
        }

        else if (!isGround && !_superJump)
        {
            _superJump = true;
        }

        if (isGround && _jumpReady && _jump)
        {
            _jumpReady = false;
            _jump = false;
        }

        else if (!isGround && _jumpReady && !_jump)
        {
            _superJump = false;
        }
    }

    private void Move()
    {
        if (!_collisionEagle._isCollision)
        {
            _rigid.velocity = new Vector2(_frogInput.moveDir.x * _speed,_rigid.velocity.y);
        }
    }

    private void Flip()
    {
        if (_frogInput.moveDir.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (_frogInput.moveDir.x > 0)
        {
            _spriteRenderer.flipX = false;
        }
    }

}
