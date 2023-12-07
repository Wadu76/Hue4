using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public PlayerInputControl inputControl;
    [SerializeField] spawn isGround;
    private Rigidbody2D rb;
    public Vector2 inputDirection;
    [Header("基本参数")]
    public float speed;
    public float jumpForce;
    private PhysicsCheck physicsCheck;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        physicsCheck = GetComponent<PhysicsCheck>();

        inputControl = new PlayerInputControl();

    }


    void colision_detection()
    {
        GameObject[] collider_detect = GameObject.FindGameObjectsWithTag("ground");

        foreach (GameObject go in collider_detect)
        {
            print("jump");
            isGround = go.GetComponent<spawn>();
            if (isGround.collider_collision_interact == true && Input.GetKeyDown(KeyCode.Space))//只能用getkeydown否则将一跳到顶
            {
                rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            }
        }

    }


    private void OnEnable()
    {
        inputControl.Enable();
    }

    private void OnDisable()
    {
        inputControl.Disable();
    }

    private void Update()
    {
        colision_detection();
        inputDirection = inputControl.GamePlay.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        rb.velocity = new Vector2(inputDirection.x * speed * Time.deltaTime, rb.velocity.y);

        int faceDir = (int)transform.localScale.x;

        if (inputDirection.x > 0)
            faceDir = 1;
        if (inputDirection.x < 0)
            faceDir = -1;
        //人物翻转
        transform.localScale = new Vector3(faceDir, 1, 1);
    }


}
