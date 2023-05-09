using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    ActionMap playerController;
    CharacterController characterController;
    public GameObject avatar;
    public GameObject camera;
    [Range(0.5f, 5f)]
    public float moveSpeed = 1f;
    [Range(0.5f, 5f)]
    public float rotationSpeed = 1f;

    private void Awake()
    {
        characterController = avatar.GetComponent<CharacterController>();
        playerController = new ActionMap();
    }

    private void Update()
    {
        //camera.transform.localPosition = new Vector3(0, 0.35f, 0);
        Move();
    }

    private void Move()
    {
        Vector2 m = playerController.KeyboardPlayer.Move.ReadValue<Vector2>();
        Vector3 movement = (m.y * avatar.transform.forward) + (m.x * avatar.transform.right);
        characterController.Move(moveSpeed * Time.deltaTime * movement);

        //if (m.y > 0.9f)
        //{
        //    movement = avatar.transform.forward;
        //    characterController.Move(moveSpeed * Time.deltaTime * movement);
        //}
        //if (m.y < -0.9f)
        //{
        //    movement = -avatar.transform.forward;
        //    characterController.Move(moveSpeed * Time.deltaTime * movement);
        //}
        //if (m.x > 0.9f)
        //{
        //    movement = avatar.transform.right;
        //    characterController.Move(moveSpeed * Time.deltaTime * movement);
        //}
        //if (m.x < -0.9f)
        //{
        //    movement = -avatar.transform.right;
        //    characterController.Move(moveSpeed * Time.deltaTime * movement);
        //}
    }

    private void OnEnable()
    {
        playerController.KeyboardPlayer.Enable();
    }

    private void OnDisable()
    {
        playerController.KeyboardPlayer.Disable();
    }
}
