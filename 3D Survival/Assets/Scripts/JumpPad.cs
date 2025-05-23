using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField]
    float power = 5f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Okay");
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * power, ForceMode.Impulse);
        }
    }


}




