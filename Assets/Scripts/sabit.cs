using UnityEngine;

public class sabit : MonoBehaviour
{
    public Transform sabitKonum; // D��menin sabit konumu

    void Update()
    {
        if (sabitKonum != null)
        {
            // D��menin konumunu sabit konuma ayarla
            transform.position = sabitKonum.position;
        }
    }
}
