using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abduction : MonoBehaviour
{
    public Transform beamPoint;
    public GameObject beamPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Abduct();
            Debug.Log("BEAM");
        }
    }

    void Abduct()
    {
        //Creates the beam
      GameObject newBeam = Instantiate(beamPrefab, beamPoint.position, beamPoint.rotation,transform);
        newBeam.GetComponent<Beam>().Ship = gameObject;
    }
}
