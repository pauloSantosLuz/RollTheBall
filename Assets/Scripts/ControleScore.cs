using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleScore : MonoBehaviour
{
  public static int placar = 0;
  public GameObject texto;

  public ControleScore(GameObject texto)
  {
  	this.texto = texto;
  }

  public void AtualizaPlacar()
  {
  	this.texto.GetComponent<Text>() = placar.ToString();
  }

}
