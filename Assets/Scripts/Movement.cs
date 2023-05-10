using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    ActionMap playerController;
    CharacterController characterController;
    //public GameObject avatar;
    public new GameObject camera;
    [Range(5f, 30f)]
    public float moveSpeed = 15f;
    [Range(0.5f, 5f)]
    public float rotationSpeed = 1f;

    private void Awake()
    {
        characterController = camera.GetComponent<CharacterController>();
        playerController = new ActionMap();
    }

    private void Update()
    {
        camera.transform.localPosition = new Vector3(0, 0.35f, 0);
        Move();
    }

    private void Move()
    {
        Vector2 m = playerController.KeyboardPlayer.Move.ReadValue<Vector2>();
        camera.transform.rotation = camera.transform.rotation;
        Vector3 movement = (m.y * camera.transform.forward) + (m.x * camera.transform.right);
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
