using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardblocks : MonoBehaviour
{
  public  int hp=1;
  private void OnCollisionEnter2D(Collision2D collisioninfo)
  {
    hp--;
    if(hp<=0)
    {
        Destroy(gameObject);
    }
  }
}
