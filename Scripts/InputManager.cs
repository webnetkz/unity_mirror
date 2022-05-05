using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

  #region Singletone
  private static InputManager _instance;

  public static InputManager Instance
  {
    get
    {
      return _instance;
    } 
  }
  #endregion

  private Vector3 movementVector = new Vector3();
  [SerializeField]
  private Player playerObj;

  private void Awake()
  {
    _instance = this;
  }

  private void Update()
  {
    MoveInput();
  }

  public void SetPlayer(Player pl)
  {
    playerObj = pl;
  }


  private void MoveInput()
  {
    movementVector.x = Input.GetAxis("Horizontal");
    movementVector.z = Input.GetAxis("Vertical");
  }
}
