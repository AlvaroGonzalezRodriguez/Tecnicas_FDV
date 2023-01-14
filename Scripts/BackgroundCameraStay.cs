using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCameraStay : MonoBehaviour
{
    
    public Transform cameraTransform;
    public Transform otherBg;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 2);

        SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
        float width = spr.size.x;

        if(this.transform.position.x + width < cameraTransform.position.x)
        {
            transform.position = new Vector3(otherBg.position.x + width, otherBg.position.y, otherBg.position.z);
        }
    }
}
