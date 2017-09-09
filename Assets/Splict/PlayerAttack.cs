﻿using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
    public GameObject taget;
    public float attackTimer;
    public float coolDown;

	// Use this for initialization
	void Start () {
        attackTimer = 0;
        coolDown = 2.0f;

	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;

		if (attackTimer < 0)
			attackTimer = 0;

		if (Input.GetKeyUp (KeyCode.F)) {
			if (attackTimer == 0)
				;
			{
				Attack ();
				attackTimer = coolDown;
			}
		}
	}

	    private void Attack() {
        float distance = Vector3.Distance(taget.transform.position, transform.position);

        Vector3 dir = (taget.transform.position - transform.position).normalized;

        float direction = Vector3.Dot(dir, transform.forward);

        Debug.Log(direction);



        //Debug.Log(distance);
//        if (distance < 2.5f) 
        if (distance < 0.5f) 
		{
            if (distance > 0 ){
            EnemyHaelth eh = (EnemyHaelth)taget.GetComponent("EnemyHaelth");
				eh.AddjustCurrentHealth(-5);
			}
        }
    }
}