using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private CharacterController controller;
        [SerializeField] private float runSpeed = 40f;

        private float horizontalMove = 0f;
        private bool jump = false;

        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if  (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }

        void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
    }
}