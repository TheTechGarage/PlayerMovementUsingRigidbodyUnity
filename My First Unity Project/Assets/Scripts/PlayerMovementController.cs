using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody PlayerRigidBody;
    public float JumpForce;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRigidBody.velocity = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, PlayerRigidBody.velocity.y, Input.GetAxis("Vertical") * MoveSpeed);

        if(PlayerRigidBody.transform.position.y == 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                PlayerRigidBody.velocity = new Vector3(PlayerRigidBody.velocity.x, JumpForce, PlayerRigidBody.velocity.z);
            }
        }
        
    }
}
