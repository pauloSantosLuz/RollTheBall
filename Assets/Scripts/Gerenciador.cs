using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Classe que gerencia o jogo mantendo tudo organizado*/
public class Gerenciador : MonoBehaviour
{
	private ControleCamera controleCamera;
	private ControleJogador controleJogador;
	private ControleObjeto controleObjeto;	
	private ControleScore controleScore;

	void Start()
	{
		IniciaObjetos();

	}
	void FixedUpdate()
	{
		controleJogador.ControleMovimento();
	}
	void LateUpdate()
	{
		controleCamera.SegueJogador();		
	}

	private void IniciaObjetos()
	{
		controleObjeto = new ControleObjeto();
		controleScore = new ControleScore();
		controleJogador = new ControleJogador();
		controleCamera = new ControleCamera(controleJogador);
	}
}
