using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorTablosu : MonoBehaviour
{
    public Text skorText; // Unity Edit�r�'nde UI Text eleman�n� ba�lay�n.
    public int skor = 0;
    public float skorhizi;// Skorun artma h�z�.

    private void Start()
    {
        StartCoroutine(skorArtisi());
        // belli zamanlar belli i�lemler
    }
    
    IEnumerator skorArtisi()
    {
        while (true)
        {
            yield return new WaitForSeconds(skorhizi);
            skor++;
            skorText.text = skor.ToString();
        }
    }

 
}