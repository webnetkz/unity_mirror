using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerNetwork : NetworkBehaviour
{
  [SyncVar]
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

  //[ClientRpc]

  [Command]
  public void CmdMovePlayer(Vector3 movementVector)
  {
    rb.AddForce(movementVector.normalized * speed);
  }

}
