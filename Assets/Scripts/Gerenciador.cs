using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Classe que gerencia o jogo mantendo tudo organizado*/
public class Gerenciador : MonoBehaviour
{
	private ControleCamera controleCamera;
	private ControleJogador controleJogador;
	private ControleObjeto[] controleObjeto = new ControleObjeto[11];
	private ControleScore controleScore;

	void Start()
	{
		IniciaObjetos();

	}
	void FixedUpdate()
	{
		controleJogador.ControleMovimento();
		controleScore.AtualizaPlacar();
		for(int i = 0; i < 11; i++)
		{
			try
			{
				controleObjeto[i].Roda();
			}catch(MissingReferenceException erro)
			{

			}
		}
	}
	void LateUpdate()
	{
		controleCamera.SegueJogador();		
	}

	private void IniciaObjetos()
	{
		controleScore = new ControleScore(GameObject.Find("QtdPontos"));
		controleJogador = new ControleJogador();
		controleCamera = new ControleCamera(controleJogador);

		for(int i = 0; i < 11; i++)
			controleObjeto[i] = new ControleObjeto(GameObject.Find(i.ToString()));
	}
}
