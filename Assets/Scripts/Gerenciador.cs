using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**Classe que gerencia o jogo mantendo tudo organizado*/
public class Gerenciador : MonoBehaviour
{
	public GameObject TextFimDeJogo;

	private bool fimDeJogo = false;
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
		if(fimDeJogo)
			return;
		if(controleJogador.posicao.transform.position.y < 0)
		{
			TextFimDeJogo.GetComponent<Text>().text = "Perdeu!";
			controleScore.ExibeVitoria();
			fimDeJogo = true;
		}
		if(ControleJogador.Slerp)
			controleJogador.Especial();

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

		if(ControleScore.placar == 11)
		{
			fimDeJogo = true;
			controleScore.ExibeVitoria();
		}
	}
	void LateUpdate()
	{
		if(fimDeJogo)
			return;
		controleCamera.SegueJogador();		
	}

	private void IniciaObjetos()
	{
		controleScore = new ControleScore(GameObject.Find("QtdPontos"), TextFimDeJogo);
		controleJogador = new ControleJogador();
		controleCamera = new ControleCamera(controleJogador);

		for(int i = 0; i < 11; i++)
			controleObjeto[i] = new ControleObjeto(GameObject.Find(i.ToString()));
	}
}
