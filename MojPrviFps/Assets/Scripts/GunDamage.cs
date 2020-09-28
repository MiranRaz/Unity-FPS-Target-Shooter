using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour

{
    public int DamageAmount = 20;
 public float TargetDistance;
 public float AllowedRange = 30.0f;


  void Update () {

if(GlobalAmmo.LoadedAmmo>=1){

  if(Input.GetButtonDown("Fire1")) {
   RaycastHit Shot;
  
 if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot)) {
    TargetDistance = Shot.distance;
   
 if (TargetDistance < AllowedRange) {
     Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
   
 }
   }
  }
 }
}
}
