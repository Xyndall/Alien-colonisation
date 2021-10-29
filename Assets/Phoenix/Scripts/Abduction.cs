using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abduction : MonoBehaviour
{
    public Transform beamPoint;
    public GameObject beamPrefab;
    public static int Score = 0;

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
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "NPC")
        {
            Destroy(other.gameObject);
            Score++;
        }
    }

    void Abduct()
    {
        //Creates the beam
      GameObject newBeam = Instantiate(beamPrefab, beamPoint.position, beamPoint.rotation,transform);
        newBeam.GetComponent<Beam>().Ship = gameObject;
    }
}
