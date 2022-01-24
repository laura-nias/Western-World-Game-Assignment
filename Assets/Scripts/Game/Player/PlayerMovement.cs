using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D _rb;
    private float moveSpeed = 150.0f;
    public float farTop=-10, farBot=10;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!PlayerManager.isPlayerDead)
        {
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0);
            if (((transform.position.x > farTop) && (_rb.velocity.x > 0)) || ((transform.position.x < farBot) && (_rb.velocity.x < 0)))             //boundaries for player
            {
                _rb.velocity = Vector2.zero;
            }
        }
        else
            _rb.velocity = Vector3.zero;

    }
}
