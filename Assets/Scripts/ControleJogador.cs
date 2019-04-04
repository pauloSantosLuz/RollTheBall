using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
	Vector3 posicaoInicial;
	private float timer = 0;
	public Transform posicao;
	private Rigidbody rigidbody;
	public static bool Slerp = false;
	public ControleJogador()
	{
		this.posicao = GameObject.FindWithTag("Bola").GetComponent<Transform>();
		this.rigidbody = GameObject.FindWithTag("Bola").GetComponent<Rigidbody>();
	}

	public void ControleMovimento()
	{
        float direcaoHorizontal = Input.GetAxis("Horizontal");
        float direcaoVertical = Input.GetAxis("Vertical");

		Vector3 forca = new Vector3(direcaoHorizontal, 0f, direcaoVertical);

        rigidbody.AddForce(forca*10);
 		Vector3 posicaoInicial= posicao.transform.position;

	} 

	public void Especial()
	{
		Vector3 posicaoInicial= posicao.transform.position;
		Vector3 target = new Vector3(0f,100f,0f);
		posicao.transform.position = Vector3.Slerp(posicaoInicial, target, 0.1f);
		timer += Time.deltaTime;
		if(timer > 1f){
			Slerp = false;	
			timer = 0f;
		}
	}
}
