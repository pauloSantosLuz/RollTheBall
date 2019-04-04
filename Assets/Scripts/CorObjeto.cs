using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorObjeto : MonoBehaviour {
	
	private Renderer rend;
	private Color cor;
	private Color cor1;
	private Color cor2;

	float time = 0;

	void Start () {
		rend = GetComponent<Renderer>();
		cor1 = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
		cor2 = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
	}
	
	void Update () {
		time += Time.deltaTime;
		cor =  Color.Lerp(cor1, cor2, Mathf.PingPong(Time.time, 1));
		rend.material.SetColor("_Color", cor);		
		if(time >= 2f){
			cor2 = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
			time = 0;
		}
		
	}
}
