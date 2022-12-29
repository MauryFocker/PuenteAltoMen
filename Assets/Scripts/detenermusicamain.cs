using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detenermusicamain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("musicamain").GetComponent<musicaescenasmain>().StopMusic();
    }

}
