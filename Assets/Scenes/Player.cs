using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameManager gameManager;    
    public float speed;
    private Rigidbody playerRigdibody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigdibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManager.isGameOver)
        {
            return;
        }

        
        float inputX = Input.GetAxis("Horizontal"); // Edit > ProjectSettings > Input
        float inputY = Input.GetAxis("Vertical");

        float fallSpeed = playerRigdibody.velocity.y;
        Vector3 velocity = new Vector3(inputX, fallSpeed, inputY);

        velocity = velocity * speed;
        playerRigdibody.velocity = velocity;

        //Vector3 vector4 = new Vector3(inputY, 0, -inputY);
        //playerRigdibody.velocity = vector4;

        //Vector3 vector = new Vector3(1, 0, 0);  // X : 1 오른쪽, -1 왼쪽. X 방향 증가
        //Vector3 vector = new Vector3(0, 0, 1);  // Z : 1 뒤쪽, -1 내쪽
        //playerRigdibody.velocity = vector;
    }
}
