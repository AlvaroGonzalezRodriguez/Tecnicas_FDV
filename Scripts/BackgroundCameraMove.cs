using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCameraMove : MonoBehaviour
{
    
	public Transform fondoADer;
	public Transform fondoAIzq;
	public Transform fondoBDer;
	public Transform fondoBIzq;
	public Transform fondoCDer;
	public Transform fondoCIzq;
	public Transform fondoDDer;
	public Transform fondoDIzq;
	
	public GameObject camara;
	
	private bool segundaFila = false;
	private SpriteRenderer sprRend;
	private Camera cCamera;
	private Transform tCamera;
	
	// Start is called before the first frame update
    void Start()
    {
        sprRend = fondoADer.GetComponent<SpriteRenderer>();
		cCamera = camara.GetComponent<Camera>();
		tCamera = camara.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		float size = cCamera.orthographicSize;
		float spacing = sprRend.size.x * 1.5f;

        if(tCamera.position.y - size > fondoADer.position.y + sprRend.size.x * 1.5f && segundaFila == false){
			fondoADer.position = fondoCDer.position + Vector3.up * spacing;
			fondoAIzq.position = fondoCIzq.position + Vector3.up * spacing;
			fondoBDer.position = fondoDDer.position + Vector3.up * spacing;
			fondoBIzq.position = fondoDIzq.position + Vector3.up * spacing;
			segundaFila = true;
		} else if(tCamera.position.y + size < fondoADer.position.y - sprRend.size.x * 1.5f && segundaFila == true){
			fondoADer.position = fondoCDer.position - Vector3.up * spacing;
			fondoAIzq.position = fondoCIzq.position - Vector3.up * spacing;
			fondoBDer.position = fondoDDer.position - Vector3.up * spacing;
			fondoBIzq.position = fondoDIzq.position - Vector3.up * spacing;
			segundaFila = false;
		}
		if(tCamera.position.y - size > fondoCDer.position.y + sprRend.size.x * 1.5f && segundaFila == true){
			fondoCDer.position = fondoADer.position + Vector3.up * spacing;
			fondoCIzq.position = fondoAIzq.position + Vector3.up * spacing;
			fondoDDer.position = fondoBDer.position + Vector3.up * spacing;
			fondoDIzq.position = fondoBIzq.position + Vector3.up * spacing;
			segundaFila = false;
		}else if(tCamera.position.y + size < fondoCDer.position.y - sprRend.size.x * 1.5f && segundaFila == false){
			fondoCDer.position = fondoADer.position - Vector3.up * spacing;
			fondoCIzq.position = fondoAIzq.position - Vector3.up * spacing;
			fondoDDer.position = fondoBDer.position - Vector3.up * spacing;
			fondoDIzq.position = fondoBIzq.position - Vector3.up * spacing;
			segundaFila = true;
		}
    }
}
