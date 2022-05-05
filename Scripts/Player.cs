using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
  [SyncVar] // Синхронизация значения
  [SerializeField]
  private float speed;

  private Rigidbody rb;


  private void Start()
  {
    rb = GetComponent<Rigidbody>();

    if(isClient)
    {
      SetInputManagerPlayer();
    }

    if(isServer)
    {
      speed = 3;
    }
  }

  private void SetInputManagerPlayer()
  {
    InputManager.Instance.SetPlayer(this);
  }


  public void CmdMovePlayer(Vector3 movementVector)
  {
    
  }

}
