using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaplay : MonoBehaviour
{
    public void Start(){
        GameObject.FindGameObjectWithTag("musicamain").GetComponent<musicaescenasmain>().PlayMusic();
    }
}
