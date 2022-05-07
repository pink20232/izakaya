using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SandwichPlate : MonoBehaviour
{
    public GameObject sandwichPiece1, sandwichPiece2, sandwichPiece3;
    public GameObject assembleSandwich;

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "Sandwich_p1")
        {
            sandwichPiece1.SetActive(true);
            Destroy(other.gameObject);
        }else if (other.gameObject.name == "Sandwich_p2")
        {
            sandwichPiece2.SetActive(true);
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Sandwich_p2")
        {
            sandwichPiece2.SetActive(true);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name == "Sandwich_p3")
        {
            sandwichPiece3.SetActive(true);
            Destroy(other.gameObject);
        }



        if (sandwichPiece1.activeSelf &&  sandwichPiece2.activeSelf && sandwichPiece3.activeSelf)
        {
            assembleSandwich.GetComponent<XRGrabInteractable>().enabled = true;
            assembleSandwich.GetComponent<Rigidbody>().isKinematic = false;
            //from preset kinematic to use gravity 
            assembleSandwich.GetComponent<Rigidbody>().useGravity = true;
            //indika's example: workbench which to hold all the objects 
            //Destroy(gameObject);
        }
    }
}
