using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int ID;
    
    public void SetID(int id){
        ID = id;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Zombie"){
            this.gameObject.SetActive(false);
        }
    }

}
