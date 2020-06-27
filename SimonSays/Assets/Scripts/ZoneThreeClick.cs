﻿using UnityEngine;
 using System.Collections;
 using UnityEngine.EventSystems;
 using UnityEngine.SceneManagement;
 
 public class ZoneThreeClick : MonoBehaviour {

    public GameObject thirdZone;
    public int val = 3;

    void Start()
    {
        thirdZone = GameObject.Find("zone3");
    }

    private void Update(){

         if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()){
             Debug.Log("Doing Ray test");
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out hit, Mathf.Infinity))
             {
                 //Debug.Log("Selected" +hit.name);
                 Debug.Log("Hit Somthing" +hit.transform.tag);
                 //Replace this with whatever logic you want to use to validate the objects you want to click on
                 if(hit.collider.gameObject.name == "zone3")
                 {
                     SceneManager.LoadScene("Zone-A-Screen");
                 }
             }
         }


     }
 }
