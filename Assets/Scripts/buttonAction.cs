using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class buttonAction : MonoBehaviour
{
    public GameObject menu = null;
    public GameObject panel = null;
    public TMP_InputField planetid = null;
    
    public GameObject[] planets;
    
    public void onClickMenu(){
        panel.SetActive(true);
        
    }

    public void onClickOkButton(){
        panel.SetActive(false);
    }

    public void onClickAddButton(){
        //Debug.Log(planetid.text);
        try{
            int id = Convert.ToInt32(planetid.text);
            if(id > 20 || id < 0){
                return;
            }
            id--;
            planets[id].SetActive(true);
        }catch(Exception e){
            Debug.Log(e.ToString());
        }
        
    }
}
