using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{
    public GameObject firePrefab;
    public float farTop = 90, farBot = -80;

    public RuntimeAnimatorController arm;
    public Animator anim;
    
    void Awake()
    {
        anim = GetComponent<Animator>();            //gets components for the animation
        anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Finding the angle in degrees by using the distance from object to mouse
        var pos = Camera.main.WorldToScreenPoint(transform.position);   //gets position of object on screen
        var dir = Input.mousePosition - pos;                            //calculates the direction
        var angleDeg = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;       //works out an angle to rotate the arm in degrees


        if (!PlayerManager.isPlayerDead)
        { 
            angleDeg = Mathf.Clamp(angleDeg, farBot, farTop);                               //Clamps the angle so it can only be a value between farBot and farTop
            transform.rotation = Quaternion.AngleAxis(angleDeg - 90, Vector3.forward);      //Rotates arm
       
            if (Input.GetButtonDown("Fire1"))
            {
                anim.speed = 1.5f;                                                          //plays animation
                StartCoroutine(loadAfterAnimation());                                       //waits to stop animation
                GameObject bullet = Instantiate(firePrefab, transform.position + new Vector3(0.5f, 0.8f, 0), transform.rotation) as GameObject;   //instantiates a bullet gameObject
            }
        }

    }
    public IEnumerator loadAfterAnimation()
    {

        //Wait the length of the clip
        yield return new WaitForSeconds(3f);                                                //waits 3 seconds
        anim.speed = 0;                                                                     //Stops animation
        }

    }


