using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  [SerializeField] private Transform playerTrans;

  // Update is called once per frame
  void Update()
  {
    transform.position = new Vector3(playerTrans.position.x, transform.position.y, playerTrans.position.z);
  }
}
