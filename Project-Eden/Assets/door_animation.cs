using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_animation : MonoBehaviour
{
    Start function:
this.GetComponent<Animator>().SetBool("open", true); //open door

this.GetComponent<Animator>().SetBool("open", false); //close door

}
