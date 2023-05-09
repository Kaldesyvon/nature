using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   PlayerController controller;
   CharacterController chController;
   public GameObject avatar;

   [Range(1f, 10f)]
   public float moveSpeed = 1f;
   [Range(1f, 10f)]
   public float rotationSpeed = 1f;

   private void Awake()
   {
      controller = new PlayerController();
   }

   void Update()
   {
      Move();
   }

   private void Move()
   {
      
   }

   private void OnEnable()
   {
      controller.keyboard.Enable();
   }

   private void OnDisable()
   {
      controller.keyboard.Disable();
   }
}
