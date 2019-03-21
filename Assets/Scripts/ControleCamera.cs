using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
	private Transform posicao;
	private ControleJogador jogador;
	private Vector3 offset;
	public ControleCamera(ControleJogador jogador)
	{
		this.posicao = GameObject.Find("Main Camera").GetComponent<Transform>();
		this.jogador = jogador;
		this.offset = this.posicao.transform.position - this.jogador.posicao.position;
	}

	public void SegueJogador()
	{
		Vector3 posicaoJogador = this.jogador.posicao.transform.position;
		Vector3 posicaoCamera = this.posicao.transform.position;

		Vector3 novaPosicao = new Vector3(posicaoJogador.x, posicaoCamera.y, posicaoJogador.z - this.offset.z);

		this.posicao.transform.position = novaPosicao;
		this.offset = this.posicao.transform.position - this.jogador.posicao.position;
	}
}
