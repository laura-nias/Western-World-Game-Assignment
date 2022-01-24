using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {
    Rigidbody2D _rb;
    public static bool isInvulnerable = false;
    
	void Start () {
        _rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if(!PlayerManager.isPlayerDead)
             _rb.velocity = new Vector3(0, -5, 0);
        else
            _rb.velocity = Vector3.zero;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            switch (gameObject.tag)
            {
                case "pu_ExtraHealth":
                        PlayerStats.IncreaseHealth();
                    break;

                case "pu_LessHealth":
                        PlayerStats.DecreaseHealth();                       
                        break;

                case "pu_invulnerable":
                        
                        //isInvulnerable = true;        
                        //StartCoroutine(ResetInvulnerable());
                        break;
            }
            Destroy(gameObject);
        }
    }
    //public IEnumerator ResetInvulnerable()
    //{
    //    yield return new WaitForSeconds(3f);                                                //waits 3 seconds
    //    isInvulnerable = false;
    //    Debug.Log("WORK?");
    //}





}
