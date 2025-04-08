using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedWalk;
    [SerializeField] private float _gravity;
    [SerializeField] private float _jumpPower;
    private Vector3 _walkDirection;

    private Vector3 _velocity;

    private CharacterController _characterController;

   // public Animator _animator;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        
    }


    void Update()
    {
        DoJump(  Input.GetKey(KeyCode.Space) && _characterController.isGrounded);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _walkDirection = transform.right * x + transform.forward * z;
       // _animator.SetBool("walk", false);
    }

    private void FixedUpdate()
    {

        Walk(_walkDirection);

        DoGravity(_characterController.isGrounded);
    }



    private void Walk(Vector3 direction)
    {
        _characterController.Move(direction * _speedWalk * Time.fixedDeltaTime);

        //_animator.SetBool("walk",true);
    }

    private void DoGravity(bool isGrounded)

    {
        if (isGrounded && _velocity.y < 0)
            _velocity.y = -1f;
        _velocity.y -= _gravity * Time.fixedDeltaTime;
        _characterController.Move(_velocity * Time.fixedDeltaTime);
    }
    private void DoJump(bool canJump)
    {
        if(canJump)
        _velocity.y = _jumpPower;


    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
