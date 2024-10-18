using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dortislem : MonoBehaviour
{

    public UnityEngine.UI.Text ÝlkSayi,Ýslem,ÝkinciSayi,Sonuc,Durum;
    public UnityEngine.UI.InputField SonucInput;
    float sayi1, sayi2, isaret,islemsonucu;
    void Start()
    {
        yenisoru();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cevapkontrol()
    {
        if(float.Parse(Sonuc.text)==islemsonucu) {
            Durum.text = "DOÐRU";
        }
        else {
            Durum.text = "Yanlýþ";
                }
    }
    public void yenisoru()
    {
        SonucInput.text = "";
        Durum.text = "";
        sayi1 = Random.Range(1, 11);
        sayi2 = Random.Range(1, 11);
        isaret = Random.Range(1, 5);
        switch (isaret)
        {
            case 1:
                Ýslem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                Ýslem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                Ýslem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                Ýslem.text = "/";
                islemsonucu = sayi1 / sayi2;
                break;

        }
        ÝlkSayi.text = sayi1 + "";
        ÝkinciSayi.text = sayi2 + "";
    }
}
