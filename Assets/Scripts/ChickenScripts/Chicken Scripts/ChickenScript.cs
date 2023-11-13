using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenScript : MonoBehaviour
{   [SerializeField]
    private float _moveSpeed = 3.0f;
    private Rigidbody2D _rBody;
    private Animator _animator;
    private SpriteRenderer _sRenderer;

    [SerializeField]
    private float _firstJumpForce = 5f,_secondJumpForce = 7f;
    private bool _isFirstJump,_isSecondJump;


    [SerializeField]
    private bool _isGoingLeft;


    private void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _sRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }


    private void Update()
    {
        MoveChicken();
        if(Input.GetMouseButtonDown(0))
        {
            JumpChicken();
        }
        
    }
    private void MoveChicken()
    {
        if(_isGoingLeft == true)
        {
            _rBody.velocity = new Vector2(-_moveSpeed,0f);
        }
        else
        {
            _rBody.velocity = new Vector2(_moveSpeed,0);

        }
        
    }//MoveChicken
    private void JumpChicken()
    {
        if (_isFirstJump == true)
        {
            _isFirstJump = false;

            _rBody.velocity = new Vector2 (_rBody.velocity.x,_firstJumpForce);

            _animator.SetTrigger("Fly");
             
            

        }
        else if(_isSecondJump == true)
        {
            _isSecondJump = false;

            _rBody.velocity = new Vector2 (_rBody.velocity.x, _secondJumpForce);

            _animator.SetTrigger("Fly");

        }
    }//JumpChicken
    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Border")
        {
            _isGoingLeft = !_isGoingLeft;
            _sRenderer.flipX = _isGoingLeft;
        }
        if(target.gameObject.tag == "Ground")
        {
            _isFirstJump = true;
            _isSecondJump = true;

        }

    }
}
