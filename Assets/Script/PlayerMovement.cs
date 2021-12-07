using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  [SerializeField] private float MoveSpeed = 1.0f;

  private Rigidbody rb;

  private float dirX = 0.0f;
  private float dirY = 0.0f;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    Movement();
  }

  private void Movement()
  {
    dirX = Input.GetAxis("Horizontal"); // With smoothing, so character can slide
    dirY = Input.GetAxis("Vertical"); // With smoothing, so character can slide
    //dirX = Input.GetAxisRaw("Horizontal"); // No smoothing
    
    rb.velocity = new Vector3(dirX * MoveSpeed, rb.velocity.y, dirY * MoveSpeed);
  }
}
