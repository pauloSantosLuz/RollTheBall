using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleScore : MonoBehaviour
{
	public static int placar = 0;
	public Text texto;
	public GameObject textoFimDeJogo;

	public ControleScore(GameObject texto, GameObject textoFimDeJogo)
  	{
  		this.texto = texto.GetComponent<Text>();
  		this.textoFimDeJogo = textoFimDeJogo;
  	}

 	public void AtualizaPlacar()
 	{
  		this.texto.GetComponent<Text>().text = placar.ToString();
  	}
 	public void ExibeVitoria()
	{
		textoFimDeJogo.SetActive(true);
	}
}
