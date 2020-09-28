using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickup : MonoBehaviour
{
  public AudioSource AmmoSound;
    void OnTriggerEnter(Collider other)
    {
        AmmoSound.Play();

        if (GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 35;
            GlobalAmmo.CurrentAmmo += 85;

            this.gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 120;
            this.gameObject.SetActive(false);
        }
    }
}

