using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dortislem : MonoBehaviour
{

    public UnityEngine.UI.Text �lkSayi,�slem,�kinciSayi,Sonuc,Durum;
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
            Durum.text = "DO�RU";
        }
        else {
            Durum.text = "Yanl��";
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
                �slem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                �slem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                �slem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                �slem.text = "/";
                islemsonucu = sayi1 / sayi2;
                break;

        }
        �lkSayi.text = sayi1 + "";
        �kinciSayi.text = sayi2 + "";
    }
}
