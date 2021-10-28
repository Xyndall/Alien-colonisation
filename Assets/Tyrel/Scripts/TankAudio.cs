using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAudio : MonoBehaviour
{

    AudioSource aSource = null;
    public AudioClip[] aClip = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TankShoot()
    {
        aSource.clip = aClip[0];
        TankShootAudio(aClip[0]);
    }

    void TankShootAudio(AudioClip clip)
    {

        aSource.PlayOneShot(clip);

    }

}
