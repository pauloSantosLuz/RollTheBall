using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
	public Transform posicao;
	private Rigidbody rigidbody;

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
 
	} 
}
