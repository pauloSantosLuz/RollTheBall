using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleObjeto : MonoBehaviour
{
	public Transform posicao;

	public ControleObjeto(GameObject objeto)
	{
		this.posicao = objeto.transform;
	}

	public void Roda()
	{
		this.posicao.transform.Rotate(1f,1f,1f);
	}
}
