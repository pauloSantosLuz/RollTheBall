using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
	private Transform posicao;
	private ControleJogador jogador;
	private Vector3 offset;
	private Vector3 velocidade = Vector3.zero;

	public ControleCamera(ControleJogador jogador)
	{
		this.posicao = GameObject.Find("Main Camera").GetComponent<Transform>();
		this.jogador = jogador;
 		this.offset = this.posicao.transform.position - this.jogador.posicao.transform.position;	}

	public void SegueJogador()
	{
 		this.posicao.transform.position = jogador.posicao.transform.position + offset;	}
	}
