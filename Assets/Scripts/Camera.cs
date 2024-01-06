using UnityEngine;

public class AkiciYEksenindeHareketEdenKamera : MonoBehaviour
{
    public Transform takipEdilen; // Kameran�n takip edece�i nesne (oyuncu genellikle)
    public float yumusatmaHizi = 1f;
    public float takipHizi = 2f; // Takip h�z�, belirli bir h�zda hareket eden nesneleri takip etmek i�in

    void Update()
    {
        if (takipEdilen != null)
        {
            // Kameran�n y ekseni �zerinde takip edilen nesnenin pozisyonunu al
            float oyuncuY = takipEdilen.position.y;

            // Hesaplanan h�zla Lerp kullanarak kameran�n yeni pozisyonunu g�ncelle
            float yeniY = Mathf.Lerp(transform.position.y, oyuncuY, yumusatmaHizi * Time.deltaTime * takipHizi);
            transform.position = new Vector3(transform.position.x, yeniY, transform.position.z);
        }
    }
}