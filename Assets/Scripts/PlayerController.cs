using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour

{
    public Camera pCamera;
    public float walkSpeed = 7f;
    public float gravity = 20.0f;
    public float jumpSpeed = 8.0f;
    public float switchSpeed = 2f;
    public float switchLimit = 40.0f;
    public float runSpeed = 12;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0f;

    [SerializeField] private AudioSource walkingSource;
    [SerializeField] private AudioSource runningSource;



    [HideInInspector]
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fw = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRun = Input.GetKey(KeyCode.LeftShift);
        float curX = canMove ? (isRun ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curY = canMove ? (isRun ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float mvmDirectionY = moveDirection.y;
        moveDirection = (fw * curX) + (right * curY);

        if ((curX != 0 || curY != 0) && characterController.isGrounded)
        {
            if (isRun)
            {
                if (!runningSource.isPlaying)
                {
                    runningSource.Play();
                }

                walkingSource.Stop();
            }
            else
            {
                if (!walkingSource.isPlaying)
                {
                    walkingSource.Play();
                }

                runningSource.Stop();
            }
        }
        else
        {
            walkingSource.Stop();
            runningSource.Stop();
        }


        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {

            moveDirection.y = mvmDirectionY;

        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;

        }

        characterController.Move(moveDirection * Time.deltaTime);  

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * switchSpeed;
            rotationX = Mathf.Clamp(rotationX, -switchLimit, switchLimit);
            pCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * switchSpeed, 0);
        }
    }
}
