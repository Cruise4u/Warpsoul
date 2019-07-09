using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;


public class MouseInput : MonoBehaviour
{
    public LayerMask enemyMask;
    public List<GameObject> enemyList;
    public Camera cam;

    public void MouseTeleport(Vector2 origin,Vector2 direction,LayerMask mask,List<GameObject> GameobjectList)
    {
        if(Input.GetMouseButtonDown(0))
        {
                var hit = Physics2D.Raycast(cam.ScreenPointToRay(Input.mousePosition).origin, cam.ScreenPointToRay(Input.mousePosition).direction, Mathf.Infinity,mask);
                foreach(GameObject enemy in enemyList)
                {
                    if (hit.collider != null)
                    {
                        if (hit.collider == enemy.GetComponent<Collider>())
                        {
                            Debug.Log("Enemy " + hit.collider + "hit");
                        }
                    }
                }
            }
        }
}


