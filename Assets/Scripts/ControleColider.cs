using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleColider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    	ControleScore.placar++;
    	Debug.Log(ControleScore.placar);
    	Destroy(this.gameObject);
    	ControleJogador.Slerp = true;
    }
}
