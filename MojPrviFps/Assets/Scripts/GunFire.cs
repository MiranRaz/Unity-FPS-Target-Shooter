using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{

    public GameObject Flash;
    public GameObject CrosshairObject;
    Camera mainCam;
  

    void Start(){
	mainCam = Camera.main;
    }

    void Update()
    {
	
	if(Input.GetButtonDown("Fire2")){
	GetComponent<Animation>().Play("ZoomToShoot");
	mainCam.fieldOfView = 25;
	}
    else
	if(Input.GetButtonUp("Fire2")){
	GetComponent<Animation>().Play("UnzoomToShoot");
	mainCam.fieldOfView = 60;
        }

        if (Input.GetButtonDown("Fire1") && GlobalAmmo.LoadedAmmo >= 1)
        {
            AudioSource GunSound = GetComponent<AudioSource>();
            GunSound.Play();
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
            GetComponent<Animation>().Play("GunShot1");
            GlobalAmmo.LoadedAmmo -= 1;
	    
        }
	
    }

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        Flash.SetActive(false);
    }
}