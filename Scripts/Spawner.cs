using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coin;

    private GameObject[] pool;
    private int size = 5;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        int increment = 0;
        pool = new GameObject[size];
        for(int i = 0; i < pool.Length; i++){
            pool[i] = Instantiate(coin, this.transform.position + new Vector3(this.transform.position.x + 2.0f + increment, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            pool[i].SetActive(false);
            pool[i].GetComponent<Coin>().SetID(index);
            increment += 2;
        }

        InvokeRepeating(nameof(Spawn), 0.0f, 2.0f);
    }

    private void Spawn()
    {
        pool[index].SetActive(true);
        index++;

        if (index >= size)
        {
            index = 0;
        }
    }
}
